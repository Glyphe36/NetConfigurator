using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NetConfigurtor
{
    

    public partial class Form1 : Form
    {
        string Dns0 = "";
        string Dns1 = "1.1.1.1";
        string Dns8 = "8.8.8.8";
        public class NetworkConfig
        {
            [XmlElement("Location")]
            public List<LocationConfig> Locations { get; set; }
        }

        public class LocationConfig
        {
            [XmlAttribute("Name")]
            public string Name { get; set; }

            [XmlElement("IPAddress")]
            public string IPAddress { get; set; }

            [XmlElement("SubnetMask")]
            public string SubnetMask { get; set; }

            [XmlElement("Gateway")]
            public string Gateway { get; set; }

            [XmlElement("UseDNS")]
            public bool UseDNS { get; set; }

            [XmlElement("PrimaryDNS")]
            public string PrimaryDNS { get; set; }

            [XmlElement("SecondaryDNS")]
            public string SecondaryDNS { get; set; }
        }


        public Form1()
        {
            if (File.Exists("config.xml"))
            { 
                // Le fichier existe, ne pas toucher à la configuration
            }
            else { 
                // Créer les objets de configuration
                var networkConfig = new NetworkConfig();
                networkConfig.Locations = new List<LocationConfig>
                {
                    new LocationConfig { Name = "Desk", IPAddress = "10.123.10.1", SubnetMask = "255.255.0.0" },
                    new LocationConfig { Name = "Preview", IPAddress = "10.123.20.1", SubnetMask = "255.255.0.0" },
                    new LocationConfig { Name = "Room", IPAddress = "10.123.30.1", SubnetMask = "255.255.0.0" },
                    new LocationConfig { Name = "Display", IPAddress = "10.123.40.1", SubnetMask = "255.255.0.0" },
                    new LocationConfig { Name = "Accre", IPAddress = "172.20.10.1", SubnetMask = "255.255.0.0", Gateway = "172.20.0.254", UseDNS = true, PrimaryDNS = "8.8.8.8", SecondaryDNS = "1.1.1.1" },
                };

                // Sérialiser les objets en XML et écrire le fichier
                XmlSerializer serializer = new XmlSerializer(typeof(NetworkConfig));
                using (StreamWriter streamWriter = new StreamWriter("config.xml"))
                {
                    serializer.Serialize(streamWriter, networkConfig);
                }
            }
            InitializeComponent();
            checkBoxDns.Checked = false;
            renameTextBox.Text = Environment.MachineName;

            ManagementObjectSearcher NetworkSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
            ManagementObjectCollection moCollection = NetworkSearcher.Get();

            foreach (ManagementObject mo in moCollection)
            {

                String[] addresses = (String[])(mo["IPAddress"]);
                foreach (string ipaddress in addresses)
                {
                    ipAuto.Text = addresses[0];
                    ipAddressTextBox.Text = addresses[0];

                }

                String[] subnets = (String[])(mo["IPSubnet"]);
                foreach (string ipsubnet in subnets)
                {
                    masque.Text = subnets[0];
                    maskTextBox.Text = subnets[0];
                }

            }


            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();

            foreach (NetworkInterface networkCard in NetworkInterface.GetAllNetworkInterfaces())

            {

                foreach (GatewayIPAddressInformation gatewayAddr in networkCard.GetIPProperties().GatewayAddresses)

                {

                    label12.Text = gatewayAddr.Address.ToString();
                    getwayTextBox.Text = gatewayAddr.Address.ToString();

                }

            }


            int index = -1;
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            var activeEthernetInterface = interfaces
                .Where(i => i.OperationalStatus == OperationalStatus.Up &&
                            i.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                .FirstOrDefault();

            // Remplir la ComboBox avec les interfaces Ethernet
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    comboBoxInterface.Items.Add(ni.Name);
                }
            }

            // Trouver l'index de l'interface Ethernet 2
            if (activeEthernetInterface !=null)
            {
                for (int i = 0; i < comboBoxInterface.Items.Count; i++)
                {
                    if (comboBoxInterface.Items[i].ToString() == activeEthernetInterface.Name)
                    {
                        index = i;
                        break;
                    }
                }
            }
            else
            {
                comboBoxInterface.SelectedIndex = index;
            }

            // Sélectionner l'interface Ethernet 2
            if (index != -1)
            {
                comboBoxInterface.SelectedIndex = index;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateParams cp = base.CreateParams;
            cp.ClassName = "SysIPAddress32";
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            imgValid.Visible= false;
            //comboBoxInterface.SelectedIndex = 0;
            checkBoxDns.Checked= false;

            // si checkbox true afficher la liste des imprimante existante
            foreach (string sPrinters in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                LstPrinterLocal.Items.Add(sPrinters);
            }

            //verifie si l'interface active est en dhcp et check ou non le bon radiobuttin
            var host = Dns.GetHostEntry(Dns.GetHostName());
            // Récupérer l'interface réseau active
            NetworkInterface activeInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(ni => ni.OperationalStatus == OperationalStatus.Up);

            if (activeInterface != null)
            {
                // Récupérer l'état DHCP de l'interface
                IPInterfaceProperties properties = activeInterface.GetIPProperties();
                bool isDhcpEnabled = properties.GetIPv4Properties().IsDhcpEnabled;
                radioButtonIpAuto.Checked = true;
                radioButtonIpManuel.Checked = false;

                ipAuto.Enabled = true;
                masque.Enabled = true;
                label12.Enabled = true;

                comboBoxIpManuel.Enabled = false;
                ipAddressTextBox.Enabled = false;
                maskTextBox.Enabled = false;
                getwayTextBox.Enabled = false;
                dnsPrimTextBox.Enabled = false;
                dnsSecTextBox.Enabled = false;
                // Afficher l'état DHCP dans une boîte de dialogue
                //MessageBox.Show("DHCP est " + (isDhcpEnabled ? "activé" : "désactivé"));
            }
            else
            {
                Console.WriteLine("The IP address is not configured with DHCP.");
                // Code pour ne pas sélectionner votre bouton radio
                radioButtonIpManuel.Checked = true;
                radioButtonIpAuto.Checked = false;

                comboBoxIpManuel.Enabled = true;
                ipAddressTextBox.Enabled = true;
                maskTextBox.Enabled = true;
                getwayTextBox.Enabled = true;
                dnsPrimTextBox.Enabled = true;
                dnsSecTextBox.Enabled = true;
            }
        }

            private void SetCMD(string arg)
        {

            try
            {

                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Verb = "runas";
                psi.Arguments = arg;
                Process.Start(psi);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string interfacebox = comboBoxInterface.SelectedItem.ToString();
            // Afficher l'image en rendant le contrôle PictureBox visible
            imgValid.Visible = true;

            
            if (radioButtonIpAuto.Checked == true)
            {
                SetCMD("/c netsh interface ipv4 set address \"" + interfacebox + "\" dhcp");
            }

            if (radioButtonIpManuel.Checked == true)
            {
                string IpAddress = ipAddressTextBox.Text;
                string Subnet = maskTextBox.Text;
                string wifiDefaultGetway = getwayTextBox.Text;


                //string interfacebox = comboBox2.SelectedItem.ToString();
                string PrimaryDNS = dnsPrimTextBox.Text;
                string SecondDNS = dnsSecTextBox.Text;

                

                SetCMD("/c netsh interface ipv4 set address \"" + interfacebox + "\" static " + IpAddress + " " + Subnet + " " + wifiDefaultGetway + "");

                if (checkBoxDns.Checked == true)
                {
                    SetCMD("/c netsh interface ipv4 set dns \"" + interfacebox + "\" static " + PrimaryDNS + " & netsh interface ipv4 add dns \"" + interfacebox + "\" " + SecondDNS + " index=2");
                }
                if (checkBoxDns.Checked == false)
                {
                    SetCMD("/c netsh interface ipv4 set dns \"" + interfacebox + "\" dhcp");
                }

            }

            // Attendre deux secondes
            System.Threading.Thread.Sleep(2000);

            // Rendre le contrôle PictureBox invisible
            imgValid.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (true)
            {
                ipAuto.Enabled = true;
                masque.Enabled = true;
                label12.Enabled = true;

                comboBoxIpManuel.Enabled = false;
                ipAddressTextBox.Enabled = false;
                maskTextBox.Enabled = false;
                getwayTextBox.Enabled = false;
                dnsPrimTextBox.Enabled = false;
                dnsSecTextBox.Enabled = false;

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {

                comboBoxIpManuel.Enabled = true;
                ipAddressTextBox.Enabled = true;
                maskTextBox.Enabled = true;
                getwayTextBox.Enabled = true;
                dnsPrimTextBox.Enabled = true;
                dnsSecTextBox.Enabled = true;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Charger le fichier XML
            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");



            if (comboBoxIpManuel.SelectedItem.ToString() == "Desk")
            {
                // Rechercher l'élément "IPAddress" sous "Location" avec l'attribut "Name" égal à "Desk"
                XmlNode ipAddressNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Desk']/IPAddress");
                XmlNode MaskNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Accre']/SubnetMask");

                // Afficher la valeur de l'élément "IPAddress"
                //MessageBox.Show(ipAddressNode.InnerText);

                ipAddressTextBox.Text = ipAddressNode.InnerText;
                maskTextBox.Text = MaskNode.InnerText;
                getwayTextBox.Text = "";
                checkBoxDns.Checked = false;
            }

            if (comboBoxIpManuel.SelectedItem.ToString() == "Preview")
            {
                // Rechercher l'élément "IPAddress" sous "Location" avec l'attribut "Name" égal à "Desk"
                XmlNode ipAddressNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Preview']/IPAddress");
                XmlNode MaskNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Accre']/SubnetMask");

                // Afficher la valeur de l'élément "IPAddress"
                //MessageBox.Show(ipAddressNode.InnerText);

                ipAddressTextBox.Text = ipAddressNode.InnerText;
                maskTextBox.Text = MaskNode.InnerText;
                getwayTextBox.Text = "";
                checkBoxDns.Checked = false;
            }

            if (comboBoxIpManuel.SelectedItem.ToString() == "Room")
            {
                // Rechercher l'élément "IPAddress" sous "Location" avec l'attribut "Name" égal à "Desk"
                XmlNode ipAddressNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Room']/IPAddress");
                XmlNode MaskNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Accre']/SubnetMask");

                // Afficher la valeur de l'élément "IPAddress"
                //MessageBox.Show(ipAddressNode.InnerText);

                ipAddressTextBox.Text = ipAddressNode.InnerText;
                maskTextBox.Text = MaskNode.InnerText;
                getwayTextBox.Text = "";
                checkBoxDns.Checked = false;
            }

            if (comboBoxIpManuel.SelectedItem.ToString() == "Display")
            {
                // Rechercher l'élément "IPAddress" sous "Location" avec l'attribut "Name" égal à "Desk"
                XmlNode ipAddressNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Display']/IPAddress");
                XmlNode MaskNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Accre']/SubnetMask");

                // Afficher la valeur de l'élément "IPAddress"
                //MessageBox.Show(ipAddressNode.InnerText);

                ipAddressTextBox.Text = ipAddressNode.InnerText;
                maskTextBox.Text = MaskNode.InnerText;
                getwayTextBox.Text = "";
                checkBoxDns.Checked = false;
            }

            if (comboBoxIpManuel.SelectedItem.ToString() == "Accre")
            {
                // Rechercher l'élément "IPAddress" sous "Location" avec l'attribut "Name" égal à "Desk"
                XmlNode ipAddressNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Accre']/IPAddress");
                XmlNode MaskNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Accre']/SubnetMask");
                XmlNode GatewayNode = doc.SelectSingleNode("/NetworkConfig/Location[@Name='Accre']/Gateway");

                // Afficher la valeur de l'élément "IPAddress"
                //MessageBox.Show(ipAddressNode.InnerText);

                ipAddressTextBox.Text = ipAddressNode.InnerText;
                maskTextBox.Text = MaskNode.InnerText;
                getwayTextBox.Text = GatewayNode.InnerText;
                checkBoxDns.Checked = true;
                dnsPrimTextBox.Text = "8.8.8.8";
                dnsSecTextBox.Text = "1.1.1.1";
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDns.Checked == false)
            {
                dnsPrimTextBox.Enabled = false;
                dnsSecTextBox.Enabled=false;
                dnsPrimTextBox.Text = Dns0;
                dnsSecTextBox.Text = Dns0;
            }
            if (checkBoxDns.Checked == true)
            {
                dnsPrimTextBox.Enabled = true;
                dnsSecTextBox.Enabled= true;
                dnsPrimTextBox.Text = Dns8;
                dnsSecTextBox.Text = Dns1;

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(renameTextBox.Text))
            {
                string message = "Vous Devez definir un nom pour votre ordinateur !";
                string caption = "Information";

                MessageBox.Show(message, caption);
            }
            else
            {
                string NewName = renameTextBox.Text;

                string message = "Vous Devez Redemarrer votre ordinateur " + NewName +" pour appliquer ces modifications. Voulez-vous Redemarer ?";
                string caption = "Information";
                SetCMD("/c WMIC Computersystem where Name='%COMPUTERNAME%' call Rename Name=" + NewName +" ");

                var result = MessageBox.Show(message, caption,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SetCMD("/c Shutdown -r -t 10");
                    this.Close();
                }
                if (result == DialogResult.No)
                {
                    return;
                }


            }
        }
        private void btnActiveWindows_Click(object sender, EventArgs e)
        {
            SetCMD("/c ncpa.cpl");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string idPrinter = LstPrinterLocal.SelectedItem.ToString();
            string ip = txtIpprinter.Text;
            SetCMD("/c cscript C:\\Windows\\SysWOW64\\Printing_Admin_Scripts\\fr-FR\\prnport.vbs -a -r " + ip + " -h " + ip + " -o raw -n 9100");
            SetCMD("/c cscript C:\\Windows\\SysWOW64\\Printing_Admin_Scripts\\fr-FR\\prnport.vbs -t -p " + idPrinter + " -r " + ip + " -o raw -n 9100");

            valideprinter.Visible = true ;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SetCMD("/c netsh advfirewall set allprofiles state off");
            SetCMD("/c firewall.cpl");
        }

        private ErrorProvider errorProvider1 = new ErrorProvider();

        private void textBoxIP_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^([0-9]{1,3}\.){3}[0-9]{1,3}$";

            if (!Regex.IsMatch(ipAddressTextBox.Text, pattern))
            {
                errorProvider1.SetError(ipAddressTextBox, "Adresse IP non valide");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(ipAddressTextBox, "");
            }
        }

        private void imgValid_Click(object sender, EventArgs e)
        {

        }
    }

    }

