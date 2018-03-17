using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Lab2.ViewModels;

namespace Lab2
{
    class SideMenuView : UserControl
    {
        public int Prop { get; set; }

        public SideMenuView()
        {
            DataContext = new SideMenuViewModel();

            var stackPanel = new StackPanel();
            AddSortButton(stackPanel);
            AddSortPropertiesChooser(stackPanel);

            Content = stackPanel;
        }

        void AddSortButton(Panel stackPanel)
        {
            var sortButton = new Button
            {
                Width = 75,
                Height = 35,
                Content = "Sort",
                
            };

            stackPanel.Children.Add(sortButton);
        }

        void AddSortPropertiesChooser(Panel stackPanel)
        {
            var sortPropChooser = new ComboBox
            {
                ItemsSource = Enum.GetValues(typeof(PersonPropertyName)).Cast<PersonPropertyName>()
            };

            var b = new Binding();



            //MessageBox.Show(sortPropChooser.SelectedItem.ToString());
            //MessageBox.Show("\n\n" + sortPropChooser.SelectedValue);

            stackPanel.Children.Add(sortPropChooser);
        }
    }
}
