using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ExcelOleDbDataAdapter
{
    public partial class Form1 : Form
    {
        private string _fileName = Path.Combine(Application.StartupPath, "File1.xls");
        private OleDbConnection _excelConnection = new OleDbConnection();
        private DataSet _dataSet1 = new DataSet();
        private OleDbDataAdapter _excelAdapter = new OleDbDataAdapter();
        private BindingSource _bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            
            Shown += Form1_Shown;
            _bindingSource.PositionChanged += _bindingSource_PositionChanged;
        }

        private void _bindingSource_PositionChanged(object sender, EventArgs e)
        {
            var dataRow = ((DataRowView)_bindingSource.Current).Row;
            if (string.IsNullOrWhiteSpace(dataRow.Field<string>("FirstName")) || string.IsNullOrWhiteSpace(dataRow.Field<string>("LastName")))
            {
                UpdateButton.Enabled = false;
            }
            else
            {
                UpdateButton.Enabled = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _excelConnection.SetExcelConnectionString(
                _fileName, 
                ExcelExtensions.UseHeader.Yes, 
                ExcelExtensions.ExcelImex.TryScan);

            var cmd = new OleDbCommand("SELECT Firstname, Lastname FROM [Sheet1$]", _excelConnection);
            _excelAdapter.SelectCommand = cmd;
            _excelConnection.Open();
            _excelAdapter.Fill(_dataSet1, "Sheet1");
            _bindingSource.DataSource = _dataSet1.Tables[0];
            dataGridView1.DataSource = _bindingSource;

            _excelAdapter.UpdateCommand = new OleDbCommand
            {
                CommandText = "UPDATE [Sheet1$] " +
                              "SET FirstName=@P1, LastName = @P2 " +
                              "WHERE FirstName=@P3 AND LastName = @P4",





                Connection = _excelConnection, CommandType = CommandType.StoredProcedure
            };

            
            _excelAdapter.UpdateCommand.Parameters.Add(new OleDbParameter
            {
                ParameterName = "@P1",
                OleDbType = OleDbType.WChar
            });

            _excelAdapter.UpdateCommand.Parameters.Add(new OleDbParameter
            {
                ParameterName = "@P2",
                OleDbType = OleDbType.WChar
            });

            _excelAdapter.UpdateCommand.Parameters.Add(new OleDbParameter
            {
                ParameterName = "@P3",
                OleDbType = OleDbType.WChar
            });

            _excelAdapter.UpdateCommand.Parameters.Add(new OleDbParameter
            {
                ParameterName = "@P4",
                OleDbType = OleDbType.WChar
            });

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var dataRow = ((DataRowView) _bindingSource.Current).Row;

            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                MessageBox.Show("Need values");
                return;
            }

            _excelAdapter.UpdateCommand.Parameters[0].Value = dataRow.Field<string>("FirstName");
            _excelAdapter.UpdateCommand.Parameters[1].Value = dataRow.Field<string>("LastName");
            _excelAdapter.UpdateCommand.Parameters[2].Value = FirstNameTextBox.Text;
            _excelAdapter.UpdateCommand.Parameters[3].Value = LastNameTextBox.Text;

            var affected = _excelAdapter.UpdateCommand.ExecuteNonQuery();

            if (affected == 1)
            {
                dataRow.SetField("FirstName", FirstNameTextBox.Text);
                dataRow.SetField("LastName", LastNameTextBox.Text);
            }
            else if (affected > 1)
            {
                /*
                 * Very easy for this to happen
                 */
                MessageBox.Show("More than one row has been updated, was this expected?");
            }
            else
            {
                MessageBox.Show("Nothing updated");
            }

        }
    }
}
