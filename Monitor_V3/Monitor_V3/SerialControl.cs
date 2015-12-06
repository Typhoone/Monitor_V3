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
        

        //GUI Elements
        Thread serialThread;

        Form1 form;

        ListBox logBox;
        public delegate void delLogUpdate(string data_rx);

        Label infoLabel;
        public delegate void delInfoUpdate(string info);

        //Control Variables
        public int PULSETIME; // seconds for one pulse/log to arrive
        public int timeout;//How long before disconnect in seconds (preferably double that of the clock rate)

        //Serial Variables
        SerialPort myPort;
        bool connected = false;


        public SerialControl(ListBox logs, Label infoLabel, Form1 form)
        {

            this.form = form;
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
            this.timeout = PULSETIME * 4000;

            if(myPort != null)
            {
                myPort.ReadTimeout = timeout;
                delUpdateInfo("INFO: Pulse Time set to " + time + " seconds");
            }
        }

        public void firstConnect()
        {
            string[] allports = SerialPort.GetPortNames();

            if(allports.Length == 1)
            {
                connectPort(allports[0]);
            }
        }

        public void connectPort(string portName)
        {
            
            if(myPort != null && connected)
            {
                connected = false;
                myPort.Close();
            }

            myPort = new SerialPort();
            myPort.BaudRate = 115200;
            
            myPort.PortName = portName;
            myPort.ReadTimeout = timeout;

            try {
                myPort.Open();
            }catch (Exception e)
            {
                delUpdateInfo("Connect fail: " + e.Message);
                return;
            }
            delUpdateInfo("Connected on Port: " + portName);
            connected = true;

            serialThread = new Thread(new ThreadStart(interpret));
            serialThread.Name = "SerialThread";
            serialThread.IsBackground = true;
            serialThread.Start();
        }

        public void delUpdateInfo(string info)
        {
            delInfoUpdate updator = new delInfoUpdate(form.updateInfo);
            
            infoLabel.BeginInvoke(updator, info);
        }

        public void interpret()
        {
            string data_rx = "";// data from COM
            while (connected)
            {
                try {
                    data_rx = myPort.ReadLine();

                    delLogUpdate updator = new delLogUpdate(form.addLog);

                    this.logBox.BeginInvoke(updator, data_rx);

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    connected = false;
                    delUpdateInfo("ERROR: COM Disconnect");
                }
            }
        }
    }
}
