using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using System.Xml;

namespace DisCO
{
    public partial class ucDisc : UserControl
    {
        public bool StatusDisc = false;
        public frmDisCO formParent = null;
        public ucDisc()
        {
            InitializeComponent();
            formParent = (frmDisCO)ParentForm;
            //LoadUSBSettings();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            /*

            // Create a new process start info
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c dir";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            // Start the process with the specified start info
            Process process = Process.Start(startInfo);

            // Read the output of the process
            string output = process.StandardOutput.ReadToEnd();

            // Display the output in the TextBox
            txtOutput.AppendText(output);
            panelStatus.BackColor = Color.Red;
            formParent.MC_NLOG_info(this.Name + "Disc ON");

            */

            if(IsDiskOnline( int.Parse(txtNO.Text) ))
                panelStatus.BackColor = Color.Red;
            else panelStatus.BackColor = Color.Green;

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            //txtOutput.Clear();

            // Create a new process start info
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c ping iskon.hr";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            // Start the process with the specified start info
            Process process = Process.Start(startInfo);

            // Read the output of the process
            string output = process.StandardOutput.ReadToEnd();

            // Display the output in the TextBox
            txtOutput.AppendText(output);
            panelStatus.BackColor = Color.GreenYellow;
            formParent.MC_NLOG_info(this.Name + "Disc OFF");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var ansForma = formParent.ShowDialog_1YesNo("Snimanje", "Da li želite snimiti ovaj file");
            if (ansForma == false)
            {
                return;
            }

            UsbDisc usbDisc = new UsbDisc();
            usbDisc.IPAddress = txtIPAddress.Text;
            usbDisc.OrderNO = int.Parse(txtNO.Text);
            usbDisc.DiscID = txtUnique.Text;
            usbDisc.Letter = txtLetter.Text;

            FileStream fs = new FileStream(this.Name + ".bin", FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(typeof(UsbDisc));
            serializer.Serialize(fs, usbDisc);
            fs.Close();

            // number of usb
            int numOfUsb = int.Parse(this.Name.Substring(this.Name.Length - 1));
            string usbProp = "usb" + numOfUsb + "_id";
            formParent.common.SetPropertyValue(Path.Combine(formParent.dirConfig, "config.ini"), usbProp, usbDisc.DiscID);
            // Grep IP
            formParent.common.GrepIpByEveryFiles(txtIPAddress.Text);
        }


        private void LoadUSBSettings()
        {
            UsbDisc usbDisc; //= new UsbDisc();
            string fileBin = this.Name + ".bin";
            if (File.Exists(fileBin))
            {
                try
                {
                    FileStream fs = new FileStream(fileBin, FileMode.Open, FileAccess.Read);
                    XmlSerializer serializer = new XmlSerializer(typeof(UsbDisc));
                    //serializer.Deserialize(fs);
                    usbDisc = (UsbDisc)serializer.Deserialize(fs);
                    fs.Close();

                    txtIPAddress.Text = usbDisc.IPAddress;
                    txtNO.Text = usbDisc.OrderNO.ToString();
                    txtUnique.Text = usbDisc.DiscID;
                    txtLetter.Text = usbDisc.Letter;
                }
                catch(Exception ex) 
                {
                    formParent.MC_NLOG_error("Error 74 " + fileBin + " " + ex.Message.ToString());
                    Debug.WriteLine("Error 74 " + fileBin + " " + ex.Message.ToString());
                }
            }
        }

        private void ucDisc_Load(object sender, EventArgs e)
        {
            LoadUSBSettings();
        }


        static bool IsDiskOnline(int diskNumber)
        {
            // Execute diskpart command to list disk attributes
            string[] commands = {
            $"list disk",
            $"select disk {diskNumber}",
            $"attributes disk"
        };
            string output = ExecuteDiskpartCommands(commands);

            // Parse the output to determine if the disk is online
            return output.Contains("Current Read-only State : No");
        }

        static string ExecuteDiskpartCommands(string[] commands)
        {
            // Create process info
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "diskpart.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Verb = "runas"
            };

            // Start the process
            using (Process process = Process.Start(psi))
            {
                // Write commands to the standard input of the process
                foreach (string command in commands)
                {
                    process.StandardInput.WriteLine(command);
                }

                // Close the standard input stream to signal the end of commands
                process.StandardInput.Close();

                // Read the output of the process
                string output = process.StandardOutput.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                // Return the output
                return output;
            }
        }



    }

    [Serializable]
    public class UsbDisc()
    {
        public string IPAddress = string.Empty;
        public string DiscID = string.Empty;
        public int OrderNO = 0;
        public string Letter = string.Empty;

    }
}
