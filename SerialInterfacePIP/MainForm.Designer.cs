namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Status_Indicator = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBox_RTSEnable = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBox_PortName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox_Parity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBox_Handshake = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox_DTREnable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_DiscardNull = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_DataBits = new System.Windows.Forms.ComboBox();
            this.Serial_Port = new System.IO.Ports.SerialPort(this.components);
            this.Status_Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Message_Recieved_Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arduinoFreetronicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status_Indicator)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baud Rate";
            // 
            // ComboBox_BaudRate
            // 
            this.ComboBox_BaudRate.FormattingEnabled = true;
            this.ComboBox_BaudRate.Location = new System.Drawing.Point(256, 19);
            this.ComboBox_BaudRate.Name = "ComboBox_BaudRate";
            this.ComboBox_BaudRate.Size = new System.Drawing.Size(176, 21);
            this.ComboBox_BaudRate.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Status_Indicator);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ComboBox_StopBits);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ComboBox_RTSEnable);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ComboBox_PortName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ComboBox_Parity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboBox_Handshake);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ComboBox_DTREnable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboBox_DiscardNull);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBox_DataBits);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBox_BaudRate);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 302);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Properties";
            // 
            // Status_Indicator
            // 
            this.Status_Indicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Status_Indicator.Location = new System.Drawing.Point(411, 262);
            this.Status_Indicator.Name = "Status_Indicator";
            this.Status_Indicator.Size = new System.Drawing.Size(21, 21);
            this.Status_Indicator.TabIndex = 5;
            this.Status_Indicator.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Stop Bits";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBox_StopBits
            // 
            this.ComboBox_StopBits.FormattingEnabled = true;
            this.ComboBox_StopBits.Location = new System.Drawing.Point(256, 235);
            this.ComboBox_StopBits.Name = "ComboBox_StopBits";
            this.ComboBox_StopBits.Size = new System.Drawing.Size(176, 21);
            this.ComboBox_StopBits.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "RTS Enable";
            // 
            // ComboBox_RTSEnable
            // 
            this.ComboBox_RTSEnable.FormattingEnabled = true;
            this.ComboBox_RTSEnable.Location = new System.Drawing.Point(256, 208);
            this.ComboBox_RTSEnable.Name = "ComboBox_RTSEnable";
            this.ComboBox_RTSEnable.Size = new System.Drawing.Size(176, 21);
            this.ComboBox_RTSEnable.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Port Name";
            // 
            // ComboBox_PortName
            // 
            this.ComboBox_PortName.FormattingEnabled = true;
            this.ComboBox_PortName.Location = new System.Drawing.Point(256, 181);
            this.ComboBox_PortName.Name = "ComboBox_PortName";
            this.ComboBox_PortName.Size = new System.Drawing.Size(176, 21);
            this.ComboBox_PortName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Parity";
            // 
            // ComboBox_Parity
            // 
            this.ComboBox_Parity.FormattingEnabled = true;
            this.ComboBox_Parity.Location = new System.Drawing.Point(256, 154);
            this.ComboBox_Parity.Name = "ComboBox_Parity";
            this.ComboBox_Parity.Size = new System.Drawing.Size(176, 21);
            this.ComboBox_Parity.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Handshake";
            // 
            // ComboBox_Handshake
            // 
            this.ComboBox_Handshake.FormattingEnabled = true;
            this.ComboBox_Handshake.Location = new System.Drawing.Point(256, 127);
            this.ComboBox_Handshake.Name = "ComboBox_Handshake";
            this.ComboBox_Handshake.Size = new System.Drawing.Size(176, 21);
            this.ComboBox_Handshake.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DTR Enable";
            // 
            // ComboBox_DTREnable
            // 
            this.ComboBox_DTREnable.FormattingEnabled = true;
            this.ComboBox_DTREnable.Location = new System.Drawing.Point(256, 100);
            this.ComboBox_DTREnable.Name = "ComboBox_DTREnable";
            this.ComboBox_DTREnable.Size = new System.Drawing.Size(176, 21);
            this.ComboBox_DTREnable.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Discard Null";
            // 
            // ComboBox_DiscardNull
            // 
            this.ComboBox_DiscardNull.FormattingEnabled = true;
            this.ComboBox_DiscardNull.Location = new System.Drawing.Point(256, 73);
            this.ComboBox_DiscardNull.Name = "ComboBox_DiscardNull";
            this.ComboBox_DiscardNull.Size = new System.Drawing.Size(176, 21);
            this.ComboBox_DiscardNull.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Bits";
            // 
            // ComboBox_DataBits
            // 
            this.ComboBox_DataBits.FormattingEnabled = true;
            this.ComboBox_DataBits.Location = new System.Drawing.Point(256, 46);
            this.ComboBox_DataBits.Name = "ComboBox_DataBits";
            this.ComboBox_DataBits.Size = new System.Drawing.Size(176, 21);
            this.ComboBox_DataBits.TabIndex = 4;
            // 
            // Status_Timer
            // 
            this.Status_Timer.Enabled = true;
            this.Status_Timer.Tick += new System.EventHandler(this.Status_Timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 99);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Transmit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(411, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(423, 20);
            this.textBox2.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 21);
            this.button3.TabIndex = 19;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Baud Rate";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(12, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 221);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Received";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 19);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(423, 186);
            this.textBox3.TabIndex = 10;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Message_Recieved_Timer
            // 
            this.Message_Recieved_Timer.Enabled = true;
            this.Message_Recieved_Timer.Interval = 1000;
            this.Message_Recieved_Timer.Tick += new System.EventHandler(this.Message_Recieved_Timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickToolStripMenuItem,
            this.refreshConnectionsToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // quickToolStripMenuItem
            // 
            this.quickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arduinoFreetronicsToolStripMenuItem});
            this.quickToolStripMenuItem.Name = "quickToolStripMenuItem";
            this.quickToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quickToolStripMenuItem.Text = "Quick";
            // 
            // arduinoFreetronicsToolStripMenuItem
            // 
            this.arduinoFreetronicsToolStripMenuItem.Name = "arduinoFreetronicsToolStripMenuItem";
            this.arduinoFreetronicsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.arduinoFreetronicsToolStripMenuItem.Text = "Arduino (Freetronics)";
            this.arduinoFreetronicsToolStripMenuItem.Click += new System.EventHandler(this.arduinoFreetronicsToolStripMenuItem_Click);
            // 
            // refreshConnectionsToolStripMenuItem
            // 
            this.refreshConnectionsToolStripMenuItem.Name = "refreshConnectionsToolStripMenuItem";
            this.refreshConnectionsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.refreshConnectionsToolStripMenuItem.Text = "Refresh Connections";
            this.refreshConnectionsToolStripMenuItem.Click += new System.EventHandler(this.refreshConnectionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(472, 678);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Serial Interface (PIP)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status_Indicator)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_BaudRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Status_Indicator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboBox_StopBits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBox_RTSEnable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBox_PortName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBox_Parity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBox_Handshake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBox_DTREnable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_DiscardNull;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_DataBits;
        private System.IO.Ports.SerialPort Serial_Port;
        private System.Windows.Forms.Timer Status_Timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer Message_Recieved_Timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arduinoFreetronicsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem refreshConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

