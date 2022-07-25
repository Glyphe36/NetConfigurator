using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

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

            ManagementObjectSearcher NetworkSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
            ManagementObjectCollection moCollection = NetworkSearcher.Get();

            foreach (ManagementObject mo in moCollection)
            {
                String[] addresses = (String[])(mo["IPAddress"]);
                foreach (string ipaddress in addresses)
                {
                    ipAuto.Text = addresses[0];

                }

                String[] subnets = (String[])(mo["IPSubnet"]);
                foreach (string ipsubnet in subnets)
                {
                    masque.Text = subnets[0];
                }

                //string[] defaultgateways = (string[])mo["DefaultIPGateway"];
                //foreach (string defaultipgateway in defaultgateways)
                //{
                //    label12.Text = defaultgateways.ToString();
                //}
            }

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    comboBoxInterface.Items.Add(ni.Name);
                    Console.WriteLine(ni.Name);
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateParams cp = base.CreateParams;
            cp.ClassName = "SysIPAddress32";
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            nameComputerLabel.Text = ipProperties.HostName.ToString();
            radioButtonIpManuel.Checked=true;
            imgValid.Visible= false;
            comboBoxInterface.SelectedIndex =1;
            checkBoxDns.Checked= true;
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
                // si checkbox true afficher la liste des imprimante existante


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
            string PathKeyInstall = "C:\\key4 install\\activation Office 2019.bat";

            MessageBox.Show(PathKeyInstall);
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = PathKeyInstall;
            proc.Start();

            if (!File.Exists(PathKeyInstall))
            {
                MessageBox.Show("Le fichier d'installation est introuvable, verifier bien qu'il existe Key4install !");
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  
    }
}
