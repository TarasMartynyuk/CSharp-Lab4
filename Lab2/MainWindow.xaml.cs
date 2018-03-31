using System.Windows;
using System.Windows.Controls;
using Lab2.ViewModels;

namespace Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PersonsGrid.DataContext = new PersonListViewModel();

            var sideMenu = new SideMenuView();
            Grid.SetColumn(sideMenu, 9);
            MainGrid.Children.Add(sideMenu);
        }
    }
}
