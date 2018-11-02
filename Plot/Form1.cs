using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Timers;

namespace Plot
{
    public partial class SignalView : Form
    {
        public string data { get; set; }

        System.IO.StreamWriter out_file;
        System.IO.StreamReader in_file;
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;
        String receiveData;
        int licznik = 0;
        bool send_data_flag = false;
        bool plotter_flag = false;
        public SignalView()
        {
            InitializeComponent();
            configuration();
        }
        
        public void configuration()
        {
            String[] ports = SerialPort.GetPortNames();
            mySerial.DataReceived += DataReceivedHandler;
            nameportCombobox.Items.AddRange(ports);
            backgroundWorker1.DoWork += new DoWorkEventHandler(update_receiveTextBox_event);

            for (int i = 0; i < 5 && i < 5; i++)
                chart1.Series[i].Points.Add(0);

        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (!mySerial.IsOpen)
            {
                try
                {
                    if (nameportCombobox.Text == "")
                    {
                        statusBox.Text = "Wybierz port";
                    }
                    else if (predkoscCombobox.Text == "")
                    {
                        statusBox.Text = "Wybierz szybkość";
                    }
                    else
                    {


                        mySerial.PortName = nameportCombobox.Text;
                        mySerial.BaudRate = Convert.ToInt32(predkoscCombobox.Text);
                        mySerial.Open();
                        statusBox.Text = "OK";

                                                  
                        closeButton.Enabled = true;
                        wykresButtonOpen.Enabled = true;
                        wykresButtonClose.Enabled = true;

                        tabControl1.Enabled = true;

                        
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    statusBox.Text = "Błąd z połączeniem";
                    return;
                }
            }else if (mySerial.IsOpen)
            {
                try
                {
                    mySerial.Close();
                    mySerial.DiscardInBuffer();
                    mySerial.DiscardOutBuffer();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
        //wypisywanie dane wyjściowe w textbox
        public void AddDataMethod(String myString)
        {
            receiveTextBox.AppendText(myString);
        }

        /* Append text to receiveTextBox*/
        private void update_receiveTextBox_event(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                if (receiveTextBox.Lines.Count() > 5000)
                    receiveTextBox.ResetText();
                receiveTextBox.AppendText("[RX]> " + data);
            }));
        }



        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            /*
             SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            //string indata = sp.ReadExisting();
            receiveData += indata + Environment.NewLine;

            receiveTextBox.BeginInvoke(this.myDelegate, new Object[] { indata });

            */
            if (mySerial.IsOpen)
            {
                try
                {
                    int dataLength = mySerial.BytesToRead;
                    byte[] dataReceived = new byte[dataLength];
                    int nbytes = mySerial.Read(dataReceived, 0, dataLength);

                    if (nbytes == 0) return;

                    //if()

                    this.BeginInvoke((Action)(() =>
                    {
                        data = System.Text.Encoding.Default.GetString(dataReceived);

                        if (!plotter_flag && !backgroundWorker1.IsBusy)
                        {
                            //if(opcjeToolStripMenuItem. == "HEX")
                            //data = BitConverter.ToString(dataReceived);

                            backgroundWorker1.RunWorkerAsync();
                        }
                        else if (plotter_flag)
                        {
                            double number;
                            string[] variables = data.Split('\n')[0].Split(',');
                            for (int i = 0; i < variables.Length && i < 5; i++)
                            {
                                if (double.TryParse(variables[i], out number))
                                {
                                    if (chart1.Series[i].Points.Count > 500)
                                        chart1.Series[i].Points.RemoveAt(0);
                                    chart1.Series[i].Points.Add(number);
                                }
                            }
                            chart1.ResetAutoValues();
                        }

                    }));  
                }
                catch (Exception)
                {

                    throw;
                }
            }
                
        
        }

        //zamykanie portu
        private void closeButton_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
                mySerial.Close();
        }
        //tworzenie obiektu wykres
        private void wykresButton_Click(object sender, EventArgs e)
        {
            try
            {
                plotter_flag = true;
            }
            catch (Exception)
            {   
                //poprawka
                statusBox.Text = "Time Exception";
                throw;
            }
        }

        private void SignalView_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                plotter_flag = true;
            else
                plotter_flag = false;
        }

        private void wykresButtonClose_Click(object sender, EventArgs e)
        {
            plotter_flag = false;
        }

        private void graphSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (setGraphMaxEnable.Checked)
                try
                {
                    graphMax.Value = (int)chart1.ChartAreas[0].AxisY.Maximum;
                    chart1.ChartAreas[0].AxisY.Maximum = (int)graphMax.Value;
                }
                catch { throw; }
            else
                chart1.ChartAreas[0].AxisY.Maximum = Double.NaN;

            graphMax.Enabled = setGraphMaxEnable.Checked;
        }

        private void graph_scale_ValueChanged(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Interval = (int)graphSpeed.Value;
        }
    }
}
