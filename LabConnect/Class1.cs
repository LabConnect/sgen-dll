using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace LabConnect
{
    
    public class USB
    {
        GenericHid.FindHid DeviceHandle = new GenericHid.FindHid();
        
        public bool InitUSB(int vid, int pid)
        {
            
            bool enumerated = false;
            enumerated = DeviceHandle.enumerate(vid, pid);
            return enumerated;
        }

        public bool SendData(byte[] Message)
        {
            bool success = false;
            if (!DeviceHandle._hidHandle.IsClosed && !DeviceHandle._hidHandle.IsInvalid)
            {
                success = DeviceHandle._myHid.SendOutputReportViaControlTransfer(DeviceHandle._hidHandle, Message);
            }
            return success;
        }

        public bool GetData(ref byte[] buffer)
        {
            buffer = new Byte[DeviceHandle._myHid.Capabilities.InputReportByteLength];
            bool success = false;

            success = DeviceHandle._myHid.GetInputReportViaControlTransfer(DeviceHandle._hidHandle, ref buffer);

            return success;
        }
    }

    public class Sgen
    {
        //definition der klassenvariablen
        LabConnect.USB USB = new LabConnect.USB();
        bool rechteck = false;
        int frequenz = 1750;
        int MCLK;
        
        public byte[] output_data = { 0x20, 0x00, 0x66, 0x49, 0x01, 0x40, 0xD4, 0xD5, 0x80, 0x7F, 0x02, 0x01 };
        public byte[] calibration_data = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
        
        //registerwerte für die Digipotis für die Ausgangsspannung berechnen
        
        public bool init()
        {
            bool success = false;
           
            
            int vid = 4617;
            int pid = 8738;

            success = USB.InitUSB(vid, pid);
            if (success)
            {
                ConfigRequest(ref calibration_data);
                MCLK = calibration_data[2] * 16777216 + calibration_data[3] * 65536 + calibration_data[4] * 256 + calibration_data[5];
            }
            
            return success;
        }

        public bool GetBootLoad()
        {
            bool config = false;
            if ((calibration_data[1] & 0xF0) == 0x10)
            {
                config = true;
            }

            return config;
        }

        public void BootData(bool save_data, bool load_data_at_boot)
        {
            byte save, load;
            if (save_data == true)
            {
                save = 0x01;
            }
            else
            {
                save = 0x00;
            }

            if (load_data_at_boot == true)
            {
                load = 0x10;
            }
            else
            {
                load = 0x00;
            }

            output_data[11] = Convert.ToByte(load | save);
            return;
        }
        
        public void RegwertUout(int u_amplitude_mv)
        {
            int bits = 512;
            int register1, register2;
            
            //Berechnen der Verstärker-eingangsspannung aus den Kalibrierungswerten
            float uein = (Convert.ToInt32(calibration_data[6]) * 256) + Convert.ToInt32(calibration_data[7]);
            
            //Benötigten Verstärkungsfaktor berrechnen
            float relation = ((float)u_amplitude_mv / uein)-1;

            //berechnet die Auflösung (~390Ohm pro bit)
            float aufloesung = ((float)200000 / bits);

            float zwischen = ((100000 / relation) - 2200) / aufloesung;

            /*
            //nen twischnschritt, der halt sein muss, merkt man wenn man die Formel umstellt.
            float resistance = (1 / (relation - 1));
            
            
            
            //umrechnen in 2. Widerstand des Verstärkers mit dem ersten Widerstand. Das durch
            //Ohm pro Bit teilen, damit man weis wieviel bit man braucht.
            float zwischen = ((resistance * 100000) - 2200) / aufloesung;
            */
            //in int umbauen, weil es (noch) keine halben bits gibt
            int ergebnis = Convert.ToInt32(zwischen);
            
            
            //prüfen ob grade und auf register aufteilen
            if (bits < ergebnis)
            {
                ergebnis = bits;
            }
            else if (ergebnis <= 0)
            {
                ergebnis = 0;
            }

            if (ergebnis%2 == 0)
            {
                register1 = (ergebnis / 2);
                register2 = (ergebnis / 2);
            }
            else
            {
                ergebnis = ergebnis - 1;
                register1 = Convert.ToInt32((ergebnis / 2) + 1);
                register2 = Convert.ToInt32(ergebnis / 2);
            }

            output_data[6] = Convert.ToByte(register1);
            output_data[7] = Convert.ToByte(register2);
            return;
        }

        //Registerwerte für die offsetspannung berechnen
        public void RegwertOffset(double u_offset)
        {
            float uges = 12, bits = 512;
            int register1, register2;

            int ergebnis = Convert.ToInt32((u_offset + 6) / (uges / bits));

            if (ergebnis%2 == 0)
            {
                register1 = ergebnis / 2;
                register2 = ergebnis / 2;
            }
            else
            {
                ergebnis = ergebnis - 1;
                register1 = (ergebnis / 2) + 1;
                register2 = ergebnis / 2;
            }

            output_data[8] = Convert.ToByte(register1);
            output_data[9] = Convert.ToByte(register2);
            return;
        }

        //Signalform setzen
        public void SetWaveform(int form)
        {
            //0=sinus
            //1=dreieck
            //2=rechteck
            byte creg_wf, creg_base_msb = 0x20, creg_base_lsb = 0x00;
            
            switch (form)
            {
                case 0: creg_wf = 0x00; rechteck = false; break;
                case 1: creg_wf = 0x02; rechteck = false; break;
                case 2: creg_wf = 0x28; rechteck = true;  break;
                default: creg_wf = 0x00; rechteck = false; break;
            }

            output_data[0] = creg_base_msb;
            output_data[1] = Convert.ToByte(Convert.ToInt32(creg_wf) | creg_base_lsb);

            SetFilter();            
            return;
        }

        //Frequenzregister des AD9833 berechnen
        public void SetFrequency(int frequenz_local)
        {
            float mclk = MCLK;
            float register_size = 268435456;
            float teiler = mclk / register_size;
            int f_regwert = Convert.ToInt32(frequenz_local / teiler);
            frequenz = frequenz_local;
            //block1=lsb --> block4 = msb
            byte block1, block2, block3, block4;

            block1 = Convert.ToByte(f_regwert & 0xFF);
            f_regwert = f_regwert >> 8;
            block2 = Convert.ToByte(f_regwert & 0xFF);
            block2 = Convert.ToByte((block2 | 0x40) & (~0x80));
            f_regwert = f_regwert >> 6;
            block3 = Convert.ToByte(f_regwert & 0xFF);
            f_regwert = f_regwert >> 8;
            block4 = Convert.ToByte(f_regwert & 0xFF);
            block4 = Convert.ToByte((block4 | 0x40) & (~0x80));

            output_data[2] = block1;
            output_data[3] = block2;
            output_data[4] = block3;
            output_data[5] = block4;

            SetFilter();
        }
        
        //Daten senden
        public void SetCommand()
        {
            byte[] Data = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            for (int i = 0; i < 12; i++)
            {
                Data[i + 1] = output_data[i];
            }

            Data[0] = 0x01;
            USB.SendData(Data);

            return;
        }

        //setze den Wert für den analogmultiplexer
        void SetFilter()
        {
            if (rechteck == true)
            {
                output_data[10] = 3;
            }
            else
            {
                if (frequenz <= 500)
                {
                    output_data[10] = 3;
                }
                else if (frequenz <= 10000)
                {
                    output_data[10] = 2;
                }
                else
                {
                    output_data[10] = 1;
                }
            }
        }

        void ConfigRequest(ref byte[] ConfigData)
        {
            //Config Request senden
            byte[] Message = { 0x00, 0x00, 0x55, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            USB.SendData(Message);
            byte[] buffer = null;
            USB.GetData(ref buffer);
            int offset = 3;
            
            if (buffer[2] == 0x10)
            {
                for (int i = 0; i < 6; i++)
                {
                    ConfigData[i] = buffer[i + offset];
                }
            }
            
            return;
        }

        bool GetErrors()
        {
            bool success = false;
            byte[] Message = { 0x00, 0x03 };
            USB.SendData(Message);
            USB.GetData(ref Message);

            if (Message[4] == 0x00)
            {
                success = true;
            }
            return success;
        }


    }
}
