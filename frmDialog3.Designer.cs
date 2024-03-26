namespace DisCO
{
    partial class frmDialog3
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
            Label1 = new Label();
            SuspendLayout();
            // 
            // txtMsg
            // 
            txtMsg.BackColor = SystemColors.Control;
            txtMsg.Location = new Point(28, 24);
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(223, 20);
            txtMsg.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(25, 60);
            Label1.Name = "Label1";
            Label1.Size = new Size(0, 15);
            Label1.TabIndex = 1;
            // 
            // frmDialog3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 110);
            Controls.Add(Label1);
            Controls.Add(txtMsg);
            MaximizeBox = false;
            Name = "frmDialog3";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtMsg;
        public Label Label1;
    }
}