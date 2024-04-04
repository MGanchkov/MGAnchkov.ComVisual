namespace MGAnchkov.ComVisual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            BaudRate = new ComboBox();
            PortName = new ComboBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label8 = new Label();
            label1 = new Label();
            DataBits = new NumericUpDown();
            label7 = new Label();
            StopBits = new ComboBox();
            label2 = new Label();
            label6 = new Label();
            Parity = new ComboBox();
            groupBox2 = new GroupBox();
            CBStop = new CheckBox();
            GBStop = new GroupBox();
            RStopByteStr = new RadioButton();
            RStopByteHex = new RadioButton();
            RStopByteDec = new RadioButton();
            TStopByte = new TextBox();
            groupBox4 = new GroupBox();
            TBSkipByte = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CBTypeReadValue = new ComboBox();
            CBStart = new CheckBox();
            GBStart = new GroupBox();
            RStartByteStr = new RadioButton();
            RStartByteHex = new RadioButton();
            RStartByteDec = new RadioButton();
            TStartByte = new TextBox();
            button2 = new Button();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataBits).BeginInit();
            groupBox2.SuspendLayout();
            GBStop.SuspendLayout();
            groupBox4.SuspendLayout();
            GBStart.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(103, 191);
            button1.Name = "button1";
            button1.Size = new Size(98, 28);
            button1.TabIndex = 0;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            // 
            // BaudRate
            // 
            BaudRate.FormattingEnabled = true;
            BaudRate.Location = new Point(76, 32);
            BaudRate.Name = "BaudRate";
            BaudRate.Size = new Size(121, 23);
            BaudRate.TabIndex = 1;
            // 
            // PortName
            // 
            PortName.FormattingEnabled = true;
            PortName.Location = new Point(76, 3);
            PortName.Name = "PortName";
            PortName.Size = new Size(121, 23);
            PortName.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 227);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Подключение";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DataBits);
            panel1.Controls.Add(BaudRate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(PortName);
            panel1.Controls.Add(StopBits);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Parity);
            panel1.Location = new Point(3, 19);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 145);
            panel1.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 92);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 10;
            label8.Text = "Data Bits:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Port Name:";
            // 
            // DataBits
            // 
            DataBits.Location = new Point(76, 90);
            DataBits.Name = "DataBits";
            DataBits.Size = new Size(50, 23);
            DataBits.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 122);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 8;
            label7.Text = "Stop Bits:";
            // 
            // StopBits
            // 
            StopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            StopBits.FormattingEnabled = true;
            StopBits.Location = new Point(76, 119);
            StopBits.Name = "StopBits";
            StopBits.Size = new Size(121, 23);
            StopBits.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Baud Rate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 64);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 6;
            label6.Text = "Parity:";
            // 
            // Parity
            // 
            Parity.DropDownStyle = ComboBoxStyle.DropDownList;
            Parity.FormattingEnabled = true;
            Parity.Location = new Point(76, 61);
            Parity.Name = "Parity";
            Parity.Size = new Size(121, 23);
            Parity.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CBStop);
            groupBox2.Controls.Add(GBStop);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(CBStart);
            groupBox2.Controls.Add(GBStart);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(225, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 227);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Данные";
            // 
            // CBStop
            // 
            CBStop.AutoSize = true;
            CBStop.Location = new Point(10, 133);
            CBStop.Name = "CBStop";
            CBStop.Size = new Size(161, 19);
            CBStop.TabIndex = 8;
            CBStop.Text = "Биты окончания данных";
            CBStop.UseVisualStyleBackColor = true;
            CBStop.CheckedChanged += CBStop_CheckedChanged;
            // 
            // GBStop
            // 
            GBStop.Controls.Add(RStopByteStr);
            GBStop.Controls.Add(RStopByteHex);
            GBStop.Controls.Add(RStopByteDec);
            GBStop.Controls.Add(TStopByte);
            GBStop.Enabled = false;
            GBStop.Location = new Point(6, 133);
            GBStop.Name = "GBStop";
            GBStop.Size = new Size(448, 52);
            GBStop.TabIndex = 9;
            GBStop.TabStop = false;
            // 
            // RStopByteStr
            // 
            RStopByteStr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RStopByteStr.AutoSize = true;
            RStopByteStr.Location = new Point(386, 0);
            RStopByteStr.Name = "RStopByteStr";
            RStopByteStr.Size = new Size(56, 19);
            RStopByteStr.TabIndex = 8;
            RStopByteStr.TabStop = true;
            RStopByteStr.Text = "String";
            RStopByteStr.UseVisualStyleBackColor = true;
            RStopByteStr.CheckedChanged += RStopByte_CheckedChanged;
            // 
            // RStopByteHex
            // 
            RStopByteHex.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RStopByteHex.AutoSize = true;
            RStopByteHex.Checked = true;
            RStopByteHex.Location = new Point(334, 0);
            RStopByteHex.Name = "RStopByteHex";
            RStopByteHex.Size = new Size(46, 19);
            RStopByteHex.TabIndex = 2;
            RStopByteHex.TabStop = true;
            RStopByteHex.Text = "Hex";
            RStopByteHex.UseVisualStyleBackColor = true;
            RStopByteHex.CheckedChanged += RStopByte_CheckedChanged;
            // 
            // RStopByteDec
            // 
            RStopByteDec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RStopByteDec.AutoSize = true;
            RStopByteDec.Location = new Point(283, 0);
            RStopByteDec.Name = "RStopByteDec";
            RStopByteDec.Size = new Size(45, 19);
            RStopByteDec.TabIndex = 1;
            RStopByteDec.TabStop = true;
            RStopByteDec.Text = "Dec";
            RStopByteDec.UseVisualStyleBackColor = true;
            RStopByteDec.CheckedChanged += RStopByte_CheckedChanged;
            // 
            // TStopByte
            // 
            TStopByte.Location = new Point(6, 22);
            TStopByte.Name = "TStopByte";
            TStopByte.Size = new Size(436, 23);
            TStopByte.TabIndex = 0;
            TStopByte.TextChanged += TStopByte_TextChanged;
            TStopByte.KeyPress += TStopByte_KeyPress;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(TBSkipByte);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(CBTypeReadValue);
            groupBox4.Location = new Point(6, 80);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(448, 47);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Данные";
            // 
            // TBSkipByte
            // 
            TBSkipByte.Location = new Point(87, 16);
            TBSkipByte.Name = "TBSkipByte";
            TBSkipByte.Size = new Size(82, 23);
            TBSkipByte.TabIndex = 6;
            TBSkipByte.TextChanged += TBSkipByte_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 1;
            label3.Text = "Пропускать:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 19);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 2;
            label4.Text = "байт";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 19);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 5;
            label5.Text = "Считывать:";
            // 
            // CBTypeReadValue
            // 
            CBTypeReadValue.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTypeReadValue.FormattingEnabled = true;
            CBTypeReadValue.Location = new Point(321, 16);
            CBTypeReadValue.Name = "CBTypeReadValue";
            CBTypeReadValue.Size = new Size(121, 23);
            CBTypeReadValue.TabIndex = 4;
            // 
            // CBStart
            // 
            CBStart.AutoSize = true;
            CBStart.Location = new Point(10, 22);
            CBStart.Name = "CBStart";
            CBStart.Size = new Size(140, 19);
            CBStart.TabIndex = 7;
            CBStart.Text = "Биты начала данных";
            CBStart.UseVisualStyleBackColor = true;
            CBStart.CheckedChanged += CBStart_CheckedChanged;
            // 
            // GBStart
            // 
            GBStart.Controls.Add(RStartByteStr);
            GBStart.Controls.Add(RStartByteHex);
            GBStart.Controls.Add(RStartByteDec);
            GBStart.Controls.Add(TStartByte);
            GBStart.Enabled = false;
            GBStart.Location = new Point(6, 22);
            GBStart.Name = "GBStart";
            GBStart.Size = new Size(448, 52);
            GBStart.TabIndex = 7;
            GBStart.TabStop = false;
            // 
            // RStartByteStr
            // 
            RStartByteStr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RStartByteStr.AutoSize = true;
            RStartByteStr.Location = new Point(386, 0);
            RStartByteStr.Name = "RStartByteStr";
            RStartByteStr.Size = new Size(56, 19);
            RStartByteStr.TabIndex = 8;
            RStartByteStr.TabStop = true;
            RStartByteStr.Text = "String";
            RStartByteStr.UseVisualStyleBackColor = true;
            RStartByteStr.CheckedChanged += RStartByte_CheckedChanged;
            // 
            // RStartByteHex
            // 
            RStartByteHex.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RStartByteHex.AutoSize = true;
            RStartByteHex.Checked = true;
            RStartByteHex.Location = new Point(334, 0);
            RStartByteHex.Name = "RStartByteHex";
            RStartByteHex.Size = new Size(46, 19);
            RStartByteHex.TabIndex = 2;
            RStartByteHex.TabStop = true;
            RStartByteHex.Text = "Hex";
            RStartByteHex.UseVisualStyleBackColor = true;
            RStartByteHex.CheckedChanged += RStartByte_CheckedChanged;
            // 
            // RStartByteDec
            // 
            RStartByteDec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RStartByteDec.AutoSize = true;
            RStartByteDec.Location = new Point(283, 0);
            RStartByteDec.Name = "RStartByteDec";
            RStartByteDec.Size = new Size(45, 19);
            RStartByteDec.TabIndex = 1;
            RStartByteDec.TabStop = true;
            RStartByteDec.Text = "Dec";
            RStartByteDec.UseVisualStyleBackColor = true;
            RStartByteDec.CheckedChanged += RStartByte_CheckedChanged;
            // 
            // TStartByte
            // 
            TStartByte.Location = new Point(6, 22);
            TStartByte.Name = "TStartByte";
            TStartByte.Size = new Size(436, 23);
            TStartByte.TabIndex = 0;
            TStartByte.TextChanged += TStartByte_TextChanged;
            TStartByte.KeyPress += TStartByte_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(372, 191);
            button2.Name = "button2";
            button2.Size = new Size(82, 28);
            button2.TabIndex = 3;
            button2.Text = "График";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(667, 355);
            textBox1.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Location = new Point(12, 245);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(673, 377);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Данные";
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(611, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "String";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(559, 0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hex";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(508, 0);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(45, 19);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Dec";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 707);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataBits).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            GBStop.ResumeLayout(false);
            GBStop.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            GBStart.ResumeLayout(false);
            GBStart.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox BaudRate;
        private ComboBox PortName;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label5;
        private ComboBox CBTypeReadValue;
        private Button button2;
        private CheckBox CBStart;
        private GroupBox GBStart;
        private RadioButton RStartByteStr;
        private RadioButton RStartByteHex;
        private RadioButton RStartByteDec;
        private TextBox TStartByte;
        private GroupBox groupBox4;
        private CheckBox CBStop;
        private GroupBox GBStop;
        private RadioButton RStopByteStr;
        private RadioButton RStopByteHex;
        private RadioButton RStopByteDec;
        private TextBox TStopByte;
        private Label label8;
        private NumericUpDown DataBits;
        private Label label7;
        private ComboBox StopBits;
        private Label label6;
        private ComboBox Parity;
        private Panel panel1;
        private TextBox TBSkipByte;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}
