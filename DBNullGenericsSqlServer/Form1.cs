using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBNullGenericsSqlServer.Classes;

namespace DBNullGenericsSqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadTableWithNullsNoAssertionsButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = null;

            var operations = new SqlOperations();
            var (records, errorList) = operations.ReadTableConventionalNoAssertions();

            if (records.Any())
            {
                textBox1.AppendText($"Good records out of 50, {records.Count}\n");
            }

            if (errorList.Count >0)
            {
                textBox1.AppendText("Issues\n");
                foreach (var errorMessage in errorList)
                {
                    textBox1.AppendText(errorMessage + "\n");
                }
            }
        }

        private void ReadNullsWithInlineNullAssertsButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            var operations = new SqlOperations();
            var (records, errorList) = operations.ReadTableWithAssertions();

            if (records.Any())
            {
                textBox1.AppendText($"Good records out of 50, {records.Count}\n");
                dataGridView1.DataSource = records;
            }

            if (errorList.Count > 0)
            {
                textBox1.AppendText("Issues\n");
                foreach (var errorMessage in errorList)
                {
                    textBox1.AppendText(errorMessage + "\n");
                }
            }
        }

        private void ReadWithNullsUsingGenericsButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = null;

            var operations = new SqlOperations();
            var (records, errorList) = operations.ReadTableWithGenerics();

            if (records.Any())
            {
                textBox1.AppendText($"Good records out of 50, {records.Count}\n");
                dataGridView1.DataSource = records;
            }

            if (errorList.Count > 0)
            {
                textBox1.AppendText("Issues\n");
                foreach (var errorMessage in errorList)
                {
                    textBox1.AppendText(errorMessage + "\n");
                }
            }
        }

        private async void ReadWithNullsUsingGenericExtensionButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = null;

            var operations = new SqlOperations();
            var (records, errorList) = await operations.ReadTableWithGenericsExtensionsAsync();

            if (records.Any())
            {
                textBox1.AppendText($"Good records out of 50, {records.Count}\n");
                dataGridView1.DataSource = records;
            }

            if (errorList.Count > 0)
            {
                textBox1.AppendText("Issues\n");
                foreach (var errorMessage in errorList)
                {
                    textBox1.AppendText(errorMessage + "\n");
                }
            }
        }

        private void ReaderToGenericListButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = null;

            var operations = new SqlOperations();

            dataGridView1.DataSource = operations.ReaderToList();

        }
    }
}
