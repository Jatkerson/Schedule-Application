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
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonAppointments = new System.Windows.Forms.Button();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelAppointments = new System.Windows.Forms.Panel();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.panelDisplayHeading = new System.Windows.Forms.Panel();
            this.labelDisplayHeading = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.buttonCustomerAdd = new System.Windows.Forms.Button();
            this.buttonCustomerUpdate = new System.Windows.Forms.Button();
            this.buttonCustomerDelete = new System.Windows.Forms.Button();
            this.buttonAppointmentDelete = new System.Windows.Forms.Button();
            this.buttonAppointmentUpdate = new System.Windows.Forms.Button();
            this.buttonAppointmentAdd = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.buttonCalendarMonth = new System.Windows.Forms.Button();
            this.buttonCalendarWeek = new System.Windows.Forms.Button();
            this.buttonCalendarAll = new System.Windows.Forms.Button();
            this.dgvCalendar = new System.Windows.Forms.DataGridView();
            this.panelNavigation.SuspendLayout();
            this.panelAppointments.SuspendLayout();
            this.panelCustomers.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.panelDisplayHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.buttonLogout);
            this.panelNavigation.Controls.Add(this.buttonCalendar);
            this.panelNavigation.Controls.Add(this.buttonAppointments);
            this.panelNavigation.Controls.Add(this.buttonCustomers);
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(200, 560);
            this.panelNavigation.TabIndex = 0;
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomers.Location = new System.Drawing.Point(23, 100);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(150, 30);
            this.buttonCustomers.TabIndex = 0;
            this.buttonCustomers.Text = "Customers";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // buttonAppointments
            // 
            this.buttonAppointments.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointments.Location = new System.Drawing.Point(23, 175);
            this.buttonAppointments.Name = "buttonAppointments";
            this.buttonAppointments.Size = new System.Drawing.Size(150, 30);
            this.buttonAppointments.TabIndex = 1;
            this.buttonAppointments.Text = "Appointments";
            this.buttonAppointments.UseVisualStyleBackColor = true;
            this.buttonAppointments.Click += new System.EventHandler(this.buttonAppointments_Click);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendar.Location = new System.Drawing.Point(23, 250);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(150, 30);
            this.buttonCalendar.TabIndex = 2;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
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
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(40, 25);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(700, 350);
            this.dgvCustomers.TabIndex = 0;
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
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(40, 25);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Size = new System.Drawing.Size(700, 350);
            this.dgvAppointments.TabIndex = 4;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelDisplayHeading);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelCustomers);
            this.Controls.Add(this.panelAppointments);
            this.Controls.Add(this.panelCalendar);
            this.Name = "MainForm";
            this.Text = "Schedule Application";
            this.panelNavigation.ResumeLayout(false);
            this.panelAppointments.ResumeLayout(false);
            this.panelCustomers.ResumeLayout(false);
            this.panelCalendar.ResumeLayout(false);
            this.panelDisplayHeading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
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
    }
}