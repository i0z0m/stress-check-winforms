using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StressCheck.ScreenTransition
{
    public class NavigationHelper
    {
        public static void NavigateTo<T>(Control currentControl) where T : Control, new()
        {
            var targetControl = new T();
            currentControl.Controls.Clear();
            currentControl.Controls.Add(targetControl);
        }
    }
}
