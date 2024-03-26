namespace DisCO
{
    partial class frmDisCO
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ucDisc1 = new ucDisc();
            ucDisc2 = new ucDisc();
            btnLog = new Button();
            panelRunnerScript = new Panel();
            btnStyleBlueMatrix = new Button();
            btnStyleApple = new Button();
            btnStyleColorA = new Button();
            btnStyleBW = new Button();
            label1 = new Label();
            txtOutput = new TextBox();
            btnEditBatch = new Button();
            btnEdit = new Button();
            cmbConfig = new ComboBox();
            btnRunBatch = new Button();
            cmbListScripts = new ComboBox();
            panel2 = new Panel();
            ucDisc3 = new ucDisc();
            tableLayoutPanel1.SuspendLayout();
            panelRunnerScript.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(ucDisc1, 0, 0);
            tableLayoutPanel1.Controls.Add(ucDisc2, 1, 0);
            tableLayoutPanel1.Controls.Add(ucDisc3, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.97324F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.026756F));
            tableLayoutPanel1.Size = new Size(941, 306);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ucDisc1
            // 
            ucDisc1.Dock = DockStyle.Fill;
            ucDisc1.Location = new Point(3, 3);
            ucDisc1.Name = "ucDisc1";
            ucDisc1.Size = new Size(307, 275);
            ucDisc1.TabIndex = 0;
            // 
            // ucDisc2
            // 
            ucDisc2.Dock = DockStyle.Fill;
            ucDisc2.Location = new Point(316, 3);
            ucDisc2.Name = "ucDisc2";
            ucDisc2.Size = new Size(307, 275);
            ucDisc2.TabIndex = 1;
            // 
            // btnLog
            // 
            btnLog.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLog.BackColor = Color.WhiteSmoke;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnLog.Location = new Point(906, 324);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(47, 23);
            btnLog.TabIndex = 16;
            btnLog.Text = "LOG";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // panelRunnerScript
            // 
            panelRunnerScript.Controls.Add(btnStyleBlueMatrix);
            panelRunnerScript.Controls.Add(btnStyleApple);
            panelRunnerScript.Controls.Add(btnStyleColorA);
            panelRunnerScript.Controls.Add(btnStyleBW);
            panelRunnerScript.Controls.Add(label1);
            panelRunnerScript.Controls.Add(txtOutput);
            panelRunnerScript.Location = new Point(12, 455);
            panelRunnerScript.Name = "panelRunnerScript";
            panelRunnerScript.Size = new Size(776, 199);
            panelRunnerScript.TabIndex = 17;
            // 
            // btnStyleBlueMatrix
            // 
            btnStyleBlueMatrix.BackColor = Color.Sienna;
            btnStyleBlueMatrix.BackgroundImage = Properties.Resources.black_white_svgrepo_com_1;
            btnStyleBlueMatrix.BackgroundImageLayout = ImageLayout.Stretch;
            btnStyleBlueMatrix.Location = new Point(753, 39);
            btnStyleBlueMatrix.Name = "btnStyleBlueMatrix";
            btnStyleBlueMatrix.Size = new Size(16, 16);
            btnStyleBlueMatrix.TabIndex = 22;
            btnStyleBlueMatrix.UseVisualStyleBackColor = false;
            btnStyleBlueMatrix.Click += btnStyleBlueMatrix_Click;
            // 
            // btnStyleApple
            // 
            btnStyleApple.BackColor = Color.RosyBrown;
            btnStyleApple.BackgroundImage = Properties.Resources.black_white_svgrepo_com_1;
            btnStyleApple.BackgroundImageLayout = ImageLayout.Stretch;
            btnStyleApple.Location = new Point(734, 39);
            btnStyleApple.Name = "btnStyleApple";
            btnStyleApple.Size = new Size(16, 16);
            btnStyleApple.TabIndex = 19;
            btnStyleApple.UseVisualStyleBackColor = false;
            btnStyleApple.Click += btnStyleApple_Click;
            // 
            // btnStyleColorA
            // 
            btnStyleColorA.BackgroundImage = Properties.Resources.black_white_svgrepo_com_1;
            btnStyleColorA.BackgroundImageLayout = ImageLayout.Stretch;
            btnStyleColorA.Location = new Point(713, 39);
            btnStyleColorA.Name = "btnStyleColorA";
            btnStyleColorA.Size = new Size(16, 16);
            btnStyleColorA.TabIndex = 18;
            btnStyleColorA.UseVisualStyleBackColor = true;
            btnStyleColorA.Click += btnStyleColorA_Click;
            // 
            // btnStyleBW
            // 
            btnStyleBW.BackgroundImage = Properties.Resources.black_white_svgrepo_com;
            btnStyleBW.BackgroundImageLayout = ImageLayout.Stretch;
            btnStyleBW.Location = new Point(693, 39);
            btnStyleBW.Name = "btnStyleBW";
            btnStyleBW.Size = new Size(16, 16);
            btnStyleBW.TabIndex = 17;
            btnStyleBW.UseVisualStyleBackColor = true;
            btnStyleBW.Click += btnStyleBW_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Scripts:";
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.BackColor = Color.MediumBlue;
            txtOutput.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtOutput.ForeColor = Color.Yellow;
            txtOutput.Location = new Point(0, 47);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(773, 149);
            txtOutput.TabIndex = 16;
            // 
            // btnEditBatch
            // 
            btnEditBatch.BackgroundImage = Properties.Resources._62914memo_109205;
            btnEditBatch.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditBatch.Location = new Point(435, 11);
            btnEditBatch.Name = "btnEditBatch";
            btnEditBatch.Size = new Size(32, 32);
            btnEditBatch.TabIndex = 21;
            btnEditBatch.UseVisualStyleBackColor = true;
            btnEditBatch.Click += btnEditBatch_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackgroundImage = Properties.Resources._62914memo_109205;
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.Location = new Point(737, 11);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(32, 32);
            btnEdit.TabIndex = 20;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cmbConfig
            // 
            cmbConfig.FormattingEnabled = true;
            cmbConfig.Location = new Point(474, 17);
            cmbConfig.Name = "cmbConfig";
            cmbConfig.Size = new Size(256, 23);
            cmbConfig.TabIndex = 19;
            cmbConfig.KeyUp += cmbConfig_KeyUp;
            // 
            // btnRunBatch
            // 
            btnRunBatch.BackgroundImage = Properties.Resources.play_svgrepo_com;
            btnRunBatch.BackgroundImageLayout = ImageLayout.Stretch;
            btnRunBatch.Location = new Point(391, 10);
            btnRunBatch.Name = "btnRunBatch";
            btnRunBatch.Size = new Size(38, 32);
            btnRunBatch.TabIndex = 2;
            btnRunBatch.UseVisualStyleBackColor = true;
            btnRunBatch.Click += btnRunBatch_Click;
            // 
            // cmbListScripts
            // 
            cmbListScripts.FormattingEnabled = true;
            cmbListScripts.Location = new Point(3, 17);
            cmbListScripts.Name = "cmbListScripts";
            cmbListScripts.Size = new Size(382, 23);
            cmbListScripts.TabIndex = 0;
            cmbListScripts.KeyUp += cmbListScripts_KeyUp;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbListScripts);
            panel2.Controls.Add(btnEditBatch);
            panel2.Controls.Add(btnRunBatch);
            panel2.Controls.Add(cmbConfig);
            panel2.Controls.Add(btnEdit);
            panel2.Location = new Point(12, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 125);
            panel2.TabIndex = 18;
            // 
            // ucDisc3
            // 
            ucDisc3.Dock = DockStyle.Fill;
            ucDisc3.Location = new Point(629, 3);
            ucDisc3.Name = "ucDisc3";
            ucDisc3.Size = new Size(309, 275);
            ucDisc3.TabIndex = 2;
            // 
            // frmDisCO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 719);
            Controls.Add(panel2);
            Controls.Add(btnLog);
            Controls.Add(panelRunnerScript);
            Controls.Add(tableLayoutPanel1);
            Name = "frmDisCO";
            Text = "DisCO";
            Load += frmDisCO_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelRunnerScript.ResumeLayout(false);
            panelRunnerScript.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ucDisc ucDisc2;
        public ucDisc ucDisc1;
        private Button btnLog;
        public Panel panelRunnerScript;
        private ComboBox cmbListScripts;
        private Panel panel1;
        private Label label1;
        private Button btnRunBatch;
        public TextBox txtOutput;
        private Button btnStyleBW;
        private Button btnStyleColorA;
        private Button btnEdit;
        private ComboBox cmbConfig;
        private Button btnStyleApple;
        private Button btnEditBatch;
        private Button btnStyleBlueMatrix;
        private Panel panel2;
        private ucDisc ucDisc3;
    }
}