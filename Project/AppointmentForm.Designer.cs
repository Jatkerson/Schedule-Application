namespace Project
{
    partial class AppointmentForm
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
            this.labelAppointmentHeading = new System.Windows.Forms.Label();
            this.buttonAppointmentCancel = new System.Windows.Forms.Button();
            this.buttonAppointmentChange = new System.Windows.Forms.Button();
            this.labelAppointmentType = new System.Windows.Forms.Label();
            this.labelAppointmentCustomer = new System.Windows.Forms.Label();
            this.labelAppointmentEnd = new System.Windows.Forms.Label();
            this.labelAppointmentStart = new System.Windows.Forms.Label();
            this.cbAppointmentType = new System.Windows.Forms.ComboBox();
            this.cbAppointmentCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAppointmentUserID = new System.Windows.Forms.TextBox();
            this.dtpAppointmentStart = new System.Windows.Forms.DateTimePicker();
            this.dtpAppointmentEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelAppointmentHeading
            // 
            this.labelAppointmentHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentHeading.Location = new System.Drawing.Point(10, 0);
            this.labelAppointmentHeading.Name = "labelAppointmentHeading";
            this.labelAppointmentHeading.Size = new System.Drawing.Size(780, 75);
            this.labelAppointmentHeading.TabIndex = 5;
            this.labelAppointmentHeading.Text = "Appointment";
            this.labelAppointmentHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAppointmentCancel
            // 
            this.buttonAppointmentCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentCancel.Location = new System.Drawing.Point(440, 375);
            this.buttonAppointmentCancel.Name = "buttonAppointmentCancel";
            this.buttonAppointmentCancel.Size = new System.Drawing.Size(150, 30);
            this.buttonAppointmentCancel.TabIndex = 30;
            this.buttonAppointmentCancel.Text = "Cancel";
            this.buttonAppointmentCancel.UseVisualStyleBackColor = true;
            this.buttonAppointmentCancel.Click += new System.EventHandler(this.buttonAppointmentCancel_Click);
            // 
            // buttonAppointmentChange
            // 
            this.buttonAppointmentChange.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentChange.Location = new System.Drawing.Point(225, 375);
            this.buttonAppointmentChange.Name = "buttonAppointmentChange";
            this.buttonAppointmentChange.Size = new System.Drawing.Size(150, 30);
            this.buttonAppointmentChange.TabIndex = 29;
            this.buttonAppointmentChange.Text = "Add";
            this.buttonAppointmentChange.UseVisualStyleBackColor = true;
            this.buttonAppointmentChange.Click += new System.EventHandler(this.buttonAppointmentChange_Click);
            // 
            // labelAppointmentType
            // 
            this.labelAppointmentType.AutoSize = true;
            this.labelAppointmentType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentType.Location = new System.Drawing.Point(197, 98);
            this.labelAppointmentType.Name = "labelAppointmentType";
            this.labelAppointmentType.Size = new System.Drawing.Size(147, 19);
            this.labelAppointmentType.TabIndex = 23;
            this.labelAppointmentType.Text = "Appointment Type:";
            // 
            // labelAppointmentCustomer
            // 
            this.labelAppointmentCustomer.AutoSize = true;
            this.labelAppointmentCustomer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentCustomer.Location = new System.Drawing.Point(261, 148);
            this.labelAppointmentCustomer.Name = "labelAppointmentCustomer";
            this.labelAppointmentCustomer.Size = new System.Drawing.Size(83, 19);
            this.labelAppointmentCustomer.TabIndex = 22;
            this.labelAppointmentCustomer.Text = "Customer:";
            // 
            // labelAppointmentEnd
            // 
            this.labelAppointmentEnd.AutoSize = true;
            this.labelAppointmentEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentEnd.Location = new System.Drawing.Point(261, 251);
            this.labelAppointmentEnd.Name = "labelAppointmentEnd";
            this.labelAppointmentEnd.Size = new System.Drawing.Size(83, 19);
            this.labelAppointmentEnd.TabIndex = 18;
            this.labelAppointmentEnd.Text = "End Time:";
            // 
            // labelAppointmentStart
            // 
            this.labelAppointmentStart.AutoSize = true;
            this.labelAppointmentStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentStart.Location = new System.Drawing.Point(255, 201);
            this.labelAppointmentStart.Name = "labelAppointmentStart";
            this.labelAppointmentStart.Size = new System.Drawing.Size(89, 19);
            this.labelAppointmentStart.TabIndex = 14;
            this.labelAppointmentStart.Text = "Start Time:";
            // 
            // cbAppointmentType
            // 
            this.cbAppointmentType.FormattingEnabled = true;
            this.cbAppointmentType.Items.AddRange(new object[] {
            "",
            "Presentation",
            "Scrum"});
            this.cbAppointmentType.Location = new System.Drawing.Point(350, 100);
            this.cbAppointmentType.Name = "cbAppointmentType";
            this.cbAppointmentType.Size = new System.Drawing.Size(200, 21);
            this.cbAppointmentType.TabIndex = 24;
            this.cbAppointmentType.SelectedIndexChanged += new System.EventHandler(this.cbAppointmentType_SelectedIndexChanged);
            // 
            // cbAppointmentCustomer
            // 
            this.cbAppointmentCustomer.FormattingEnabled = true;
            this.cbAppointmentCustomer.Items.AddRange(new object[] {
            ""});
            this.cbAppointmentCustomer.Location = new System.Drawing.Point(350, 150);
            this.cbAppointmentCustomer.Name = "cbAppointmentCustomer";
            this.cbAppointmentCustomer.Size = new System.Drawing.Size(200, 21);
            this.cbAppointmentCustomer.TabIndex = 25;
            this.cbAppointmentCustomer.SelectedIndexChanged += new System.EventHandler(this.cbAppointmentCustomer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "User ID:";
            // 
            // tbAppointmentUserID
            // 
            this.tbAppointmentUserID.Enabled = false;
            this.tbAppointmentUserID.Location = new System.Drawing.Point(350, 300);
            this.tbAppointmentUserID.Name = "tbAppointmentUserID";
            this.tbAppointmentUserID.Size = new System.Drawing.Size(100, 20);
            this.tbAppointmentUserID.TabIndex = 28;
            // 
            // dtpAppointmentStart
            // 
            this.dtpAppointmentStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpAppointmentStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentStart.Location = new System.Drawing.Point(350, 200);
            this.dtpAppointmentStart.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpAppointmentStart.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpAppointmentStart.Name = "dtpAppointmentStart";
            this.dtpAppointmentStart.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointmentStart.TabIndex = 26;
            this.dtpAppointmentStart.Value = new System.DateTime(2022, 11, 15, 8, 0, 0, 0);
            this.dtpAppointmentStart.ValueChanged += new System.EventHandler(this.dtpAppointmentStart_ValueChanged);
            // 
            // dtpAppointmentEnd
            // 
            this.dtpAppointmentEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpAppointmentEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentEnd.Location = new System.Drawing.Point(350, 250);
            this.dtpAppointmentEnd.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpAppointmentEnd.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpAppointmentEnd.Name = "dtpAppointmentEnd";
            this.dtpAppointmentEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointmentEnd.TabIndex = 27;
            this.dtpAppointmentEnd.Value = new System.DateTime(2022, 11, 15, 9, 0, 0, 0);
            this.dtpAppointmentEnd.ValueChanged += new System.EventHandler(this.dtpAppointmentEnd_ValueChanged);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpAppointmentEnd);
            this.Controls.Add(this.dtpAppointmentStart);
            this.Controls.Add(this.tbAppointmentUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAppointmentCustomer);
            this.Controls.Add(this.cbAppointmentType);
            this.Controls.Add(this.buttonAppointmentCancel);
            this.Controls.Add(this.buttonAppointmentChange);
            this.Controls.Add(this.labelAppointmentType);
            this.Controls.Add(this.labelAppointmentCustomer);
            this.Controls.Add(this.labelAppointmentEnd);
            this.Controls.Add(this.labelAppointmentStart);
            this.Controls.Add(this.labelAppointmentHeading);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointmentHeading;
        private System.Windows.Forms.Button buttonAppointmentCancel;
        private System.Windows.Forms.Button buttonAppointmentChange;
        private System.Windows.Forms.Label labelAppointmentType;
        private System.Windows.Forms.Label labelAppointmentCustomer;
        private System.Windows.Forms.Label labelAppointmentEnd;
        private System.Windows.Forms.Label labelAppointmentStart;
        private System.Windows.Forms.ComboBox cbAppointmentType;
        private System.Windows.Forms.ComboBox cbAppointmentCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAppointmentUserID;
        private System.Windows.Forms.DateTimePicker dtpAppointmentStart;
        private System.Windows.Forms.DateTimePicker dtpAppointmentEnd;
    }
}