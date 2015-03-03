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
        byte[] output_data = {0x20, 0x00, 0x66, 0x49, 0x01, 0x40, 0xD4, 0xD5, 0x80, 0x7F, 0x01};

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

        }

        //Frequenzregister des AD9833 berechnen
        void SetFrequency(int frequenz)
        {

        }
    }

    public class Psup
    {
    }
}
