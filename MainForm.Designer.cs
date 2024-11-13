namespace MunicipalServices
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutMainHead = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutMainHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportIssues.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.ForeColor = System.Drawing.Color.Peru;
            this.btnReportIssues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportIssues.Location = new System.Drawing.Point(7, 3);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(244, 52);
            this.btnReportIssues.TabIndex = 0;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLocalEvents.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLocalEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEvents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLocalEvents.ForeColor = System.Drawing.Color.Peru;
            this.btnLocalEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalEvents.Location = new System.Drawing.Point(266, 3);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(244, 53);
            this.btnLocalEvents.TabIndex = 1;
            this.btnLocalEvents.Text = "Local Events and Announcements";
            this.btnLocalEvents.UseVisualStyleBackColor = false;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnServiceStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnServiceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnServiceStatus.ForeColor = System.Drawing.Color.Peru;
            this.btnServiceStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceStatus.Location = new System.Drawing.Point(525, 3);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new System.Drawing.Size(244, 53);
            this.btnServiceStatus.TabIndex = 2;
            this.btnServiceStatus.Text = "Service Status";
            this.btnServiceStatus.UseVisualStyleBackColor = false;
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Peru;
            this.lblTitle.Location = new System.Drawing.Point(139, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(484, 67);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Municipal Services";
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutMain.AutoSize = true;
            this.tableLayoutMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutMain.ColumnCount = 3;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutMain.Controls.Add(this.btnLocalEvents, 1, 0);
            this.tableLayoutMain.Controls.Add(this.btnServiceStatus, 2, 0);
            this.tableLayoutMain.Controls.Add(this.btnReportIssues, 0, 0);
            this.tableLayoutMain.Location = new System.Drawing.Point(12, 376);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.Size = new System.Drawing.Size(776, 59);
            this.tableLayoutMain.TabIndex = 4;
            // 
            // tableLayoutMainHead
            // 
            this.tableLayoutMainHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutMainHead.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutMainHead.ColumnCount = 1;
            this.tableLayoutMainHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMainHead.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutMainHead.Location = new System.Drawing.Point(15, 12);
            this.tableLayoutMainHead.Name = "tableLayoutMainHead";
            this.tableLayoutMainHead.RowCount = 1;
            this.tableLayoutMainHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMainHead.Size = new System.Drawing.Size(762, 89);
            this.tableLayoutMainHead.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutMainHead);
            this.Controls.Add(this.tableLayoutMain);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Municipal Services";
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMainHead.ResumeLayout(false);
            this.tableLayoutMainHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMainHead;
    }
}