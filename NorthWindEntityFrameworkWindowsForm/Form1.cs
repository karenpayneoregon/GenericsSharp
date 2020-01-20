using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWindEntityFramework;
using WinFormsLanguageExtensions;
using GeneralExtensionMethods;

namespace NorthWindEntityFrameworkWindowsForm
{
    public partial class Form1 : Form
    {
        private EmployeesOperations<Employee> _employeesOperations = new EmployeesOperations<Employee>();
        private BindingSource _employeeBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            this.EnableButton(false);
            EmployeeSetup();
        }

        private async void EmployeeSetup()
        {
            EmployeeDataGridView.AutoGenerateColumns = false;

            IEnumerable<Employee> employees = await _employeesOperations.GetEmployeesAsync().ConfigureAwait(true);
            _employeeBindingSource.DataSource = employees.ToList();

            EmployeeDataGridView.InvokeIfRequired(d => { d.DataSource = _employeeBindingSource; });

            EmployeeDataGridView.Columns["idColumn"].Width = 30;
            EmployeeDataGridView.Columns["LastNameColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            EmployeeFirstNameTextBox.DataBindings.Add("Text", _employeeBindingSource, "FirstName");
            EmployeeLastNameTextBox.DataBindings.Add("Text", _employeeBindingSource, "LastName");

            EmployeesGroupBox.EnableButton();
        }
        /// <summary>
        /// Get current employee from table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetByEmployeeIdButton_Click(object sender, EventArgs e)
        {

            var employeeId = ((Employee)_employeeBindingSource.Current).EmployeeID;
            Employee employee = _employeesOperations.Edit(employeeId);
            MessageBox.Show($"ID: {employee.EmployeeID}\nBirthday: {employee.BirthDate.Value.Date:d}");

        }
        private void EmployeeUpdateButton_Click(object sender, EventArgs e)
        {
            var emp = ((Employee)_employeeBindingSource.Current);
            var employee = _employeesOperations.Edit(emp.EmployeeID);

            employee.FirstName = EmployeeFirstNameTextBox.Text;
            employee.LastName = EmployeeLastNameTextBox.Text;

            _employeesOperations.Edit(employee);


        }
        private void EmployeesDeleteButton_Click(object sender, EventArgs e)
        {

            var employeeId = ((Employee)_employeeBindingSource.Current).EmployeeID;
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
                BirthDate = new DateTime(2000, 1, 1)
            };

            _employeesOperations.Add(employee);

            var results = _employeesOperations.Save();

            if (results == 1)
            {
                ((List<Employee>)_employeeBindingSource.DataSource).Add(new Employee()
                {
                    EmployeeID = employee.EmployeeID,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName
                });

                _employeeBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("Save failed");
            }

        }
        /// <summary>
        /// Hard coded search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForButton_Click(object sender, EventArgs e)
        {
            var employees = _employeesOperations.SearchFor(emp => emp.Title == "Sales Representative" && emp.Country == "USA");
            var results = employees.Select(emp => $"{emp.SearchForInformation}").ToDelimitedString("\n");
            MessageBox.Show(results);

        }
    }
}
