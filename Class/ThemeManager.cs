using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISManager.Class
{
    public static class ThemeManager
    {
        public static void ApplyDarkTheme(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl.HasChildren)
                {
                    ApplyDarkTheme(childControl);
                }

                ApplyDarkThemeToControl(childControl);
            }
        }

        private static void ApplyDarkThemeToControl(Control control)
        {
            if (control is TextBox)
            {
                TextBox textBox = (TextBox)control;
                // Altere as propriedades do TextBox
                textBox.BackColor = Color.FromArgb(25, 25, 25);
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.ForeColor = Color.White;
            }
            else if (control is Panel)
            {
                Panel panel = (Panel)control;
                // Altere as propriedades do Panel
                panel.BackColor = Color.FromArgb(25, 25, 25);
            }
            else if (control is ComboBox)
            {
                ComboBox comboBox = (ComboBox)control;
                // Altere as propriedades do form
                comboBox.BackColor = Color.FromArgb(25, 25, 25);
                comboBox.ForeColor = Color.White;
            }
            else if (control is Label)
            {
                Label label = (Label)control;
                // Altere as propriedades do label
                label.ForeColor = Color.White;
               //label.BackColor = Color.FromArgb(25, 25, 25);
                label.BackColor = Color.Transparent;
            }
            else if (control is GroupBox)
            {
                GroupBox groupBox = (GroupBox)control;
                // Altere as propriedades do label
                groupBox.ForeColor = Color.White;
            }
            else if (control is CheckBox)
            {
                CheckBox checkBox = (CheckBox)control;
                // Altere as propriedades do label
                checkBox.ForeColor = Color.White;
            }

        }

    }
}
