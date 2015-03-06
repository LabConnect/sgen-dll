﻿using System;
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
        
        bool rechteck = false;
        public byte[] output_data = { 0x20, 0x00, 0x66, 0x49, 0x01, 0x40, 0xD4, 0xD5, 0x80, 0x7F, 0x01 };
        //registerwerte für die Digipotis für die Ausgangsspannung berechnen
        public double RegwertUout(double u_amplitude)
        {
            double umax = 12, bits = 510;
            int register1, register2;
            //berechnen des gesamtwertes
             double ergebnis = u_amplitude / (umax / bits);
            //prüfen ob grade und auf register aufteilen
            if (ergebnis%2 == 0)
            {
                register1 = Convert.ToInt32(255 - (ergebnis / 2));
                register2 = Convert.ToInt32(255 - (ergebnis / 2));
            }
            else
            {
                ergebnis = ergebnis - 1;
                register1 = Convert.ToInt32(255 - ((ergebnis / 2) + 1));
                register2 = Convert.ToInt32(255 - (ergebnis / 2));
            }

            output_data[6] = Convert.ToByte(register1);
            output_data[7] = Convert.ToByte(register2);
            return ergebnis;
        }

        //Registerwerte für die offsetspannung berechnen
        public void RegwertOffset(double u_offset)
        {
            float uges = 12, bits = 510;
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
            output_data[1] = Convert.ToByte(Convert.ToInt32(creg_wf & 0x29) | creg_base_lsb);
            
            if (rechteck == true)
            {
                output_data[10] = 3;
            }
            
            return;
        }

        //Frequenzregister des AD9833 berechnen
        public void SetFrequency(int frequenz)
        {
            float mclk = 25000000, register_size = 268435456;
            float teiler = mclk / register_size;
            int f_regwert = Convert.ToInt32(frequenz / teiler);
            
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
