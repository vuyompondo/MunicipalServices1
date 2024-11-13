namespace MunicipalServices
{
    partial class ServiceRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestForm));
            this.lblServiceRequesttlt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearchReq = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridServiceRequests = new System.Windows.Forms.DataGridView();
            this.RequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReported = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblServiceRequ = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRequestId = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDateReported = new System.Windows.Forms.Label();
            this.lblEstimatedCompletion = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRequestDetails = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriorityFilter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiceRequests)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServiceRequesttlt
            // 
            this.lblServiceRequesttlt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServiceRequesttlt.AutoSize = true;
            this.lblServiceRequesttlt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServiceRequesttlt.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.lblServiceRequesttlt.ForeColor = System.Drawing.Color.Peru;
            this.lblServiceRequesttlt.Location = new System.Drawing.Point(235, 7);
            this.lblServiceRequesttlt.Name = "lblServiceRequesttlt";
            this.lblServiceRequesttlt.Size = new System.Drawing.Size(496, 57);
            this.lblServiceRequesttlt.TabIndex = 0;
            this.lblServiceRequesttlt.Text = "Service Request Status";
            this.lblServiceRequesttlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblServiceRequesttlt, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 72);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.lblSearchReq, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 155);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(445, 36);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblSearchReq
            // 
            this.lblSearchReq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchReq.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchReq.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSearchReq.ForeColor = System.Drawing.Color.Peru;
            this.lblSearchReq.Location = new System.Drawing.Point(3, 4);
            this.lblSearchReq.Name = "lblSearchReq";
            this.lblSearchReq.Size = new System.Drawing.Size(77, 27);
            this.lblSearchReq.TabIndex = 0;
            this.lblSearchReq.Text = "Search:";
            this.lblSearchReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(87, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 25);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Peru;
            this.btnSearch.Location = new System.Drawing.Point(370, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridServiceRequests, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 194);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(976, 170);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // dataGridServiceRequests
            // 
            this.dataGridServiceRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridServiceRequests.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridServiceRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridServiceRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServiceRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestId,
            this.Location,
            this.Description,
            this.Status,
            this.DateReported});
            this.dataGridServiceRequests.GridColor = System.Drawing.Color.DimGray;
            this.dataGridServiceRequests.Location = new System.Drawing.Point(3, 3);
            this.dataGridServiceRequests.Name = "dataGridServiceRequests";
            this.dataGridServiceRequests.RowHeadersWidth = 51;
            this.dataGridServiceRequests.RowTemplate.Height = 24;
            this.dataGridServiceRequests.Size = new System.Drawing.Size(964, 164);
            this.dataGridServiceRequests.TabIndex = 0;
            this.dataGridServiceRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridServiceRequests_CellContentClick);
            // 
            // RequestId
            // 
            this.RequestId.DataPropertyName = "RequestId";
            this.RequestId.HeaderText = "Request ID";
            this.RequestId.MinimumWidth = 6;
            this.RequestId.Name = "RequestId";
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // DateReported
            // 
            this.DateReported.DataPropertyName = "DateReported";
            this.DateReported.HeaderText = "Date Reported";
            this.DateReported.MinimumWidth = 6;
            this.DateReported.Name = "DateReported";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblServiceRequ, 0, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.Peru;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(15, 92);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(964, 45);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lblServiceRequ
            // 
            this.lblServiceRequ.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServiceRequ.AutoSize = true;
            this.lblServiceRequ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServiceRequ.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.lblServiceRequ.Location = new System.Drawing.Point(3, 5);
            this.lblServiceRequ.Name = "lblServiceRequ";
            this.lblServiceRequ.Size = new System.Drawing.Size(377, 35);
            this.lblServiceRequ.TabIndex = 0;
            this.lblServiceRequ.Text = "Submitted Service Requests   ";
            this.lblServiceRequ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel5.Controls.Add(this.lblRequestId, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblLocation, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblCategory, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblStatus, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblDateReported, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblEstimatedCompletion, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblDescription, 6, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(15, 503);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(964, 93);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // lblRequestId
            // 
            this.lblRequestId.AutoSize = true;
            this.lblRequestId.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestId.ForeColor = System.Drawing.Color.Peru;
            this.lblRequestId.Location = new System.Drawing.Point(6, 37);
            this.lblRequestId.Name = "lblRequestId";
            this.lblRequestId.Size = new System.Drawing.Size(16, 17);
            this.lblRequestId.TabIndex = 0;
            this.lblRequestId.Text = "  ";
            this.lblRequestId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.Peru;
            this.lblLocation.Location = new System.Drawing.Point(104, 37);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(20, 17);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "   ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.Peru;
            this.lblCategory.Location = new System.Drawing.Point(209, 37);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(20, 17);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "   ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Peru;
            this.lblStatus.Location = new System.Drawing.Point(331, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "   ";
            // 
            // lblDateReported
            // 
            this.lblDateReported.AutoSize = true;
            this.lblDateReported.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblDateReported.ForeColor = System.Drawing.Color.Peru;
            this.lblDateReported.Location = new System.Drawing.Point(429, 37);
            this.lblDateReported.Name = "lblDateReported";
            this.lblDateReported.Size = new System.Drawing.Size(20, 17);
            this.lblDateReported.TabIndex = 3;
            this.lblDateReported.Text = "   ";
            this.lblDateReported.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstimatedCompletion
            // 
            this.lblEstimatedCompletion.AutoSize = true;
            this.lblEstimatedCompletion.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblEstimatedCompletion.ForeColor = System.Drawing.Color.Peru;
            this.lblEstimatedCompletion.Location = new System.Drawing.Point(524, 37);
            this.lblEstimatedCompletion.Name = "lblEstimatedCompletion";
            this.lblEstimatedCompletion.Size = new System.Drawing.Size(20, 17);
            this.lblEstimatedCompletion.TabIndex = 4;
            this.lblEstimatedCompletion.Text = "   ";
            this.lblEstimatedCompletion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.Peru;
            this.lblDescription.Location = new System.Drawing.Point(720, 37);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(20, 17);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "   ";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Request ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(104, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(209, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(331, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Peru;
            this.label5.Location = new System.Drawing.Point(429, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date Reported";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Peru;
            this.label6.Location = new System.Drawing.Point(524, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estimated Completion";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Peru;
            this.label7.Location = new System.Drawing.Point(720, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lblRequestDetails, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(17, 453);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(964, 44);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // lblRequestDetails
            // 
            this.lblRequestDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRequestDetails.AutoSize = true;
            this.lblRequestDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRequestDetails.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.lblRequestDetails.ForeColor = System.Drawing.Color.Peru;
            this.lblRequestDetails.Location = new System.Drawing.Point(3, 4);
            this.lblRequestDetails.Name = "lblRequestDetails";
            this.lblRequestDetails.Size = new System.Drawing.Size(301, 35);
            this.lblRequestDetails.TabIndex = 0;
            this.lblRequestDetails.Text = "Service Request Details";
            this.lblRequestDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel10.Controls.Add(this.btnReportIssues, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.btnLocalEvents, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.btnBackToMenu, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(12, 602);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(964, 54);
            this.tableLayoutPanel10.TabIndex = 33;
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportIssues.AutoSize = true;
            this.btnReportIssues.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.ForeColor = System.Drawing.Color.Peru;
            this.btnReportIssues.Location = new System.Drawing.Point(332, 9);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(300, 35);
            this.btnReportIssues.TabIndex = 13;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLocalEvents.AutoSize = true;
            this.btnLocalEvents.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocalEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEvents.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnLocalEvents.ForeColor = System.Drawing.Color.Peru;
            this.btnLocalEvents.Location = new System.Drawing.Point(659, 9);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(300, 35);
            this.btnLocalEvents.TabIndex = 14;
            this.btnLocalEvents.Text = "Local Events and Announcements";
            this.btnLocalEvents.UseVisualStyleBackColor = false;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackToMenu.AutoSize = true;
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBackToMenu.ForeColor = System.Drawing.Color.Peru;
            this.btnBackToMenu.Location = new System.Drawing.Point(5, 9);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(300, 35);
            this.btnBackToMenu.TabIndex = 12;
            this.btnBackToMenu.Text = "Back To Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel7.Controls.Add(this.lblPriority, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.cmbPriorityFilter, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(475, 155);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(371, 36);
            this.tableLayoutPanel7.TabIndex = 34;
            // 
            // lblPriority
            // 
            this.lblPriority.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPriority.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblPriority.ForeColor = System.Drawing.Color.Peru;
            this.lblPriority.Location = new System.Drawing.Point(7, 4);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(66, 27);
            this.lblPriority.TabIndex = 0;
            this.lblPriority.Text = "Priority";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPriorityFilter
            // 
            this.cmbPriorityFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPriorityFilter.FormattingEnabled = true;
            this.cmbPriorityFilter.Location = new System.Drawing.Point(88, 6);
            this.cmbPriorityFilter.Name = "cmbPriorityFilter";
            this.cmbPriorityFilter.Size = new System.Drawing.Size(190, 24);
            this.cmbPriorityFilter.TabIndex = 1;
            this.cmbPriorityFilter.SelectedIndexChanged += new System.EventHandler(this.cmbPriorityFilter_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Peru;
            this.button1.Location = new System.Drawing.Point(288, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServiceRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 668);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel10);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "ServiceRequestForm";
            this.Text = "ServiceRequestForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiceRequests)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServiceRequesttlt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblServiceRequ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblRequestDetails;
        private System.Windows.Forms.Label lblRequestId;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDateReported;
        private System.Windows.Forms.Label lblEstimatedCompletion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriorityFilter;
        private System.Windows.Forms.Label lblSearchReq;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridServiceRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReported;
        private System.Windows.Forms.Button button1;
    }
}