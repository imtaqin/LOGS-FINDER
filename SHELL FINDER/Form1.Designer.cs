namespace LogsFinder
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblRegex;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblThreads;  // Label for thread count
        private System.Windows.Forms.TextBox txtThreads; // TextBox for thread count

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnBrowse = new Button();
            txtFolderPath = new TextBox();
            btnSearch = new Button();
            rtbResults = new RichTextBox();
            btnSave = new Button();
            lblFolder = new Label();
            lblRegex = new Label();
            txtRegex = new TextBox();
            lblThreads = new Label();
            txtThreads = new TextBox();
            btnCancel = new Button();
            outputPath = new TextBox();
            btnOutput = new Button();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Black;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Consolas", 10F);
            btnBrowse.ForeColor = Color.Lime;
            btnBrowse.Location = new Point(298, 45);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.BackColor = Color.Black;
            txtFolderPath.Font = new Font("Consolas", 10F);
            txtFolderPath.ForeColor = Color.Lime;
            txtFolderPath.Location = new Point(12, 46);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(280, 23);
            txtFolderPath.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Consolas", 10F);
            btnSearch.ForeColor = Color.Lime;
            btnSearch.Location = new Point(754, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // rtbResults
            // 
            rtbResults.BackColor = Color.Black;
            rtbResults.Font = new Font("Consolas", 10F);
            rtbResults.ForeColor = Color.Lime;
            rtbResults.Location = new Point(12, 141);
            rtbResults.Name = "rtbResults";
            rtbResults.Size = new Size(863, 293);
            rtbResults.TabIndex = 3;
            rtbResults.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Consolas", 10F);
            btnSave.ForeColor = Color.Lime;
            btnSave.Location = new Point(800, 453);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Font = new Font("Consolas", 10F);
            lblFolder.ForeColor = Color.Lime;
            lblFolder.Location = new Point(12, 26);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(104, 17);
            lblFolder.TabIndex = 5;
            lblFolder.Text = "Folder Path:";
            // 
            // lblRegex
            // 
            lblRegex.AutoSize = true;
            lblRegex.Font = new Font("Consolas", 10F);
            lblRegex.ForeColor = Color.Lime;
            lblRegex.Location = new Point(254, 109);
            lblRegex.Name = "lblRegex";
            lblRegex.Size = new Size(176, 17);
            lblRegex.TabIndex = 6;
            lblRegex.Text = "Regex for extracting:";
            // 
            // txtRegex
            // 
            txtRegex.BackColor = Color.Black;
            txtRegex.Font = new Font("Consolas", 10F);
            txtRegex.ForeColor = Color.Lime;
            txtRegex.Location = new Point(436, 106);
            txtRegex.Name = "txtRegex";
            txtRegex.Size = new Size(280, 23);
            txtRegex.TabIndex = 7;
            txtRegex.Text = "SOFT:.*?\\nURL:(.*?)\\nUSER:(.*?)\\nPASS:(.*?)\\n";
            // 
            // lblThreads
            // 
            lblThreads.AutoSize = true;
            lblThreads.ForeColor = Color.Lime;
            lblThreads.Location = new Point(15, 111);
            lblThreads.Name = "lblThreads";
            lblThreads.Size = new Size(113, 15);
            lblThreads.TabIndex = 6;
            lblThreads.Text = "Number of Threads:";
            // 
            // txtThreads
            // 
            txtThreads.BackColor = Color.Black;
            txtThreads.ForeColor = Color.Lime;
            txtThreads.Location = new Point(134, 108);
            txtThreads.Name = "txtThreads";
            txtThreads.Size = new Size(100, 23);
            txtThreads.TabIndex = 7;
            txtThreads.Text = "4";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Consolas", 10F);
            btnCancel.ForeColor = Color.Lime;
            btnCancel.Location = new Point(719, 453);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // outputPath
            // 
            outputPath.BackColor = Color.Black;
            outputPath.Font = new Font("Consolas", 10F);
            outputPath.ForeColor = Color.Lime;
            outputPath.Location = new Point(30, 449);
            outputPath.Multiline = true;
            outputPath.Name = "outputPath";
            outputPath.Size = new Size(280, 31);
            outputPath.TabIndex = 8;
            // 
            // btnOutput
            // 
            btnOutput.BackColor = Color.Black;
            btnOutput.FlatStyle = FlatStyle.Flat;
            btnOutput.Font = new Font("Consolas", 10F);
            btnOutput.ForeColor = Color.Lime;
            btnOutput.Location = new Point(316, 449);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(75, 31);
            btnOutput.TabIndex = 9;
            btnOutput.Text = "Output";
            btnOutput.UseVisualStyleBackColor = false;
            btnOutput.Click += btnOutput_Click_1;
            // 
            // Form1
            // 
            BackColor = Color.Black;
            ClientSize = new Size(890, 519);
            Controls.Add(btnOutput);
            Controls.Add(outputPath);
            Controls.Add(txtThreads);
            Controls.Add(lblThreads);
            Controls.Add(txtRegex);
            Controls.Add(lblRegex);
            Controls.Add(lblFolder);
            Controls.Add(btnSave);
            Controls.Add(rtbResults);
            Controls.Add(btnSearch);
            Controls.Add(btnCancel);
            Controls.Add(txtFolderPath);
            Controls.Add(btnBrowse);
            ForeColor = Color.Lime;
            Name = "Form1";
            Text = "Hacker Logs Finder";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox outputPath;
        private Button btnOutput;
    }
}
