using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWindEntityFramework;

namespace NorthWindEntityFrameworkWindowsForm
{
    public partial class Form1 : Form
    {
        private EmployeesOperations _employeesOperations = new EmployeesOperations();
        private BindingSource _employeeBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            EmployeeSetup();
        }

        private async void EmployeeSetup()
        {
            var employees = await _employeesOperations.GetEmployeesAsync().ConfigureAwait(true);
            _employeeBindingSource.DataSource = employees.ToList();
            EmployeeDataGridView.Invoke((MethodInvoker)(() => EmployeeDataGridView.DataSource = _employeeBindingSource));

            EmployeeDataGridView.Columns["id"].Width = 30;
            EmployeeDataGridView.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeDataGridView.Columns["FullName"].HeaderText = "Name";

            EmployeesInsertButton.Enabled = true;
            EmployeesDeleteButton.Enabled = true;

        }

        private void EmployeesDeleteButton_Click(object sender, EventArgs e)
        {

            var employeeId = ((EmployeeDto) _employeeBindingSource.Current).Id;
           
            var result = _employeesOperations.Delete(employeeId);
            if (result)
            {
                _employeeBindingSource.RemoveCurrent();
            }
            else
            {
                MessageBox.Show("Not deleted");
            }

        }
        /// <summary>
        /// Insert new employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeesInsertButton_Click(object sender, EventArgs e)
        {

            var employee = new Employee()
            {
                FirstName = "Karen",
                LastName = "Payne",
                BirthDate = new DateTime(2000,1,1)
            };

            _employeesOperations.Add(employee);

            var results = _employeesOperations.Save();

            if (results == 1)
            {
                ((List<EmployeeDto>)_employeeBindingSource.DataSource).Add(new EmployeeDto() {Id = employee.EmployeeID, FullName = $"{employee.FirstName} {employee.LastName}"});
                _employeeBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Save failed");
            }
            
        }
    }
}
