using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StressCheck
{
    public static class NavigationHelper
    {
        private static readonly Stack<(Type ControlType, object Data)> History = new Stack<(Type, object)>();
        private static readonly Dictionary<Type, object> NavigationData = new Dictionary<Type, object>();

        public static void NavigateTo<T>(object data = null) where T : Control, new()
        {
            var controlType = typeof(T);
            var parentControl = GetMainPanel();
            var previousControl = parentControl.Controls.Count > 0 ? parentControl.Controls[0] : null;
            var currentControl = previousControl != null && previousControl.GetType() == controlType ?
                previousControl :
                CreateControl<T>(data);

            if (previousControl != null)
            {
                NavigationData[previousControl.GetType()] = previousControl.Tag;
                parentControl.Controls.Remove(previousControl);
            }

            if (data != null)
            {
                NavigationData[controlType] = data;
            }

            parentControl.Controls.Add(currentControl);
            History.Push((controlType, currentControl.Tag));
        }

        public static void NavigateBack()
        {
            if (History.Count > 1)
            {
                var (currentType, currentData) = History.Pop();
                NavigationData[currentType] = null;
                var (previousType, previousData) = History.Peek();
                var parentControl = GetMainPanel();
                parentControl.Controls.Clear();
                var previousControl = CreateControl(previousType, previousData);
                parentControl.Controls.Add(previousControl);
            }
        }

        public static T GetNavigationData<T>() where T : class
        {
            var controlType = typeof(T);
            if (NavigationData.ContainsKey(controlType))
            {
                var data = NavigationData[controlType];
                if (data is T result)
                {
                    return result;
                }
            }

            return null;
        }
        private static Panel GetMainPanel()
        {
            var mainForm = Application.OpenForms[0] as mainForm;
            if (mainForm == null)
            {
                throw new ArgumentException("MainForm is not open.");
            }

            return mainForm.MainPanel;
        }

        private static TControl CreateControl<TControl>(object data) where TControl : Control, new()
        {
            var control = new TControl();
            control.Dock = DockStyle.Fill;
            control.Tag = data;
            return control;
        }

        private static Control CreateControl(Type controlType, object data)
        {
            var control = Activator.CreateInstance(controlType) as Control;
            control.Dock = DockStyle.Fill;
            control.Tag = data;
            return control;
        }
    }
}

