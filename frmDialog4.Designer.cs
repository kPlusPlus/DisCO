namespace DisCO
{
    partial class frmDialog4
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
            btnOk = new Button();
            txtInfo = new TextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(187, 131);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Control;
            txtInfo.Location = new Point(4, 2);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(430, 123);
            txtInfo.TabIndex = 1;
            // 
            // frmDialog4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 166);
            ControlBox = false;
            Controls.Add(txtInfo);
            Controls.Add(btnOk);
            MaximizeBox = false;
            Name = "frmDialog4";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDialog4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnOk;
        public TextBox txtInfo;
    }
}