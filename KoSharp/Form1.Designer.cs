namespace KoSharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HpKoordX = new System.Windows.Forms.Label();
            this.HpKoordY = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.MpKoordX = new System.Windows.Forms.Label();
            this.MpKoordY = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.OtoAtak = new System.Windows.Forms.CheckBox();
            this.OtoHp = new System.Windows.Forms.CheckBox();
            this.OtoMp = new System.Windows.Forms.CheckBox();
            this.OtoWolf = new System.Windows.Forms.CheckBox();
            this.OtoDef = new System.Windows.Forms.CheckBox();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Knight OnLine Client";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Handle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "zr3";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(311, 90);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(125, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 500;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hız(ms)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Basılacak Tuş";
            // 
            // HpKoordX
            // 
            this.HpKoordX.AutoSize = true;
            this.HpKoordX.Location = new System.Drawing.Point(243, 142);
            this.HpKoordX.Name = "HpKoordX";
            this.HpKoordX.Size = new System.Drawing.Size(56, 13);
            this.HpKoordX.TabIndex = 10;
            this.HpKoordX.Text = "HpKoordX";
            // 
            // HpKoordY
            // 
            this.HpKoordY.AutoSize = true;
            this.HpKoordY.Location = new System.Drawing.Point(321, 142);
            this.HpKoordY.Name = "HpKoordY";
            this.HpKoordY.Size = new System.Drawing.Size(56, 13);
            this.HpKoordY.TabIndex = 11;
            this.HpKoordY.Text = "HpKoordY";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "2";
            // 
            // MpKoordX
            // 
            this.MpKoordX.AutoSize = true;
            this.MpKoordX.Location = new System.Drawing.Point(243, 182);
            this.MpKoordX.Name = "MpKoordX";
            this.MpKoordX.Size = new System.Drawing.Size(57, 13);
            this.MpKoordX.TabIndex = 14;
            this.MpKoordX.Text = "MpKoordX";
            // 
            // MpKoordY
            // 
            this.MpKoordY.AutoSize = true;
            this.MpKoordY.Location = new System.Drawing.Point(321, 182);
            this.MpKoordY.Name = "MpKoordY";
            this.MpKoordY.Size = new System.Drawing.Size(57, 13);
            this.MpKoordY.TabIndex = 15;
            this.MpKoordY.Text = "MpKoordY";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "6";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(323, 215);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "78";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "AtakBaslat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "HpKoordinatAl";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 491);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "MpKoordinatAl";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(432, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Koordinat al butonuna bastıktan sonra mouseyi alınacak noktaya götürüp k tuşuna b" +
    "asınız.";
            // 
            // timer2
            // 
            this.timer2.Interval = 122000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 16000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // OtoAtak
            // 
            this.OtoAtak.AutoSize = true;
            this.OtoAtak.Location = new System.Drawing.Point(12, 93);
            this.OtoAtak.Name = "OtoAtak";
            this.OtoAtak.Size = new System.Drawing.Size(65, 17);
            this.OtoAtak.TabIndex = 24;
            this.OtoAtak.Text = "OtoAtak";
            this.OtoAtak.UseVisualStyleBackColor = true;
            // 
            // OtoHp
            // 
            this.OtoHp.AutoSize = true;
            this.OtoHp.Location = new System.Drawing.Point(12, 137);
            this.OtoHp.Name = "OtoHp";
            this.OtoHp.Size = new System.Drawing.Size(57, 17);
            this.OtoHp.TabIndex = 25;
            this.OtoHp.Text = "OtoHp";
            this.OtoHp.UseVisualStyleBackColor = true;
            // 
            // OtoMp
            // 
            this.OtoMp.AutoSize = true;
            this.OtoMp.Location = new System.Drawing.Point(12, 178);
            this.OtoMp.Name = "OtoMp";
            this.OtoMp.Size = new System.Drawing.Size(58, 17);
            this.OtoMp.TabIndex = 26;
            this.OtoMp.Text = "OtoMp";
            this.OtoMp.UseVisualStyleBackColor = true;
            // 
            // OtoWolf
            // 
            this.OtoWolf.AutoSize = true;
            this.OtoWolf.Location = new System.Drawing.Point(12, 218);
            this.OtoWolf.Name = "OtoWolf";
            this.OtoWolf.Size = new System.Drawing.Size(65, 17);
            this.OtoWolf.TabIndex = 27;
            this.OtoWolf.Text = "OtoWolf";
            this.OtoWolf.UseVisualStyleBackColor = true;
            // 
            // OtoDef
            // 
            this.OtoDef.AutoSize = true;
            this.OtoDef.Location = new System.Drawing.Point(220, 218);
            this.OtoDef.Name = "OtoDef";
            this.OtoDef.Size = new System.Drawing.Size(60, 17);
            this.OtoDef.TabIndex = 28;
            this.OtoDef.Text = "OtoDef";
            this.OtoDef.UseVisualStyleBackColor = true;
            // 
            // timer5
            // 
            this.timer5.Interval = 500;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(257, 491);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Atak Durdur";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 522);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.OtoDef);
            this.Controls.Add(this.OtoWolf);
            this.Controls.Add(this.OtoMp);
            this.Controls.Add(this.OtoHp);
            this.Controls.Add(this.OtoAtak);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.MpKoordY);
            this.Controls.Add(this.MpKoordX);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.HpKoordY);
            this.Controls.Add(this.HpKoordX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "KoSharp";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label HpKoordX;
        private System.Windows.Forms.Label HpKoordY;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label MpKoordX;
        private System.Windows.Forms.Label MpKoordY;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.CheckBox OtoAtak;
        private System.Windows.Forms.CheckBox OtoHp;
        private System.Windows.Forms.CheckBox OtoMp;
        private System.Windows.Forms.CheckBox OtoWolf;
        private System.Windows.Forms.CheckBox OtoDef;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Button button5;
    }
}

