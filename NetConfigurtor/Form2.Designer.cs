namespace NetConfigurtor
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.subnet_mask = new IPv4Address.IPv4AddressTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ip_address = new IPv4Address.IPv4AddressTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.getway = new IPv4Address.IPv4AddressTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pri_Dns = new IPv4Address.IPv4AddressTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sec_Dns = new IPv4Address.IPv4AddressTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // subnet_mask
            // 
            this.subnet_mask.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.subnet_mask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subnet_mask.BackColor = System.Drawing.SystemColors.Window;
            this.subnet_mask.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnet_mask.IPAddress = ((System.Net.IPAddress)(resources.GetObject("subnet_mask.IPAddress")));
            this.subnet_mask.Location = new System.Drawing.Point(254, 183);
            this.subnet_mask.Margin = new System.Windows.Forms.Padding(2);
            this.subnet_mask.Name = "subnet_mask";
            this.subnet_mask.Size = new System.Drawing.Size(158, 22);
            this.subnet_mask.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 38;
            this.label7.Text = "DNS auxiliaire :";
            // 
            // ip_address
            // 
            this.ip_address.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.ip_address.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ip_address.BackColor = System.Drawing.SystemColors.Window;
            this.ip_address.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_address.IPAddress = ((System.Net.IPAddress)(resources.GetObject("ip_address.IPAddress")));
            this.ip_address.Location = new System.Drawing.Point(254, 144);
            this.ip_address.Margin = new System.Windows.Forms.Padding(2);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(158, 23);
            this.ip_address.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 14);
            this.label6.TabIndex = 37;
            this.label6.Text = "DNS prefere :";
            // 
            // getway
            // 
            this.getway.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.getway.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getway.BackColor = System.Drawing.SystemColors.Window;
            this.getway.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getway.IPAddress = ((System.Net.IPAddress)(resources.GetObject("getway.IPAddress")));
            this.getway.Location = new System.Drawing.Point(254, 222);
            this.getway.Margin = new System.Windows.Forms.Padding(2);
            this.getway.Name = "getway";
            this.getway.Size = new System.Drawing.Size(158, 23);
            this.getway.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 14);
            this.label5.TabIndex = 36;
            this.label5.Text = "Passerelle Par default :";
            // 
            // pri_Dns
            // 
            this.pri_Dns.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.pri_Dns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pri_Dns.BackColor = System.Drawing.SystemColors.Window;
            this.pri_Dns.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pri_Dns.IPAddress = ((System.Net.IPAddress)(resources.GetObject("pri_Dns.IPAddress")));
            this.pri_Dns.Location = new System.Drawing.Point(254, 264);
            this.pri_Dns.Margin = new System.Windows.Forms.Padding(2);
            this.pri_Dns.Name = "pri_Dns";
            this.pri_Dns.Size = new System.Drawing.Size(158, 23);
            this.pri_Dns.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "Masque de sous-Reseau :";
            // 
            // sec_Dns
            // 
            this.sec_Dns.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.sec_Dns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sec_Dns.BackColor = System.Drawing.SystemColors.Window;
            this.sec_Dns.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec_Dns.IPAddress = ((System.Net.IPAddress)(resources.GetObject("sec_Dns.IPAddress")));
            this.sec_Dns.Location = new System.Drawing.Point(254, 304);
            this.sec_Dns.Margin = new System.Windows.Forms.Padding(2);
            this.sec_Dns.Name = "sec_Dns";
            this.sec_Dns.Size = new System.Drawing.Size(158, 23);
            this.sec_Dns.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 34;
            this.label3.Text = "Adresse IP :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 80);
            this.panel1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Les parametres IP sont a determines \r\npar leur utilisation Accre/preview ...\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assitance de configuration IP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.ok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 58);
            this.panel2.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 25);
            this.button2.TabIndex = 34;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(318, 16);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 25);
            this.ok.TabIndex = 15;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.button1_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(254, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 14);
            this.label8.TabIndex = 49;
            this.label8.Text = "Modifier les parametres ip :";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(492, 405);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.subnet_mask);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ip_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.getway);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pri_Dns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sec_Dns);
            this.Controls.Add(this.label3);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private IPv4Address.IPv4AddressTextBox subnet_mask;
        private System.Windows.Forms.Label label7;
        public IPv4Address.IPv4AddressTextBox ip_address;
        private System.Windows.Forms.Label label6;
        private IPv4Address.IPv4AddressTextBox getway;
        private System.Windows.Forms.Label label5;
        private IPv4Address.IPv4AddressTextBox pri_Dns;
        private System.Windows.Forms.Label label4;
        private IPv4Address.IPv4AddressTextBox sec_Dns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}
