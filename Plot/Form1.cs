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
using System.Windows.Forms.DataVisualization.Charting;



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
        int graph_scaler = 500;
        bool send_data_flag = false;
        bool plotterBool = false;
        public SignalView()
        {
            InitializeComponent();
            configuration();
        }
        
        public void configuration()
        {
            alert("Witam!");
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
                        alert("Wybierz port");
                    }
                    else if (predkoscCombobox.Text == "")
                    {
                        statusBox.Text = "Wybierz szybkość";
                        alert("Wybierz szybkość");
                    }
                    else if (bitdanychCombobox.Text == "")
                    {
                        statusBox.Text = "Wybierz bit danych";
                        alert("Wybierz bit danych");
                    }
                    else if (bitstopuCombobox.Text == "")
                    {
                        statusBox.Text = "Wybierz bit stopu";
                        alert("Wybierz bit stopu");
                    }
                    else if (bitparzystosciCombobox.Text == "")
                    {
                        statusBox.Text = "Wybierz bit parzystości";
                        alert("Wybierz bit parzystości");
                    }
                    else if (flowcontrolCombobox.Text == "")
                    {
                        statusBox.Text = "Wybierz flow control";
                        alert("Wybierz flow control");
                    }
                    else
                    {


                        mySerial.PortName = nameportCombobox.Text;
                        mySerial.BaudRate = Convert.ToInt32(predkoscCombobox.Text);                        
                        mySerial.Open();
                        statusBox.Text = "OK";

                                                  
                        closeButton.Enabled = true;
                        wykresButtonOpen.Enabled = true;

                        tabControl1.Enabled = true;

                        setGraphMaxEnable.Enabled = true;
                        setGraphMinEnable.Enabled = true;
                        graphScale.ReadOnly = false;
                        graphSpeed.ReadOnly = false;

                        mySerial.BaudRate = (Int32.Parse(predkoscCombobox.Text));
                        mySerial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (bitstopuCombobox.SelectedIndex + 1).ToString(), true);
                        mySerial.Parity = (Parity)Enum.Parse(typeof(Parity), bitparzystosciCombobox.SelectedIndex.ToString(), true);
                        mySerial.DataBits = (Int32.Parse(bitdanychCombobox.Text));
                        mySerial.Handshake = (Handshake)Enum.Parse(typeof(Handshake), flowcontrolCombobox.SelectedIndex.ToString(), true);



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

        private void send_data(object sender, EventArgs e)
        {

            string tx_data = "";

            
                if (mySerial.IsOpen)
                {
                    try
                    {

                        mySerial.Write(tx_data.Replace("\\n", Environment.NewLine));
                        terminalTextBox.AppendText("[TX]> " + tx_data + "\n");
                    }
                    catch
                    {
                        alert("Nie można wysłać do " + mySerial.PortName + " port może być używany w innym programie!");
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

                        if (!plotterBool && !backgroundWorker1.IsBusy)
                        {
                            //if(opcjeToolStripMenuItem. == "HEX")
                            //data = BitConverter.ToString(dataReceived);

                            backgroundWorker1.RunWorkerAsync();
                        }
                        else if (plotterBool)
                        {
                            double number;
                            string[] variables = data.Split('\n')[0].Split(',');
                            for (int i = 0; i < variables.Length && i < 5; i++)
                            {
                                if (double.TryParse(variables[i], out number))
                                {
                                    if (chart1.Series[i].Points.Count > graph_scaler)
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
                setGraphMaxEnable.Enabled = true;
                setGraphMinEnable.Enabled = true;
                graphScale.ReadOnly = false;
                graphSpeed.ReadOnly = false;

                wykresButtonClose.Enabled = true;
                plotterBool = true;

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
                plotterBool = true;
            else
                plotterBool = false;
        }

        private void wykresButtonClose_Click(object sender, EventArgs e)
        {
            plotterBool = false;
            wykresButtonClose.Enabled = false;
            setGraphMaxEnable.Enabled = false;
            setGraphMinEnable.Enabled = false;
            graphScale.ReadOnly = true;
            graphSpeed.ReadOnly = true;
        }

        private void graphSpeed_ValueChanged(object sender, EventArgs e)
        {

            chart1.ChartAreas[0].AxisY.Interval = (int)graphSpeed.Value;


        }

        private void graph_scale_ValueChanged(object sender, EventArgs e)
        {
            graph_scaler = (int)graphScale.Value;
            for (int i = 0; i < 5; i++)
                chart1.Series[i].Points.Clear();
        }

        private void SignalView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mySerial.IsOpen)
                mySerial.Close();
        }

        private void setGraphMaxEnable_CheckedChanged(object sender, EventArgs e)
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

        private void setGraphMinEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (setGraphMinEnable.Checked)
                try
                {
                    graphMin.Value = (int)chart1.ChartAreas[0].AxisY.Minimum;
                    chart1.ChartAreas[0].AxisY.Minimum = (int)graphMin.Value;
                }
                catch { throw; }
            else
                chart1.ChartAreas[0].AxisY.Minimum = Double.NaN;

            graphMin.Enabled = setGraphMinEnable.Checked;
        }

        private void graphMax_ValueChanged(object sender, EventArgs e)
        {
            if (graphMax.Value > graphMin.Value)
                chart1.ChartAreas[0].AxisY.Maximum = (int)graphMax.Value;
            else
                alert("Zła maksymalna wartość");
        }

        private void alert(string text)
        {
            message.Icon = Icon;
            message.Visible = true;
            message.ShowBalloonTip(5000, "Praca Inżynierska", text, ToolTipIcon.Info);
        }

        private void information(string text)
        {        
            message.Icon = Icon;
            message.Visible = true;
            message.ShowBalloonTip(5000, "Serial Lab", text, ToolTipIcon.Error);
        }

        private void graphMin_ValueChanged(object sender, EventArgs e)
        {
            if (graphMax.Value > graphMin.Value)
                chart1.ChartAreas[0].AxisY.Minimum = (int)graphMin.Value;
            else
                alert("Zła minimalna wartość");
        }

        private void dopisaćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nadpiszToolStripMenuItem.Checked = false;
        }

        private void nadpiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dopisaćToolStripMenuItem.Checked = false;
        }

        private void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dopisaćToolStripMenuItem.Checked == true || nadpiszToolStripMenuItem.Checked == true) { 
            dopisaćToolStripMenuItem.Checked = false;
            nadpiszToolStripMenuItem.Checked = false;
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sendData_Click(object sender, EventArgs e)
        {
            terminalTextBox.Clear();

            }

        //get number of lines
        private int file_size(string path)
        {
            var file = new StreamReader(path).ReadToEnd();
            string[] lines = file.Split(new char[] { '\n' });
            int count = lines.Count();
            return count;
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void screenChart_Click(object sender, EventArgs e)
        {
            chart1.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Png);
        }

        /*
        // save graph as image
        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                graph.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Png);
        }
        //clear graph
        private void clear_graph_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                graph.Series[i].Points.Clear();
        }
        */

    }
}
