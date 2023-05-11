using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StressCheck.ScreenTransition
{
    public static class NavigationHelper
    {
        private static readonly ScreenManager ScreenManager = new ScreenManager();

        public static void RegisterScreen(string name, UserControl screen)
        {
            ScreenManager.RegisterScreen(name, screen);
        }

        public static void NavigateTo(string name, Control container)
        {
            ScreenManager.NavigateTo(name, container);
        }

        public static bool CanGoBack()
        {
            return ScreenManager.CanGoBack();
        }

        public static void GoBack(Control container)
        {
            ScreenManager.GoBack(container);
        }
    }
}
