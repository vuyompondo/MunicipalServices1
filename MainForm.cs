using MunicipalServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServices
{
    public partial class MainForm : Form
    {
        public List<Issue> issues = new List<Issue>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide current form (Main Menu)
                this.Hide();

                ReportIssueForm reportIssueForm = new ReportIssueForm(issues, this);
                // Add an event handler to reshow the main form when reportIssueForm closes
                reportIssueForm.FormClosed += (s, args) => this.Show();
                reportIssueForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Report Issue form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide current form (Main Menu)
                this.Hide();

                LocalEventsForm localEventsForm = new LocalEventsForm(this);
                // Add an event handler to reshow the main form when localEventsForm closes
                localEventsForm.FormClosed += (s, args) => this.Show();
                localEventsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Local Events form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide current form (Main Menu)
                this.Hide();

                ServiceRequestForm serviceRequestForm = new ServiceRequestForm(this);
                // Add an event handler to reshow the main form when serviceRequestForm closes
                serviceRequestForm.FormClosed += (s, args) => this.Show();
                serviceRequestForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying the Service Status form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
