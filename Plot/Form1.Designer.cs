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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignalView));
            this.mySerial = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dopisaćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nadpiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sendData = new System.Windows.Forms.Button();
            this.tx_textarea = new System.Windows.Forms.TextBox();
            this.terminalTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.receiveTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.wykresButtonOpen = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.wykresButtonClose = new System.Windows.Forms.Button();
            this.plotterOption = new System.Windows.Forms.GroupBox();
            this.screenChart = new System.Windows.Forms.Button();
            this.graphMax = new System.Windows.Forms.NumericUpDown();
            this.setGraphMinEnable = new System.Windows.Forms.CheckBox();
            this.graphMin = new System.Windows.Forms.NumericUpDown();
            this.setGraphMaxEnable = new System.Windows.Forms.CheckBox();
            this.graphScale = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.graphSpeed = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Wykres = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.configurationBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.plotterOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphSpeed)).BeginInit();
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
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1219, 23);
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
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.DoubleClickEnabled = true;
            this.zapiszToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dopisaćToolStripMenuItem,
            this.nadpiszToolStripMenuItem,
            this.toolStripSeparator1,
            this.wyczyśćToolStripMenuItem});
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // dopisaćToolStripMenuItem
            // 
            this.dopisaćToolStripMenuItem.CheckOnClick = true;
            this.dopisaćToolStripMenuItem.Name = "dopisaćToolStripMenuItem";
            this.dopisaćToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dopisaćToolStripMenuItem.Text = "Dopisać";
            this.dopisaćToolStripMenuItem.Click += new System.EventHandler(this.dopisaćToolStripMenuItem_Click);
            // 
            // nadpiszToolStripMenuItem
            // 
            this.nadpiszToolStripMenuItem.CheckOnClick = true;
            this.nadpiszToolStripMenuItem.Name = "nadpiszToolStripMenuItem";
            this.nadpiszToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nadpiszToolStripMenuItem.Text = "Nadpisz";
            this.nadpiszToolStripMenuItem.Click += new System.EventHandler(this.nadpiszToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.DoubleClickEnabled = true;
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
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
            this.stringToolStripMenuItem.Click += new System.EventHandler(this.stringToolStripMenuItem_Click);
            // 
            // hexToolStripMenuItem
            // 
            this.hexToolStripMenuItem.Name = "hexToolStripMenuItem";
            this.hexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hexToolStripMenuItem.Text = "Hex";
            this.hexToolStripMenuItem.Click += new System.EventHandler(this.hexToolStripMenuItem_Click);
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
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
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
            this.configurationBox.Location = new System.Drawing.Point(13, 27);
            this.configurationBox.Name = "configurationBox";
            this.configurationBox.Size = new System.Drawing.Size(263, 189);
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
            // nameportCombobox
            // 
            this.nameportCombobox.FormattingEnabled = true;
            this.nameportCombobox.Location = new System.Drawing.Point(110, 19);
            this.nameportCombobox.Name = "nameportCombobox";
            this.nameportCombobox.Size = new System.Drawing.Size(121, 21);
            this.nameportCombobox.TabIndex = 6;
            this.nameportCombobox.Click += new System.EventHandler(this.nameportCombobox_Click);
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
            // szybkosctransmisjiLabel
            // 
            this.szybkosctransmisjiLabel.AutoSize = true;
            this.szybkosctransmisjiLabel.Location = new System.Drawing.Point(7, 49);
            this.szybkosctransmisjiLabel.Name = "szybkosctransmisjiLabel";
            this.szybkosctransmisjiLabel.Size = new System.Drawing.Size(98, 13);
            this.szybkosctransmisjiLabel.TabIndex = 4;
            this.szybkosctransmisjiLabel.Text = "Szybkość transmisji";
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
            this.openButton.Size = new System.Drawing.Size(100, 32);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Otwórz port";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Enabled = false;
            this.closeButton.Location = new System.Drawing.Point(282, 182);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 32);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(361, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wyślij";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sendData
            // 
            this.sendData.Location = new System.Drawing.Point(6, 37);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(63, 25);
            this.sendData.TabIndex = 15;
            this.sendData.Text = "Wyślij";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // tx_textarea
            // 
            this.tx_textarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tx_textarea.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_textarea.Location = new System.Drawing.Point(6, 6);
            this.tx_textarea.Name = "tx_textarea";
            this.tx_textarea.Size = new System.Drawing.Size(352, 24);
            this.tx_textarea.TabIndex = 16;
            // 
            // terminalTextBox
            // 
            this.terminalTextBox.Location = new System.Drawing.Point(6, 68);
            this.terminalTextBox.Name = "terminalTextBox";
            this.terminalTextBox.Size = new System.Drawing.Size(352, 397);
            this.terminalTextBox.TabIndex = 10;
            this.terminalTextBox.Text = "";
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
            // receiveTextBox
            // 
            this.receiveTextBox.Location = new System.Drawing.Point(6, 6);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.Size = new System.Drawing.Size(349, 457);
            this.receiveTextBox.TabIndex = 10;
            this.receiveTextBox.Text = "";
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
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(388, 27);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "1 czujnik";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "2 czujnik";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "3 czujnik";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "4 czujnik";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "5 czujnik";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(819, 620);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // wykresButtonOpen
            // 
            this.wykresButtonOpen.Enabled = false;
            this.wykresButtonOpen.Location = new System.Drawing.Point(282, 106);
            this.wykresButtonOpen.Name = "wykresButtonOpen";
            this.wykresButtonOpen.Size = new System.Drawing.Size(100, 32);
            this.wykresButtonOpen.TabIndex = 10;
            this.wykresButtonOpen.Text = "Wyświetl wykres";
            this.wykresButtonOpen.UseVisualStyleBackColor = true;
            this.wykresButtonOpen.Click += new System.EventHandler(this.wykresButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // wykresButtonClose
            // 
            this.wykresButtonClose.Enabled = false;
            this.wykresButtonClose.Location = new System.Drawing.Point(282, 144);
            this.wykresButtonClose.Name = "wykresButtonClose";
            this.wykresButtonClose.Size = new System.Drawing.Size(100, 32);
            this.wykresButtonClose.TabIndex = 11;
            this.wykresButtonClose.Text = "Zatrzymaj wykres";
            this.wykresButtonClose.UseVisualStyleBackColor = true;
            this.wykresButtonClose.Click += new System.EventHandler(this.wykresButtonClose_Click);
            // 
            // plotterOption
            // 
            this.plotterOption.Controls.Add(this.screenChart);
            this.plotterOption.Controls.Add(this.graphMax);
            this.plotterOption.Controls.Add(this.setGraphMinEnable);
            this.plotterOption.Controls.Add(this.graphMin);
            this.plotterOption.Controls.Add(this.setGraphMaxEnable);
            this.plotterOption.Controls.Add(this.graphScale);
            this.plotterOption.Controls.Add(this.label3);
            this.plotterOption.Controls.Add(this.graphSpeed);
            this.plotterOption.Controls.Add(this.label7);
            this.plotterOption.Location = new System.Drawing.Point(388, 653);
            this.plotterOption.Name = "plotterOption";
            this.plotterOption.Size = new System.Drawing.Size(819, 64);
            this.plotterOption.TabIndex = 26;
            this.plotterOption.TabStop = false;
            this.plotterOption.Text = "Ustawienia wykresu";
            // 
            // screenChart
            // 
            this.screenChart.Enabled = false;
            this.screenChart.Location = new System.Drawing.Point(713, 22);
            this.screenChart.Name = "screenChart";
            this.screenChart.Size = new System.Drawing.Size(100, 32);
            this.screenChart.TabIndex = 29;
            this.screenChart.Text = "Screen wykresu";
            this.screenChart.UseVisualStyleBackColor = true;
            this.screenChart.Click += new System.EventHandler(this.screenChart_Click);
            // 
            // graphMax
            // 
            this.graphMax.AutoSize = true;
            this.graphMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphMax.Enabled = false;
            this.graphMax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graphMax.Location = new System.Drawing.Point(137, 30);
            this.graphMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.graphMax.Name = "graphMax";
            this.graphMax.Size = new System.Drawing.Size(59, 20);
            this.graphMax.TabIndex = 28;
            this.graphMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graphMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graphMax.ValueChanged += new System.EventHandler(this.graphMax_ValueChanged);
            // 
            // setGraphMinEnable
            // 
            this.setGraphMinEnable.AutoSize = true;
            this.setGraphMinEnable.Enabled = false;
            this.setGraphMinEnable.Location = new System.Drawing.Point(202, 31);
            this.setGraphMinEnable.Name = "setGraphMinEnable";
            this.setGraphMinEnable.Size = new System.Drawing.Size(103, 17);
            this.setGraphMinEnable.TabIndex = 27;
            this.setGraphMinEnable.Text = "Ustaw Minimum:";
            this.setGraphMinEnable.UseVisualStyleBackColor = true;
            this.setGraphMinEnable.CheckedChanged += new System.EventHandler(this.setGraphMinEnable_CheckedChanged);
            // 
            // graphMin
            // 
            this.graphMin.AutoSize = true;
            this.graphMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphMin.Enabled = false;
            this.graphMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graphMin.Location = new System.Drawing.Point(311, 30);
            this.graphMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.graphMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graphMin.Name = "graphMin";
            this.graphMin.Size = new System.Drawing.Size(59, 20);
            this.graphMin.TabIndex = 26;
            this.graphMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graphMin.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.graphMin.ValueChanged += new System.EventHandler(this.graphMin_ValueChanged);
            // 
            // setGraphMaxEnable
            // 
            this.setGraphMaxEnable.AutoSize = true;
            this.setGraphMaxEnable.Enabled = false;
            this.setGraphMaxEnable.Location = new System.Drawing.Point(19, 31);
            this.setGraphMaxEnable.Name = "setGraphMaxEnable";
            this.setGraphMaxEnable.Size = new System.Drawing.Size(112, 17);
            this.setGraphMaxEnable.TabIndex = 25;
            this.setGraphMaxEnable.Text = "Ustaw Maksimum:";
            this.setGraphMaxEnable.UseVisualStyleBackColor = true;
            this.setGraphMaxEnable.CheckedChanged += new System.EventHandler(this.setGraphMaxEnable_CheckedChanged);
            // 
            // graphScale
            // 
            this.graphScale.AutoSize = true;
            this.graphScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphScale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graphScale.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.graphScale.Location = new System.Drawing.Point(426, 30);
            this.graphScale.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.graphScale.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.graphScale.Name = "graphScale";
            this.graphScale.ReadOnly = true;
            this.graphScale.Size = new System.Drawing.Size(53, 20);
            this.graphScale.TabIndex = 19;
            this.graphScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graphScale.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.graphScale.ValueChanged += new System.EventHandler(this.graph_scale_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Skala:";
            // 
            // graphSpeed
            // 
            this.graphSpeed.AllowDrop = true;
            this.graphSpeed.AutoSize = true;
            this.graphSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graphSpeed.Location = new System.Drawing.Point(556, 30);
            this.graphSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.graphSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graphSpeed.Name = "graphSpeed";
            this.graphSpeed.ReadOnly = true;
            this.graphSpeed.Size = new System.Drawing.Size(53, 20);
            this.graphSpeed.TabIndex = 17;
            this.graphSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graphSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graphSpeed.ValueChanged += new System.EventHandler(this.graphSpeed_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Przedział:";
            // 
            // Wykres
            // 
            this.Wykres.AutoSize = true;
            this.Wykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wykres.Location = new System.Drawing.Point(706, 0);
            this.Wykres.Name = "Wykres";
            this.Wykres.Size = new System.Drawing.Size(91, 26);
            this.Wykres.TabIndex = 27;
            this.Wykres.Text = "Wykres";
            this.Wykres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // message
            // 
            this.message.Text = "notifyIcon1";
            this.message.Visible = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.FileName = "figure";
            this.saveFileDialog1.Filter = "PNG|.png| JPEG|.jpg";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // SignalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 729);
            this.Controls.Add(this.Wykres);
            this.Controls.Add(this.plotterOption);
            this.Controls.Add(this.wykresButtonClose);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.wykresButtonOpen);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignalView_FormClosing);
            this.Load += new System.EventHandler(this.SignalView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.configurationBox.ResumeLayout(false);
            this.configurationBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.plotterOption.ResumeLayout(false);
            this.plotterOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphSpeed)).EndInit();
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
        private System.Windows.Forms.Button wykresButtonOpen;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.TextBox tx_textarea;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button wykresButtonClose;
        private System.Windows.Forms.GroupBox plotterOption;
        private System.Windows.Forms.NumericUpDown graphMax;
        private System.Windows.Forms.CheckBox setGraphMinEnable;
        private System.Windows.Forms.NumericUpDown graphMin;
        private System.Windows.Forms.CheckBox setGraphMaxEnable;
        private System.Windows.Forms.NumericUpDown graphScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown graphSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Wykres;
        private System.Windows.Forms.NotifyIcon message;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.Button screenChart;
    }
}

