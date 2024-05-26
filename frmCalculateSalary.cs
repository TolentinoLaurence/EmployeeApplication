using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class EmployeeMain : Form
    {
        private PartTimeEmployee employee;
        public EmployeeMain()
        {
            InitializeComponent();
            employee = new PartTimeEmployee();
        }

        private void btCompute_Click(object sender, EventArgs e)
        {
            string lastname = txtLastName.Text;
            string firstname = txtFirstName.Text;

            employee.TotalHouseWorked = Convert.ToInt32(txtTotalHoursWorked.Text);
            employee.RatePerHour = Convert.ToDouble(txtRatePerHour.Text);

            double basicSalary = employee.ComputeSalary();

            lblFirstName.Text = firstname;
            lblLastName.Text = lastname;
            lblBasicSalary.Text = basicSalary.ToString();

            
        }
    }
}
