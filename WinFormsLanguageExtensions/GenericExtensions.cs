using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLanguageExtensions
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Get a collection of a specific type of control from a control or form.
        /// </summary>
        /// <typeparam name="T">Type of control</typeparam>
        /// <param name="control">Control to traverse</param>
        /// <returns>IEnumerable of T</returns>
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                T thisControl = child as T;
                if (thisControl != null)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
        public static void EnableButton(this Control control, bool value = true) 
        {
            control.ButtonList().ForEach(button => button.Enabled = value);
            
        }
        public static List<TextBox> TextBoxList(this Control control) => control.Descendants<TextBox>().ToList();
        public static List<Label> LabelList(this Control control) => control.Descendants<Label>().ToList();
        public static List<DataGridView> DataGridViewList(this Control control) => control.Descendants<DataGridView>().ToList();
        public static List<ListView> ListViewViewList(this Control control) => control.Descendants<ListView>().ToList();
        public static List<CheckBox> CheckBoxList(this Control control) => control.Descendants<CheckBox>().ToList();
        public static List<ComboBox> ComboBoxList(this Control control) => control.Descendants<ComboBox>().ToList();
        public static List<ListBox> ListBoxList(this Control control) => control.Descendants<ListBox>().ToList();
        public static List<DateTimePicker> DateTimePickerList(this Control control) => control.Descendants<DateTimePicker>().ToList();
        public static List<PictureBox> PictureBoxList(this Control control) => control.Descendants<PictureBox>().ToList();
        public static List<Panel> PanelList(this Control control) => control.Descendants<Panel>().ToList();
        public static List<GroupBox> GroupBoxList(this Control control) => control.Descendants<GroupBox>().ToList();
        public static List<Button> ButtonList(this Control control) => control.Descendants<Button>().ToList();
        public static List<RadioButton> RadioButtonList(this Control control) => control.Descendants<RadioButton>().ToList();
        public static List<NumericUpDown> NumericUpDownList(this Control control) => control.Descendants<NumericUpDown>().ToList();
        public static RadioButton RadioButtonChecked(this Control control, bool pChecked = true) =>
            control.Descendants<RadioButton>().ToList()
                .FirstOrDefault((radioButton) => radioButton.Checked == pChecked);
        public static string[] ControlNames(this IEnumerable<Control> controls) => controls.Select((control) => control.Name).ToArray();
    }
}
