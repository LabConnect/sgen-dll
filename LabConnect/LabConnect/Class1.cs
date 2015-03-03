using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabConnect
{
    public class USB
    {
    }

    public class Sgen
    {
        //definition der klassenvariablen
        byte[] output_data = {0x20, 0x00, 0x66, 0x49, 0x01, 0x40, 0xD4, 0xD5, 0x80, 0x7F, 0x01};
        bool rechteck = false;

        //registerwerte für die Digipotis für die Ausgangsspannung berechnen
        void RegwertUout(int u_amplitude)
        {
            float umax = 12, bits = 510;
            int register1, register2;
            //berechnen des gesamtwertes
            int ergebnis = (u_amplitude / Convert.ToInt32(umax / bits));
            //prüfen ob grade und auf register aufteilen
            if (ergebnis%2==0)
            {
                register1 = 255 - (ergebnis / 2);
                register2 = 255 - (ergebnis / 2);
            }
            else
            {
                ergebnis = ergebnis - 1;
                register1 = 255 - ((ergebnis / 2) + 1);
                register2 = 255 - (ergebnis / 2);
            }

            output_data[6] = Convert.ToByte(register1);
            output_data[7] = Convert.ToByte(register2);
            return;
        }

        //Registerwerte für die offsetspannung berechnen
        void RegwertOffset(int u_offset)
        {
            float uges = 12, bits = 510;
            int register1, register2;

            int ergebnis = ((u_offset + 6) / Convert.ToInt32(uges / bits));

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

        //zwischen Rechteck und Sinus/Dreieck unterscheiden
        void SetWaveform(int form)
        {
            if (form == 2)
            {
                rechteck = true;
            }
            else
            {
                rechteck = false;
            }
            return;
        }

        //Frequenzregister des AD9833 berechnen
        void SetFrequency(int frequenz)
        {
            float mclk = 25000000, register_size = 268435456;
            float teiler = mclk / register_size;
            int f_regwert = Convert.ToInt32(frequenz / teiler);
            
            //block1=lsb --> block4 = msb
            byte block1, block2, block3, block4;

            block1 = Convert.ToByte(f_regwert);
            f_regwert = f_regwert >> 8;
            block2 = Convert.ToByte(f_regwert);
            block2 = Convert.ToByte((block2 | 0x40) & (~0x80));
            f_regwert = f_regwert >> 6;
            block3 = Convert.ToByte(f_regwert);
            f_regwert = f_regwert >> 8;
            block4 = Convert.ToByte(f_regwert);
            block4 = Convert.ToByte((block4 | 0x40) & (~0x80));
            
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
                else if(frequenz <= 10000)
                {
                    output_data[10] = 2;
                }
                else
                {
                    output_data[10] = 1;
                }
            }
        }
        
        //Daten senden
        void CommitData()
        {
            //this is where we call the usbfunction
            return;
        }
    }
}
