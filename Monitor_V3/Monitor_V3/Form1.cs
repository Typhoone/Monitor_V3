using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor_V3
{
    public partial class Form1 : Form
    {
        List<Log> dataList = new List<Log>();
        SerialControl serialControl;
        public Form1()
        {
            InitializeComponent();

            this.serialControl = new SerialControl(this.logBox, this.infoLabel, this);

            refreshCOM();
        }

        /// <summary>
        /// Prints to the Info message dialogue at the bottom
        /// </summary>
        /// <param name="info"></param>
        public void updateInfo(string info)
        {
            this.infoLabel.Text = info;
        }

        public void addLog(string data_rx)
        {
            dataList.Add(new Log(DateTime.Now.ToString("HH:mm:ss"), data_rx));
            this.logBox.Items.Add(dataList[dataList.Count - 1].print());
            Console.WriteLine("added");
        }

        private void logBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clrNoteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void COMconnect_Click(object sender, EventArgs e)
        {
            serialControl.connectPort((string)portSelect.Items[portSelect.SelectedIndex]);
            //Console.WriteLine();
        }

        private void COMportRefresh_Click(object sender, EventArgs e)
        {
            refreshCOM();
        }

        private void refreshCOM()
        {
            string[] allports = SerialPort.GetPortNames();

            this.portSelect.Items.Clear();
            this.portSelect.Items.AddRange(allports);

            if (portSelect.Items.Count > 0)
            {
                portSelect.SelectedIndex = 0;
            }
        }
    }
}
