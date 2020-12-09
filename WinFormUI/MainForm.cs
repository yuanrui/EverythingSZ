using QueryEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        private List<FileAndDirectoryEntry> entries = new List<FileAndDirectoryEntry>();
        private int allFilesCount;
        private string previousFilterString;

        private string FilterString
        {
            get
            {
                return txtFilterString.Text.Trim();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void txtFilterString_TextChanged(object sender, EventArgs e)
        {
            if (this.entries == null || this.entries.Count == 0)
            {                
                return;
            }

            if (string.IsNullOrWhiteSpace(FilterString))
            {
                ClearResult();
                return;
            }

            if (string.Compare(this.previousFilterString, this.FilterString, true) == 0)
            {
                return;
            }
            
            SearchResultAsync();
        }

        private void ClearResult()
        {
            if (dgvResult.Rows.Count > 0)
            {
                statusLabel.Text = "Ready";

                dgvResult.DataSource = new List<FileAndDirectoryEntry>();
            }
        }

        private void ShowSearchResult()
        {
            string filterString = this.FilterString;

            var filteredResult = this.entries
                    .Where(f => f.FileName != null && f.FileName.IndexOf(filterString, StringComparison.OrdinalIgnoreCase) > -1)
                    .OrderBy(f => f.FileName)
                    .ToList();

            dgvResult.DataSource = filteredResult;

            int fileCount = filteredResult.Count();

            statusLabel.Text = string.Format("{0} files found in {1} files", fileCount, allFilesCount);
        }

        private void SearchResultAsync() 
        {
            Task.Factory.StartNew(() => {
                Thread.Sleep(500);
                string filterString = this.FilterString;

                var filteredResult = this.entries
                    .Where(f => f.FileName != null && f.FileName.IndexOf(filterString, StringComparison.OrdinalIgnoreCase) > -1)
                    .OrderBy(f => f.FileName)
                    .ToList();

                if (this.FilterString != filterString)
                {
                    return;
                }

                dgvResult.InvokeIfRequired(dgv =>
                {
                    dgv.DataSource = filteredResult;
                });
                int fileCount = filteredResult.Count();

                this.InvokeIfRequired(m =>
                {
                    m.statusLabel.Text = string.Format("{0} files found in {1} files", fileCount, allFilesCount);
                });

                this.previousFilterString = filterString;
            });
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            statusLabel.Text = "Getting files information";
            LoadEntriesAsync();
            statusLabel.Text = "Loading";

            txtFilterString.Enabled = true;
            txtFilterString.Focus();
        }

        private void LoadEntriesAsync()
        {
            var task = Task.Factory.StartNew(() =>
            {
                try
                {
                    this.entries = Engine.GetAllFilesAndDirectories();
                    this.allFilesCount = entries.Count();
                    
                    this.InvokeIfRequired(m =>
                    {
                        m.statusLabel.Text = "Ready";
                    });
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);

                    this.InvokeIfRequired(m =>
                    {
                        m.statusLabel.Text = ex.Message;
                    });
                }
            });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtFilterString.Text = string.Empty;
            txtFilterString.Enabled = false;

            dgvResult.AutoGenerateColumns = false;
        }

        private void miOpenFileLocation_Click(object sender, EventArgs e)
        {
            OpenFileLocationBySelectedRow();
        }

        private void OpenFileLocationBySelectedRow()
        {
            if (dgvResult.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvResult.SelectedRows[0];

                var dataItem = selectedRow.DataBoundItem as FileAndDirectoryEntry;

                OpenFileLocation(dataItem);
            }
        }

        private static void OpenFileLocation(FileAndDirectoryEntry fileAndDirectoryEntry)
        {
            if (File.Exists(fileAndDirectoryEntry.FullFileName))
            {
                ShowSelectedInExplorer.FileOrFolder(fileAndDirectoryEntry.FullFileName, false);
                //Process.Start("explorer.exe", "/select, " + fileAndDirectoryEntry.FullFileName);
            }
        }

        private void dgvResult_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvResult.ClearSelection();

                dgvResult.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
