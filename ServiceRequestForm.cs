using MunicipalServices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServices
{
    public partial class ServiceRequestForm : Form
    {
        private MainForm mainMenuForm;
        private List<Issue> issues;
        private BinarySearchTree serviceRequestTree = new BinarySearchTree();

        public ServiceRequestForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainMenuForm = mainForm;
            this.FormClosing += new FormClosingEventHandler(ServiceRequestForm_FormClosing);
            LoadServiceRequests();
            dataGridServiceRequests.CellClick += dataGridServiceRequests_CellContentClick;

            cmbPriorityFilter.Items.Add("High");
            cmbPriorityFilter.Items.Add("Medium");
            cmbPriorityFilter.Items.Add("Low");
        }


        // Load requests to the datagrid
        private void LoadServiceRequests()
        {
            try 
            {
                     // Create a new BinarySearchTree instance
            serviceRequestTree = new BinarySearchTree();

            // Insert sample data into the BinarySearchTree
            serviceRequestTree.Insert(new ServiceRequest(1001, "Sanitation", "Garbage collection issue", "New", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(2), "High", "Sector 1"));
            serviceRequestTree.Insert(new ServiceRequest(1002, "Roads and Transportation", "Pothole on Main St", "In Progress", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(1), "Medium", "Sector 3"));
            serviceRequestTree.Insert(new ServiceRequest(1003, "Utilities", "Power outage in residential block", "Resolved", DateTime.Now.AddDays(-14), DateTime.Now.AddDays(-10), "High", "Sector 4"));
            serviceRequestTree.Insert(new ServiceRequest(1004, "Public Safety", "Streetlight not working", "New", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(3), "Low", "Sector 2"));
            serviceRequestTree.Insert(new ServiceRequest(1005, "Environment", "Illegal dumping of waste", "In Progress", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(4), "Medium", "Sector 5"));
            serviceRequestTree.Insert(new ServiceRequest(1006, "Housing", "Leaking roof in public housing unit", "Resolved", DateTime.Now.AddDays(-20), DateTime.Now.AddDays(-15), "High", "Sector 6"));
            serviceRequestTree.Insert(new ServiceRequest(1007, "Health", "Pest control request for community center", "In Progress", DateTime.Now.AddDays(-6), DateTime.Now.AddDays(5), "Medium", "Sector 7"));
            serviceRequestTree.Insert(new ServiceRequest(1008, "Education", "Request for school fence repair", "New", DateTime.Now.AddDays(-1), DateTime.Now.AddDays(7), "Low", "Sector 8"));
            serviceRequestTree.Insert(new ServiceRequest(1009, "Public Facilities", "Damaged bench in park", "Resolved", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-6), "Low", "Sector 9"));
            serviceRequestTree.Insert(new ServiceRequest(1010, "Miscellaneous", "Lost property inquiry", "New", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(1), "Medium", "Sector 10"));

                // Load the requests into the DataGridView
                LoadRequestsIntoDataGridView(serviceRequestTree.InOrderTraversal());
                // Enable cmbPriorityFilter now that data is available
                cmbPriorityFilter.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading service requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRequestsIntoDataGridView(List<ServiceRequest> requests)
        {
            try
            {
                // set AutoGenerateColumns off
                dataGridServiceRequests.AutoGenerateColumns = false;

                // Set the new data source
                dataGridServiceRequests.DataSource = requests;

                // Adjust column display settings if necessary (e.g., width, visibility)
                dataGridServiceRequests.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading requests: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();

                // Validate input
                if (string.IsNullOrEmpty(searchTerm))
                {
                    MessageBox.Show("Please enter a search term.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Perform search
                var searchResults = serviceRequestTree.Search(searchTerm);

                // Display results
                if (searchResults.Count > 0)
                {
                    dataGridServiceRequests.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("No service requests found matching the search criteria.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridServiceRequests.DataSource = null; // Clear DataGridView if no results
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridServiceRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Get the selected request ID
                    int selectedRequestId = Convert.ToInt32(dataGridServiceRequests.Rows[e.RowIndex].Cells["RequestId"].Value);

                    // Search for the selected request in the Binary Search Tree
                    var searchResults = serviceRequestTree.Search(selectedRequestId.ToString());

                    // Check if we found any results
                    if (searchResults.Count > 0)
                    {
                        var selectedRequest = searchResults.First(); // Assuming IDs are unique

                        // Display details in UI labels or text boxes
                        lblRequestId.Text = selectedRequest.RequestId.ToString();
                        lblCategory.Text = selectedRequest.Category;
                        lblDescription.Text = selectedRequest.Description;
                        lblStatus.Text = selectedRequest.Status;
                        lblDateReported.Text = selectedRequest.DateReported.ToShortDateString();
                        lblEstimatedCompletion.Text = selectedRequest.EstimatedCompletion.HasValue
                            ? selectedRequest.EstimatedCompletion.Value.ToShortDateString()
                            : "NO DATE YET!!";
                        lblLocation.Text = selectedRequest.Location;
                    }
                    else
                    {
                        // Handle case where no matching request was found
                        MessageBox.Show("Request not found.");
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error: Invalid Request ID format. Please check the data and try again.");
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Error: Unable to retrieve the selected request. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
        }

        private int GetPriorityValue(string priority)
        {
            switch (priority.ToLower())
            {
                case "low":
                    return 1;
                case "medium":
                    return 2;
                case "high":
                    return 3;
                default:
                    return 0; // For undefined priorities
            }
        }

        public List<ServiceRequest> FilterByPriority(bool ascending = true)
        {
            var priorityHeap = new SortedDictionary<int, List<ServiceRequest>>();

            // Populate the heap with service requests
            foreach (var request in serviceRequestTree.InOrderTraversal())
            {
                int priorityValue = GetPriorityValue(request.Priority);

                if (!priorityHeap.ContainsKey(priorityValue))
                {
                    priorityHeap[priorityValue] = new List<ServiceRequest>();
                }
                priorityHeap[priorityValue].Add(request);
            }

            // Extract sorted requests based on priority order
            var sortedRequests = new List<ServiceRequest>();
            var keys = ascending ? priorityHeap.Keys : priorityHeap.Keys.Reverse();

            foreach (var key in keys)
            {
                sortedRequests.AddRange(priorityHeap[key]);
            }

            return sortedRequests;
        }

        // NAV BAR 
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

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ReportIssueForm reportIssueForm = new ReportIssueForm(issues, this.mainMenuForm);
                reportIssueForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the report issue form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ServiceRequestForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cmbPriorityFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (serviceRequestTree == null)
                {
                    MessageBox.Show("Service requests data is not yet loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the selected item is null (filter is cleared)
                if (cmbPriorityFilter.SelectedItem == null || cmbPriorityFilter.SelectedIndex == 0)
                {
                    // Load all requests without filtering
                    var allRequests = serviceRequestTree.InOrderTraversal().ToList();
                    LoadRequestsIntoDataGridView(allRequests);
                    return;
                }

                // Use a different name for the local variable to avoid conflicts
                string selectedPriorityValue = cmbPriorityFilter.SelectedItem.ToString();
                var filteredRequests = serviceRequestTree.InOrderTraversal()
                    .Where(r => r.Priority == selectedPriorityValue)
                    .ToList();

                LoadRequestsIntoDataGridView(filteredRequests);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while filtering by priority: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear search text box
                txtSearch.Text = string.Empty;

                // Reset combo box selections (assuming you have a combo box for priority filtering)
                cmbPriorityFilter.SelectedIndex = -1;

                // Reload all data into the DataGridView from the binary search tree
                var allRequests = serviceRequestTree.InOrderTraversal(); // Retrieve all data from the tree
                LoadRequestsIntoDataGridView(allRequests);               // Display all data in DataGridView

                MessageBox.Show("All filters and search have been cleared.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while clearing filters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
