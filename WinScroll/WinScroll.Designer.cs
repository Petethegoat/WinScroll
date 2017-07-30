namespace WinScroll
{
    partial class WinScroll
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinScroll));
            this.options = new System.Windows.Forms.GroupBox();
            this.windowCheck = new System.Windows.Forms.CheckBox();
            this.startupCheck = new System.Windows.Forms.CheckBox();
            this.trayCheck = new System.Windows.Forms.CheckBox();
            this.captureCheck = new System.Windows.Forms.CheckBox();
            this.credit = new System.Windows.Forms.GroupBox();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cursor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelCoords = new System.Windows.Forms.Label();
            this.captureHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.captureWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.captureY = new System.Windows.Forms.NumericUpDown();
            this.captureX = new System.Windows.Forms.NumericUpDown();
            this.window = new System.Windows.Forms.GroupBox();
            this.colsNum = new System.Windows.Forms.NumericUpDown();
            this.rowsNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.columns = new System.Windows.Forms.NumericUpDown();
            this.rows = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.options.SuspendLayout();
            this.credit.SuspendLayout();
            this.cursor.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureX)).BeginInit();
            this.window.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // options
            // 
            this.options.Controls.Add(this.windowCheck);
            this.options.Controls.Add(this.startupCheck);
            this.options.Controls.Add(this.trayCheck);
            this.options.Controls.Add(this.captureCheck);
            this.options.Location = new System.Drawing.Point(12, 12);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(128, 112);
            this.options.TabIndex = 0;
            this.options.TabStop = false;
            this.options.Text = "Options";
            // 
            // windowCheck
            // 
            this.windowCheck.AutoSize = true;
            this.windowCheck.Location = new System.Drawing.Point(6, 88);
            this.windowCheck.Name = "windowCheck";
            this.windowCheck.Size = new System.Drawing.Size(105, 17);
            this.windowCheck.TabIndex = 3;
            this.windowCheck.Text = "Enable snapping";
            this.tooltip.SetToolTip(this.windowCheck, "Enable window snapping hotkeys.");
            this.windowCheck.UseVisualStyleBackColor = true;
            // 
            // startupCheck
            // 
            this.startupCheck.AutoSize = true;
            this.startupCheck.Location = new System.Drawing.Point(6, 42);
            this.startupCheck.Name = "startupCheck";
            this.startupCheck.Size = new System.Drawing.Size(96, 17);
            this.startupCheck.TabIndex = 1;
            this.startupCheck.Text = "Run on startup";
            this.tooltip.SetToolTip(this.startupCheck, "Start WinScroll automatically on startup.");
            this.startupCheck.UseVisualStyleBackColor = true;
            // 
            // trayCheck
            // 
            this.trayCheck.AutoSize = true;
            this.trayCheck.Location = new System.Drawing.Point(6, 19);
            this.trayCheck.Name = "trayCheck";
            this.trayCheck.Size = new System.Drawing.Size(91, 17);
            this.trayCheck.TabIndex = 0;
            this.trayCheck.Text = "Hide tray icon";
            this.tooltip.SetToolTip(this.trayCheck, "Hide the icon in the tray area.");
            this.trayCheck.UseVisualStyleBackColor = true;
            // 
            // captureCheck
            // 
            this.captureCheck.AutoSize = true;
            this.captureCheck.Location = new System.Drawing.Point(6, 65);
            this.captureCheck.Name = "captureCheck";
            this.captureCheck.Size = new System.Drawing.Size(98, 17);
            this.captureCheck.TabIndex = 2;
            this.captureCheck.Text = "Enable capture";
            this.tooltip.SetToolTip(this.captureCheck, "Prevent the cursor from leaving the specified area.");
            this.captureCheck.UseVisualStyleBackColor = true;
            // 
            // credit
            // 
            this.credit.Controls.Add(this.aboutLink);
            this.credit.Location = new System.Drawing.Point(12, 130);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(128, 40);
            this.credit.TabIndex = 1;
            this.credit.TabStop = false;
            this.credit.Text = "WinScroll 0.5";
            // 
            // aboutLink
            // 
            this.aboutLink.AutoSize = true;
            this.aboutLink.LinkArea = new System.Windows.Forms.LinkArea(3, 18);
            this.aboutLink.LinkColor = System.Drawing.Color.Blue;
            this.aboutLink.Location = new System.Drawing.Point(6, 16);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(102, 17);
            this.aboutLink.TabIndex = 1;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "by Pete Goodfellow";
            this.tooltip.SetToolTip(this.aboutLink, "Visit the Github project page!");
            this.aboutLink.UseCompatibleTextRendering = true;
            this.aboutLink.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // cursor
            // 
            this.cursor.Controls.Add(this.tableLayoutPanel);
            this.cursor.Controls.Add(this.captureHeight);
            this.cursor.Controls.Add(this.label4);
            this.cursor.Controls.Add(this.captureWidth);
            this.cursor.Controls.Add(this.label3);
            this.cursor.Controls.Add(this.label2);
            this.cursor.Controls.Add(this.label1);
            this.cursor.Controls.Add(this.captureY);
            this.cursor.Controls.Add(this.captureX);
            this.cursor.Location = new System.Drawing.Point(146, 12);
            this.cursor.Name = "cursor";
            this.cursor.Size = new System.Drawing.Size(226, 73);
            this.cursor.TabIndex = 2;
            this.cursor.TabStop = false;
            this.cursor.Text = "Cursor Capture";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelCoords, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(170, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(50, 13);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // labelCoords
            // 
            this.labelCoords.AutoSize = true;
            this.labelCoords.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelCoords.Location = new System.Drawing.Point(8, 0);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(39, 13);
            this.labelCoords.TabIndex = 9;
            this.labelCoords.Text = "coords";
            // 
            // captureHeight
            // 
            this.captureHeight.Location = new System.Drawing.Point(150, 46);
            this.captureHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.captureHeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.captureHeight.Name = "captureHeight";
            this.captureHeight.Size = new System.Drawing.Size(70, 20);
            this.captureHeight.TabIndex = 8;
            this.captureHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height";
            // 
            // captureWidth
            // 
            this.captureWidth.Location = new System.Drawing.Point(150, 19);
            this.captureWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.captureWidth.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.captureWidth.Name = "captureWidth";
            this.captureWidth.Size = new System.Drawing.Size(70, 20);
            this.captureWidth.TabIndex = 6;
            this.captureWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // captureY
            // 
            this.captureY.Location = new System.Drawing.Point(26, 46);
            this.captureY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.captureY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.captureY.Name = "captureY";
            this.captureY.Size = new System.Drawing.Size(70, 20);
            this.captureY.TabIndex = 2;
            // 
            // captureX
            // 
            this.captureX.Location = new System.Drawing.Point(26, 19);
            this.captureX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.captureX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.captureX.Name = "captureX";
            this.captureX.Size = new System.Drawing.Size(70, 20);
            this.captureX.TabIndex = 1;
            // 
            // window
            // 
            this.window.Controls.Add(this.colsNum);
            this.window.Controls.Add(this.rowsNum);
            this.window.Controls.Add(this.label7);
            this.window.Controls.Add(this.label8);
            this.window.Controls.Add(this.columns);
            this.window.Controls.Add(this.rows);
            this.window.Controls.Add(this.label6);
            this.window.Controls.Add(this.label5);
            this.window.Enabled = false;
            this.window.Location = new System.Drawing.Point(146, 146);
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(226, 79);
            this.window.TabIndex = 3;
            this.window.TabStop = false;
            this.window.Text = "Window Snapping";
            this.window.Visible = false;
            // 
            // colsNum
            // 
            this.colsNum.Enabled = false;
            this.colsNum.Location = new System.Drawing.Point(160, 45);
            this.colsNum.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.colsNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.colsNum.Name = "colsNum";
            this.colsNum.Size = new System.Drawing.Size(60, 20);
            this.colsNum.TabIndex = 16;
            this.colsNum.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // rowsNum
            // 
            this.rowsNum.Enabled = false;
            this.rowsNum.Location = new System.Drawing.Point(160, 19);
            this.rowsNum.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.rowsNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowsNum.Name = "rowsNum";
            this.rowsNum.Size = new System.Drawing.Size(60, 20);
            this.rowsNum.TabIndex = 15;
            this.rowsNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "# Cols";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "# Rows";
            // 
            // columns
            // 
            this.columns.Enabled = false;
            this.columns.Location = new System.Drawing.Point(56, 45);
            this.columns.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.columns.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(40, 20);
            this.columns.TabIndex = 12;
            this.columns.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // rows
            // 
            this.rows.Enabled = false;
            this.rows.Location = new System.Drawing.Point(56, 19);
            this.rows.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.rows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(40, 20);
            this.rows.TabIndex = 11;
            this.rows.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Columns";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rows";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WinScroll";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 54);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Contributions welcome on Github.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Snapping options coming soon!";
            // 
            // WinScroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 182);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.window);
            this.Controls.Add(this.cursor);
            this.Controls.Add(this.options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WinScroll";
            this.ShowInTaskbar = false;
            this.Text = "WinScroll";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.credit.ResumeLayout(false);
            this.credit.PerformLayout();
            this.cursor.ResumeLayout(false);
            this.cursor.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureX)).EndInit();
            this.window.ResumeLayout(false);
            this.window.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.CheckBox startupCheck;
        private System.Windows.Forms.CheckBox trayCheck;
        private System.Windows.Forms.GroupBox credit;
        private System.Windows.Forms.LinkLabel aboutLink;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.GroupBox cursor;
        private System.Windows.Forms.GroupBox window;
        private System.Windows.Forms.CheckBox captureCheck;
        private System.Windows.Forms.NumericUpDown captureHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown captureWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown captureY;
        private System.Windows.Forms.NumericUpDown captureX;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label labelCoords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox windowCheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.NumericUpDown columns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown colsNum;
        private System.Windows.Forms.NumericUpDown rowsNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown rows;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

