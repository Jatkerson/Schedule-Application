namespace Project
{
    partial class CustomerForm
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
            this.tbCustomerCity = new System.Windows.Forms.TextBox();
            this.labelCustomerCity = new System.Windows.Forms.Label();
            this.labelCustomerHeading = new System.Windows.Forms.Label();
            this.tbCustomerCountry = new System.Windows.Forms.TextBox();
            this.labelCustomerCountry = new System.Windows.Forms.Label();
            this.tbCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.labelCustomerAddress = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.buttonCustomerChange = new System.Windows.Forms.Button();
            this.buttonCustomerCancel = new System.Windows.Forms.Button();
            this.tbCustomerZipCode = new System.Windows.Forms.TextBox();
            this.labelCustomerZipCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCustomerCity
            // 
            this.tbCustomerCity.Location = new System.Drawing.Point(350, 175);
            this.tbCustomerCity.Name = "tbCustomerCity";
            this.tbCustomerCity.Size = new System.Drawing.Size(200, 20);
            this.tbCustomerCity.TabIndex = 3;
            this.tbCustomerCity.TextChanged += new System.EventHandler(this.tbCustomerCity_TextChanged);
            // 
            // labelCustomerCity
            // 
            this.labelCustomerCity.AutoSize = true;
            this.labelCustomerCity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerCity.Location = new System.Drawing.Point(302, 173);
            this.labelCustomerCity.Name = "labelCustomerCity";
            this.labelCustomerCity.Size = new System.Drawing.Size(42, 19);
            this.labelCustomerCity.TabIndex = 2;
            this.labelCustomerCity.Text = "City:";
            // 
            // labelCustomerHeading
            // 
            this.labelCustomerHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerHeading.Location = new System.Drawing.Point(10, 0);
            this.labelCustomerHeading.Name = "labelCustomerHeading";
            this.labelCustomerHeading.Size = new System.Drawing.Size(780, 75);
            this.labelCustomerHeading.TabIndex = 4;
            this.labelCustomerHeading.Text = "Customer";
            this.labelCustomerHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCustomerCountry
            // 
            this.tbCustomerCountry.Location = new System.Drawing.Point(350, 225);
            this.tbCustomerCountry.Name = "tbCustomerCountry";
            this.tbCustomerCountry.Size = new System.Drawing.Size(200, 20);
            this.tbCustomerCountry.TabIndex = 4;
            this.tbCustomerCountry.TextChanged += new System.EventHandler(this.tbCustomerCountry_TextChanged);
            // 
            // labelCustomerCountry
            // 
            this.labelCustomerCountry.AutoSize = true;
            this.labelCustomerCountry.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerCountry.Location = new System.Drawing.Point(273, 223);
            this.labelCustomerCountry.Name = "labelCustomerCountry";
            this.labelCustomerCountry.Size = new System.Drawing.Size(71, 19);
            this.labelCustomerCountry.TabIndex = 5;
            this.labelCustomerCountry.Text = "Country:";
            // 
            // tbCustomerPhoneNumber
            // 
            this.tbCustomerPhoneNumber.Location = new System.Drawing.Point(350, 325);
            this.tbCustomerPhoneNumber.Name = "tbCustomerPhoneNumber";
            this.tbCustomerPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.tbCustomerPhoneNumber.TabIndex = 6;
            this.tbCustomerPhoneNumber.TextChanged += new System.EventHandler(this.tbCustomerPhoneNumber_TextChanged);
            // 
            // labelCustomerPhoneNumber
            // 
            this.labelCustomerPhoneNumber.AutoSize = true;
            this.labelCustomerPhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerPhoneNumber.Location = new System.Drawing.Point(223, 323);
            this.labelCustomerPhoneNumber.Name = "labelCustomerPhoneNumber";
            this.labelCustomerPhoneNumber.Size = new System.Drawing.Size(121, 19);
            this.labelCustomerPhoneNumber.TabIndex = 7;
            this.labelCustomerPhoneNumber.Text = "Phone Number:";
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Location = new System.Drawing.Point(350, 125);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(200, 20);
            this.tbCustomerAddress.TabIndex = 2;
            this.tbCustomerAddress.TextChanged += new System.EventHandler(this.tbCustomerAddress_TextChanged);
            // 
            // labelCustomerAddress
            // 
            this.labelCustomerAddress.AutoSize = true;
            this.labelCustomerAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerAddress.Location = new System.Drawing.Point(272, 123);
            this.labelCustomerAddress.Name = "labelCustomerAddress";
            this.labelCustomerAddress.Size = new System.Drawing.Size(72, 19);
            this.labelCustomerAddress.TabIndex = 9;
            this.labelCustomerAddress.Text = "Address:";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(350, 75);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(200, 20);
            this.tbCustomerName.TabIndex = 1;
            this.tbCustomerName.TextChanged += new System.EventHandler(this.tbCustomerName_TextChanged);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(288, 73);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(56, 19);
            this.labelCustomerName.TabIndex = 11;
            this.labelCustomerName.Text = "Name:";
            // 
            // buttonCustomerChange
            // 
            this.buttonCustomerChange.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerChange.Location = new System.Drawing.Point(250, 400);
            this.buttonCustomerChange.Name = "buttonCustomerChange";
            this.buttonCustomerChange.Size = new System.Drawing.Size(150, 30);
            this.buttonCustomerChange.TabIndex = 7;
            this.buttonCustomerChange.Text = "Add";
            this.buttonCustomerChange.UseVisualStyleBackColor = true;
            this.buttonCustomerChange.Click += new System.EventHandler(this.buttonCustomerChange_Click);
            // 
            // buttonCustomerCancel
            // 
            this.buttonCustomerCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerCancel.Location = new System.Drawing.Point(450, 400);
            this.buttonCustomerCancel.Name = "buttonCustomerCancel";
            this.buttonCustomerCancel.Size = new System.Drawing.Size(150, 30);
            this.buttonCustomerCancel.TabIndex = 8;
            this.buttonCustomerCancel.Text = "Cancel";
            this.buttonCustomerCancel.UseVisualStyleBackColor = true;
            this.buttonCustomerCancel.Click += new System.EventHandler(this.buttonCustomerCancel_Click);
            // 
            // tbCustomerZipCode
            // 
            this.tbCustomerZipCode.Location = new System.Drawing.Point(350, 275);
            this.tbCustomerZipCode.Name = "tbCustomerZipCode";
            this.tbCustomerZipCode.Size = new System.Drawing.Size(115, 20);
            this.tbCustomerZipCode.TabIndex = 5;
            this.tbCustomerZipCode.TextChanged += new System.EventHandler(this.tbCustomerZipCode_TextChanged);
            // 
            // labelCustomerZipCode
            // 
            this.labelCustomerZipCode.AutoSize = true;
            this.labelCustomerZipCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerZipCode.Location = new System.Drawing.Point(266, 273);
            this.labelCustomerZipCode.Name = "labelCustomerZipCode";
            this.labelCustomerZipCode.Size = new System.Drawing.Size(78, 19);
            this.labelCustomerZipCode.TabIndex = 13;
            this.labelCustomerZipCode.Text = "Zip Code:";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCustomerZipCode);
            this.Controls.Add(this.labelCustomerZipCode);
            this.Controls.Add(this.buttonCustomerCancel);
            this.Controls.Add(this.buttonCustomerChange);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.tbCustomerAddress);
            this.Controls.Add(this.labelCustomerAddress);
            this.Controls.Add(this.tbCustomerPhoneNumber);
            this.Controls.Add(this.labelCustomerPhoneNumber);
            this.Controls.Add(this.tbCustomerCountry);
            this.Controls.Add(this.labelCustomerCountry);
            this.Controls.Add(this.labelCustomerHeading);
            this.Controls.Add(this.tbCustomerCity);
            this.Controls.Add(this.labelCustomerCity);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCustomerCity;
        private System.Windows.Forms.Label labelCustomerCity;
        private System.Windows.Forms.Label labelCustomerHeading;
        private System.Windows.Forms.TextBox tbCustomerCountry;
        private System.Windows.Forms.Label labelCustomerCountry;
        private System.Windows.Forms.TextBox tbCustomerPhoneNumber;
        private System.Windows.Forms.Label labelCustomerPhoneNumber;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.Label labelCustomerAddress;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Button buttonCustomerChange;
        private System.Windows.Forms.Button buttonCustomerCancel;
        private System.Windows.Forms.TextBox tbCustomerZipCode;
        private System.Windows.Forms.Label labelCustomerZipCode;
    }
}