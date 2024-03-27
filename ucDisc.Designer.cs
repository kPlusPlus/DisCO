namespace DisCO
{
    partial class ucDisc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLetter = new TextBox();
            txtIPAddress = new TextBox();
            txtUnique = new TextBox();
            btnOff = new Button();
            btnOn = new Button();
            txtOutput = new TextBox();
            txtNO = new TextBox();
            panelStatus = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            label4 = new Label();
            label5 = new Label();
            txtVolNo = new TextBox();
            btnDiscNo = new Button();
            btnDiskID = new Button();
            btnVolumeNo = new Button();
            SuspendLayout();
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(143, 158);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(45, 23);
            txtLetter.TabIndex = 4;
            // 
            // txtIPAddress
            // 
            txtIPAddress.Location = new Point(9, 26);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(197, 23);
            txtIPAddress.TabIndex = 0;
            txtIPAddress.Text = "192.168.0.0";
            // 
            // txtUnique
            // 
            txtUnique.Location = new Point(9, 70);
            txtUnique.Name = "txtUnique";
            txtUnique.Size = new Size(232, 23);
            txtUnique.TabIndex = 5;
            // 
            // btnOff
            // 
            btnOff.Anchor = AnchorStyles.Top;
            btnOff.BackgroundImage = Properties.Resources.power_button_svgrepo_com;
            btnOff.BackgroundImageLayout = ImageLayout.Stretch;
            btnOff.Location = new Point(3, 183);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(32, 32);
            btnOff.TabIndex = 2;
            btnOff.UseVisualStyleBackColor = true;
            btnOff.Click += btnOff_Click;
            // 
            // btnOn
            // 
            btnOn.Anchor = AnchorStyles.Top;
            btnOn.BackgroundImage = Properties.Resources.power_on_power_button_svgrepo_com;
            btnOn.BackgroundImageLayout = ImageLayout.Stretch;
            btnOn.Location = new Point(36, 183);
            btnOn.Name = "btnOn";
            btnOn.Size = new Size(32, 32);
            btnOn.TabIndex = 1;
            btnOn.UseVisualStyleBackColor = true;
            btnOn.Click += btnOn_Click;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.BackColor = Color.MediumBlue;
            txtOutput.ForeColor = Color.Yellow;
            txtOutput.Location = new Point(3, 221);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(271, 34);
            txtOutput.TabIndex = 15;
            // 
            // txtNO
            // 
            txtNO.Location = new Point(9, 114);
            txtNO.Name = "txtNO";
            txtNO.Size = new Size(48, 23);
            txtNO.TabIndex = 6;
            // 
            // panelStatus
            // 
            panelStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelStatus.Location = new Point(226, 8);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(45, 52);
            panelStatus.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 16;
            label1.Text = "IP Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 17;
            label2.Text = "Disk ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 96);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 18;
            label3.Text = "Disk Order Number";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackgroundImage = Properties.Resources.Save;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Location = new Point(239, 183);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(32, 32);
            btnSave.TabIndex = 19;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 140);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 20;
            label4.Text = "Letter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 140);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 22;
            label5.Text = "Volume Order Number";
            // 
            // txtVolNo
            // 
            txtVolNo.Location = new Point(9, 158);
            txtVolNo.Name = "txtVolNo";
            txtVolNo.Size = new Size(48, 23);
            txtVolNo.TabIndex = 21;
            // 
            // btnDiscNo
            // 
            btnDiscNo.Location = new Point(63, 111);
            btnDiscNo.Name = "btnDiscNo";
            btnDiscNo.Size = new Size(32, 27);
            btnDiscNo.TabIndex = 23;
            btnDiscNo.Text = "...";
            btnDiscNo.UseVisualStyleBackColor = true;
            btnDiscNo.Click += btnDiscNo_Click;
            // 
            // btnDiskID
            // 
            btnDiskID.Location = new Point(245, 70);
            btnDiskID.Name = "btnDiskID";
            btnDiskID.Size = new Size(32, 27);
            btnDiskID.TabIndex = 24;
            btnDiskID.Text = "...";
            btnDiskID.UseVisualStyleBackColor = true;
            btnDiskID.Click += btnDiskID_Click;
            // 
            // btnVolumeNo
            // 
            btnVolumeNo.Location = new Point(63, 155);
            btnVolumeNo.Name = "btnVolumeNo";
            btnVolumeNo.Size = new Size(32, 27);
            btnVolumeNo.TabIndex = 25;
            btnVolumeNo.Text = "...";
            btnVolumeNo.UseVisualStyleBackColor = true;
            btnVolumeNo.Click += btnVolumeNo_Click;
            // 
            // ucDisc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnVolumeNo);
            Controls.Add(btnDiskID);
            Controls.Add(btnDiscNo);
            Controls.Add(label5);
            Controls.Add(txtVolNo);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(btnOn);
            Controls.Add(btnOff);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUnique);
            Controls.Add(panelStatus);
            Controls.Add(txtOutput);
            Controls.Add(txtIPAddress);
            Controls.Add(txtNO);
            Controls.Add(txtLetter);
            Name = "ucDisc";
            Size = new Size(277, 258);
            Load += ucDisc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtIPAddress;
        public Button btnOff;
        public Button btnOn;
        public TextBox txtOutput;
        public TextBox txtLetter;
        public TextBox txtUnique;
        public TextBox txtNO;
        public Panel panelStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        public Button btnSave;
        private Label label4;
        private Label label5;
        public TextBox txtVolNo;
        private Button btnDiscNo;
        private Button btnDiskID;
        private Button btnVolumeNo;
    }
}
