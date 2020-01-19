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
            this.EnableButton(false);
            EmployeeSetup();
        }

        private async void EmployeeSetup()
        {
            EmployeeDataGridView.AutoGenerateColumns = false;

            var employees = await _employeesOperations.GetEmployeesAsync().ConfigureAwait(true);
            _employeeBindingSource.DataSource = employees.ToList();

            EmployeeDataGridView.InvokeIfRequired(d => { d.DataSource = _employeeBindingSource; });

            EmployeeDataGridView.Columns["idColumn"].Width = 30;
            EmployeeDataGridView.Columns["FullNameColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeDataGridView.Columns["FullNameColumn"].HeaderText = "Name";

            EmployeeFirstNameTextBox.DataBindings.Add("Text", _employeeBindingSource, "FirstName");
            EmployeeLastNameTextBox.DataBindings.Add("Text", _employeeBindingSource, "LastName");

            EmployeesGroupBox.EnableButton();
        }

        private void GetByEmployeeIdButton_Click(object sender, EventArgs e)
        {
            var employeeId = ((EmployeeDto)_employeeBindingSource.Current).Id;
            var employee = _employeesOperations.Edit(employeeId);
            Console.WriteLine();

        }
        private void EmployeeUpdateButton_Click(object sender, EventArgs e)
        {
            var empDto = ((EmployeeDto)_employeeBindingSource.Current);
            var employee = _employeesOperations.Edit(empDto.Id);
            employee.FirstName = EmployeeFirstNameTextBox.Text;
            employee.LastName = EmployeeLastNameTextBox.Text;
            _employeesOperations.Edit(employee);

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
                ((List<EmployeeDto>)_employeeBindingSource.DataSource).Add(new EmployeeDto()
                {
                    Id = employee.EmployeeID,
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


    }
}
