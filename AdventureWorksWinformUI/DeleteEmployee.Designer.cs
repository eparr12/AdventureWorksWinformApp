namespace AdventureWorksWinformUI
{
    partial class DeleteEmployee
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
            this.deleteEmployeeLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeFullNameComboBox = new System.Windows.Forms.ComboBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteEmployeeLabel
            // 
            this.deleteEmployeeLabel.AutoSize = true;
            this.deleteEmployeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteEmployeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteEmployeeLabel.Location = new System.Drawing.Point(199, 9);
            this.deleteEmployeeLabel.Name = "deleteEmployeeLabel";
            this.deleteEmployeeLabel.Size = new System.Drawing.Size(287, 50);
            this.deleteEmployeeLabel.TabIndex = 2;
            this.deleteEmployeeLabel.Text = "Delete Employee";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeNameLabel.Location = new System.Drawing.Point(107, 113);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(213, 31);
            this.employeeNameLabel.TabIndex = 9;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // employeeFullNameComboBox
            // 
            this.employeeFullNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.employeeFullNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.employeeFullNameComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.employeeFullNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeFullNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeFullNameComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeFullNameComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeFullNameComboBox.FormattingEnabled = true;
            this.employeeFullNameComboBox.Location = new System.Drawing.Point(338, 116);
            this.employeeFullNameComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.employeeFullNameComboBox.Name = "employeeFullNameComboBox";
            this.employeeFullNameComboBox.Size = new System.Drawing.Size(252, 33);
            this.employeeFullNameComboBox.Sorted = true;
            this.employeeFullNameComboBox.TabIndex = 12;
            this.employeeFullNameComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeFullNameComboBox_SelectedIndexChanged);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(199, 273);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(257, 61);
            this.homeButton.TabIndex = 67;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(199, 200);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(257, 61);
            this.deleteEmployeeButton.TabIndex = 66;
            this.deleteEmployeeButton.Text = "Submit";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 358);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.employeeFullNameComboBox);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.deleteEmployeeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "DeleteEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label deleteEmployeeLabel;
        private Label employeeNameLabel;
        private ComboBox employeeFullNameComboBox;
        private Button homeButton;
        private Button deleteEmployeeButton;
    }
}