using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor_V3
{
    class SerialControl
    {
        public delegate void delLogUpdate(Log log);

        //GUI Elements
        Thread serialThread;
        ListBox logBox;
        Label infoLabel;

        //Control Variables
        public int PULSETIME; // seconds for one pulse/log to arrive
        public int timeout;//How long before disconnect in seconds (preferably double that of the clock rate)

        //Serial Variables
        SerialPort myPort;
        bool connected = false;


        public SerialControl(ListBox logs, Label infoLabel)
        {
            this.logBox = logs;
            this.infoLabel = infoLabel;


            setPulseTime(30);
           
        }

        /// <summary>
        /// Sets the Expected time for one pulse of data
        /// Using PULSETIME sets the timeout value
        /// </summary>
        /// <param name="time"></param>
        public void setPulseTime(int time)
        {
            this.PULSETIME = time;
            this.timeout = PULSETIME * 4;
        }

        public void connectPort(string portName)
        {
            
            if(myPort != null || connected)
            {
                connected = false;
                myPort.Close();
            }

            myPort = new SerialPort();
            myPort.BaudRate = 115200;
            
            myPort.PortName = portName;
            myPort.ReadTimeout = timeout * 1000;

            connected = true;
        }

        /// <summary>
        /// Prints to the Info message dialogue at the bottom
        /// </summary>
        /// <param name="info"></param>
        public void updateInfo(string info)
        {

        }
    }
}
