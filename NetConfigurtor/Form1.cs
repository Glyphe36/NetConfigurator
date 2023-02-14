using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace NetConfigurtor
{

    public partial class Form1 : Form
    {
        string Dns0 = "";
        string Dns1 = "1.1.1.1";
        string Dns8 = "8.8.8.8";
       
        

        public Form1()
        {
            InitializeComponent();
            radioButtonIpAuto.Checked = true;
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
            radioButtonIpAuto.Checked=true;
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
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                    foreach (NetworkInterface ni in interfaces)
                    {
                        var adapter = ni.GetIPProperties().UnicastAddresses.FirstOrDefault(a => a.Address.Equals(ip));
                        if (adapter != null)
                        {
                            Console.WriteLine("The IP address is configured with " + adapter.DuplicateAddressDetectionState + " configuration.");
                            if (ni.GetIPProperties().GetIPv4Properties().IsDhcpEnabled)
                            {
                                Console.WriteLine("The IP address is configured with DHCP.");
                                // Code pour sélectionner votre bouton radio
                                radioButtonIpAuto.Checked=true;
                                radioButtonIpManuel.Checked=false;

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
                            else
                            {
                                Console.WriteLine("The IP address is not configured with DHCP.");
                                // Code pour ne pas sélectionner votre bouton radio
                                radioButtonIpManuel.Checked=true;
                                radioButtonIpAuto.Checked=false;

                                comboBoxIpManuel.Enabled = true;
                                ipAddressTextBox.Enabled = true;
                                maskTextBox.Enabled = true;
                                getwayTextBox.Enabled = true;
                                dnsPrimTextBox.Enabled = true;
                                dnsSecTextBox.Enabled = true;

                            }

                            // On peut sortir de la boucle car on a trouvé l'interface active
                            break;
                        }
                    }
                }
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
            imgValid.Visible= true;

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

            if (comboBoxIpManuel.SelectedItem.ToString() == "Desk")
            {
                ipAddressTextBox.Text = "10.123.10.1";
                maskTextBox.Text = "255.255.0.0";
                getwayTextBox.Text = "";
                checkBoxDns.Checked = false;
            }

            if (comboBoxIpManuel.SelectedItem.ToString() == "Preview")
            {
                ipAddressTextBox.Text = "10.123.20.1";
                maskTextBox.Text = "255.255.0.0";
                getwayTextBox.Text = "";
                checkBoxDns.Checked = false;
            }

            if (comboBoxIpManuel.SelectedItem.ToString() == "Room")
            {
                ipAddressTextBox.Text = "10.123.30.1";
                maskTextBox.Text = "255.255.0.0";
                getwayTextBox.Text = "";
                checkBoxDns.Checked = false;
            }

            if (comboBoxIpManuel.SelectedItem.ToString() == "Display")
            {
                ipAddressTextBox.Text = "10.123.40.1";
                maskTextBox.Text = "255.255.0.0";
                getwayTextBox.Text = "";
                checkBoxDns.Checked = false;
            }

            if (comboBoxIpManuel.SelectedItem.ToString() == "Accre")
            {
                ipAddressTextBox.Text = "172.20.10.1";
                maskTextBox.Text = "255.255.0.0";
                getwayTextBox.Text = "172.20.0.254";
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
    }

    }

