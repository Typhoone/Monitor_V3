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
using System.Windows.Forms.DataVisualization.Charting;

namespace Monitor_V3
{
    public partial class Form1 : Form
    {
        List<Log> dataList = new List<Log>();
        SerialControl serialControl;
        FileManager fileManager;

        int graph1ValuesToShow = 10;
        int graph2ValuesToShow = 10;

        bool autoScroll = true;
        public Form1()
        {
            InitializeComponent();

            this.serialControl = new SerialControl(this.logBox, this.infoLabel, this);

            refreshCOM();

            this.chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
            this.chart2.ChartAreas[0].AxisY.IsStartedFromZero = false;

            fileManager = new FileManager(this.dataList, this.noteTextBox);


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
            dataList.Add(new Log(DateTime.Now, data_rx));
            this.logBox.Items.Add(dataList[dataList.Count - 1].print());
            if (autoScroll)
            {
                this.logBox.SelectedIndex = this.logBox.Items.Count - 1;
            }
            updateGraphs();
            
        }

        private void logBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(dataList != null && dataList.Count > 0 && logBox.SelectedIndex >= 0)
            //{
            //    Log log = dataList[logBox.SelectedIndex];
            //    this.noteTextBox.Text = log.getNote();
            //}
            
        }

        

        private void COMconnect_Click(object sender, EventArgs e)
        {
            if(portSelect.SelectedIndex >= 0)
            {
                serialControl.connectPort((string)portSelect.Items[portSelect.SelectedIndex]);

            }
            

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

        

        private void noteTextBox_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void autoScrollCheck_CheckedChanged(object sender, EventArgs e)
        {
            autoScroll = this.autoScrollCheck.Checked;
        }

        public void updateGraphs()
        {
            DataPointCollection chart1Points = this.chart1.Series["Series1"].Points;
            DataPointCollection chart2Points = this.chart2.Series["Series1"].Points;

            chart1Points.Clear();
            chart2Points.Clear();




            for(int i = Math.Min(graph1ValuesToShow, dataList.Count); i > 0; i--)
            {
                if(chart1_x.SelectedIndex >= 0 && chart1_y.SelectedIndex >= 0)
                {
                    double chart1XVal = dataList[dataList.Count - i].getValue((String)this.chart1_x.SelectedItem);
                    double chart1YVal = dataList[dataList.Count - i].getValue((String)this.chart1_y.SelectedItem);

                    chart1Points.AddXY(chart1XVal, chart1YVal);

                }                
            }

            for (int i = Math.Min(graph2ValuesToShow, dataList.Count); i > 0; i--)
            {
                if (chart2_x.SelectedIndex >= 0 && chart2_y.SelectedIndex >= 0)
                {
                    double chart2XVal = dataList[dataList.Count - i].getValue((String)this.chart2_x.SelectedItem);
                    double chart2YVal = dataList[dataList.Count - i].getValue((String)this.chart2_y.SelectedItem);

                    chart2Points.AddXY(chart2XVal, chart2YVal);

                }


            }

        }

        private void chart1Size_ValueChanged(object sender, EventArgs e)
        {
            this.graph1ValuesToShow = (int)chart1Size.Value;
        }

        private void chart2Size_ValueChanged(object sender, EventArgs e)
        {
            this.graph2ValuesToShow = (int)chart2Size.Value;
        }

        private void pulseTimeBtn_Click(object sender, EventArgs e)
        {
            serialControl.setPulseTime((int)pulseTime.Value);
        }

        private void graphUpdateBtn_Click(object sender, EventArgs e)
        {
            updateGraphs();
        }
    }
}
