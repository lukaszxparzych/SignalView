/*
Praca inżynierska
Łukasz Parzych 
*/
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
        String path;
        public string data { get; set; }
        String[] ports;
        System.IO.StreamWriter out_file;
        System.IO.StreamReader in_file;
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;
        int graph_scaler = 500;
        bool plotterBool = false;
       

        public SignalView()
        {
            InitializeComponent();
            configuration();
        }
        
        public void configuration()
        {
            alert("Witam!");
            ports = SerialPort.GetPortNames();
            mySerial.DataReceived += DataReceivedHandler;
            nameportCombobox.Items.AddRange(ports);
            backgroundWorker1.DoWork += new DoWorkEventHandler(update_receiveTextBox_event);

            dopisaćToolStripMenuItem.Enabled = true;
            nadpiszToolStripMenuItem.Enabled = true;
            wyczyśćToolStripMenuItem.Enabled = true;


            bitdanychCombobox.SelectedIndex = 0;
            bitstopuCombobox.SelectedIndex = 0;
            bitparzystosciCombobox.SelectedIndex = 0;
            flowcontrolCombobox.SelectedIndex = 0;

            for (int i = 0; i < 5; i++)
                chart1.Series[i].Points.Add(0);

        }

        public void findPorts()
        {
            if(ports.Length != 0)
            {
                Array.Clear(ports, 0, ports.Length);
                nameportCombobox.Items.Clear();
            }
            ports = SerialPort.GetPortNames();
            nameportCombobox.Items.AddRange(ports);
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
                        alert("Otworzono port");
                        tx_textarea.Enabled = true;
                                                  
                        closeButton.Enabled = true;
                        wykresButtonOpen.Enabled = true;

                        dopisaćToolStripMenuItem.Enabled = false;
                        nadpiszToolStripMenuItem.Enabled = false;
                        wyczyśćToolStripMenuItem.Enabled = false;

                        tabControl1.Enabled = true;

                        nameportCombobox.Enabled = false;
                        predkoscCombobox.Enabled = false;
                        bitdanychCombobox.Enabled = false;
                        bitstopuCombobox.Enabled = false;
                        bitparzystosciCombobox.Enabled = false;
                        flowcontrolCombobox.Enabled = false;

                        setGraphMaxEnable.Enabled = true;
                        setGraphMinEnable.Enabled = true;
                        graphScale.ReadOnly = false;
                        graphSpeed.ReadOnly = false;
                        screenChart.Enabled = true;

                        
                        mySerial.BaudRate = (Int32.Parse(predkoscCombobox.Text.ToString()));
                        mySerial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (bitstopuCombobox.Text), true);
                        mySerial.Parity = (Parity)Enum.Parse(typeof(Parity), bitparzystosciCombobox.Text.ToString(), true);
                        //mySerial.DataBits = (Int32.Parse(bitdanychCombobox.Text.ToString()));
                        //mySerial.Handshake = (Handshake)Enum.Parse(typeof(Handshake), flowcontrolCombobox.Text.ToString(), true);
                        


                        if (dopisaćToolStripMenuItem.Checked)
                        {
                            try
                            {
                                out_file = new System.IO.StreamWriter(path, dopisaćToolStripMenuItem.Checked);
                            }
                            catch
                            {
                                alert("Nie mogę zapisać do " + path + " plik może być otwarty przez inny program1"); return;
                            }
                        }
                     

                    }
                }
                catch (UnauthorizedAccessException)
                {
                    statusBox.Text = "Błąd z połączeniem";
                    alert("Błąd z połączeniem");
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
                        terminalTextBox.AppendText(tx_data + "\n");
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
                receiveTextBox.AppendText(data);
            }));
        }



        public void DataReceivedHandler(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (mySerial.IsOpen)
            {
                try
                {
                    int dataLength = mySerial.BytesToRead;
                    byte[] dataReceived = new byte[dataLength];
                    int nbytes = mySerial.Read(dataReceived, 0, dataLength);

                    if (nbytes == 0) return;

                    if (dopisaćToolStripMenuItem.Checked)
                    {
                        try
                        { out_file.Write(data.Replace("\\n", Environment.NewLine)); }
                        catch { alert("Nie mogę zapisać do " + path + " plik może być otwarty przez inny program"); return; }
                    }


                    this.BeginInvoke((Action)(() =>
                    {
                        data = System.Text.Encoding.Default.GetString(dataReceived);

                        
                        if (!plotterBool && !backgroundWorker1.IsBusy)
                        {
                            if(hexToolStripMenuItem.Checked)
                            data = BitConverter.ToString(dataReceived);

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
            if (mySerial.IsOpen) { 
                mySerial.Close();

                dopisaćToolStripMenuItem.Enabled = true;
                nadpiszToolStripMenuItem.Enabled = true;
                wyczyśćToolStripMenuItem.Enabled = true;

                closeButton.Enabled = false;
                wykresButtonOpen.Enabled = false;
                screenChart.Enabled = false;

                tabControl1.Enabled = false;

                setGraphMaxEnable.Enabled = false;
                setGraphMinEnable.Enabled = false;
                graphScale.ReadOnly = true;
                graphSpeed.ReadOnly = true;

                nameportCombobox.Enabled = true;
                predkoscCombobox.Enabled = true;
                bitdanychCombobox.Enabled = true;
                bitstopuCombobox.Enabled = true;
                bitparzystosciCombobox.Enabled = true;
                flowcontrolCombobox.Enabled = true;

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                tx_textarea.Clear();
                receiveTextBox.Clear();
                terminalTextBox.Clear();

                statusBox.Text = "Zamknięto port";
                alert("Zamknięto port");

                if (dopisaćToolStripMenuItem.Checked || nadpiszToolStripMenuItem.Checked) { 
                    try { out_file.Dispose(); }
                    catch {}
                }
            }
        }
        //tworzenie obiektu wykres
        private void wykresButton_Click(object sender, EventArgs e)
        {
            try
            {
                wykresButtonOpen.Enabled = false;
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
            wykresButtonOpen.Enabled = true;
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
            message.ShowBalloonTip(3000, "Praca Inżynierska", text, ToolTipIcon.Info);
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
            if (dopisaćToolStripMenuItem.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                }
                else
                {
                    dopisaćToolStripMenuItem.Checked = false;
                }
            }
        }

        private void nadpiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dopisaćToolStripMenuItem.Checked = false;

            if (nadpiszToolStripMenuItem.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                }
                else
                {
                    nadpiszToolStripMenuItem.Checked = false;
                }
            }
        }

        private void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dopisaćToolStripMenuItem.Checked == true || nadpiszToolStripMenuItem.Checked == true)
            { 
                dopisaćToolStripMenuItem.Checked = false;
                nadpiszToolStripMenuItem.Checked = false;
                path = "";
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sendData_Click(object sender, EventArgs e)
        {

            if(tx_textarea.Text.Length != 0)
            {
                try
                {
                    String data;
                    data = tx_textarea.Text;
                    mySerial.WriteLine(data);
                    tx_textarea.Text = "";
                 
                    terminalTextBox.AppendText("[TX]> " + data + "\n");
                }
                catch
                {
                    alert("Nie można wysłać do " + mySerial.PortName + ", port może być używany w innym programie!");
                }
            }
            else
            {
                alert("Wpisz dane");
            }
            //terminalTextBox.Clear();

            }

       
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
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                chart1.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Png);
        }

        private void nameportCombobox_Click(object sender, EventArgs e)
        {
            findPorts();
        }

        private void hexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stringToolStripMenuItem.Checked = false;
            hexToolStripMenuItem.Checked = true;
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hexToolStripMenuItem.Checked = false;
            stringToolStripMenuItem.Checked = true;

        }
    }
}
