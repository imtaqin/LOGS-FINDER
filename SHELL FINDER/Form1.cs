using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogsFinder
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Text Files (*.txt)|*.txt";
                saveDialog.FileName = "result_logs.txt"; // Default name for output file
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    outputPath.Text = saveDialog.FileName; // Set the output path in the TextBox
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string folderPath = txtFolderPath.Text;
            string regexPattern = txtRegex.Text;
            string outputPathValue = outputPath.Text;
            int threadCount;

            if (!int.TryParse(txtThreads.Text, out threadCount) || threadCount <= 0)
            {
                MessageBox.Show("Please enter a valid number of threads.");
                return;
            }

            if (string.IsNullOrWhiteSpace(outputPathValue))
            {
                MessageBox.Show("Please set the result output path.");
                return;
            }

            if (Directory.Exists(folderPath))
            {
                rtbResults.Clear();
                btnSearch.Enabled = false; // Disable the button to prevent multiple clicks during the search
                btnBrowse.Enabled = false; // Disable browsing while search is running
                _cancellationTokenSource = new CancellationTokenSource();

                try
                {
                    await SearchFilesAsync(folderPath, regexPattern, threadCount, outputPathValue, _cancellationTokenSource.Token);
                }
                catch (OperationCanceledException)
                {
                    rtbResults.AppendText("\nSearch cancelled.");
                }
                finally
                {
                    btnSearch.Enabled = true;
                    btnBrowse.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please select a valid folder.");
            }
        }

        private async Task SearchFilesAsync(string folderPath, string regexPattern, int threadCount, string outputPathValue, CancellationToken cancellationToken)
        {
            var files = Directory.EnumerateFiles(folderPath, "*.*", SearchOption.AllDirectories);
            Regex regex = new Regex(regexPattern, RegexOptions.Singleline);

            // Create output file (overwrite if exists)
            using (StreamWriter writer = new StreamWriter(outputPathValue, false))
            {
                var parallelOptions = new ParallelOptions
                {
                    MaxDegreeOfParallelism = threadCount,
                    CancellationToken = cancellationToken
                };

                await Task.Run(() =>
                {
                    Parallel.ForEach(files, parallelOptions, (file) =>
                    {
                        if (parallelOptions.CancellationToken.IsCancellationRequested)
                            parallelOptions.CancellationToken.ThrowIfCancellationRequested();

                        if (file.ToLower().Contains("passwords.txt") || file.ToLower().Contains("password.txt"))
                        {
                            string fileContent = File.ReadAllText(file);
                            MatchCollection matches = regex.Matches(fileContent);

                            foreach (Match match in matches)
                            {
                                string result = $"{match.Groups[1].Value}:{match.Groups[2].Value}:{match.Groups[3].Value}";

                                // Write to file immediately
                                lock (writer)
                                {
                                    writer.WriteLine(result);
                                }

                                // Update UI periodically
                                Invoke((Action)(() =>
                                {
                                    rtbResults.AppendText(result + Environment.NewLine);
                                }));
                            }
                        }
                    });
                });
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Text Files (*.txt)|*.txt";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialog.FileName, rtbResults.Text);
                    MessageBox.Show("Results saved successfully!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel(); // Cancel the search if it's running
        }

        private void btnOutput_Click_1(object sender, EventArgs e)
        {
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Text Files (*.txt)|*.txt";
                    saveDialog.FileName = "result_logs.txt"; // Default name for output file
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        outputPath.Text = saveDialog.FileName; // Set the output path in the TextBox
                    }
                }
            }

        }
    }
}
