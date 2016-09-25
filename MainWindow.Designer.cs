namespace dotNetdotMatrix
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRatio = new System.Windows.Forms.NumericUpDown();
            this.btnExImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearComplete = new System.Windows.Forms.Button();
            this.btnStopAnimation = new System.Windows.Forms.Button();
            this.btnStartAnimation = new System.Windows.Forms.Button();
            this.btnRestartAnimation = new System.Windows.Forms.Button();
            this.nudLines = new System.Windows.Forms.NumericUpDown();
            this.lvwTokens = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsTokenContainer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddToken = new System.Windows.Forms.Button();
            this.btnSelectCharset = new System.Windows.Forms.Button();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.pnlMargin = new System.Windows.Forms.Panel();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLines)).BeginInit();
            this.cmsTokenContainer.SuspendLayout();
            this.pnlMargin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.Black;
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(15, 15);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(456, 320);
            this.pnlDisplay.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudRatio);
            this.panel1.Controls.Add(this.btnExImport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClearComplete);
            this.panel1.Controls.Add(this.btnStopAnimation);
            this.panel1.Controls.Add(this.btnStartAnimation);
            this.panel1.Controls.Add(this.btnRestartAnimation);
            this.panel1.Controls.Add(this.nudLines);
            this.panel1.Controls.Add(this.lvwTokens);
            this.panel1.Controls.Add(this.btnAddToken);
            this.panel1.Controls.Add(this.btnSelectCharset);
            this.panel1.Controls.Add(this.tbxColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(486, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panel1.Size = new System.Drawing.Size(480, 350);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "DPXLR:";
            // 
            // nudRatio
            // 
            this.nudRatio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRatio.DecimalPlaces = 2;
            this.nudRatio.Enabled = false;
            this.nudRatio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudRatio.Location = new System.Drawing.Point(245, 312);
            this.nudRatio.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRatio.Name = "nudRatio";
            this.nudRatio.Size = new System.Drawing.Size(110, 23);
            this.nudRatio.TabIndex = 19;
            // 
            // btnExImport
            // 
            this.btnExImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExImport.Enabled = false;
            this.btnExImport.Location = new System.Drawing.Point(394, 281);
            this.btnExImport.Name = "btnExImport";
            this.btnExImport.Size = new System.Drawing.Size(75, 25);
            this.btnExImport.TabIndex = 18;
            this.btnExImport.Text = "Ex-/Import";
            this.btnExImport.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Matrix Lines:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Default Dot Color:";
            // 
            // btnClearComplete
            // 
            this.btnClearComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearComplete.Enabled = false;
            this.btnClearComplete.Location = new System.Drawing.Point(117, 15);
            this.btnClearComplete.Name = "btnClearComplete";
            this.btnClearComplete.Size = new System.Drawing.Size(89, 25);
            this.btnClearComplete.TabIndex = 15;
            this.btnClearComplete.Text = "Clear All";
            this.btnClearComplete.UseVisualStyleBackColor = true;
            // 
            // btnStopAnimation
            // 
            this.btnStopAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopAnimation.Enabled = false;
            this.btnStopAnimation.Location = new System.Drawing.Point(344, 15);
            this.btnStopAnimation.Name = "btnStopAnimation";
            this.btnStopAnimation.Size = new System.Drawing.Size(60, 25);
            this.btnStopAnimation.TabIndex = 14;
            this.btnStopAnimation.Text = "Stop";
            this.btnStopAnimation.UseVisualStyleBackColor = true;
            // 
            // btnStartAnimation
            // 
            this.btnStartAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartAnimation.Enabled = false;
            this.btnStartAnimation.Location = new System.Drawing.Point(278, 15);
            this.btnStartAnimation.Name = "btnStartAnimation";
            this.btnStartAnimation.Size = new System.Drawing.Size(60, 25);
            this.btnStartAnimation.TabIndex = 13;
            this.btnStartAnimation.Text = "Start";
            this.btnStartAnimation.UseVisualStyleBackColor = true;
            // 
            // btnRestartAnimation
            // 
            this.btnRestartAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestartAnimation.Enabled = false;
            this.btnRestartAnimation.Location = new System.Drawing.Point(409, 15);
            this.btnRestartAnimation.Name = "btnRestartAnimation";
            this.btnRestartAnimation.Size = new System.Drawing.Size(60, 25);
            this.btnRestartAnimation.TabIndex = 12;
            this.btnRestartAnimation.Text = "Restart";
            this.btnRestartAnimation.UseVisualStyleBackColor = true;
            // 
            // nudLines
            // 
            this.nudLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLines.Enabled = false;
            this.nudLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudLines.Location = new System.Drawing.Point(129, 312);
            this.nudLines.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLines.Name = "nudLines";
            this.nudLines.Size = new System.Drawing.Size(110, 23);
            this.nudLines.TabIndex = 11;
            this.nudLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lvwTokens
            // 
            this.lvwTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwTokens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwTokens.ContextMenuStrip = this.cmsTokenContainer;
            this.lvwTokens.Enabled = false;
            this.lvwTokens.FullRowSelect = true;
            this.lvwTokens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwTokens.Location = new System.Drawing.Point(11, 51);
            this.lvwTokens.MultiSelect = false;
            this.lvwTokens.Name = "lvwTokens";
            this.lvwTokens.Size = new System.Drawing.Size(457, 230);
            this.lvwTokens.TabIndex = 9;
            this.lvwTokens.UseCompatibleStateImageBehavior = false;
            this.lvwTokens.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Content";
            this.columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Align";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Index/Line";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Duration";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Inverted";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Keep";
            // 
            // cmsTokenContainer
            // 
            this.cmsTokenContainer.BackColor = System.Drawing.Color.White;
            this.cmsTokenContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDuplicate,
            this.tsmiRemove});
            this.cmsTokenContainer.Name = "cmsTokenContainer";
            this.cmsTokenContainer.ShowImageMargin = false;
            this.cmsTokenContainer.Size = new System.Drawing.Size(100, 70);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(99, 22);
            this.tsmiEdit.Text = "Edit";
            // 
            // tsmiDuplicate
            // 
            this.tsmiDuplicate.Name = "tsmiDuplicate";
            this.tsmiDuplicate.Size = new System.Drawing.Size(99, 22);
            this.tsmiDuplicate.Text = "Duplicate";
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(99, 22);
            this.tsmiRemove.Text = "Remove";
            // 
            // btnAddToken
            // 
            this.btnAddToken.Enabled = false;
            this.btnAddToken.Location = new System.Drawing.Point(212, 15);
            this.btnAddToken.Name = "btnAddToken";
            this.btnAddToken.Size = new System.Drawing.Size(60, 25);
            this.btnAddToken.TabIndex = 8;
            this.btnAddToken.Text = "Add";
            this.btnAddToken.UseVisualStyleBackColor = true;
            // 
            // btnSelectCharset
            // 
            this.btnSelectCharset.Location = new System.Drawing.Point(11, 15);
            this.btnSelectCharset.Name = "btnSelectCharset";
            this.btnSelectCharset.Size = new System.Drawing.Size(100, 25);
            this.btnSelectCharset.TabIndex = 7;
            this.btnSelectCharset.Text = "Select Charset...";
            this.btnSelectCharset.UseVisualStyleBackColor = true;
            // 
            // tbxColor
            // 
            this.tbxColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxColor.Enabled = false;
            this.tbxColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxColor.Location = new System.Drawing.Point(13, 312);
            this.tbxColor.MaxLength = 7;
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(110, 23);
            this.tbxColor.TabIndex = 6;
            this.tbxColor.Text = "#E8AA0E";
            // 
            // pnlMargin
            // 
            this.pnlMargin.BackColor = System.Drawing.Color.Black;
            this.pnlMargin.Controls.Add(this.pnlDisplay);
            this.pnlMargin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMargin.Location = new System.Drawing.Point(0, 0);
            this.pnlMargin.Name = "pnlMargin";
            this.pnlMargin.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMargin.Size = new System.Drawing.Size(486, 350);
            this.pnlMargin.TabIndex = 6;
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 350);
            this.Controls.Add(this.pnlMargin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".net.matrix";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLines)).EndInit();
            this.cmsTokenContainer.ResumeLayout(false);
            this.pnlMargin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMargin;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.Button btnSelectCharset;
        private System.Windows.Forms.Button btnAddToken;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.ListView lvwTokens;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.NumericUpDown nudLines;
        private System.Windows.Forms.Button btnStopAnimation;
        private System.Windows.Forms.Button btnStartAnimation;
        private System.Windows.Forms.Button btnRestartAnimation;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnClearComplete;
        private System.Windows.Forms.ContextMenuStrip cmsTokenContainer;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDuplicate;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRatio;
    }
}

