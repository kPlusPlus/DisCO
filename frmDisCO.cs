using NLog.Windows.Forms;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DisCO
{
    public partial class frmDisCO : Form
    {
        // --- NLOG ---
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private bool ShowHideLog = false; // bool for switch Log window        
        private string dirBatch = @"C:\BackupConf\Run";
        public string dirConfig = @"C:\BackupConf\INI";
        public Common common = new Common();
        public float dpiScaleFactor = Graphics.FromHwnd(IntPtr.Zero).DpiX / 96f;

        public frmDisCO()
        {
            InitializeComponent();
            ucDisc1.formParent = this;
            ucDisc2.formParent = this;
            ucDisc3.formParent = this;

            //TODO: ovdje dodaj slike
            ucDisc1.panelDisk.BackgroundImage = Properties.Resources.hdd_usb;
            ucDisc2.panelDisk.BackgroundImage = Properties.Resources.hdd_usb;
            ucDisc3.panelDisk.BackgroundImage = Properties.Resources.hard_drive_disk_hdd_icon_big;

            ucDisc1.panelDisk.BackgroundImageLayout = ImageLayout.Stretch;
            ucDisc2.panelDisk.BackgroundImageLayout = ImageLayout.Stretch;
            ucDisc3.panelDisk.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void frmDisCO_Load(object sender, EventArgs e)
        {
            Globals.NLOG_Config();
            Logger.Info("DisCO start");
            FillComboScript();
            btnStyleBW_Click(sender, e);
        }

        /*
        private void NLOG_Config(string sFileName = "Nlog.log")
        {
            var config = new NLog.Config.LoggingConfiguration();
            RichTextBoxTarget target = new RichTextBoxTarget();

            target.Layout = "${date:format=HH\\:MM\\:ss} ${logger} ${message}";
            //target.ControlName = "rtbLog"; // *** Use for RichTextBoxTarget on Form ***
            //target.FormName = "frmMainAkdamar";

            target.ControlName = "rtbLog2";
            target.FormName = "frmMainAkdamar";

            target.UseDefaultRowColoringRules = true;
            target.ToolWindow = true;
            target.ShowMinimized = true;
            config.AddTarget("rtbLog", target);

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = sFileName };

            // Rules for mapping loggers to targets
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, target);

            // Apply config
            NLog.LogManager.Configuration = config;

            // Initialize NLog
            //LogManager.ReconfigExistingLoggers();
        }
        */

        /*
        private void NLOG_ConfigShow(string sFileName = "Nlog.log")
        {
            var config = new NLog.Config.LoggingConfiguration();
            RichTextBoxTarget target = new RichTextBoxTarget();

            //target.Layout = "${date:format=HH\\:MM\\:ss} ${logger} ${message}";
            target.Layout = @"${longdate} ${logger} ${message}";

            target.ControlName = "rtbLog2";
            target.FormName = "frmMainAkdamar";

            target.UseDefaultRowColoringRules = true;
            target.ToolWindow = true;
            //target.ShowMinimized = true;
            config.AddTarget("rtbLog", target);

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = sFileName };

            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, target);

            // Apply config
            NLog.LogManager.Configuration = config;

            // Initialize NLog
            LogManager.ReconfigExistingLoggers();
        }

        private void NLOG_ConfigHide(string sFileName = "Nlog.log")
        {
            var config = new NLog.Config.LoggingConfiguration();
            RichTextBoxTarget target = new RichTextBoxTarget();

            target.Layout = "${longdate} ${logger} ${message}";

            target.ControlName = "rtbLog2";
            target.FormName = "frmMainAkdamar";

            target.UseDefaultRowColoringRules = true;
            target.ToolWindow = true;
            target.ShowMinimized = true;
            config.AddTarget("rtbLog", target);

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = sFileName };

            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, target);

            // Apply config
            NLog.LogManager.Configuration = config;

            // Initialize NLog
            LogManager.ReconfigExistingLoggers();
        }
        */
        #region --------------    FUNCTIONS     --------------
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (Globals.ShowHideLog == false)
            {
                Globals.NLOG_ConfigShow();
                ShowHideLog = true;
                btnLog.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                Globals.NLOG_ConfigHide();
                ShowHideLog = false;
                btnLog.FlatStyle = FlatStyle.Flat;
            }
        }


        public void MC_NLOG_info(string sInfo)
        {
            Globals.Logger.Info(sInfo);
        }

        public void MC_NLOG_warn(string sInfo)
        {
            Globals.Logger.Warn(sInfo);
        }

        public void MC_NLOG_error(string sInfo)
        {
            Globals.Logger.Error(sInfo);
        }

        private void FillComboScript()
        {
            //List<string> list = new List<string>();
            if (!Directory.Exists(dirBatch))
            {
                ShowDialog_1("Upozorenje", "Folder " + dirBatch + "ne postoji");
                return;
            }
            cmbListScripts.Items.Clear();

            foreach (string file in Directory.GetFiles(dirBatch, "*.bat"))
            {
                cmbListScripts.Items.Add(file);
                //list.Add(file);
            }

            foreach (string file in Directory.GetFiles(dirBatch, "*.ps1"))
            {
                cmbListScripts.Items.Add(file);
                //list.Add(file);
            }

            //cmbListScripts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbListScripts.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //cmbListScripts.AutoCompleteCustomSource.AddRange(list.ToArray());

            cmbConfig.Items.Clear();
            //List<string> listA = new List<string>();
            foreach (string file in Directory.GetFiles(dirConfig, "*.ini"))
            {
                cmbConfig.Items.Add(file);
                //listA.Add(file);
            }

            //cmbConfig.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbConfig.AutoCompleteSource = AutoCompleteSource.ListItems;
            //cmbConfig.AutoCompleteCustomSource.AddRange(list.ToArray());

            Logger.Info("[FILL] All lists are full");
        }

        #endregion

        #region *** Dialogs ****

        /// <summary>
        /// Show Dialog 1, with form text and info text
        /// </summary>
        /// <param name="formname"></param>
        /// <param name="Msg"></param>
        /// <param name="iWidth"></param>
        /// <param name="iHeight"></param>
        public void ShowDialog_1(string formname, string Msg, int iWidth = 300, int iHeight = 140)
        {
            frmDialog1 forma = new frmDialog1();
            forma.Text = formname;
            forma.Width = (int)(iWidth * dpiScaleFactor);
            forma.Height = (int)(iHeight * dpiScaleFactor);
            forma.txtMsg.Text = Msg;
            forma.txtMsg.TextAlign = HorizontalAlignment.Center;
            forma.txtMsg.Left = (forma.Width / 2) - (forma.txtMsg.Width / 2);
            forma.StartPosition = FormStartPosition.CenterParent;
            forma.ShowDialog();
            forma.ActiveControl = forma.btnOK;
        }

        public void ShowDialog_3(string formname, string Msg, int iWidth = 300, int iHeight = 140)
        {
            frmDialog3 forma = new frmDialog3();
            forma.Text = formname;
            forma.Width = (int)(iWidth * dpiScaleFactor);
            forma.Height = (int)(iHeight * dpiScaleFactor);
            forma.txtMsg.Text = Msg;
            forma.txtMsg.TextAlign = HorizontalAlignment.Center;
            forma.txtMsg.Left = (forma.Width / 2) - (forma.txtMsg.Width / 2);
            forma.StartPosition = FormStartPosition.CenterParent;
            forma.ShowDialog();
        }

        /// <summary>
        /// simply Yes/No Dialoge
        /// </summary>
        /// <param name="formname">Title on dialoge</param>
        /// <param name="Msg">Message</param>
        /// <param name="iWidth">Def. [457]</param>
        /// <param name="iHeight">Def. [193]</param>
        /// <returns></returns>
        public bool ShowDialog_1YesNo(string formname, string Msg, int iWidth = 457, int iHeight = 193)
        {
            frmDialog1_YesNo forma = new frmDialog1_YesNo();
            forma.Text = formname;
            forma.Width = (int)(iWidth * dpiScaleFactor);
            forma.Height = (int)(iHeight * dpiScaleFactor);
            forma.txtMsg.Text = Msg;
            forma.ShowDialog();
            if (forma.DialogResult == DialogResult.Yes)
            {
                return true;
            }
            if (forma.DialogResult != DialogResult.Yes)
            {
                return false;
            }

            return false;

        }

        #endregion

        public void btnRunBatch_Click(object sender, EventArgs e)
        {
            if (cmbListScripts.SelectedIndex == -1)
            {
                ShowDialog_1("Info", "Molim odaberite scriptu za izvršavanje");
                return;
            }

            //txtOutput.Clear();

            // Create a new process start info
            ProcessStartInfo startInfo = new ProcessStartInfo();
            if (cmbListScripts.SelectedItem.ToString().Contains(".ps1"))
            {
                startInfo.FileName = "powershell.exe";
                startInfo.Arguments = @"-File  """ + cmbListScripts.SelectedItem + @"""";
            }
            else
            {
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = @"/c """ + cmbListScripts.SelectedItem + @""""; //"/c ping iskon.hr";
            }
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            startInfo.StandardOutputEncoding = Encoding.GetEncoding("ISO-8859-1");
            startInfo.WorkingDirectory = Environment.CurrentDirectory; //TODO: kasnije zamijeni

            // Start the process with the specified start info
            Process process = Process.Start(startInfo);

            // Read the output of the process
            string output = process.StandardOutput.ReadToEnd();

            // Display the output in the TextBox
            txtOutput.AppendText("*** " + Environment.NewLine + DateTime.Now + "EXEC. " + startInfo.FileName + " " + startInfo.Arguments + Environment.NewLine);

            txtOutput.AppendText(output);
            Logger.Info("[Exec] " + startInfo.Arguments);

        }

        private void btnStyleBW_Click(object sender, EventArgs e)
        {
            /*
            txtOutput.ForeColor = Color.White;
            txtOutput.BackColor = Color.Black;

            ucDisc1.txtOutput.ForeColor = Color.White;
            ucDisc1.txtOutput.BackColor = Color.Black;

            ucDisc2.txtOutput.ForeColor = Color.White;
            ucDisc2.txtOutput.BackColor = Color.Black;
            */
            takeColorCommandWindow(Color.White, Color.Black);
        }

        private void btnStyleColorA_Click(object sender, EventArgs e)
        {
            /*
            txtOutput.ForeColor = Color.Yellow;
            txtOutput.BackColor = Color.MediumBlue;

            ucDisc1.txtOutput.ForeColor = Color.Yellow;
            ucDisc1.txtOutput.BackColor = Color.MediumBlue;

            ucDisc2.txtOutput.ForeColor = Color.Yellow;
            ucDisc2.txtOutput.BackColor = Color.MediumBlue;
            */
            takeColorCommandWindow(Color.Yellow, Color.MediumBlue);
        }
        private void btnStyleApple_Click(object sender, EventArgs e)
        {
            takeColorCommandWindow(Color.Yellow, Color.SaddleBrown);

        }
        private void btnStyleBlueMatrix_Click(object sender, EventArgs e)
        {
            takeColorCommandWindow(ColorTranslator.FromHtml("#00a2ff"), ColorTranslator.FromHtml("#101116"));
        }

        /// <summary>
        /// Simple function for take Colors of command prompt controls
        /// </summary>
        /// <param name="foreColor"></param>
        /// <param name="backColor"></param>
        private void takeColorCommandWindow(Color foreColor, Color backColor)
        {
            txtOutput.ForeColor = foreColor;
            txtOutput.BackColor = backColor;

            ucDisc1.txtOutput.ForeColor = foreColor;
            ucDisc1.txtOutput.BackColor = backColor;

            ucDisc2.txtOutput.ForeColor = foreColor;
            ucDisc2.txtOutput.BackColor = backColor;

            ucDisc3.txtOutput.ForeColor = foreColor;
            ucDisc3.txtOutput.BackColor = backColor;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbConfig.SelectedIndex == -1)
            {
                ShowDialog_1("Info", "Niste odabrali nijedan config file");
                return;
            }

            frmEditor frmEdit = new frmEditor();
            frmEdit.formaDisCO = this;
            frmEdit.fileIni = cmbConfig.SelectedItem.ToString();
            frmEdit.Text = frmEdit.fileIni;
            frmEdit.LoadINI();
            frmEdit.ShowDialog();
            Logger.Info("[edit] " + frmEdit.fileIni);
        }

        private void btnEditBatch_Click(object sender, EventArgs e)
        {
            if (cmbListScripts.SelectedIndex == -1)
            {
                ShowDialog_1("Info", "Niste odabrali nijednu scriptu");
                return;
            }

            frmEditor frmEdit = new frmEditor();
            frmEdit.formaDisCO = this;
            frmEdit.fileIni = cmbListScripts.SelectedItem.ToString();
            frmEdit.Text = frmEdit.fileIni;
            frmEdit.LoadINI();
            frmEdit.ShowDialog();
            Logger.Info("[edit] " + frmEdit.fileIni);
        }

        public void cmbListScripts_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = cmbListScripts.Text;
            if (searchText.Length < 4) return;
            int index = FindSubstringIndex(searchText);
            if (index == -1) return;
            cmbListScripts.SelectedIndex = index;
        }

        private int FindSubstringIndex(string searchText)
        {
            // Iterate through ComboBox items and find the index of the item containing the search text
            for (int i = 0; i < cmbListScripts.Items.Count; i++)
            {
                string item = cmbListScripts.Items[i].ToString();
                if (item.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return i; // Found
                }
            }
            return -1; // Not found
        }

        private void cmbConfig_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = cmbConfig.Text;
            if (searchText.Length < 4) return;
            int index = FindSubstringIndex(searchText);
            if (index == -1) return;
            cmbConfig.SelectedIndex = index;
        }
    }
}
