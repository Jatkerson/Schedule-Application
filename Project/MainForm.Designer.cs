namespace Project
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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonAppointments = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.panelAppointments = new System.Windows.Forms.Panel();
            this.buttonAppointmentDelete = new System.Windows.Forms.Button();
            this.buttonAppointmentUpdate = new System.Windows.Forms.Button();
            this.buttonAppointmentAdd = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.buttonCustomerDelete = new System.Windows.Forms.Button();
            this.buttonCustomerUpdate = new System.Windows.Forms.Button();
            this.buttonCustomerAdd = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.buttonCalendarMonth = new System.Windows.Forms.Button();
            this.buttonCalendarWeek = new System.Windows.Forms.Button();
            this.buttonCalendarAll = new System.Windows.Forms.Button();
            this.dgvCalendar = new System.Windows.Forms.DataGridView();
            this.panelDisplayHeading = new System.Windows.Forms.Panel();
            this.labelDisplayHeading = new System.Windows.Forms.Label();
            this.panelReports = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelReport3 = new System.Windows.Forms.Label();
            this.cbReportConsultant = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelReport1 = new System.Windows.Forms.Label();
            this.labelReport2 = new System.Windows.Forms.Label();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.cbReportMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReport3 = new System.Windows.Forms.Button();
            this.buttonReportConsultantSchedule = new System.Windows.Forms.Button();
            this.buttonReportTypeByMonth = new System.Windows.Forms.Button();
            this.panelNavigation.SuspendLayout();
            this.panelAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.panelCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panelCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
            this.panelDisplayHeading.SuspendLayout();
            this.panelReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.buttonReports);
            this.panelNavigation.Controls.Add(this.buttonLogout);
            this.panelNavigation.Controls.Add(this.buttonCalendar);
            this.panelNavigation.Controls.Add(this.buttonAppointments);
            this.panelNavigation.Controls.Add(this.buttonCustomers);
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(200, 560);
            this.panelNavigation.TabIndex = 0;
            // 
            // buttonReports
            // 
            this.buttonReports.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReports.Location = new System.Drawing.Point(23, 275);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(150, 30);
            this.buttonReports.TabIndex = 4;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(23, 493);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(150, 30);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendar.Location = new System.Drawing.Point(23, 200);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(150, 30);
            this.buttonCalendar.TabIndex = 2;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonAppointments
            // 
            this.buttonAppointments.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointments.Location = new System.Drawing.Point(23, 125);
            this.buttonAppointments.Name = "buttonAppointments";
            this.buttonAppointments.Size = new System.Drawing.Size(150, 30);
            this.buttonAppointments.TabIndex = 1;
            this.buttonAppointments.Text = "Appointments";
            this.buttonAppointments.UseVisualStyleBackColor = true;
            this.buttonAppointments.Click += new System.EventHandler(this.buttonAppointments_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomers.Location = new System.Drawing.Point(23, 50);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(150, 30);
            this.buttonCustomers.TabIndex = 0;
            this.buttonCustomers.Text = "Customers";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // panelAppointments
            // 
            this.panelAppointments.Controls.Add(this.buttonAppointmentDelete);
            this.panelAppointments.Controls.Add(this.buttonAppointmentUpdate);
            this.panelAppointments.Controls.Add(this.buttonAppointmentAdd);
            this.panelAppointments.Controls.Add(this.dgvAppointments);
            this.panelAppointments.Location = new System.Drawing.Point(200, 75);
            this.panelAppointments.Name = "panelAppointments";
            this.panelAppointments.Size = new System.Drawing.Size(780, 485);
            this.panelAppointments.TabIndex = 1;
            // 
            // buttonAppointmentDelete
            // 
            this.buttonAppointmentDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentDelete.Location = new System.Drawing.Point(500, 400);
            this.buttonAppointmentDelete.Name = "buttonAppointmentDelete";
            this.buttonAppointmentDelete.Size = new System.Drawing.Size(150, 30);
            this.buttonAppointmentDelete.TabIndex = 7;
            this.buttonAppointmentDelete.Text = "Delete";
            this.buttonAppointmentDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentUpdate
            // 
            this.buttonAppointmentUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentUpdate.Location = new System.Drawing.Point(300, 400);
            this.buttonAppointmentUpdate.Name = "buttonAppointmentUpdate";
            this.buttonAppointmentUpdate.Size = new System.Drawing.Size(150, 30);
            this.buttonAppointmentUpdate.TabIndex = 6;
            this.buttonAppointmentUpdate.Text = "Update";
            this.buttonAppointmentUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentAdd
            // 
            this.buttonAppointmentAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentAdd.Location = new System.Drawing.Point(100, 400);
            this.buttonAppointmentAdd.Name = "buttonAppointmentAdd";
            this.buttonAppointmentAdd.Size = new System.Drawing.Size(150, 30);
            this.buttonAppointmentAdd.TabIndex = 5;
            this.buttonAppointmentAdd.Text = "Add";
            this.buttonAppointmentAdd.UseVisualStyleBackColor = true;
            this.buttonAppointmentAdd.Click += new System.EventHandler(this.buttonAppointmentAdd_Click);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(40, 25);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Size = new System.Drawing.Size(700, 350);
            this.dgvAppointments.TabIndex = 4;
            // 
            // panelCustomers
            // 
            this.panelCustomers.Controls.Add(this.buttonCustomerDelete);
            this.panelCustomers.Controls.Add(this.buttonCustomerUpdate);
            this.panelCustomers.Controls.Add(this.buttonCustomerAdd);
            this.panelCustomers.Controls.Add(this.dgvCustomers);
            this.panelCustomers.Location = new System.Drawing.Point(200, 75);
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Size = new System.Drawing.Size(780, 485);
            this.panelCustomers.TabIndex = 2;
            // 
            // buttonCustomerDelete
            // 
            this.buttonCustomerDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerDelete.Location = new System.Drawing.Point(500, 400);
            this.buttonCustomerDelete.Name = "buttonCustomerDelete";
            this.buttonCustomerDelete.Size = new System.Drawing.Size(150, 30);
            this.buttonCustomerDelete.TabIndex = 3;
            this.buttonCustomerDelete.Text = "Delete";
            this.buttonCustomerDelete.UseVisualStyleBackColor = true;
            // 
            // buttonCustomerUpdate
            // 
            this.buttonCustomerUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerUpdate.Location = new System.Drawing.Point(300, 400);
            this.buttonCustomerUpdate.Name = "buttonCustomerUpdate";
            this.buttonCustomerUpdate.Size = new System.Drawing.Size(150, 30);
            this.buttonCustomerUpdate.TabIndex = 2;
            this.buttonCustomerUpdate.Text = "Update";
            this.buttonCustomerUpdate.UseVisualStyleBackColor = true;
            this.buttonCustomerUpdate.Click += new System.EventHandler(this.buttonCustomerUpdate_Click);
            // 
            // buttonCustomerAdd
            // 
            this.buttonCustomerAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerAdd.Location = new System.Drawing.Point(100, 400);
            this.buttonCustomerAdd.Name = "buttonCustomerAdd";
            this.buttonCustomerAdd.Size = new System.Drawing.Size(150, 30);
            this.buttonCustomerAdd.TabIndex = 1;
            this.buttonCustomerAdd.Text = "Add";
            this.buttonCustomerAdd.UseVisualStyleBackColor = true;
            this.buttonCustomerAdd.Click += new System.EventHandler(this.buttonCustomerAdd_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(40, 25);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(700, 350);
            this.dgvCustomers.TabIndex = 0;
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.buttonCalendarMonth);
            this.panelCalendar.Controls.Add(this.buttonCalendarWeek);
            this.panelCalendar.Controls.Add(this.buttonCalendarAll);
            this.panelCalendar.Controls.Add(this.dgvCalendar);
            this.panelCalendar.Location = new System.Drawing.Point(200, 75);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(780, 485);
            this.panelCalendar.TabIndex = 3;
            // 
            // buttonCalendarMonth
            // 
            this.buttonCalendarMonth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendarMonth.Location = new System.Drawing.Point(500, 400);
            this.buttonCalendarMonth.Name = "buttonCalendarMonth";
            this.buttonCalendarMonth.Size = new System.Drawing.Size(150, 30);
            this.buttonCalendarMonth.TabIndex = 11;
            this.buttonCalendarMonth.Text = "Month";
            this.buttonCalendarMonth.UseVisualStyleBackColor = true;
            // 
            // buttonCalendarWeek
            // 
            this.buttonCalendarWeek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendarWeek.Location = new System.Drawing.Point(300, 400);
            this.buttonCalendarWeek.Name = "buttonCalendarWeek";
            this.buttonCalendarWeek.Size = new System.Drawing.Size(150, 30);
            this.buttonCalendarWeek.TabIndex = 10;
            this.buttonCalendarWeek.Text = "Week";
            this.buttonCalendarWeek.UseVisualStyleBackColor = true;
            // 
            // buttonCalendarAll
            // 
            this.buttonCalendarAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendarAll.Location = new System.Drawing.Point(100, 400);
            this.buttonCalendarAll.Name = "buttonCalendarAll";
            this.buttonCalendarAll.Size = new System.Drawing.Size(150, 30);
            this.buttonCalendarAll.TabIndex = 9;
            this.buttonCalendarAll.Text = "All";
            this.buttonCalendarAll.UseVisualStyleBackColor = true;
            // 
            // dgvCalendar
            // 
            this.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendar.Location = new System.Drawing.Point(40, 25);
            this.dgvCalendar.Name = "dgvCalendar";
            this.dgvCalendar.Size = new System.Drawing.Size(700, 350);
            this.dgvCalendar.TabIndex = 8;
            // 
            // panelDisplayHeading
            // 
            this.panelDisplayHeading.Controls.Add(this.labelDisplayHeading);
            this.panelDisplayHeading.Location = new System.Drawing.Point(200, 0);
            this.panelDisplayHeading.Name = "panelDisplayHeading";
            this.panelDisplayHeading.Size = new System.Drawing.Size(780, 75);
            this.panelDisplayHeading.TabIndex = 4;
            // 
            // labelDisplayHeading
            // 
            this.labelDisplayHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayHeading.Location = new System.Drawing.Point(0, 0);
            this.labelDisplayHeading.Name = "labelDisplayHeading";
            this.labelDisplayHeading.Size = new System.Drawing.Size(780, 75);
            this.labelDisplayHeading.TabIndex = 0;
            this.labelDisplayHeading.Text = "Customers";
            this.labelDisplayHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelReports
            // 
            this.panelReports.Controls.Add(this.label6);
            this.panelReports.Controls.Add(this.labelReport3);
            this.panelReports.Controls.Add(this.cbReportConsultant);
            this.panelReports.Controls.Add(this.label5);
            this.panelReports.Controls.Add(this.labelReport1);
            this.panelReports.Controls.Add(this.labelReport2);
            this.panelReports.Controls.Add(this.cbReportType);
            this.panelReports.Controls.Add(this.cbReportMonth);
            this.panelReports.Controls.Add(this.label1);
            this.panelReports.Controls.Add(this.buttonReport3);
            this.panelReports.Controls.Add(this.buttonReportConsultantSchedule);
            this.panelReports.Controls.Add(this.buttonReportTypeByMonth);
            this.panelReports.Location = new System.Drawing.Point(200, 75);
            this.panelReports.Name = "panelReports";
            this.panelReports.Size = new System.Drawing.Size(780, 485);
            this.panelReports.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(500, 50);
            this.label6.TabIndex = 14;
            this.label6.Text = "Third Report";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReport3
            // 
            this.labelReport3.AutoSize = true;
            this.labelReport3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReport3.Location = new System.Drawing.Point(272, 255);
            this.labelReport3.Name = "labelReport3";
            this.labelReport3.Size = new System.Drawing.Size(90, 19);
            this.labelReport3.TabIndex = 13;
            this.labelReport3.Text = "Consultant:";
            // 
            // cbReportConsultant
            // 
            this.cbReportConsultant.FormattingEnabled = true;
            this.cbReportConsultant.Items.AddRange(new object[] {
            ""});
            this.cbReportConsultant.Location = new System.Drawing.Point(368, 253);
            this.cbReportConsultant.Name = "cbReportConsultant";
            this.cbReportConsultant.Size = new System.Drawing.Size(202, 21);
            this.cbReportConsultant.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "Consultant Schedule";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReport1
            // 
            this.labelReport1.AutoSize = true;
            this.labelReport1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReport1.Location = new System.Drawing.Point(178, 84);
            this.labelReport1.Name = "labelReport1";
            this.labelReport1.Size = new System.Drawing.Size(50, 19);
            this.labelReport1.TabIndex = 8;
            this.labelReport1.Text = "Type:";
            // 
            // labelReport2
            // 
            this.labelReport2.AutoSize = true;
            this.labelReport2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReport2.Location = new System.Drawing.Point(407, 85);
            this.labelReport2.Name = "labelReport2";
            this.labelReport2.Size = new System.Drawing.Size(59, 19);
            this.labelReport2.TabIndex = 7;
            this.labelReport2.Text = "Month:";
            // 
            // cbReportType
            // 
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Items.AddRange(new object[] {
            "",
            "Presentation",
            "Scrum"});
            this.cbReportType.Location = new System.Drawing.Point(234, 83);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(121, 21);
            this.cbReportType.TabIndex = 6;
            // 
            // cbReportMonth
            // 
            this.cbReportMonth.FormattingEnabled = true;
            this.cbReportMonth.Items.AddRange(new object[] {
            "",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbReportMonth.Location = new System.Drawing.Point(472, 83);
            this.cbReportMonth.Name = "cbReportMonth";
            this.cbReportMonth.Size = new System.Drawing.Size(121, 21);
            this.cbReportMonth.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Appointment Type By Month";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReport3
            // 
            this.buttonReport3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport3.Location = new System.Drawing.Point(316, 411);
            this.buttonReport3.Name = "buttonReport3";
            this.buttonReport3.Size = new System.Drawing.Size(150, 30);
            this.buttonReport3.TabIndex = 3;
            this.buttonReport3.Text = "View";
            this.buttonReport3.UseVisualStyleBackColor = true;
            // 
            // buttonReportConsultantSchedule
            // 
            this.buttonReportConsultantSchedule.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportConsultantSchedule.Location = new System.Drawing.Point(316, 294);
            this.buttonReportConsultantSchedule.Name = "buttonReportConsultantSchedule";
            this.buttonReportConsultantSchedule.Size = new System.Drawing.Size(150, 30);
            this.buttonReportConsultantSchedule.TabIndex = 2;
            this.buttonReportConsultantSchedule.Text = "View";
            this.buttonReportConsultantSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonReportTypeByMonth
            // 
            this.buttonReportTypeByMonth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportTypeByMonth.Location = new System.Drawing.Point(316, 129);
            this.buttonReportTypeByMonth.Name = "buttonReportTypeByMonth";
            this.buttonReportTypeByMonth.Size = new System.Drawing.Size(150, 30);
            this.buttonReportTypeByMonth.TabIndex = 1;
            this.buttonReportTypeByMonth.Text = "View";
            this.buttonReportTypeByMonth.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelDisplayHeading);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelReports);
            this.Controls.Add(this.panelCustomers);
            this.Controls.Add(this.panelAppointments);
            this.Controls.Add(this.panelCalendar);
            this.Name = "MainForm";
            this.Text = "Schedule Application";
            this.panelNavigation.ResumeLayout(false);
            this.panelAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.panelCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panelCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
            this.panelDisplayHeading.ResumeLayout(false);
            this.panelReports.ResumeLayout(false);
            this.panelReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonAppointments;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Panel panelAppointments;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Panel panelDisplayHeading;
        private System.Windows.Forms.Label labelDisplayHeading;
        private System.Windows.Forms.Button buttonAppointmentDelete;
        private System.Windows.Forms.Button buttonAppointmentUpdate;
        private System.Windows.Forms.Button buttonAppointmentAdd;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button buttonCustomerDelete;
        private System.Windows.Forms.Button buttonCustomerUpdate;
        private System.Windows.Forms.Button buttonCustomerAdd;
        private System.Windows.Forms.Button buttonCalendarMonth;
        private System.Windows.Forms.Button buttonCalendarWeek;
        private System.Windows.Forms.Button buttonCalendarAll;
        private System.Windows.Forms.DataGridView dgvCalendar;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Panel panelReports;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.ComboBox cbReportMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReport3;
        private System.Windows.Forms.Button buttonReportConsultantSchedule;
        private System.Windows.Forms.Button buttonReportTypeByMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelReport3;
        private System.Windows.Forms.ComboBox cbReportConsultant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelReport1;
        private System.Windows.Forms.Label labelReport2;
    }
}