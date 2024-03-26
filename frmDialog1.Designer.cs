namespace DisCO
{
    partial class frmDialog1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMsg = new TextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // txtMsg
            // 
            txtMsg.BackColor = SystemColors.Control;
            txtMsg.Location = new Point(4, 6);
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(419, 55);
            txtMsg.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(159, 67);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(90, 28);
            btnOK.TabIndex = 1;
            btnOK.Text = "X";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // frmDialog1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 101);
            ControlBox = false;
            Controls.Add(btnOK);
            Controls.Add(txtMsg);
            MaximizeBox = false;
            Name = "frmDialog1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "e kad bi sve bilo u redu";
            Load += frmDialog1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnOK;
        public TextBox txtMsg;
    }
}