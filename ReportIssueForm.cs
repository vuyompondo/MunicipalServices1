using MunicipalServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServices
{
    public partial class ReportIssueForm : Form
    {
        private List<Issue> issues;
        private MainForm mainMenuForm;

        public ReportIssueForm(List<Issue> issues, MainForm mainForm)
        {
            InitializeComponent();
            this.issues = issues;
            this.mainMenuForm = mainForm;
            this.FormClosing += new FormClosingEventHandler(ReportIssueForm_FormClosing);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Input
                if (string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    MessageBox.Show("Please enter the location of the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a category for the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(rtxtDescription.Text))
                {
                    MessageBox.Show("Please provide a description of the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Issue newIssue = new Issue
                {
                    Location = txtLocation.Text,
                    Category = cmbCategory.SelectedItem.ToString(),
                    Description = rtxtDescription.Text,
                    Attachments = lstAttachedFiles.Items.Cast<ListViewItem>().Select(item => item.Text).ToList(),
                    DateReported = DateTime.Now
                };

                issues.Add(newIssue); // Add issue to the list

                dataGridViewIssues.Rows.Add(newIssue.Location, newIssue.Category, newIssue.Description, newIssue.DateReported.ToString());

                // Show success message
                MessageBox.Show("Issue submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Update engagement label
                lblEngagement.Text = "Thank you for your submission!";

                // Clear the form for new input
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while submitting the issue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            try
            {
                txtLocation.Clear();
                cmbCategory.SelectedIndex = -1;
                rtxtDescription.Clear();
                lstAttachedFiles.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while clearing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();

                // Update the engagement label
                lblEngagement.Text = "Form cleared. You can start a new report.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while clearing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportIssueForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Welcome the user
                lblEngagement.Text = "Welcome! Please fill out the form to report an issue.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and configure OpenFileDialog
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|Document Files|*.pdf;*.doc;*.docx|All Files|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.Multiselect = true; // Allow multiple file selection

                    // Show the dialog and check if the user selected a file
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Process selected files
                        foreach (string fileName in openFileDialog.FileNames)
                        {
                            // Add the file to the ListView
                            lstAttachedFiles.Items.Add(fileName);
                        }

                        // Show success message in lblEngagement
                        lblEngagement.Text = "File(s) attached successfully!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while attaching files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Hide current form
                mainMenuForm.Show(); // Return to Main Menu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while returning to the main menu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                LocalEventsForm localEventsForm = new LocalEventsForm(this.mainMenuForm);
                localEventsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the local events form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportIssueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Show the mainform when the form closes
                mainMenuForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while closing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide current form (Main Menu)
                this.Hide();

                ServiceRequestForm serviceRequestForm = new ServiceRequestForm(this.mainMenuForm);
                serviceRequestForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying the service status message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
