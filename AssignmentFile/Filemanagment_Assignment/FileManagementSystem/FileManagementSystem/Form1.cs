
using System;
using System.IO;
using System.Windows.Forms;

namespace FileManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. CREATE FILE - Sameynta File cusub
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get file name from TextBox
                string path = txtFileName.Text.Trim();

                // Check if file name is empty
                if (path == "")
                {
                    MessageBox.Show("Please Enter File Name!");
                    return;
                }

                // Create a new file
                using (StreamWriter sw = File.CreateText(path))
                {
                    // File created successfully
                }

                MessageBox.Show("File Created Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 2. WRITE FILE - Qorista xogta File-ka
        private void btnWrite_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get file name
                string path = txtFileName.Text.Trim();

                // Check file name
                if (path == "")
                {
                    MessageBox.Show("Please Enter File Name!");
                    return;
                }

                // Write text into file
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(txtInput.Text);
                }

                MessageBox.Show("Data Written Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 3. READ FILE

        private void btnRead_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get file name
                string path = txtFileName.Text.Trim();

                // Check if file exists
                if (File.Exists(path))
                {
                    // Open file for reading
                    using (StreamReader sr = File.OpenText(path))
                    {
                        // Read all text
                        txtOutput.Text = sr.ReadToEnd();
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 4. APPEND FILE
        private void btnAppend_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get file name
                string path = txtFileName.Text.Trim();

                // Check file name
                if (path == "")
                {
                    MessageBox.Show("Please Enter File Name!");
                    return;
                }

                // Add new text to existing file
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(txtInput.Text);
                }

                MessageBox.Show("Data Appended Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 5. DELETE FILE

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get file name
                string path = txtFileName.Text.Trim();

                // Check if file exists
                if (File.Exists(path))
                {
                    // Ask user before deleting
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this file?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Delete file
                        File.Delete(path);

                        // Clear output
                        txtOutput.Clear();

                        MessageBox.Show("File Deleted Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 6. CLEAR
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            // Clear file name
            txtFileName.Clear();

            // Clear input text
            txtInput.Clear();

            // Clear output text
            txtOutput.Clear();
        }
    }
}
