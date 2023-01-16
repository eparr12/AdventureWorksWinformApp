namespace AdventureWorksWinformUI
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNonSalesEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateNonSalesEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNonSalesEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.employeeInformationButton = new System.Windows.Forms.Button();
            this.adventureWorksLabel = new System.Windows.Forms.Label();
            this.updateNonSalesEmployeeButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Adventure Works";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNonSalesEmployeeToolStripMenuItem,
            this.employeeInformationToolStripMenuItem,
            this.updateNonSalesEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.employeesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.DodgerBlue;
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(130, 34);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // addNonSalesEmployeeToolStripMenuItem
            // 
            this.addNonSalesEmployeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNonSalesEmployeeToolStripMenuItem.Name = "addNonSalesEmployeeToolStripMenuItem";
            this.addNonSalesEmployeeToolStripMenuItem.Size = new System.Drawing.Size(364, 34);
            this.addNonSalesEmployeeToolStripMenuItem.Text = "Add Non-Sales Employee";
            this.addNonSalesEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNonSalesEmployeeToolStripMenuItem_Click);
            // 
            // employeeInformationToolStripMenuItem
            // 
            this.employeeInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(364, 34);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";
            this.employeeInformationToolStripMenuItem.Click += new System.EventHandler(this.employeeInformationToolStripMenuItem_Click);
            // 
            // updateNonSalesEmployeeToolStripMenuItem
            // 
            this.updateNonSalesEmployeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateNonSalesEmployeeToolStripMenuItem.Name = "updateNonSalesEmployeeToolStripMenuItem";
            this.updateNonSalesEmployeeToolStripMenuItem.Size = new System.Drawing.Size(364, 34);
            this.updateNonSalesEmployeeToolStripMenuItem.Text = "Update Non-Sales Employee";
            this.updateNonSalesEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateNonSalesEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(364, 34);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(93, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // addNonSalesEmployeeButton
            // 
            this.addNonSalesEmployeeButton.Location = new System.Drawing.Point(88, 150);
            this.addNonSalesEmployeeButton.Name = "addNonSalesEmployeeButton";
            this.addNonSalesEmployeeButton.Size = new System.Drawing.Size(239, 84);
            this.addNonSalesEmployeeButton.TabIndex = 1;
            this.addNonSalesEmployeeButton.Text = "Add Non-Sales Employee";
            this.addNonSalesEmployeeButton.UseVisualStyleBackColor = true;
            this.addNonSalesEmployeeButton.Click += new System.EventHandler(this.addNonSalesEmployeeButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(406, 287);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(239, 84);
            this.deleteEmployeeButton.TabIndex = 2;
            this.deleteEmployeeButton.Text = "Delete Employee";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // employeeInformationButton
            // 
            this.employeeInformationButton.Location = new System.Drawing.Point(406, 150);
            this.employeeInformationButton.Name = "employeeInformationButton";
            this.employeeInformationButton.Size = new System.Drawing.Size(239, 84);
            this.employeeInformationButton.TabIndex = 3;
            this.employeeInformationButton.Text = "Employee Information";
            this.employeeInformationButton.UseVisualStyleBackColor = true;
            this.employeeInformationButton.Click += new System.EventHandler(this.employeeInformationButton_Click);
            // 
            // adventureWorksLabel
            // 
            this.adventureWorksLabel.AutoSize = true;
            this.adventureWorksLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adventureWorksLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.adventureWorksLabel.Location = new System.Drawing.Point(222, 61);
            this.adventureWorksLabel.Name = "adventureWorksLabel";
            this.adventureWorksLabel.Size = new System.Drawing.Size(288, 50);
            this.adventureWorksLabel.TabIndex = 67;
            this.adventureWorksLabel.Text = "Adventure Works";
            this.adventureWorksLabel.Click += new System.EventHandler(this.employeeInformationLabel_Click);
            // 
            // updateNonSalesEmployeeButton
            // 
            this.updateNonSalesEmployeeButton.Location = new System.Drawing.Point(88, 287);
            this.updateNonSalesEmployeeButton.Name = "updateNonSalesEmployeeButton";
            this.updateNonSalesEmployeeButton.Size = new System.Drawing.Size(239, 84);
            this.updateNonSalesEmployeeButton.TabIndex = 68;
            this.updateNonSalesEmployeeButton.Text = "Update Non-Sales Employee";
            this.updateNonSalesEmployeeButton.UseVisualStyleBackColor = true;
            this.updateNonSalesEmployeeButton.Click += new System.EventHandler(this.updateNonSalesEmployee_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(247, 419);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(239, 84);
            this.logoutButton.TabIndex = 69;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 527);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.updateNonSalesEmployeeButton);
            this.Controls.Add(this.adventureWorksLabel);
            this.Controls.Add(this.employeeInformationButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.addNonSalesEmployeeButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem addNonSalesEmployeeToolStripMenuItem;
        private Button addNonSalesEmployeeButton;
        private ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private Button deleteEmployeeButton;
        private ToolStripMenuItem employeeInformationToolStripMenuItem;
        private Button employeeInformationButton;
        private Label adventureWorksLabel;
        private ToolStripMenuItem updateNonSalesEmployeeToolStripMenuItem;
        private Button updateNonSalesEmployeeButton;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Button logoutButton;
    }
}