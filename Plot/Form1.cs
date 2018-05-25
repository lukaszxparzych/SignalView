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


        public SignalView()
        {
            InitializeComponent();
            konfiguracja();
        }
        
        public void konfiguracja()
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
    }
}
