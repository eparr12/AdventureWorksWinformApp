using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksWinformUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            if (Login.role != "Administrator")
            {
                addNonSalesEmployeeButton.Enabled = false;
                deleteEmployeeButton.Enabled = false;
                updateNonSalesEmployeeButton.Enabled= false;
            }

        }

        private void addNonSalesEmployee_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dashboardMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addNonSalesEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNonSalesEmployee form = new AddNonSalesEmployee();
            form.ShowDialog();
        }

        private void addNonSalesEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNonSalesEmployee form = new AddNonSalesEmployee();
            form.ShowDialog();
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEmployee form = new DeleteEmployee();
            form.ShowDialog();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEmployee form = new DeleteEmployee();
            form.ShowDialog();
        }

        private void employeeInformationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeInformation form = new employeeInformation();
            form.ShowDialog();
        }

        private void employeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeInformation form = new employeeInformation();
            form.ShowDialog();
        }

        private void employeeInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateNonSalesEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateNonSalesEmployee form = new UpdateNonSalesEmployee();
            form.ShowDialog();
        }

        private void updateNonSalesEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateNonSalesEmployee form = new UpdateNonSalesEmployee();
            form.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Login form = new Login();
                form.ShowDialog();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Login form = new Login();
                form.ShowDialog();
            }
        }
    }
}
