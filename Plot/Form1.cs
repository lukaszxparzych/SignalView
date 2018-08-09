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
        public SignalView()
        {
            InitializeComponent();
            configuration();
        }
        
        public void configuration()
        {
            String[] ports = SerialPort.GetPortNames();
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
                        wykresButton.Enabled = true;

                        tabControl1.Enabled = true;

                        

                    }
                }
                catch (UnauthorizedAccessException)
                {
                    statusBox.Text = "Błąd z połączeniem";
                    return;
                }
            }
        }
        //wypisywanie dane wyjściowe w textbox
        public void AddDataMethod(String myString)
        {
            receiveTextBox.AppendText(myString);
        }



        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            //string indata = sp.ReadExisting();
            receiveData += indata + Environment.NewLine;

           



            receiveTextBox.BeginInvoke(this.myDelegate, new Object[] { indata });


            if (mySerial.IsOpen)
            {
                
            }
        }

        /* Append text to rx_textarea*/
        private void update_rxtextarea_event(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                if (receiveTextBox.Lines.Count() > 5000)
                    receiveTextBox.ResetText();
                receiveTextBox.AppendText("[RX]> " + data);
            }));
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
                this.myDelegate = new AddDataDelegate(AddDataMethod);
                mySerial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception)
            {   
                //poprawka
                statusBox.Text = "Time Exception";
                throw;
            }
        }
    }
}
