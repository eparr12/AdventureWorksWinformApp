namespace AdventureWorksWinformUI
{
    partial class employeeInformation
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
            this.homeButton = new System.Windows.Forms.Button();
            this.addNonSalesEmployeeButton = new System.Windows.Forms.Button();
            this.employeeInformationLabel = new System.Windows.Forms.Label();
            this.employeeInformationListView = new System.Windows.Forms.ListView();
            this.personIDColumn = new System.Windows.Forms.ColumnHeader();
            this.personTypeColumn = new System.Windows.Forms.ColumnHeader();
            this.socialSecurityNumberColumn = new System.Windows.Forms.ColumnHeader();
            this.loginIdColumn = new System.Windows.Forms.ColumnHeader();
            this.employeeInformationComboBox = new System.Windows.Forms.ComboBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeInformationListView2 = new System.Windows.Forms.ListView();
            this.emailAddressColumn = new System.Windows.Forms.ColumnHeader();
            this.phoneNumberColumn = new System.Windows.Forms.ColumnHeader();
            this.phoneTypeColumn = new System.Windows.Forms.ColumnHeader();
            this.addressColumn = new System.Windows.Forms.ColumnHeader();
            this.employeeInformationListView3 = new System.Windows.Forms.ListView();
            this.cityColumn = new System.Windows.Forms.ColumnHeader();
            this.stateProvinceColumn = new System.Windows.Forms.ColumnHeader();
            this.postalCodeColumn = new System.Windows.Forms.ColumnHeader();
            this.countryColumn = new System.Windows.Forms.ColumnHeader();
            this.employeeInformationListView4 = new System.Windows.Forms.ListView();
            this.birthDateColumn = new System.Windows.Forms.ColumnHeader();
            this.maritalStatusColumn = new System.Windows.Forms.ColumnHeader();
            this.genderColumn = new System.Windows.Forms.ColumnHeader();
            this.lengthOfServiceColumn = new System.Windows.Forms.ColumnHeader();
            this.employeeInformationListView5 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.employeeInformationListView6 = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.employeeInformationListView7 = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(378, 778);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(257, 61);
            this.homeButton.TabIndex = 126;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // addNonSalesEmployeeButton
            // 
            this.addNonSalesEmployeeButton.Location = new System.Drawing.Point(378, 705);
            this.addNonSalesEmployeeButton.Name = "addNonSalesEmployeeButton";
            this.addNonSalesEmployeeButton.Size = new System.Drawing.Size(257, 61);
            this.addNonSalesEmployeeButton.TabIndex = 111;
            this.addNonSalesEmployeeButton.Text = "Submit";
            this.addNonSalesEmployeeButton.UseVisualStyleBackColor = true;
            this.addNonSalesEmployeeButton.Click += new System.EventHandler(this.addNonSalesEmployeeButton_Click);
            // 
            // employeeInformationLabel
            // 
            this.employeeInformationLabel.AutoSize = true;
            this.employeeInformationLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeInformationLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeInformationLabel.Location = new System.Drawing.Point(345, 16);
            this.employeeInformationLabel.Name = "employeeInformationLabel";
            this.employeeInformationLabel.Size = new System.Drawing.Size(365, 50);
            this.employeeInformationLabel.TabIndex = 66;
            this.employeeInformationLabel.Text = "Employee Information";
            // 
            // employeeInformationListView
            // 
            this.employeeInformationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.personIDColumn,
            this.personTypeColumn,
            this.socialSecurityNumberColumn,
            this.loginIdColumn});
            this.employeeInformationListView.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeInformationListView.GridLines = true;
            this.employeeInformationListView.Location = new System.Drawing.Point(26, 154);
            this.employeeInformationListView.Name = "employeeInformationListView";
            this.employeeInformationListView.Size = new System.Drawing.Size(957, 77);
            this.employeeInformationListView.TabIndex = 127;
            this.employeeInformationListView.UseCompatibleStateImageBehavior = false;
            this.employeeInformationListView.View = System.Windows.Forms.View.Details;
            // 
            // personIDColumn
            // 
            this.personIDColumn.Text = "PersonID";
            this.personIDColumn.Width = 100;
            // 
            // personTypeColumn
            // 
            this.personTypeColumn.Text = "Person Type";
            this.personTypeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.personTypeColumn.Width = 150;
            // 
            // socialSecurityNumberColumn
            // 
            this.socialSecurityNumberColumn.Text = "Social Security Number";
            this.socialSecurityNumberColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.socialSecurityNumberColumn.Width = 250;
            // 
            // loginIdColumn
            // 
            this.loginIdColumn.Text = "LoginID";
            this.loginIdColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginIdColumn.Width = 100;
            // 
            // employeeInformationComboBox
            // 
            this.employeeInformationComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.employeeInformationComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.employeeInformationComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.employeeInformationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeInformationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeInformationComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeInformationComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeInformationComboBox.FormattingEnabled = true;
            this.employeeInformationComboBox.Location = new System.Drawing.Point(517, 103);
            this.employeeInformationComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.employeeInformationComboBox.Name = "employeeInformationComboBox";
            this.employeeInformationComboBox.Size = new System.Drawing.Size(252, 33);
            this.employeeInformationComboBox.Sorted = true;
            this.employeeInformationComboBox.TabIndex = 129;
            this.employeeInformationComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeFullNameComboBox_SelectedIndexChanged);
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeNameLabel.Location = new System.Drawing.Point(286, 100);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(213, 31);
            this.employeeNameLabel.TabIndex = 128;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // employeeInformationListView2
            // 
            this.employeeInformationListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emailAddressColumn,
            this.phoneNumberColumn,
            this.phoneTypeColumn,
            this.addressColumn});
            this.employeeInformationListView2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeInformationListView2.GridLines = true;
            this.employeeInformationListView2.Location = new System.Drawing.Point(26, 228);
            this.employeeInformationListView2.Name = "employeeInformationListView2";
            this.employeeInformationListView2.Size = new System.Drawing.Size(957, 77);
            this.employeeInformationListView2.TabIndex = 130;
            this.employeeInformationListView2.UseCompatibleStateImageBehavior = false;
            this.employeeInformationListView2.View = System.Windows.Forms.View.Details;
            // 
            // emailAddressColumn
            // 
            this.emailAddressColumn.Text = "Email Address";
            this.emailAddressColumn.Width = 150;
            // 
            // phoneNumberColumn
            // 
            this.phoneNumberColumn.Text = "Phone Number";
            this.phoneNumberColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneNumberColumn.Width = 175;
            // 
            // phoneTypeColumn
            // 
            this.phoneTypeColumn.Text = "Phone Type";
            this.phoneTypeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneTypeColumn.Width = 130;
            // 
            // addressColumn
            // 
            this.addressColumn.Text = "Address";
            this.addressColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addressColumn.Width = 200;
            // 
            // employeeInformationListView3
            // 
            this.employeeInformationListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cityColumn,
            this.stateProvinceColumn,
            this.postalCodeColumn,
            this.countryColumn});
            this.employeeInformationListView3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeInformationListView3.GridLines = true;
            this.employeeInformationListView3.Location = new System.Drawing.Point(26, 302);
            this.employeeInformationListView3.Name = "employeeInformationListView3";
            this.employeeInformationListView3.Size = new System.Drawing.Size(957, 77);
            this.employeeInformationListView3.TabIndex = 131;
            this.employeeInformationListView3.UseCompatibleStateImageBehavior = false;
            this.employeeInformationListView3.View = System.Windows.Forms.View.Details;
            // 
            // cityColumn
            // 
            this.cityColumn.Text = "City";
            this.cityColumn.Width = 125;
            // 
            // stateProvinceColumn
            // 
            this.stateProvinceColumn.Text = "State/Province";
            this.stateProvinceColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stateProvinceColumn.Width = 200;
            // 
            // postalCodeColumn
            // 
            this.postalCodeColumn.Text = "Postal Code";
            this.postalCodeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postalCodeColumn.Width = 150;
            // 
            // countryColumn
            // 
            this.countryColumn.Text = "Country";
            this.countryColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countryColumn.Width = 100;
            // 
            // employeeInformationListView4
            // 
            this.employeeInformationListView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.birthDateColumn,
            this.maritalStatusColumn,
            this.genderColumn,
            this.lengthOfServiceColumn});
            this.employeeInformationListView4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeInformationListView4.GridLines = true;
            this.employeeInformationListView4.Location = new System.Drawing.Point(26, 376);
            this.employeeInformationListView4.Name = "employeeInformationListView4";
            this.employeeInformationListView4.Size = new System.Drawing.Size(957, 77);
            this.employeeInformationListView4.TabIndex = 132;
            this.employeeInformationListView4.UseCompatibleStateImageBehavior = false;
            this.employeeInformationListView4.View = System.Windows.Forms.View.Details;
            // 
            // birthDateColumn
            // 
            this.birthDateColumn.Text = "Birth Date";
            this.birthDateColumn.Width = 125;
            // 
            // maritalStatusColumn
            // 
            this.maritalStatusColumn.Text = "Marital Status";
            this.maritalStatusColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maritalStatusColumn.Width = 150;
            // 
            // genderColumn
            // 
            this.genderColumn.Text = "Gender";
            this.genderColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genderColumn.Width = 100;
            // 
            // lengthOfServiceColumn
            // 
            this.lengthOfServiceColumn.Text = "Length Of Service";
            this.lengthOfServiceColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lengthOfServiceColumn.Width = 200;
            // 
            // employeeInformationListView5
            // 
            this.employeeInformationListView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.employeeInformationListView5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeInformationListView5.GridLines = true;
            this.employeeInformationListView5.Location = new System.Drawing.Point(26, 450);
            this.employeeInformationListView5.Name = "employeeInformationListView5";
            this.employeeInformationListView5.Size = new System.Drawing.Size(957, 77);
            this.employeeInformationListView5.TabIndex = 133;
            this.employeeInformationListView5.UseCompatibleStateImageBehavior = false;
            this.employeeInformationListView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Job Group";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Job Department";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Job Title";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Shift Number";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 175;
            // 
            // employeeInformationListView6
            // 
            this.employeeInformationListView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.employeeInformationListView6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeInformationListView6.GridLines = true;
            this.employeeInformationListView6.Location = new System.Drawing.Point(26, 524);
            this.employeeInformationListView6.Name = "employeeInformationListView6";
            this.employeeInformationListView6.Size = new System.Drawing.Size(957, 77);
            this.employeeInformationListView6.TabIndex = 134;
            this.employeeInformationListView6.UseCompatibleStateImageBehavior = false;
            this.employeeInformationListView6.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Shift Name";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hourly Rate";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pay Frequency";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Vacation Hours";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 175;
            // 
            // employeeInformationListView7
            // 
            this.employeeInformationListView7.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.employeeInformationListView7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeInformationListView7.GridLines = true;
            this.employeeInformationListView7.Location = new System.Drawing.Point(26, 598);
            this.employeeInformationListView7.Name = "employeeInformationListView7";
            this.employeeInformationListView7.Size = new System.Drawing.Size(957, 77);
            this.employeeInformationListView7.TabIndex = 135;
            this.employeeInformationListView7.UseCompatibleStateImageBehavior = false;
            this.employeeInformationListView7.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Sick Leave Hours";
            this.columnHeader9.Width = 170;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Sales Territory";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 175;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Currency";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 125;
            // 
            // employeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 854);
            this.Controls.Add(this.employeeInformationListView7);
            this.Controls.Add(this.employeeInformationListView6);
            this.Controls.Add(this.employeeInformationListView5);
            this.Controls.Add(this.employeeInformationListView4);
            this.Controls.Add(this.employeeInformationListView3);
            this.Controls.Add(this.employeeInformationListView2);
            this.Controls.Add(this.employeeInformationComboBox);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.employeeInformationListView);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.addNonSalesEmployeeButton);
            this.Controls.Add(this.employeeInformationLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "employeeInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button homeButton;
        private Button addNonSalesEmployeeButton;
        private Label employeeInformationLabel;
        private ListView employeeInformationListView;
        private ComboBox employeeInformationComboBox;
        private Label employeeNameLabel;
        private ColumnHeader personIDColumn;
        private ColumnHeader personTypeColumn;
        private ColumnHeader socialSecurityNumberColumn;
        private ColumnHeader loginIdColumn;
        private ListView employeeInformationListView2;
        private ColumnHeader emailAddressColumn;
        private ColumnHeader phoneNumberColumn;
        private ColumnHeader phoneTypeColumn;
        private ColumnHeader addressColumn;
        private ListView employeeInformationListView3;
        private ColumnHeader cityColumn;
        private ColumnHeader stateProvinceColumn;
        private ColumnHeader postalCodeColumn;
        private ColumnHeader countryColumn;
        private ListView employeeInformationListView4;
        private ColumnHeader birthDateColumn;
        private ColumnHeader maritalStatusColumn;
        private ColumnHeader genderColumn;
        private ColumnHeader lengthOfServiceColumn;
        private ListView employeeInformationListView5;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView employeeInformationListView6;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView employeeInformationListView7;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}