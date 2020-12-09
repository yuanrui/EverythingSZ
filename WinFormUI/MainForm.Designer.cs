
namespace WinFormUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.muCellContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miOpenFileLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterString = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.muCellContextMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFileName,
            this.cPath});
            this.dgvResult.GridColor = System.Drawing.SystemColors.Window;
            this.dgvResult.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvResult.Location = new System.Drawing.Point(0, 21);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(0);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowTemplate.ContextMenuStrip = this.muCellContextMenu;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(686, 281);
            this.dgvResult.TabIndex = 0;
            this.dgvResult.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResult_CellMouseDown);
            // 
            // muCellContextMenu
            // 
            this.muCellContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenFileLocation});
            this.muCellContextMenu.Name = "muCellContextMenu";
            this.muCellContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.muCellContextMenu.Size = new System.Drawing.Size(185, 26);
            // 
            // miOpenFileLocation
            // 
            this.miOpenFileLocation.Name = "miOpenFileLocation";
            this.miOpenFileLocation.Size = new System.Drawing.Size(184, 22);
            this.miOpenFileLocation.Text = "Open File Location";
            this.miOpenFileLocation.Click += new System.EventHandler(this.miOpenFileLocation_Click);
            // 
            // txtFilterString
            // 
            this.txtFilterString.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilterString.Location = new System.Drawing.Point(0, 0);
            this.txtFilterString.Name = "txtFilterString";
            this.txtFilterString.Size = new System.Drawing.Size(686, 21);
            this.txtFilterString.TabIndex = 1;
            this.txtFilterString.TextChanged += new System.EventHandler(this.txtFilterString_TextChanged);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 296);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(686, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 17);
            this.statusLabel.Text = "Ready";
            // 
            // cFileName
            // 
            this.cFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cFileName.DataPropertyName = "FileName";
            this.cFileName.HeaderText = "Name";
            this.cFileName.Name = "cFileName";
            this.cFileName.ReadOnly = true;
            this.cFileName.Width = 300;
            // 
            // cPath
            // 
            this.cPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPath.DataPropertyName = "Path";
            this.cPath.HeaderText = "Path";
            this.cPath.Name = "cPath";
            this.cPath.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 318);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.txtFilterString);
            this.Controls.Add(this.dgvResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Everything SZ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.muCellContextMenu.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.TextBox txtFilterString;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ContextMenuStrip muCellContextMenu;
        private System.Windows.Forms.ToolStripMenuItem miOpenFileLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPath;
    }
}

