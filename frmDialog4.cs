namespace DisCO
{
    public partial class frmDialog4 : Form
    {
        public frmDialog4()
        {
            InitializeComponent();
            txtInfo.SelectionStart = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
