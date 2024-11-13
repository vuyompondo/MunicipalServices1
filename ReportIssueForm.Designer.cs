namespace MunicipalServices
{
    partial class ReportIssueForm
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
            if (disposing && (components != null))
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssueForm));
            this.lblReportIssue = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.tableLayoutReportHead = new System.Windows.Forms.TableLayoutPanel();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lstAttachedFiles = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewIssues = new System.Windows.Forms.DataGridView();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReported = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutReportHead.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportIssue
            // 
            this.lblReportIssue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReportIssue.AutoSize = true;
            this.lblReportIssue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReportIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblReportIssue.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.lblReportIssue.ForeColor = System.Drawing.Color.Peru;
            this.lblReportIssue.Location = new System.Drawing.Point(281, 7);
            this.lblReportIssue.Name = "lblReportIssue";
            this.lblReportIssue.Size = new System.Drawing.Size(355, 57);
            this.lblReportIssue.TabIndex = 0;
            this.lblReportIssue.Text = "Report An Issue";
            this.lblReportIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.Peru;
            this.lblLocation.Location = new System.Drawing.Point(3, 5);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(111, 30);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.Peru;
            this.lblCategory.Location = new System.Drawing.Point(3, 5);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(111, 30);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.Peru;
            this.btnSubmit.Location = new System.Drawing.Point(774, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 35);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Peru;
            this.btnClear.Location = new System.Drawing.Point(3, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 35);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackToMenu.AutoSize = true;
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBackToMenu.ForeColor = System.Drawing.Color.Peru;
            this.btnBackToMenu.Location = new System.Drawing.Point(3, 9);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(290, 35);
            this.btnBackToMenu.TabIndex = 12;
            this.btnBackToMenu.Text = "Back To Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLocalEvents.AutoSize = true;
            this.btnLocalEvents.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocalEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEvents.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnLocalEvents.ForeColor = System.Drawing.Color.Peru;
            this.btnLocalEvents.Location = new System.Drawing.Point(300, 9);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(300, 35);
            this.btnLocalEvents.TabIndex = 13;
            this.btnLocalEvents.Text = "Local Events and Announcements";
            this.btnLocalEvents.UseVisualStyleBackColor = false;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnServiceStatus.AutoSize = true;
            this.btnServiceStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServiceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnServiceStatus.ForeColor = System.Drawing.Color.Peru;
            this.btnServiceStatus.Location = new System.Drawing.Point(610, 9);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new System.Drawing.Size(300, 35);
            this.btnServiceStatus.TabIndex = 14;
            this.btnServiceStatus.Text = "Service Status";
            this.btnServiceStatus.UseVisualStyleBackColor = false;
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);
            // 
            // lblEngagement
            // 
            this.lblEngagement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEngagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEngagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEngagement.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.lblEngagement.ForeColor = System.Drawing.Color.Peru;
            this.lblEngagement.Location = new System.Drawing.Point(364, 4);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(190, 21);
            this.lblEngagement.TabIndex = 15;
            this.lblEngagement.Text = "\"Please fill out the form\".";
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttachFile.AutoSize = true;
            this.btnAttachFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttachFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAttachFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachFile.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnAttachFile.ForeColor = System.Drawing.Color.Peru;
            this.btnAttachFile.Location = new System.Drawing.Point(3, 4);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(111, 31);
            this.btnAttachFile.TabIndex = 16;
            this.btnAttachFile.Text = "Attach File";
            this.btnAttachFile.UseVisualStyleBackColor = false;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // tableLayoutReportHead
            // 
            this.tableLayoutReportHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutReportHead.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutReportHead.ColumnCount = 1;
            this.tableLayoutReportHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutReportHead.Controls.Add(this.lblReportIssue, 0, 0);
            this.tableLayoutReportHead.Location = new System.Drawing.Point(21, 13);
            this.tableLayoutReportHead.Name = "tableLayoutReportHead";
            this.tableLayoutReportHead.RowCount = 1;
            this.tableLayoutReportHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutReportHead.Size = new System.Drawing.Size(918, 71);
            this.tableLayoutReportHead.TabIndex = 19;
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocation.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtLocation.Location = new System.Drawing.Point(3, 6);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(292, 28);
            this.txtLocation.TabIndex = 2;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rtxtDescription.Location = new System.Drawing.Point(6, 3);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(436, 84);
            this.rtxtDescription.TabIndex = 6;
            this.rtxtDescription.Text = "";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads and Transportation",
            "Utilities",
            "Public Safety",
            "Environment",
            "Housing",
            "Health",
            "Education",
            "Public Facilities",
            "Miscellaneous"});
            this.cmbCategory.Location = new System.Drawing.Point(3, 6);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(292, 28);
            this.cmbCategory.TabIndex = 4;
            // 
            // lstAttachedFiles
            // 
            this.lstAttachedFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstAttachedFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lstAttachedFiles.HideSelection = false;
            this.lstAttachedFiles.Location = new System.Drawing.Point(3, 6);
            this.lstAttachedFiles.Name = "lstAttachedFiles";
            this.lstAttachedFiles.Size = new System.Drawing.Size(292, 28);
            this.lstAttachedFiles.TabIndex = 17;
            this.lstAttachedFiles.UseCompatibleStateImageBehavior = false;
            this.lstAttachedFiles.View = System.Windows.Forms.View.List;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.06236F));
            this.tableLayoutPanel2.Controls.Add(this.lblCategory, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 172);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(117, 40);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.4922F));
            this.tableLayoutPanel3.Controls.Add(this.lstAttachedFiles, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(141, 219);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(298, 40);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.txtLocation, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(141, 126);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(298, 40);
            this.tableLayoutPanel5.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblLocation, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 126);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(117, 40);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.cmbCategory, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(141, 172);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(298, 40);
            this.tableLayoutPanel6.TabIndex = 26;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.lblDescription, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(490, 126);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(147, 40);
            this.tableLayoutPanel7.TabIndex = 27;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.Peru;
            this.lblDescription.Location = new System.Drawing.Point(8, 5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(131, 30);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 275);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(117, 30);
            this.tableLayoutPanel4.TabIndex = 28;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.rtxtDescription, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(490, 172);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(449, 90);
            this.tableLayoutPanel8.TabIndex = 29;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.lblEngagement, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(21, 90);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(918, 30);
            this.tableLayoutPanel9.TabIndex = 30;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel10.Controls.Add(this.btnBackToMenu, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.btnLocalEvents, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.btnServiceStatus, 2, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(24, 583);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(915, 54);
            this.tableLayoutPanel10.TabIndex = 31;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel11.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.btnAttachFile, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(18, 218);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(117, 40);
            this.tableLayoutPanel11.TabIndex = 32;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.btnSubmit, 1, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(18, 268);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(921, 46);
            this.tableLayoutPanel12.TabIndex = 33;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel13.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.dataGridViewIssues, 0, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(21, 339);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(918, 238);
            this.tableLayoutPanel13.TabIndex = 34;
            // 
            // dataGridViewIssues
            // 
            this.dataGridViewIssues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIssues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewIssues.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIssues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location,
            this.Category,
            this.Description,
            this.DateReported});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewIssues.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewIssues.GridColor = System.Drawing.Color.Black;
            this.dataGridViewIssues.Location = new System.Drawing.Point(5, 3);
            this.dataGridViewIssues.Name = "dataGridViewIssues";
            this.dataGridViewIssues.RowHeadersWidth = 51;
            this.dataGridViewIssues.RowTemplate.Height = 24;
            this.dataGridViewIssues.Size = new System.Drawing.Size(908, 232);
            this.dataGridViewIssues.TabIndex = 0;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // DateReported
            // 
            this.DateReported.HeaderText = "Date Reported";
            this.DateReported.MinimumWidth = 6;
            this.DateReported.Name = "DateReported";
            // 
            // ReportIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 638);
            this.Controls.Add(this.tableLayoutPanel13);
            this.Controls.Add(this.tableLayoutPanel12);
            this.Controls.Add(this.tableLayoutPanel11);
            this.Controls.Add(this.tableLayoutPanel10);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutReportHead);
            this.DoubleBuffered = true;
            this.Name = "ReportIssueForm";
            this.Text = "ReportIssueForm";
            this.Load += new System.EventHandler(this.ReportIssueForm_Load);
            this.tableLayoutReportHead.ResumeLayout(false);
            this.tableLayoutReportHead.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReportIssue;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutReportHead;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ListView lstAttachedFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.DataGridView dataGridViewIssues;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReported;
    }
}