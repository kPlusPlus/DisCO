namespace DisCO
{
    partial class frmDialog1_YesNo
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
            btnYes = new Button();
            btnNo = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMsg
            // 
            txtMsg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMsg.BackColor = SystemColors.Control;
            txtMsg.Location = new Point(5, 2);
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(433, 99);
            txtMsg.TabIndex = 2;
            // 
            // btnYes
            // 
            btnYes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnYes.Location = new Point(116, 7);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(90, 28);
            btnYes.TabIndex = 4;
            btnYes.Text = "DA";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNo.Location = new Point(212, 7);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(90, 28);
            btnNo.TabIndex = 5;
            btnNo.Text = "NE";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnYes);
            panel1.Controls.Add(btnNo);
            panel1.Location = new Point(5, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 44);
            panel1.TabIndex = 6;
            // 
            // frmDialog1_YesNo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 154);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(txtMsg);
            Name = "frmDialog1_YesNo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDialog1_YesNo";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtMsg;
        public Button btnYes;
        public Button btnNo;
        private Panel panel1;
    }
}