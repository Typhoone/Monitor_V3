using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor_V3
{
    class Log
    {
        private string time;

        private int magnets;
        private int electronicStartRPM;
        private int RPM;
        private int duty;
        private int delay;
        private int controlTemp;
        private int coilTemp;
        private double frequency;
        private String note;



        public Log(string time, string data)
        {
            this.time = time;

            string[] dataSplit = data.Split(',');

            if (dataSplit.Length != 7)
            {

            }
            else
            {
                this.magnets = Convert.ToInt32(dataSplit[0]);
                this.RPM = Convert.ToInt32(dataSplit[2]);
                this.duty = Convert.ToInt32(dataSplit[3]);
                this.delay = Convert.ToInt32(dataSplit[4]);
                this.coilTemp = Convert.ToInt32(dataSplit[5]);
                this.controlTemp = Convert.ToInt32(dataSplit[6]);
                this.electronicStartRPM = Convert.ToInt32(dataSplit[1]);
                this.frequency = (this.RPM / 60.0) * 9.0;
            }

        }

        public void setNote(string note)
        {
            this.note = note;
        }

        public string getNote()
        {
            return this.note;
        }

        public string print()
        {
            return (time + "\t" + RPM + "\t" + duty + "\t" + delay + "\t" + coilTemp + "\t" + controlTemp + "\t" + electronicStartRPM + "\t" + String.Format("{0:0.##}", frequency) + "\tm" + magnets);
        }
    }
}
