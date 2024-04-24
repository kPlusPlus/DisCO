namespace DisCO
{
    public partial class frmDialog1_YesNo : Form
    {
        public bool answer = false;

        public frmDialog1_YesNo()
        {
            InitializeComponent();
            txtMsg.SelectionStart = 0;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            answer = true;
            DialogResult = DialogResult.Yes;
            return;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            answer = false;
            DialogResult = DialogResult.No;
            return;
        }
    }
}
