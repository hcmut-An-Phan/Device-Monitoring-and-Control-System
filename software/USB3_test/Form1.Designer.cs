
namespace USB3_test
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_connect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAI3 = new System.Windows.Forms.TextBox();
            this.txtAI2 = new System.Windows.Forms.TextBox();
            this.txtAI1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAI0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.led_4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.led_3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.led_2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.led_1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Freq = new System.Windows.Forms.TextBox();
            this.txtDuty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DO_3 = new System.Windows.Forms.CheckBox();
            this.DO_2 = new System.Windows.Forms.CheckBox();
            this.DO_1 = new System.Windows.Forms.CheckBox();
            this.DO_0 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DimGray;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Lime;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(762, 40);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select USB device to connect";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.DimGray;
            this.btn_connect.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.Color.Lime;
            this.btn_connect.Location = new System.Drawing.Point(31, 121);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(231, 54);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 221);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USB Device Connection";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(281, 121);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(512, 54);
            this.progressBar1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(141, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 41);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Read data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAI3);
            this.groupBox2.Controls.Add(this.txtAI2);
            this.groupBox2.Controls.Add(this.txtAI1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAI0);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.shapeContainer1);
            this.groupBox2.Location = new System.Drawing.Point(12, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 366);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(412, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 33);
            this.label11.TabIndex = 18;
            this.label11.Text = "AI 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 33);
            this.label10.TabIndex = 17;
            this.label10.Text = "AI 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(412, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 33);
            this.label9.TabIndex = 16;
            this.label9.Text = "AI 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(412, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 33);
            this.label8.TabIndex = 15;
            this.label8.Text = "AI 0";
            // 
            // txtAI3
            // 
            this.txtAI3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAI3.Location = new System.Drawing.Point(244, 295);
            this.txtAI3.Name = "txtAI3";
            this.txtAI3.Size = new System.Drawing.Size(152, 41);
            this.txtAI3.TabIndex = 14;
            // 
            // txtAI2
            // 
            this.txtAI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAI2.Location = new System.Drawing.Point(244, 225);
            this.txtAI2.Name = "txtAI2";
            this.txtAI2.Size = new System.Drawing.Size(152, 41);
            this.txtAI2.TabIndex = 13;
            // 
            // txtAI1
            // 
            this.txtAI1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAI1.Location = new System.Drawing.Point(244, 152);
            this.txtAI1.Name = "txtAI1";
            this.txtAI1.Size = new System.Drawing.Size(152, 41);
            this.txtAI1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "AI";
            // 
            // txtAI0
            // 
            this.txtAI0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAI0.Location = new System.Drawing.Point(244, 74);
            this.txtAI0.Name = "txtAI0";
            this.txtAI0.Size = new System.Drawing.Size(152, 41);
            this.txtAI0.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 33);
            this.label6.TabIndex = 8;
            this.label6.Text = "DI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Led 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Led 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Led 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Led 1";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.led_4,
            this.led_3,
            this.led_2,
            this.led_1});
            this.shapeContainer1.Size = new System.Drawing.Size(500, 345);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // led_4
            // 
            this.led_4.Location = new System.Drawing.Point(23, 263);
            this.led_4.Name = "led_4";
            this.led_4.Size = new System.Drawing.Size(62, 54);
            // 
            // led_3
            // 
            this.led_3.Location = new System.Drawing.Point(25, 193);
            this.led_3.Name = "led_3";
            this.led_3.Size = new System.Drawing.Size(62, 54);
            // 
            // led_2
            // 
            this.led_2.Location = new System.Drawing.Point(27, 120);
            this.led_2.Name = "led_2";
            this.led_2.Size = new System.Drawing.Size(62, 54);
            // 
            // led_1
            // 
            this.led_1.Location = new System.Drawing.Point(27, 43);
            this.led_1.Name = "led_1";
            this.led_1.Size = new System.Drawing.Size(62, 54);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_Freq);
            this.groupBox3.Controls.Add(this.txtDuty);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.DO_3);
            this.groupBox3.Controls.Add(this.DO_2);
            this.groupBox3.Controls.Add(this.DO_1);
            this.groupBox3.Controls.Add(this.DO_0);
            this.groupBox3.Location = new System.Drawing.Point(533, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(714, 365);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(541, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 33);
            this.label16.TabIndex = 25;
            this.label16.Text = "Send Data";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(141, 229);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(393, 41);
            this.textBox8.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(279, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 33);
            this.label15.TabIndex = 23;
            this.label15.Text = "Frequency(Hz)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(279, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 33);
            this.label14.TabIndex = 22;
            this.label14.Text = "Duty ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(135, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 33);
            this.label13.TabIndex = 21;
            this.label13.Text = "PWM";
            // 
            // txt_Freq
            // 
            this.txt_Freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Freq.Location = new System.Drawing.Point(141, 149);
            this.txt_Freq.Name = "txt_Freq";
            this.txt_Freq.Size = new System.Drawing.Size(132, 41);
            this.txt_Freq.TabIndex = 20;
            this.txt_Freq.Text = "100";
            this.txt_Freq.TextChanged += new System.EventHandler(this.txt_Freq_TextChanged);
            // 
            // txtDuty
            // 
            this.txtDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuty.Location = new System.Drawing.Point(141, 66);
            this.txtDuty.Name = "txtDuty";
            this.txtDuty.Size = new System.Drawing.Size(132, 41);
            this.txtDuty.TabIndex = 19;
            this.txtDuty.Text = "50";
            this.txtDuty.TextChanged += new System.EventHandler(this.txtDuty_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 33);
            this.label12.TabIndex = 19;
            this.label12.Text = "DI";
            // 
            // DO_3
            // 
            this.DO_3.AutoSize = true;
            this.DO_3.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DO_3.Location = new System.Drawing.Point(24, 298);
            this.DO_3.Name = "DO_3";
            this.DO_3.Size = new System.Drawing.Size(97, 37);
            this.DO_3.TabIndex = 3;
            this.DO_3.Text = "Q0.3";
            this.DO_3.UseVisualStyleBackColor = true;
            // 
            // DO_2
            // 
            this.DO_2.AutoSize = true;
            this.DO_2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DO_2.Location = new System.Drawing.Point(24, 229);
            this.DO_2.Name = "DO_2";
            this.DO_2.Size = new System.Drawing.Size(97, 37);
            this.DO_2.TabIndex = 2;
            this.DO_2.Text = "Q0.2";
            this.DO_2.UseVisualStyleBackColor = true;
            // 
            // DO_1
            // 
            this.DO_1.AutoSize = true;
            this.DO_1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DO_1.Location = new System.Drawing.Point(24, 155);
            this.DO_1.Name = "DO_1";
            this.DO_1.Size = new System.Drawing.Size(97, 37);
            this.DO_1.TabIndex = 1;
            this.DO_1.Text = "Q0.1";
            this.DO_1.UseVisualStyleBackColor = true;
            // 
            // DO_0
            // 
            this.DO_0.AutoSize = true;
            this.DO_0.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DO_0.Location = new System.Drawing.Point(24, 72);
            this.DO_0.Name = "DO_0";
            this.DO_0.Size = new System.Drawing.Size(97, 37);
            this.DO_0.TabIndex = 0;
            this.DO_0.Text = "Q0.0";
            this.DO_0.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::USB3_test.Properties.Resources.logo3x;
            this.pictureBox1.Location = new System.Drawing.Point(1044, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 205);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::USB3_test.Properties.Resources.logo_bachkhoa__1_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 206);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ATMEGA32U4_USB_COMUNICTE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAI3;
        private System.Windows.Forms.TextBox txtAI2;
        private System.Windows.Forms.TextBox txtAI1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAI0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape led_4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape led_3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape led_2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape led_1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Freq;
        private System.Windows.Forms.TextBox txtDuty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox DO_3;
        private System.Windows.Forms.CheckBox DO_2;
        private System.Windows.Forms.CheckBox DO_1;
        private System.Windows.Forms.CheckBox DO_0;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

