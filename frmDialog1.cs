namespace DisCO
{
    public partial class frmDialog1 : Form
    {
        public frmDialog1()
        {
            InitializeComponent();
        }

        private void frmDialog1_Load(object sender, EventArgs e)
        {
            txtMsg.TextAlign = HorizontalAlignment.Center;
            txtMsg.Left = (this.ClientSize.Width / 2) - (txtMsg.Width / 2);
            btnOK.Left = (this.ClientSize.Width / 2) - (btnOK.Width / 2);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
