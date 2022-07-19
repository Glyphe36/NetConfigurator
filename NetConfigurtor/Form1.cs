using System;
using System.ComponentModel;
using System.Diagnostics;
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
            radioButton1.Checked = true;
            checkBox1.Checked = false;

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

                String[] defaultgateways = (String[])mo["DefaultIpGateway"];
                foreach (var defaultgateway in defaultgateways)
                {
                    label12.Text = defaultgateways[0];
                }
            }

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    comboBox2.Items.Add(ni.Name);
                    Console.WriteLine(ni.Name);
                }
            }


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            CreateParams cp = base.CreateParams;
            cp.ClassName = "SysIPAddress32";
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            label15.Text = ipProperties.HostName.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            string Interface2 = "Ethernet2";

            if (radioButton1.Checked == true)
            {
                SetCMD("/c netsh interface ipv4 set address " + Interface2 + " dhcp");
            }

            if (radioButton2.Checked == true)
            {
                string IpAddress = ip_address.Text;
                string Subnet = subnet_mask.Text;
                string wifiDefaultGetway = getway.Text;


                string interfacebox = comboBox2.SelectedItem.ToString();
                string PrimaryDNS = pri_Dns.Text;
                string SecondDNS = sec_Dns.Text;

                

                SetCMD("/c netsh interface ipv4 set address " + interfacebox + " static " + IpAddress + " " + Subnet + " " + wifiDefaultGetway + "");

                if (checkBox1.Checked == true)
                {
                    SetCMD("/c netsh interface ipv4 set dns " + interfacebox + " static " + PrimaryDNS + " & netsh interface ipv4 add dns " + Interface2 + " " + SecondDNS + " index=2");
                }
                if (checkBox1.Checked == false)
                {
                    SetCMD("/c netsh interface ipv4 set dns " + interfacebox + " dhcp");
                }

            }

            string NewName = textBox6.Text;
            string message = "Vos modification on bien ete pris en compte. Voulez-vous Redemarer ?";
            string caption = "Information";

            var result = MessageBox.Show(message, caption,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                SetCMD("/c Shutdown -r -t 0");
            }
            if (result == DialogResult.No)
            {
                return;
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            if (true)
            {
                ipAuto.Enabled = true;
                masque.Enabled = true;
                label12.Enabled = true;

                comboBox1.Enabled = false;
                ip_address.Enabled = false;
                subnet_mask.Enabled = false;
                getway.Enabled = false;
                pri_Dns.Enabled = false;
                sec_Dns.Enabled = false;



            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {

                comboBox1.Enabled = true;
                ip_address.Enabled = true;
                subnet_mask.Enabled = true;
                getway.Enabled = true;
                pri_Dns.Enabled = true;
                sec_Dns.Enabled = true;
                // si checkbox true afficher la liste des imprimante existante


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "Desk")
            {
                ip_address.Text = "10.123.10.1";
                subnet_mask.Text = "255.255.0.0";
                getway.Text = "";
                checkBox1.Checked = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Preview")
            {
                ip_address.Text = "10.123.20.1";
                subnet_mask.Text = "255.255.0.0";
                getway.Text = "";
                checkBox1.Checked = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Room")
            {
                ip_address.Text = "10.123.30.1";
                subnet_mask.Text = "255.255.0.0";
                getway.Text = "";
                checkBox1.Checked = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Display")
            {
                ip_address.Text = "10.123.40.1";
                subnet_mask.Text = "255.255.0.0";
                getway.Text = "";
                checkBox1.Checked = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Accre")
            {
                ip_address.Text = "172.20.10.1";
                subnet_mask.Text = "255.255.0.0";
                getway.Text = "172.20.0.254";
                checkBox1.Checked = true;
                pri_Dns.Text = "8.8.8.8";
                sec_Dns.Text = "1.1.1.1";
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                pri_Dns.Enabled = false;
                sec_Dns.Enabled=false;
                pri_Dns.Text = Dns0;
                sec_Dns.Text = Dns0;
            }
            if (checkBox1.Checked == true)
            {
                pri_Dns.Enabled = true;
                sec_Dns.Enabled= true;
                pri_Dns.Text = Dns8;
                sec_Dns.Text = Dns1;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ip_address_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void iPv4AddressTextBox4_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                string message = "Vous Devez definir un nom pour votre ordinateur !";
                string caption = "Information";

                MessageBox.Show(message, caption);
            }
            else
            {
                string NewName = textBox6.Text;

                string message = "Vous Devez Redemarrer votre ordinateur " + NewName +" pour appliquer ces modifications. Voulez-vous Redemarer ?";
                string caption = "Information";

                SetCMD("/c WMIC Computersystem where Name='%COMPUTERNAME%' call Rename Name=" + NewName +"");

                var result = MessageBox.Show(message, caption,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SetCMD("/c Shutdown -r -t 0");
                }
                if (result == DialogResult.No)
                {
                    return;
                }


            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLanInternet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Interfacetitle_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click_2(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
