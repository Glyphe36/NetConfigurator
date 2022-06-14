namespace NetConfigurtor
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ipAuto = new System.Windows.Forms.Label();
            this.masque = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sec_Dns = new IPv4Address.IPv4AddressTextBox();
            this.pri_Dns = new IPv4Address.IPv4AddressTextBox();
            this.getway = new IPv4Address.IPv4AddressTextBox();
            this.ip_address = new IPv4Address.IPv4AddressTextBox();
            this.subnet_mask = new IPv4Address.IPv4AddressTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assitance de configuration IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 72);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Les parametres IP sont a determines \r\npar leur utilisation Accre/preview ...\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresse IP :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Masque de sous-Reseau :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Passerelle Par default :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "DNS prefere :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "DNS auxiliaire :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nom ordinateur :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(162, 533);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(130, 22);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 573);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 58);
            this.panel2.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 25);
            this.button2.TabIndex = 34;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(22, 85);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(130, 22);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ip Automatique :";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(22, 113);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 22);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "Ip Manuel :";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Desk",
            "Preview",
            "Room",
            "Display",
            "Accre"});
            this.comboBox1.Location = new System.Drawing.Point(244, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 22);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ipAuto
            // 
            this.ipAuto.AutoSize = true;
            this.ipAuto.Location = new System.Drawing.Point(213, 27);
            this.ipAuto.Name = "ipAuto";
            this.ipAuto.Size = new System.Drawing.Size(46, 14);
            this.ipAuto.TabIndex = 20;
            this.ipAuto.Text = "Ip Auto";
            // 
            // masque
            // 
            this.masque.AutoSize = true;
            this.masque.Location = new System.Drawing.Point(213, 65);
            this.masque.Name = "masque";
            this.masque.Size = new System.Drawing.Size(51, 14);
            this.masque.TabIndex = 23;
            this.masque.Text = "Masque";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "Ip Auto";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // sec_Dns
            // 
            this.sec_Dns.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.sec_Dns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sec_Dns.BackColor = System.Drawing.SystemColors.Window;
            this.sec_Dns.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec_Dns.IPAddress = ((System.Net.IPAddress)(resources.GetObject("sec_Dns.IPAddress")));
            this.sec_Dns.Location = new System.Drawing.Point(222, 272);
            this.sec_Dns.Margin = new System.Windows.Forms.Padding(2);
            this.sec_Dns.Name = "sec_Dns";
            this.sec_Dns.Size = new System.Drawing.Size(158, 23);
            this.sec_Dns.TabIndex = 31;
            // 
            // pri_Dns
            // 
            this.pri_Dns.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.pri_Dns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pri_Dns.BackColor = System.Drawing.SystemColors.Window;
            this.pri_Dns.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pri_Dns.IPAddress = ((System.Net.IPAddress)(resources.GetObject("pri_Dns.IPAddress")));
            this.pri_Dns.Location = new System.Drawing.Point(222, 232);
            this.pri_Dns.Margin = new System.Windows.Forms.Padding(2);
            this.pri_Dns.Name = "pri_Dns";
            this.pri_Dns.Size = new System.Drawing.Size(158, 23);
            this.pri_Dns.TabIndex = 30;
            this.pri_Dns.Load += new System.EventHandler(this.iPv4AddressTextBox4_Load);
            // 
            // getway
            // 
            this.getway.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.getway.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getway.BackColor = System.Drawing.SystemColors.Window;
            this.getway.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getway.IPAddress = ((System.Net.IPAddress)(resources.GetObject("getway.IPAddress")));
            this.getway.Location = new System.Drawing.Point(222, 150);
            this.getway.Margin = new System.Windows.Forms.Padding(2);
            this.getway.Name = "getway";
            this.getway.Size = new System.Drawing.Size(158, 23);
            this.getway.TabIndex = 29;
            // 
            // ip_address
            // 
            this.ip_address.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.ip_address.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ip_address.BackColor = System.Drawing.SystemColors.Window;
            this.ip_address.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_address.IPAddress = ((System.Net.IPAddress)(resources.GetObject("ip_address.IPAddress")));
            this.ip_address.Location = new System.Drawing.Point(222, 72);
            this.ip_address.Margin = new System.Windows.Forms.Padding(2);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(158, 23);
            this.ip_address.TabIndex = 28;
            this.ip_address.Load += new System.EventHandler(this.ip_address_Load);
            // 
            // subnet_mask
            // 
            this.subnet_mask.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.subnet_mask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subnet_mask.BackColor = System.Drawing.SystemColors.Window;
            this.subnet_mask.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnet_mask.IPAddress = ((System.Net.IPAddress)(resources.GetObject("subnet_mask.IPAddress")));
            this.subnet_mask.Location = new System.Drawing.Point(222, 111);
            this.subnet_mask.Margin = new System.Windows.Forms.Padding(2);
            this.subnet_mask.Name = "subnet_mask";
            this.subnet_mask.Size = new System.Drawing.Size(158, 22);
            this.subnet_mask.TabIndex = 27;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 144);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 348);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.subnet_mask);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ip_address);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.getway);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pri_Dns);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.sec_Dns);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parametres IP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(16, 196);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 22);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Utiliser une adresse DNS :";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(392, 42);
            this.label13.TabIndex = 32;
            this.label13.Text = "Les parametres IP peuvent etres determines automatiquement si votre\r\nreseau le pe" +
    "rmet. Sinon, vous devez demander les parametres IP\r\nappropries a votre administr" +
    "ateur reseau.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.ipAuto);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.masque);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(441, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Votre IP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 14);
            this.label9.TabIndex = 28;
            this.label9.Text = "Passerelle Par default :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 26;
            this.label11.Text = "Adresse IP :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = "Masque de sous-Reseau :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 504);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "Renommer cet ordinateur :\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(244, 508);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 14);
            this.label15.TabIndex = 34;
            this.label15.Text = "label15";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 531);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 25);
            this.button3.TabIndex = 35;
            this.button3.Text = "Renomer ...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 631);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Net Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ipAuto;
        private System.Windows.Forms.Label masque;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        public IPv4Address.IPv4AddressTextBox subnet_mask;
        public IPv4Address.IPv4AddressTextBox getway;
        public IPv4Address.IPv4AddressTextBox pri_Dns;
        public IPv4Address.IPv4AddressTextBox sec_Dns;
        public IPv4Address.IPv4AddressTextBox ip_address;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
    }
}

