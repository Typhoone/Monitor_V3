using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor_V3
{
    class Log
    {
        private DateTime time;

        private int magnets;
        private int electronicStartRPM;
        private int RPM;
        private int duty;
        private int delay;
        private int controlTemp;
        private int coilTemp;
        private double frequency;

        public int Magnets
        {
            get
            {
                return magnets;
            }

            set
            {
                magnets = value;
            }
        }

        public int ElectronicStartRPM
        {
            get
            {
                return electronicStartRPM;
            }

            set
            {
                electronicStartRPM = value;
            }
        }

        public int RPM1
        {
            get
            {
                return RPM;
            }

            set
            {
                RPM = value;
            }
        }

        public int Duty
        {
            get
            {
                return duty;
            }

            set
            {
                duty = value;
            }
        }

        public int Delay
        {
            get
            {
                return delay;
            }

            set
            {
                delay = value;
            }
        }

        public int ControlTemp
        {
            get
            {
                return controlTemp;
            }

            set
            {
                controlTemp = value;
            }
        }

        public int CoilTemp
        {
            get
            {
                return coilTemp;
            }

            set
            {
                coilTemp = value;
            }
        }

        public double Frequency
        {
            get
            {
                return frequency;
            }

            set
            {
                frequency = value;
            }
        }

        /// <summary>
        /// makes a new log from raw input data from COM
        /// </summary>
        /// <param name="time"></param>
        /// <param name="data"></param>
        public Log(DateTime time, string data)
        {
            this.time = time;

            string[] dataSplit = data.Split(',');

            if (dataSplit.Length != 7)
            {

            }
            else
            {
                this.Magnets = Convert.ToInt32(dataSplit[0]);
                this.RPM1 = Convert.ToInt32(dataSplit[2]);
                this.Duty = Convert.ToInt32(dataSplit[3]);
                this.Delay = Convert.ToInt32(dataSplit[4]);
                this.CoilTemp = Convert.ToInt32(dataSplit[5]);
                this.ControlTemp = Convert.ToInt32(dataSplit[6]);
                this.ElectronicStartRPM = Convert.ToInt32(dataSplit[1]);
                this.Frequency = (this.RPM1 / 60.0) * 9.0;
            }

        }

        /// <summary>
        /// Creates a log from a line that is taken from a file in the same format and the print funtion 
        /// </summary>
        /// <param name="line"></param>
        public Log(string line)
        {
            string[] vars = line.Split('\t');
            if(vars.Length == 9)
            {
                this.time = Convert.ToDateTime(vars[0]);
                this.RPM = Int32.Parse(vars[1]);
                this.duty = Int32.Parse(vars[2]);
                this.delay = Int32.Parse(vars[3]);
                this.coilTemp = Int32.Parse(vars[4]);
                this.ControlTemp = Int32.Parse(vars[5]);
                this.electronicStartRPM = Int32.Parse(vars[6]);
                this.frequency = Int32.Parse(vars[7]);
                this.magnets = Int32.Parse(vars[8]);
            }
        }

        public double getValue(String s)
        {
            switch (s)
            {
                case "RPM": return this.RPM1;
                case "Duty": return this.Duty;
                case "Delay": return this.Delay;
                case "Coil Temp": return this.CoilTemp;
                case "Control Box Temp":
                    return this.ControlTemp;
                case "Trigger RPM":
                    return this.electronicStartRPM;
                case "Magnets":
                    return this.Magnets;
                case "Time":
                    String[] t = time.ToString("HH:mm:ss").Split(':');
                    double hours = Convert.ToDouble(t[0]) * 100;
                    double minute = Convert.ToDouble(t[1]);
                    double sec = Convert.ToDouble(t[2]) / 100.0;
                    return hours + minute + sec;



            }

            return 0;
        }
               
        public string print()
        {
            return (time.ToString("HH:mm:ss") + "\t" + RPM1 + "\t" + Duty + "\t" + Delay + "\t" + CoilTemp + "\t" + ControlTemp + "\t" + ElectronicStartRPM + "\t" + String.Format("{0:0.##}", Frequency) + "\tm" + Magnets);
        }
    }
}
