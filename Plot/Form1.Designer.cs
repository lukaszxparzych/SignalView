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
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dopisaćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nadpiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytywanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationBox = new System.Windows.Forms.GroupBox();
            this.flowcontrolCombobox = new System.Windows.Forms.ComboBox();
            this.flowcontrolLabel = new System.Windows.Forms.Label();
            this.bitparzystosciCombobox = new System.Windows.Forms.ComboBox();
            this.bitstopuCombobox = new System.Windows.Forms.ComboBox();
            this.bitparzystosciLabel = new System.Windows.Forms.Label();
            this.bitstopuLabel = new System.Windows.Forms.Label();
            this.bitdanychCombobox = new System.Windows.Forms.ComboBox();
            this.predkoscCombobox = new System.Windows.Forms.ComboBox();
            this.nameportCombobox = new System.Windows.Forms.ComboBox();
            this.bitydanychLabel = new System.Windows.Forms.Label();
            this.szybkosctransmisjiLabel = new System.Windows.Forms.Label();
            this.nazwaportuLabel = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.terminalTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.receiveTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wykresButton = new System.Windows.Forms.Button();
            this.sendData = new System.Windows.Forms.Button();
            this.tx_textarea = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.configurationBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(525, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            this.plikToolStripMenuItem.Click += new System.EventHandler(this.plikToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dopisaćToolStripMenuItem,
            this.nadpiszToolStripMenuItem});
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // dopisaćToolStripMenuItem
            // 
            this.dopisaćToolStripMenuItem.Name = "dopisaćToolStripMenuItem";
            this.dopisaćToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.dopisaćToolStripMenuItem.Text = "Dopisać";
            // 
            // nadpiszToolStripMenuItem
            // 
            this.nadpiszToolStripMenuItem.Name = "nadpiszToolStripMenuItem";
            this.nadpiszToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nadpiszToolStripMenuItem.Text = "Nadpisz";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odczytywanieToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // odczytywanieToolStripMenuItem
            // 
            this.odczytywanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringToolStripMenuItem,
            this.hexToolStripMenuItem});
            this.odczytywanieToolStripMenuItem.Name = "odczytywanieToolStripMenuItem";
            this.odczytywanieToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.odczytywanieToolStripMenuItem.Text = "Odczytywanie";
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.Checked = true;
            this.stringToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            this.stringToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.stringToolStripMenuItem.Text = "String";
            // 
            // hexToolStripMenuItem
            // 
            this.hexToolStripMenuItem.Name = "hexToolStripMenuItem";
            this.hexToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.hexToolStripMenuItem.Text = "Hex";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.infoToolStripMenuItem.Text = "Info";
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
            this.configurationBox.Location = new System.Drawing.Point(17, 33);
            this.configurationBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.configurationBox.Name = "configurationBox";
            this.configurationBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.configurationBox.Size = new System.Drawing.Size(351, 233);
            this.configurationBox.TabIndex = 2;
            this.configurationBox.TabStop = false;
            this.configurationBox.Text = "Opcje konfiguracji połączenia";
            // 
            // flowcontrolCombobox
            // 
            this.flowcontrolCombobox.FormattingEnabled = true;
            this.flowcontrolCombobox.Items.AddRange(new object[] {
            "None",
            "RTS",
            "RTS/X",
            "Xon/Xoff"});
            this.flowcontrolCombobox.Location = new System.Drawing.Point(147, 190);
            this.flowcontrolCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowcontrolCombobox.Name = "flowcontrolCombobox";
            this.flowcontrolCombobox.Size = new System.Drawing.Size(160, 24);
            this.flowcontrolCombobox.TabIndex = 13;
            // 
            // flowcontrolLabel
            // 
            this.flowcontrolLabel.AutoSize = true;
            this.flowcontrolLabel.Location = new System.Drawing.Point(55, 193);
            this.flowcontrolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flowcontrolLabel.Name = "flowcontrolLabel";
            this.flowcontrolLabel.Size = new System.Drawing.Size(83, 17);
            this.flowcontrolLabel.TabIndex = 12;
            this.flowcontrolLabel.Text = "Flow control";
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
            this.bitparzystosciCombobox.Location = new System.Drawing.Point(147, 156);
            this.bitparzystosciCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bitparzystosciCombobox.Name = "bitparzystosciCombobox";
            this.bitparzystosciCombobox.Size = new System.Drawing.Size(160, 24);
            this.bitparzystosciCombobox.TabIndex = 10;
            // 
            // bitstopuCombobox
            // 
            this.bitstopuCombobox.FormattingEnabled = true;
            this.bitstopuCombobox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.bitstopuCombobox.Location = new System.Drawing.Point(147, 123);
            this.bitstopuCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bitstopuCombobox.Name = "bitstopuCombobox";
            this.bitstopuCombobox.Size = new System.Drawing.Size(160, 24);
            this.bitstopuCombobox.TabIndex = 11;
            // 
            // bitparzystosciLabel
            // 
            this.bitparzystosciLabel.AutoSize = true;
            this.bitparzystosciLabel.Location = new System.Drawing.Point(40, 160);
            this.bitparzystosciLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitparzystosciLabel.Name = "bitparzystosciLabel";
            this.bitparzystosciLabel.Size = new System.Drawing.Size(99, 17);
            this.bitparzystosciLabel.TabIndex = 9;
            this.bitparzystosciLabel.Text = "Bit parzystości";
            // 
            // bitstopuLabel
            // 
            this.bitstopuLabel.AutoSize = true;
            this.bitstopuLabel.Location = new System.Drawing.Point(75, 127);
            this.bitstopuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitstopuLabel.Name = "bitstopuLabel";
            this.bitstopuLabel.Size = new System.Drawing.Size(63, 17);
            this.bitstopuLabel.TabIndex = 8;
            this.bitstopuLabel.Text = "Bit stopu";
            // 
            // bitdanychCombobox
            // 
            this.bitdanychCombobox.FormattingEnabled = true;
            this.bitdanychCombobox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.bitdanychCombobox.Location = new System.Drawing.Point(147, 90);
            this.bitdanychCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bitdanychCombobox.Name = "bitdanychCombobox";
            this.bitdanychCombobox.Size = new System.Drawing.Size(160, 24);
            this.bitdanychCombobox.TabIndex = 7;
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
            this.predkoscCombobox.Location = new System.Drawing.Point(147, 57);
            this.predkoscCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.predkoscCombobox.Name = "predkoscCombobox";
            this.predkoscCombobox.Size = new System.Drawing.Size(160, 24);
            this.predkoscCombobox.TabIndex = 7;
            // 
            // nameportCombobox
            // 
            this.nameportCombobox.FormattingEnabled = true;
            this.nameportCombobox.Location = new System.Drawing.Point(147, 23);
            this.nameportCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameportCombobox.Name = "nameportCombobox";
            this.nameportCombobox.Size = new System.Drawing.Size(160, 24);
            this.nameportCombobox.TabIndex = 6;
            // 
            // bitydanychLabel
            // 
            this.bitydanychLabel.AutoSize = true;
            this.bitydanychLabel.Location = new System.Drawing.Point(57, 94);
            this.bitydanychLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitydanychLabel.Name = "bitydanychLabel";
            this.bitydanychLabel.Size = new System.Drawing.Size(81, 17);
            this.bitydanychLabel.TabIndex = 5;
            this.bitydanychLabel.Text = "Bity danych";
            // 
            // szybkosctransmisjiLabel
            // 
            this.szybkosctransmisjiLabel.AutoSize = true;
            this.szybkosctransmisjiLabel.Location = new System.Drawing.Point(9, 60);
            this.szybkosctransmisjiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.szybkosctransmisjiLabel.Name = "szybkosctransmisjiLabel";
            this.szybkosctransmisjiLabel.Size = new System.Drawing.Size(131, 17);
            this.szybkosctransmisjiLabel.TabIndex = 4;
            this.szybkosctransmisjiLabel.Text = "Szybkość transmisji";
            // 
            // nazwaportuLabel
            // 
            this.nazwaportuLabel.AutoSize = true;
            this.nazwaportuLabel.Location = new System.Drawing.Point(51, 27);
            this.nazwaportuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazwaportuLabel.Name = "nazwaportuLabel";
            this.nazwaportuLabel.Size = new System.Drawing.Size(87, 17);
            this.nazwaportuLabel.TabIndex = 3;
            this.nazwaportuLabel.Text = "Nazwa portu";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(376, 52);
            this.statusBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(132, 22);
            this.statusBox.TabIndex = 8;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(376, 84);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(133, 46);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Otwórz port";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Enabled = false;
            this.closeButton.Location = new System.Drawing.Point(376, 220);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(129, 46);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Zamknij port";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sendData);
            this.tabPage2.Controls.Add(this.tx_textarea);
            this.tabPage2.Controls.Add(this.terminalTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(484, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wyślij";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // terminalTextBox
            // 
            this.terminalTextBox.Location = new System.Drawing.Point(8, 84);
            this.terminalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.terminalTextBox.Name = "terminalTextBox";
            this.terminalTextBox.Size = new System.Drawing.Size(468, 488);
            this.terminalTextBox.TabIndex = 10;
            this.terminalTextBox.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.receiveTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(484, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Odczytaj";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.Location = new System.Drawing.Point(8, 7);
            this.receiveTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.Size = new System.Drawing.Size(464, 562);
            this.receiveTextBox.TabIndex = 10;
            this.receiveTextBox.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(17, 273);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // wykresButton
            // 
            this.wykresButton.Enabled = false;
            this.wykresButton.Location = new System.Drawing.Point(376, 137);
            this.wykresButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wykresButton.Name = "wykresButton";
            this.wykresButton.Size = new System.Drawing.Size(133, 73);
            this.wykresButton.TabIndex = 10;
            this.wykresButton.Text = "Wyświetl wykres";
            this.wykresButton.UseVisualStyleBackColor = true;
            this.wykresButton.Click += new System.EventHandler(this.wykresButton_Click);
            // 
            // sendData
            // 
            this.sendData.Location = new System.Drawing.Point(8, 45);
            this.sendData.Margin = new System.Windows.Forms.Padding(4);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(84, 31);
            this.sendData.TabIndex = 15;
            this.sendData.Text = "Wyślij";
            this.sendData.UseVisualStyleBackColor = true;
            // 
            // tx_textarea
            // 
            this.tx_textarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tx_textarea.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_textarea.Location = new System.Drawing.Point(8, 8);
            this.tx_textarea.Margin = new System.Windows.Forms.Padding(4);
            this.tx_textarea.Name = "tx_textarea";
            this.tx_textarea.Size = new System.Drawing.Size(468, 29);
            this.tx_textarea.TabIndex = 16;
            // 
            // SignalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 897);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.RichTextBox terminalTextBox;
        private System.Windows.Forms.Button wykresButton;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.TextBox tx_textarea;
    }
}

