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
    public partial class LocalEventsForm : Form
    {
        private MainForm mainMenuForm;
        private List<Issue> issues;

        // Fields to hold announcements
        private Queue<Announcement> announcementQueue = new Queue<Announcement>();
        private HashSet<Announcement> announcementSet = new HashSet<Announcement>();
        private int currentAnnouncementIndex = 0;

        // Using a SortedDictionary to manage events by category
        private SortedDictionary<string, Queue<Event>> eventsByCategory = new SortedDictionary<string, Queue<Event>>();
       
        // Queue and Set for recommendations
        private Queue<Event> recommendationQueue = new Queue<Event>();
        private int currentRecommendationIndex = 0;
        private HashSet<string> recommendationSet = new HashSet<string>();
        
        // Track user preferences
        private List<string> userPreferences = new List<string>();

        private Timer timerRecommendations;

        public LocalEventsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainMenuForm = mainForm; // Pass the main form
            this.FormClosing += new FormClosingEventHandler(LocalEventsForm_FormClosing); // Subscribe to the event
            eventsByCategory = new SortedDictionary<string, Queue<Event>>();

            // Populate with some example data
            LoadEvents();
            LoadCategories();
            LoadAnnouncements();

            //reccomendation timmer to go trought
            timerRecommendations = new Timer();
            timerRecommendations.Interval = 5000; // Set interval to 5 seconds
            timerRecommendations.Tick += TimerRecommendations_Tick;
            timerRecommendations.Start(); // Start the timer
        }

        private void LoadAnnouncements()
        {
            try
            {
                // Load important announcements into the HashSet
                announcementSet.Add(new Announcement("Road Closure", "Main street will be closed for maintenance on October 15.", new DateTime(2024, 10, 10), true));
                announcementSet.Add(new Announcement("Community Meeting", "Join us for a community meeting on October 20 at City Hall.", new DateTime(2024, 10, 12), true));

                // Load regular announcements into the HashSet
                announcementSet.Add(new Announcement("Fire Drill", "A fire drill will take place on October 25 at 10 AM. Please participate.", new DateTime(2024, 10, 15)));
                announcementSet.Add(new Announcement("New Park Opening", "A new park will be opened on November 1. Come join us for the opening ceremony!", new DateTime(2024, 10, 20)));
                announcementSet.Add(new Announcement("Health Fair", "Free health fair on November 10 at the community center. Health screenings and information available.", new DateTime(2024, 10, 22)));
                announcementSet.Add(new Announcement("Winter Festival", "Mark your calendars for the Winter Festival on December 5. Fun for all ages!", new DateTime(2024, 10, 30)));
                announcementSet.Add(new Announcement("Local Art Competition", "Enter your artwork in the Local Art Competition by November 15. Prizes to be won!", new DateTime(2024, 11, 1)));

                // Clear the queue before adding announcements
                announcementQueue.Clear();

                // Add unique announcements to the queue
                foreach (var announcement in announcementSet)
                {
                    announcementQueue.Enqueue(announcement);
                }

                // Display the first announcement
                DisplayAnnouncement();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading announcements: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayAnnouncement()
        {
            try
            {
                // Clear labels first
                lblAnnouncementTitle.Text = string.Empty;
                lblAnnouncementDescription.Text = string.Empty;

                if (announcementQueue.Count > 0)
                {
                    var announcementList = announcementQueue.ToList(); // Convert queue to list to access by index

                    if (currentAnnouncementIndex < announcementList.Count)
                    {
                        var currentAnnouncement = announcementList[currentAnnouncementIndex];
                        lblAnnouncementTitle.Text = currentAnnouncement.Title;
                        lblAnnouncementDescription.Text = $"{currentAnnouncement.Message} (Date: {currentAnnouncement.Date.ToShortDateString()})";
                    }
                }
                else
                {
                    lblAnnouncementTitle.Text = "No announcements available.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying announcements: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextAnnouncement_Click(object sender, EventArgs e)
        {
            try
            {
                currentAnnouncementIndex++;
                if (currentAnnouncementIndex >= announcementQueue.Count)
                {
                    currentAnnouncementIndex = 0; // Wrap around
                }
                DisplayAnnouncement();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while navigating to the next announcement: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPreviousAnnouncement_Click(object sender, EventArgs e)
        {
            try
            {
                currentAnnouncementIndex--;
                if (currentAnnouncementIndex < 0)
                {
                    currentAnnouncementIndex = announcementQueue.Count - 1; // Wrap around
                }
                DisplayAnnouncement();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while navigating to the previous announcement: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LocalEventsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // stop timer
                timerRecommendations.Stop();
                // Show the mainform when the Local event form closes
                mainMenuForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while closing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void LoadEvents()
        {
            try
            {
                // Load community events
                Queue<Event> communityEvents = new Queue<Event>();
                communityEvents.Enqueue(new Event("Local Festival", new DateTime(2024, 10, 07), "City Park", "A fun day at the park!"));
                communityEvents.Enqueue(new Event("Art Exhibition", new DateTime(2024, 10, 14), "Art Gallery", "Explore local artwork!"));

                eventsByCategory.Add("Community", communityEvents);

                // Load sports events
                Queue<Event> sportsEvents = new Queue<Event>();
                sportsEvents.Enqueue(new Event("Soccer Match", new DateTime(2024, 10, 20), "Sports Arena", "Local teams battle it out!"));
                sportsEvents.Enqueue(new Event("Tennis Tournament", new DateTime(2024, 10, 25), "Tennis Court", "Compete in the tennis tournament!"));

                eventsByCategory.Add("Sports", sportsEvents);

                // Load music events
                Queue<Event> musicEvents = new Queue<Event>();
                musicEvents.Enqueue(new Event("Live Concert", new DateTime(2024, 10, 30), "Downtown Square", "Enjoy live performances!"));
                eventsByCategory.Add("Music", musicEvents);

                // Load cultural events
                Queue<Event> culturalEvents = new Queue<Event>();
                culturalEvents.Enqueue(new Event("Cultural Fair", new DateTime(2024, 11, 05), "City Hall", "Experience diverse cultures!"));
                eventsByCategory.Add("Culture", culturalEvents);

                // Display all events in the DataGridView on startup
                DisplayEvents(eventsByCategory.Values.SelectMany(q => q).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void DisplayEvents(List<Event> events)
        {
            try
            {
                // Clear existing data source before updating it
                dataGridViewEvents.DataSource = null;

                // Set the new data source to the list of events
                dataGridViewEvents.DataSource = events;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCategories()
        {
            try
            {
                // Clear existing items first, if necessary
                cmbCategoryEvent.Items.Clear();

                // Add "All" category to show all events
                cmbCategoryEvent.Items.Add("All");

                // Add the rest of the categories
                foreach (var category in eventsByCategory.Keys)
                {
                    cmbCategoryEvent.Items.Add(category);
                }

                // Set default selection to "All"
                cmbCategoryEvent.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategoryEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedCategory = cmbCategoryEvent.SelectedItem.ToString();
                if (eventsByCategory.ContainsKey(selectedCategory))
                {
                    var filteredEvents = eventsByCategory[selectedCategory].ToList();
                    DisplayEvents(filteredEvents);
                }
                else
                {
                    // If the category is not found, show all events or clear the DataGridView
                    DisplayEvents(eventsByCategory.Values.SelectMany(q => q).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while filtering events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search functionality
        private void SearchEvents(string searchTerm)
        {
            try
            {
                List<Event> searchResults = new List<Event>();

                foreach (var category in eventsByCategory.Values)
                {
                    foreach (var evt in category)
                    {
                        if (evt.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            evt.Location.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            searchResults.Add(evt);
                            // Track search term as a user preference for future recommendations
                            TrackUserInteraction(evt.Name);
                        }
                    }
                }

                if (searchResults.Any())
                {
                    UpdateEventGrid(searchResults);
                    GenerateRecommendations(); // Update recommendations based on search results
                }
                else
                {
                    MessageBox.Show("No events found matching the search criteria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during the search: " + ex.Message);
            }
        }

        // Update the Event Grid
        private void UpdateEventGrid(List<Event> events)
        {
            try
            {
                // Clear the existing data grid and add new data
                dataGridViewEvents.DataSource = null;
                dataGridViewEvents.DataSource = events;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the grid: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the search term from the TextBox
                string searchTerm = txtSearch.Text.Trim();

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    SearchEvents(searchTerm);
                }
                else
                {
                    MessageBox.Show("Please enter a search term.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Track user interaction (preferences)
        private void TrackUserInteraction(string preference)
        {
            try
            {
                if (!userPreferences.Contains(preference))
                {
                    userPreferences.Add(preference);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while tracking user interaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add recommendation to the queue (max 3, no duplicates)
        private void AddRecommendation(Event newEvent)
        {
            try
            {
                if (!recommendationSet.Contains(newEvent.Name))
                {
                    if (recommendationQueue.Count >= 3)
                    {
                        Event removedEvent = recommendationQueue.Dequeue();
                        recommendationSet.Remove(removedEvent.Name);
                    }

                    recommendationQueue.Enqueue(newEvent);
                    recommendationSet.Add(newEvent.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding recommendation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Generate recommendations based on user preferences
        private void GenerateRecommendations()
        {
            try
            {
                // Clear existing recommendation queue and set
                recommendationQueue.Clear();
                recommendationSet.Clear();
                currentRecommendationIndex = 0; // Reset the index to 0 when generating new recommendations

                // Iterate through user preferences and match them with events
                foreach (var category in eventsByCategory)
                {
                    foreach (var ev in category.Value)
                    {
                        // Use IndexOf for case-insensitive comparison
                        if (userPreferences.Any(pref => ev.Name.IndexOf(pref, StringComparison.OrdinalIgnoreCase) >= 0) &&
                            !recommendationSet.Contains(ev.Name))
                        {
                            AddRecommendation(ev);
                        }
                    }
                }

                // Display recommendations if any exist
                if (recommendationQueue.Count > 0)
                {
                    DisplayRecommendations(currentRecommendationIndex); // Pass the current index
                }
                else
                {
                    lblRecommendation.Text = "No recommendations available."; // Ensure a message is shown when no recommendations exist
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating recommendations: " + ex.Message);
            }
        }

        private void TimerRecommendations_Tick(object sender, EventArgs e)
        {
            try
            {
                currentRecommendationIndex++;

                // Wrap around to the first recommendation if we exceed the count
                if (currentRecommendationIndex >= recommendationQueue.Count)
                {
                    currentRecommendationIndex = 0;
                }

                // Display the updated recommendation
                DisplayRecommendations(currentRecommendationIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during recommendation update: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    // Method to display recommendations in the recommendation label
    private void DisplayRecommendations(int index)
        {
            try
            {
                // Convert the queue to a list for easier access
                List<Event> recommendationList = recommendationQueue.ToList();

                // Check if there are recommendations to display
                if (recommendationList.Count > 0)
                {
                    lblRecommendation.Text = recommendationList[index].Name + " - " + recommendationList[index].Description;
                }
                else
                {
                    lblRecommendation.Text = "No recommendations available.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying recommendations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

    }
}
