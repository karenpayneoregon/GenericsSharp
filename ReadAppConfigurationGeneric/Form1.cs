using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadAppConfigurationGeneric.Classes;

namespace ReadAppConfigurationGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.SetOut(new ControlWriter(textBox1));
        }

        private void GetStringButton_Click(object sender, EventArgs e)
        {
            var testModeConventional = ConfigurationManager.AppSettings["DatabaseServer"];
            Console.WriteLine($"Get TestMode conventional: {testModeConventional}");

            var databaseServerWrapper = AppConfiguration.DatabaseServer;
            Console.WriteLine($"Get Wrapper: {databaseServerWrapper}");

            var databaseServerGeneric = AppConfiguration.ConfigSetting<string>("DatabaseServer");
            Console.WriteLine($"Get generic: {databaseServerGeneric}");

        }

        private void GetBoolButton_Click(object sender, EventArgs e)
        {
            // conventional access to a setting
            var testModeConventional = Convert.ToBoolean(ConfigurationManager.AppSettings["TestMode"]);
            Console.WriteLine($"Get TestMode conventional: {testModeConventional}");

            // generic access to a setting
            var testModeGeneric1 = AppConfiguration.ConfigSetting<bool>("TestMode");
            Console.WriteLine($"Get TestMode generic: {testModeGeneric1}");

            // generic access to a setting with wrapper
            var testModeGeneric2 = AppConfiguration.TestMode;
            Console.WriteLine($"Get TestMode generic wrapper: {testModeGeneric2}");

            var testModeGeneric3 = AppConfiguration.TestMode1;
            Console.WriteLine(testModeGeneric3);
        }

        private void GetTimeSpanButton_Click(object sender, EventArgs e)
        {
            var backupTime = TimeSpan.Parse(ConfigurationManager.AppSettings["BackupTime"]);
            Console.WriteLine($"TimeSpan.Parse: {backupTime}");

            var testModeGeneric1 = AppConfiguration.GetConfigSetting<TimeSpan>("BackupTime");
            Console.WriteLine($"GetConfigSetting: {testModeGeneric1}");

            try
            {
                var testModeGeneric2 = AppConfiguration.ConfigSetting<TimeSpan>("BackupTime");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var anotherTest = AppConfiguration.ConvertOrDefault<TimeSpan>(ConfigurationManager.AppSettings["BackupTime"]);
                Console.WriteLine(anotherTest);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void GetAlertDateButton_Click(object sender, EventArgs e)
        {
            var alertDate1 = Convert.ToDateTime(ConfigurationManager.AppSettings["AlertDate"]);
            Console.WriteLine($"Convert.ToDateTime: {alertDate1:d}");

            var alertDate2 = AppConfiguration.GetConfigSetting<DateTime>("AlertDate");
            Console.WriteLine($"GetConfigSetting: {alertDate2:d}");

            var anotherTest = AppConfiguration.ConvertOrDefault<TimeSpan>(ConfigurationManager.AppSettings["AlertDate1"]);
            Console.WriteLine(anotherTest);

        }


    }
}
