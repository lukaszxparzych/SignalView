namespace Plot
{
    partial class SignalView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignalView));
            this.mySerial = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dopisaćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nadpiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationBox = new System.Windows.Forms.GroupBox();
            this.nazwaportuLabel = new System.Windows.Forms.Label();
            this.szybkosctransmisjiLabel = new System.Windows.Forms.Label();
            this.bitydanychLabel = new System.Windows.Forms.Label();
            this.nameportCombobox = new System.Windows.Forms.ComboBox();
            this.predkoscCombobox = new System.Windows.Forms.ComboBox();
            this.bitdanychCombobox = new System.Windows.Forms.ComboBox();
            this.bitparzystosciCombobox = new System.Windows.Forms.ComboBox();
            this.bitstopuCombobox = new System.Windows.Forms.ComboBox();
            this.bitparzystosciLabel = new System.Windows.Forms.Label();
            this.bitstopuLabel = new System.Windows.Forms.Label();
            this.flowcontrolCombobox = new System.Windows.Forms.ComboBox();
            this.flowcontrolLabel = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytywanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.receiveTextBox = new System.Windows.Forms.RichTextBox();
            this.sendTextBox = new System.Windows.Forms.RichTextBox();
            this.wykresButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.configurationBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(394, 23);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 19);
            this.plikToolStripMenuItem.Text = "Plik";
            this.plikToolStripMenuItem.Click += new System.EventHandler(this.plikToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 19);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dopisaćToolStripMenuItem,
            this.nadpiszToolStripMenuItem});
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // dopisaćToolStripMenuItem
            // 
            this.dopisaćToolStripMenuItem.Name = "dopisaćToolStripMenuItem";
            this.dopisaćToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dopisaćToolStripMenuItem.Text = "Dopisać";
            // 
            // nadpiszToolStripMenuItem
            // 
            this.nadpiszToolStripMenuItem.Name = "nadpiszToolStripMenuItem";
            this.nadpiszToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nadpiszToolStripMenuItem.Text = "Nadpisz";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // configurationBox
            // 
            this.configurationBox.Controls.Add(this.flowcontrolCombobox);
            this.configurationBox.Controls.Add(this.flowcontrolLabel);
            this.configurationBox.Controls.Add(this.bitparzystosciCombobox);
            this.configurationBox.Controls.Add(this.bitstopuCombobox);
            this.configurationBox.Controls.Add(this.bitparzystosciLabel);
            this.configurationBox.Controls.Add(this.bitstopuLabel);
            this.configurationBox.Controls.Add(this.bitdanychCombobox);
            this.configurationBox.Controls.Add(this.predkoscCombobox);
            this.configurationBox.Controls.Add(this.nameportCombobox);
            this.configurationBox.Controls.Add(this.bitydanychLabel);
            this.configurationBox.Controls.Add(this.szybkosctransmisjiLabel);
            this.configurationBox.Controls.Add(this.nazwaportuLabel);
            this.configurationBox.Location = new System.Drawing.Point(13, 27);
            this.configurationBox.Name = "configurationBox";
            this.configurationBox.Size = new System.Drawing.Size(263, 189);
            this.configurationBox.TabIndex = 2;
            this.configurationBox.TabStop = false;
            this.configurationBox.Text = "Opcje konfiguracji połączenia";
            // 
            // nazwaportuLabel
            // 
            this.nazwaportuLabel.AutoSize = true;
            this.nazwaportuLabel.Location = new System.Drawing.Point(38, 22);
            this.nazwaportuLabel.Name = "nazwaportuLabel";
            this.nazwaportuLabel.Size = new System.Drawing.Size(67, 13);
            this.nazwaportuLabel.TabIndex = 3;
            this.nazwaportuLabel.Text = "Nazwa portu";
            // 
            // szybkosctransmisjiLabel
            // 
            this.szybkosctransmisjiLabel.AutoSize = true;
            this.szybkosctransmisjiLabel.Location = new System.Drawing.Point(7, 49);
            this.szybkosctransmisjiLabel.Name = "szybkosctransmisjiLabel";
            this.szybkosctransmisjiLabel.Size = new System.Drawing.Size(98, 13);
            this.szybkosctransmisjiLabel.TabIndex = 4;
            this.szybkosctransmisjiLabel.Text = "Szybkość transmisji";
            // 
            // bitydanychLabel
            // 
            this.bitydanychLabel.AutoSize = true;
            this.bitydanychLabel.Location = new System.Drawing.Point(43, 76);
            this.bitydanychLabel.Name = "bitydanychLabel";
            this.bitydanychLabel.Size = new System.Drawing.Size(62, 13);
            this.bitydanychLabel.TabIndex = 5;
            this.bitydanychLabel.Text = "Bity danych";
            // 
            // nameportCombobox
            // 
            this.nameportCombobox.FormattingEnabled = true;
            this.nameportCombobox.Location = new System.Drawing.Point(110, 19);
            this.nameportCombobox.Name = "nameportCombobox";
            this.nameportCombobox.Size = new System.Drawing.Size(121, 21);
            this.nameportCombobox.TabIndex = 6;
            // 
            // predkoscCombobox
            // 
            this.predkoscCombobox.FormattingEnabled = true;
            this.predkoscCombobox.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "153600",
            "230400",
            "256000",
            "460800",
            "921600"});
            this.predkoscCombobox.Location = new System.Drawing.Point(110, 46);
            this.predkoscCombobox.Name = "predkoscCombobox";
            this.predkoscCombobox.Size = new System.Drawing.Size(121, 21);
            this.predkoscCombobox.TabIndex = 7;
            // 
            // bitdanychCombobox
            // 
            this.bitdanychCombobox.FormattingEnabled = true;
            this.bitdanychCombobox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.bitdanychCombobox.Location = new System.Drawing.Point(110, 73);
            this.bitdanychCombobox.Name = "bitdanychCombobox";
            this.bitdanychCombobox.Size = new System.Drawing.Size(121, 21);
            this.bitdanychCombobox.TabIndex = 7;
            // 
            // bitparzystosciCombobox
            // 
            this.bitparzystosciCombobox.FormattingEnabled = true;
            this.bitparzystosciCombobox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.bitparzystosciCombobox.Location = new System.Drawing.Point(110, 127);
            this.bitparzystosciCombobox.Name = "bitparzystosciCombobox";
            this.bitparzystosciCombobox.Size = new System.Drawing.Size(121, 21);
            this.bitparzystosciCombobox.TabIndex = 10;
            // 
            // bitstopuCombobox
            // 
            this.bitstopuCombobox.FormattingEnabled = true;
            this.bitstopuCombobox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.bitstopuCombobox.Location = new System.Drawing.Point(110, 100);
            this.bitstopuCombobox.Name = "bitstopuCombobox";
            this.bitstopuCombobox.Size = new System.Drawing.Size(121, 21);
            this.bitstopuCombobox.TabIndex = 11;
            // 
            // bitparzystosciLabel
            // 
            this.bitparzystosciLabel.AutoSize = true;
            this.bitparzystosciLabel.Location = new System.Drawing.Point(30, 130);
            this.bitparzystosciLabel.Name = "bitparzystosciLabel";
            this.bitparzystosciLabel.Size = new System.Drawing.Size(74, 13);
            this.bitparzystosciLabel.TabIndex = 9;
            this.bitparzystosciLabel.Text = "Bit parzystości";
            // 
            // bitstopuLabel
            // 
            this.bitstopuLabel.AutoSize = true;
            this.bitstopuLabel.Location = new System.Drawing.Point(56, 103);
            this.bitstopuLabel.Name = "bitstopuLabel";
            this.bitstopuLabel.Size = new System.Drawing.Size(48, 13);
            this.bitstopuLabel.TabIndex = 8;
            this.bitstopuLabel.Text = "Bit stopu";
            // 
            // flowcontrolCombobox
            // 
            this.flowcontrolCombobox.FormattingEnabled = true;
            this.flowcontrolCombobox.Items.AddRange(new object[] {
            "None",
            "RTS",
            "RTS/X",
            "Xon/Xoff"});
            this.flowcontrolCombobox.Location = new System.Drawing.Point(110, 154);
            this.flowcontrolCombobox.Name = "flowcontrolCombobox";
            this.flowcontrolCombobox.Size = new System.Drawing.Size(121, 21);
            this.flowcontrolCombobox.TabIndex = 13;
            // 
            // flowcontrolLabel
            // 
            this.flowcontrolLabel.AutoSize = true;
            this.flowcontrolLabel.Location = new System.Drawing.Point(41, 157);
            this.flowcontrolLabel.Name = "flowcontrolLabel";
            this.flowcontrolLabel.Size = new System.Drawing.Size(64, 13);
            this.flowcontrolLabel.TabIndex = 12;
            this.flowcontrolLabel.Text = "Flow control";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(282, 42);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(100, 20);
            this.statusBox.TabIndex = 8;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(282, 68);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 37);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Otwórz port";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Enabled = false;
            this.closeButton.Location = new System.Drawing.Point(284, 179);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(98, 37);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Zamknij port";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odczytywanieToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // odczytywanieToolStripMenuItem
            // 
            this.odczytywanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringToolStripMenuItem,
            this.hexToolStripMenuItem});
            this.odczytywanieToolStripMenuItem.Name = "odczytywanieToolStripMenuItem";
            this.odczytywanieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odczytywanieToolStripMenuItem.Text = "Odczytywanie";
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.Checked = true;
            this.stringToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            this.stringToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stringToolStripMenuItem.Text = "String";
            // 
            // hexToolStripMenuItem
            // 
            this.hexToolStripMenuItem.Name = "hexToolStripMenuItem";
            this.hexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hexToolStripMenuItem.Text = "Hex";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sendTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(361, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wyślij";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.receiveTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(361, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Odczytaj";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(13, 222);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.Location = new System.Drawing.Point(6, 6);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.Size = new System.Drawing.Size(349, 457);
            this.receiveTextBox.TabIndex = 10;
            this.receiveTextBox.Text = "";
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(6, 6);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(349, 457);
            this.sendTextBox.TabIndex = 10;
            this.sendTextBox.Text = "";
            // 
            // wykresButton
            // 
            this.wykresButton.Enabled = false;
            this.wykresButton.Location = new System.Drawing.Point(282, 111);
            this.wykresButton.Name = "wykresButton";
            this.wykresButton.Size = new System.Drawing.Size(100, 59);
            this.wykresButton.TabIndex = 10;
            this.wykresButton.Text = "Wyświetl wykres";
            this.wykresButton.UseVisualStyleBackColor = true;
            // 
            // SignalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 729);
            this.Controls.Add(this.wykresButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.configurationBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignalView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.configurationBox.ResumeLayout(false);
            this.configurationBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort mySerial;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dopisaćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nadpiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.GroupBox configurationBox;
        private System.Windows.Forms.ComboBox flowcontrolCombobox;
        private System.Windows.Forms.Label flowcontrolLabel;
        private System.Windows.Forms.ComboBox bitparzystosciCombobox;
        private System.Windows.Forms.ComboBox bitstopuCombobox;
        private System.Windows.Forms.Label bitparzystosciLabel;
        private System.Windows.Forms.Label bitstopuLabel;
        private System.Windows.Forms.ComboBox bitdanychCombobox;
        private System.Windows.Forms.ComboBox predkoscCombobox;
        private System.Windows.Forms.ComboBox nameportCombobox;
        private System.Windows.Forms.Label bitydanychLabel;
        private System.Windows.Forms.Label szybkosctransmisjiLabel;
        private System.Windows.Forms.Label nazwaportuLabel;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytywanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox receiveTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RichTextBox sendTextBox;
        private System.Windows.Forms.Button wykresButton;
    }
}

