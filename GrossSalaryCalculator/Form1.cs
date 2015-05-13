using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrossSalaryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void showMeSallyButton_Click(object sender, EventArgs e)
        {
            Salary employeeSalary = new Salary();
            employeeSalary.employeeName = employeeNameTextBox.Text;
            employeeSalary.employeeBasicSalary = Convert.ToDouble(basicSalaryTextBox.Text);
            employeeSalary.houseRent = Convert.ToDouble(houseRenTextBox.Text);
            employeeSalary.medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            MessageBox.Show("Gross Salary is =" + employeeSalary.CalculateSalary());
          
           
           employeeNameTextBox.Clear();
           basicSalaryTextBox.Clear();
           houseRenTextBox.Clear();
           medicalAllowanceTextBox.Clear();
        }
    }
}
