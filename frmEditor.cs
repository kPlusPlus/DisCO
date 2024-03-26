using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisCO
{
    public partial class frmEditor : Form
    {

        public frmDisCO formaDisCO;
        public string fileIni;


        public frmEditor()
        {
            InitializeComponent();
        }

        public void LoadINI()
        {            
            string iniStr = File.ReadAllText(fileIni);
            txtINI.Text = iniStr;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var ansForma = formaDisCO.ShowDialog_1YesNo("Snimanje", "Da li želite snimiti ovaj file");
            if (ansForma == false)
            {
                return;
            }

            File.WriteAllText(fileIni, txtINI.Text);
            formaDisCO.MC_NLOG_info("[SAVE] " + txtINI.Text);
            //this.Close(); TODO: test test test
        }

        /// <summary>
        /// Close before SAVE !!!, asking for it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEditor_FormClosing(object sender, FormClosingEventArgs e)
        {            
            btnSave_Click(sender,e);
        }
    }
}
