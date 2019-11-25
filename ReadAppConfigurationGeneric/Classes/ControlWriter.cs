using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadAppConfigurationGeneric.Classes
{
    public class ControlWriter : TextWriter
    {
        private Control _textbox;
        public ControlWriter(Control textbox)
        {
            _textbox = textbox;
        }
        public override void Write(char value)
        {
            _textbox.Text += value.ToString();
        }
        public override void Write(string value)
        {
            _textbox.Text += value;
        }
        public override Encoding Encoding => Encoding.ASCII;
    }
}
