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
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActiveWindows = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DesciptionTitle = new System.Windows.Forms.Label();
            this.renameLabel = new System.Windows.Forms.Label();
            this.renameTextBox = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgValid = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radioButtonIpAuto = new System.Windows.Forms.RadioButton();
            this.radioButtonIpManuel = new System.Windows.Forms.RadioButton();
            this.comboBoxIpManuel = new System.Windows.Forms.ComboBox();
            this.RenameTilteLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.valideprinter = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Imprimante = new System.Windows.Forms.Label();
            this.txtIpprinter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LstPrinterLocal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ipAuto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.masque = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dnsSecTextBox = new System.Windows.Forms.TextBox();
            this.dnsPrimTextBox = new System.Windows.Forms.TextBox();
            this.getwayTextBox = new System.Windows.Forms.TextBox();
            this.maskTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.checkBoxDns = new System.Windows.Forms.CheckBox();
            this.DesciptionParaIp = new System.Windows.Forms.Label();
            this.dnsSecLabel = new System.Windows.Forms.Label();
            this.dnsPrimLabel = new System.Windows.Forms.Label();
            this.GatewayLabel = new System.Windows.Forms.Label();
            this.MaskLabel = new System.Windows.Forms.Label();
            this.AdressIpLabel = new System.Windows.Forms.Label();
            this.comboBoxInterface = new System.Windows.Forms.ComboBox();
            this.InterfaceLabel = new System.Windows.Forms.Label();
            this.tabControlIp = new System.Windows.Forms.TabControl();
            this.DesciptionRenamelabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgValid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valideprinter)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControlIp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Title.Location = new System.Drawing.Point(15, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(186, 18);
            this.Title.TabIndex = 1;
            this.Title.Text = "Assitance de configuration IP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnActiveWindows);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.DesciptionTitle);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 72);
            this.panel1.TabIndex = 2;
            // 
            // btnActiveWindows
            // 
            this.btnActiveWindows.Location = new System.Drawing.Point(269, 41);
            this.btnActiveWindows.Name = "btnActiveWindows";
            this.btnActiveWindows.Size = new System.Drawing.Size(141, 23);
            this.btnActiveWindows.TabIndex = 2;
            this.btnActiveWindows.Text = "Configuration réseau";
            this.btnActiveWindows.UseVisualStyleBackColor = true;
            this.btnActiveWindows.Click += new System.EventHandler(this.btnActiveWindows_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "désactiver pare-feu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DesciptionTitle
            // 
            this.DesciptionTitle.AutoSize = true;
            this.DesciptionTitle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesciptionTitle.Location = new System.Drawing.Point(29, 30);
            this.DesciptionTitle.Name = "DesciptionTitle";
            this.DesciptionTitle.Size = new System.Drawing.Size(210, 28);
            this.DesciptionTitle.TabIndex = 3;
            this.DesciptionTitle.Text = "Les parametres IP sont a determines \r\npar leur utilisation Accre/preview ...\r\n";
            // 
            // renameLabel
            // 
            this.renameLabel.AutoSize = true;
            this.renameLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameLabel.Location = new System.Drawing.Point(52, 591);
            this.renameLabel.Name = "renameLabel";
            this.renameLabel.Size = new System.Drawing.Size(99, 14);
            this.renameLabel.TabIndex = 14;
            this.renameLabel.Text = "Nom ordinateur :";
            // 
            // renameTextBox
            // 
            this.renameTextBox.Location = new System.Drawing.Point(157, 588);
            this.renameTextBox.Name = "renameTextBox";
            this.renameTextBox.Size = new System.Drawing.Size(130, 22);
            this.renameTextBox.TabIndex = 13;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(149, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.imgValid);
            this.panel2.Controls.Add(this.btnRestart);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 58);
            this.panel2.TabIndex = 16;
            // 
            // imgValid
            // 
            this.imgValid.Image = ((System.Drawing.Image)(resources.GetObject("imgValid.Image")));
            this.imgValid.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgValid.InitialImage")));
            this.imgValid.Location = new System.Drawing.Point(19, 10);
            this.imgValid.Name = "imgValid";
            this.imgValid.Size = new System.Drawing.Size(36, 36);
            this.imgValid.TabIndex = 35;
            this.imgValid.TabStop = false;
            this.imgValid.Click += new System.EventHandler(this.imgValid_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(230, 16);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(87, 25);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Redemarrer";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(323, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 25);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonIpAuto
            // 
            this.radioButtonIpAuto.AutoSize = true;
            this.radioButtonIpAuto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIpAuto.Location = new System.Drawing.Point(22, 85);
            this.radioButtonIpAuto.Name = "radioButtonIpAuto";
            this.radioButtonIpAuto.Size = new System.Drawing.Size(130, 22);
            this.radioButtonIpAuto.TabIndex = 3;
            this.radioButtonIpAuto.Text = "Ip Automatique :";
            this.radioButtonIpAuto.UseVisualStyleBackColor = true;
            this.radioButtonIpAuto.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonIpManuel
            // 
            this.radioButtonIpManuel.AutoSize = true;
            this.radioButtonIpManuel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIpManuel.Location = new System.Drawing.Point(22, 113);
            this.radioButtonIpManuel.Name = "radioButtonIpManuel";
            this.radioButtonIpManuel.Size = new System.Drawing.Size(96, 22);
            this.radioButtonIpManuel.TabIndex = 4;
            this.radioButtonIpManuel.Text = "Ip Manuel :";
            this.radioButtonIpManuel.UseVisualStyleBackColor = true;
            this.radioButtonIpManuel.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBoxIpManuel
            // 
            this.comboBoxIpManuel.FormattingEnabled = true;
            this.comboBoxIpManuel.Items.AddRange(new object[] {
            "Desk",
            "Preview",
            "Room",
            "Display",
            "Accre"});
            this.comboBoxIpManuel.Location = new System.Drawing.Point(244, 113);
            this.comboBoxIpManuel.Name = "comboBoxIpManuel";
            this.comboBoxIpManuel.Size = new System.Drawing.Size(157, 22);
            this.comboBoxIpManuel.TabIndex = 5;
            this.comboBoxIpManuel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RenameTilteLabel
            // 
            this.RenameTilteLabel.AutoSize = true;
            this.RenameTilteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenameTilteLabel.Location = new System.Drawing.Point(33, 561);
            this.RenameTilteLabel.Name = "RenameTilteLabel";
            this.RenameTilteLabel.Size = new System.Drawing.Size(175, 18);
            this.RenameTilteLabel.TabIndex = 33;
            this.RenameTilteLabel.Text = "Renommer cet ordinateur :\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.valideprinter);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Imprimante);
            this.tabPage2.Controls.Add(this.txtIpprinter);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.LstPrinterLocal);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.ipAuto);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.masque);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(417, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Avancé";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // valideprinter
            // 
            this.valideprinter.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.valideprinter.Image = ((System.Drawing.Image)(resources.GetObject("valideprinter.Image")));
            this.valideprinter.InitialImage = ((System.Drawing.Image)(resources.GetObject("valideprinter.InitialImage")));
            this.valideprinter.Location = new System.Drawing.Point(362, 281);
            this.valideprinter.Name = "valideprinter";
            this.valideprinter.Size = new System.Drawing.Size(39, 38);
            this.valideprinter.TabIndex = 37;
            this.valideprinter.TabStop = false;
            this.valideprinter.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ajouter un port a une imprimante existant :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Ajouter un port ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ci-dessous vos parametres ip actuels ainsi qu\'une assistance\r\npour l\'ouverture d\'" +
    "un port ip sur une imprimante.\r\n";
            // 
            // Imprimante
            // 
            this.Imprimante.AutoSize = true;
            this.Imprimante.Location = new System.Drawing.Point(35, 214);
            this.Imprimante.Name = "Imprimante";
            this.Imprimante.Size = new System.Drawing.Size(77, 14);
            this.Imprimante.TabIndex = 33;
            this.Imprimante.Text = "Imprimante :";
            // 
            // txtIpprinter
            // 
            this.txtIpprinter.Location = new System.Drawing.Point(137, 249);
            this.txtIpprinter.Name = "txtIpprinter";
            this.txtIpprinter.Size = new System.Drawing.Size(216, 22);
            this.txtIpprinter.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ip Imprimante :";
            // 
            // LstPrinterLocal
            // 
            this.LstPrinterLocal.AccessibleName = "Listprinters";
            this.LstPrinterLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LstPrinterLocal.FormattingEnabled = true;
            this.LstPrinterLocal.Location = new System.Drawing.Point(137, 211);
            this.LstPrinterLocal.Name = "LstPrinterLocal";
            this.LstPrinterLocal.Size = new System.Drawing.Size(216, 22);
            this.LstPrinterLocal.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 14);
            this.label9.TabIndex = 28;
            this.label9.Text = "Passerelle Par default :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 26;
            this.label11.Text = "Adresse IP :";
            // 
            // ipAuto
            // 
            this.ipAuto.AutoSize = true;
            this.ipAuto.Location = new System.Drawing.Point(241, 66);
            this.ipAuto.Name = "ipAuto";
            this.ipAuto.Size = new System.Drawing.Size(46, 14);
            this.ipAuto.TabIndex = 20;
            this.ipAuto.Text = "Ip Auto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = "Masque de sous-Reseau :";
            // 
            // masque
            // 
            this.masque.AutoSize = true;
            this.masque.Location = new System.Drawing.Point(241, 104);
            this.masque.Name = "masque";
            this.masque.Size = new System.Drawing.Size(51, 14);
            this.masque.TabIndex = 23;
            this.masque.Text = "Masque";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "Ip Auto";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dnsSecTextBox);
            this.tabPage1.Controls.Add(this.dnsPrimTextBox);
            this.tabPage1.Controls.Add(this.getwayTextBox);
            this.tabPage1.Controls.Add(this.maskTextBox);
            this.tabPage1.Controls.Add(this.ipAddressTextBox);
            this.tabPage1.Controls.Add(this.checkBoxDns);
            this.tabPage1.Controls.Add(this.DesciptionParaIp);
            this.tabPage1.Controls.Add(this.dnsSecLabel);
            this.tabPage1.Controls.Add(this.dnsPrimLabel);
            this.tabPage1.Controls.Add(this.GatewayLabel);
            this.tabPage1.Controls.Add(this.MaskLabel);
            this.tabPage1.Controls.Add(this.AdressIpLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parametres IP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dnsSecTextBox
            // 
            this.dnsSecTextBox.Location = new System.Drawing.Point(222, 286);
            this.dnsSecTextBox.Name = "dnsSecTextBox";
            this.dnsSecTextBox.Size = new System.Drawing.Size(134, 22);
            this.dnsSecTextBox.TabIndex = 37;
            // 
            // dnsPrimTextBox
            // 
            this.dnsPrimTextBox.Location = new System.Drawing.Point(222, 246);
            this.dnsPrimTextBox.Name = "dnsPrimTextBox";
            this.dnsPrimTextBox.Size = new System.Drawing.Size(134, 22);
            this.dnsPrimTextBox.TabIndex = 36;
            // 
            // getwayTextBox
            // 
            this.getwayTextBox.Location = new System.Drawing.Point(222, 164);
            this.getwayTextBox.Name = "getwayTextBox";
            this.getwayTextBox.Size = new System.Drawing.Size(134, 22);
            this.getwayTextBox.TabIndex = 35;
            // 
            // maskTextBox
            // 
            this.maskTextBox.Location = new System.Drawing.Point(222, 124);
            this.maskTextBox.Name = "maskTextBox";
            this.maskTextBox.Size = new System.Drawing.Size(134, 22);
            this.maskTextBox.TabIndex = 34;
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(222, 86);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(134, 22);
            this.ipAddressTextBox.TabIndex = 33;
            // 
            // checkBoxDns
            // 
            this.checkBoxDns.AutoSize = true;
            this.checkBoxDns.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDns.Location = new System.Drawing.Point(16, 209);
            this.checkBoxDns.Name = "checkBoxDns";
            this.checkBoxDns.Size = new System.Drawing.Size(187, 22);
            this.checkBoxDns.TabIndex = 10;
            this.checkBoxDns.Text = "Utiliser une adresse DNS :";
            this.checkBoxDns.UseVisualStyleBackColor = true;
            this.checkBoxDns.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DesciptionParaIp
            // 
            this.DesciptionParaIp.AutoSize = true;
            this.DesciptionParaIp.Location = new System.Drawing.Point(13, 17);
            this.DesciptionParaIp.Name = "DesciptionParaIp";
            this.DesciptionParaIp.Size = new System.Drawing.Size(392, 42);
            this.DesciptionParaIp.TabIndex = 32;
            this.DesciptionParaIp.Text = "Les parametres IP peuvent etres determines automatiquement si votre\r\nreseau le pe" +
    "rmet. Sinon, vous devez demander les parametres IP\r\nappropries a votre administr" +
    "ateur reseau.";
            // 
            // dnsSecLabel
            // 
            this.dnsSecLabel.AutoSize = true;
            this.dnsSecLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnsSecLabel.Location = new System.Drawing.Point(35, 294);
            this.dnsSecLabel.Name = "dnsSecLabel";
            this.dnsSecLabel.Size = new System.Drawing.Size(91, 14);
            this.dnsSecLabel.TabIndex = 12;
            this.dnsSecLabel.Text = "DNS auxiliaire :";
            // 
            // dnsPrimLabel
            // 
            this.dnsPrimLabel.AutoSize = true;
            this.dnsPrimLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnsPrimLabel.Location = new System.Drawing.Point(35, 254);
            this.dnsPrimLabel.Name = "dnsPrimLabel";
            this.dnsPrimLabel.Size = new System.Drawing.Size(78, 14);
            this.dnsPrimLabel.TabIndex = 10;
            this.dnsPrimLabel.Text = "DNS prefere :";
            // 
            // GatewayLabel
            // 
            this.GatewayLabel.AutoSize = true;
            this.GatewayLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GatewayLabel.Location = new System.Drawing.Point(35, 172);
            this.GatewayLabel.Name = "GatewayLabel";
            this.GatewayLabel.Size = new System.Drawing.Size(134, 14);
            this.GatewayLabel.TabIndex = 8;
            this.GatewayLabel.Text = "Passerelle Par default :";
            // 
            // MaskLabel
            // 
            this.MaskLabel.AutoSize = true;
            this.MaskLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskLabel.Location = new System.Drawing.Point(35, 132);
            this.MaskLabel.Name = "MaskLabel";
            this.MaskLabel.Size = new System.Drawing.Size(148, 14);
            this.MaskLabel.TabIndex = 6;
            this.MaskLabel.Text = "Masque de sous-Reseau :";
            // 
            // AdressIpLabel
            // 
            this.AdressIpLabel.AutoSize = true;
            this.AdressIpLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressIpLabel.Location = new System.Drawing.Point(35, 94);
            this.AdressIpLabel.Name = "AdressIpLabel";
            this.AdressIpLabel.Size = new System.Drawing.Size(70, 14);
            this.AdressIpLabel.TabIndex = 4;
            this.AdressIpLabel.Text = "Adresse IP :";
            // 
            // comboBoxInterface
            // 
            this.comboBoxInterface.FormattingEnabled = true;
            this.comboBoxInterface.Location = new System.Drawing.Point(244, 143);
            this.comboBoxInterface.Name = "comboBoxInterface";
            this.comboBoxInterface.Size = new System.Drawing.Size(157, 22);
            this.comboBoxInterface.TabIndex = 6;
            // 
            // InterfaceLabel
            // 
            this.InterfaceLabel.AutoSize = true;
            this.InterfaceLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterfaceLabel.Location = new System.Drawing.Point(38, 143);
            this.InterfaceLabel.Name = "InterfaceLabel";
            this.InterfaceLabel.Size = new System.Drawing.Size(71, 18);
            this.InterfaceLabel.TabIndex = 36;
            this.InterfaceLabel.Text = "Interface :";
            // 
            // tabControlIp
            // 
            this.tabControlIp.Controls.Add(this.tabPage1);
            this.tabControlIp.Controls.Add(this.tabPage2);
            this.tabControlIp.Location = new System.Drawing.Point(-1, 172);
            this.tabControlIp.Name = "tabControlIp";
            this.tabControlIp.SelectedIndex = 0;
            this.tabControlIp.Size = new System.Drawing.Size(425, 355);
            this.tabControlIp.TabIndex = 32;
            // 
            // DesciptionRenamelabel
            // 
            this.DesciptionRenamelabel.AutoSize = true;
            this.DesciptionRenamelabel.Location = new System.Drawing.Point(16, 536);
            this.DesciptionRenamelabel.Name = "DesciptionRenamelabel";
            this.DesciptionRenamelabel.Size = new System.Drawing.Size(253, 14);
            this.DesciptionRenamelabel.TabIndex = 35;
            this.DesciptionRenamelabel.Text = "Vous devez redemarrer apres avoir renomer . ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 685);
            this.Controls.Add(this.comboBoxInterface);
            this.Controls.Add(this.DesciptionRenamelabel);
            this.Controls.Add(this.InterfaceLabel);
            this.Controls.Add(this.RenameTilteLabel);
            this.Controls.Add(this.renameLabel);
            this.Controls.Add(this.comboBoxIpManuel);
            this.Controls.Add(this.radioButtonIpManuel);
            this.Controls.Add(this.renameTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControlIp);
            this.Controls.Add(this.radioButtonIpAuto);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Net Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgValid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valideprinter)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControlIp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DesciptionTitle;
        private System.Windows.Forms.Label renameLabel;
        private System.Windows.Forms.TextBox renameTextBox;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonIpAuto;
        private System.Windows.Forms.RadioButton radioButtonIpManuel;
        private System.Windows.Forms.ComboBox comboBoxIpManuel;
        private System.Windows.Forms.Label RenameTilteLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ipAuto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label masque;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBoxDns;
        private System.Windows.Forms.Label DesciptionParaIp;
        private System.Windows.Forms.Label dnsSecLabel;
        private System.Windows.Forms.Label dnsPrimLabel;
        private System.Windows.Forms.Label GatewayLabel;
        private System.Windows.Forms.Label MaskLabel;
        private System.Windows.Forms.Label AdressIpLabel;
        private System.Windows.Forms.TabControl tabControlIp;
        private System.Windows.Forms.ComboBox comboBoxInterface;
        private System.Windows.Forms.Label InterfaceLabel;
        private System.Windows.Forms.PictureBox imgValid;
        private System.Windows.Forms.Label DesciptionRenamelabel;
        private System.Windows.Forms.Button btnActiveWindows;
        private System.Windows.Forms.ComboBox LstPrinterLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Imprimante;
        private System.Windows.Forms.TextBox txtIpprinter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox valideprinter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.TextBox dnsSecTextBox;
        private System.Windows.Forms.TextBox dnsPrimTextBox;
        private System.Windows.Forms.TextBox getwayTextBox;
        private System.Windows.Forms.TextBox maskTextBox;
    }
}

