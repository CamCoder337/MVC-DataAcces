using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Middleware;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CLprocessus _process;
        public MainWindow()
        {
            InitializeComponent();
            _process = new CLprocessus();
            Title = "Db CRUD App";
            Height = 600;
            Width = 800;
            Background = Brushes.Gainsboro;
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            // Liez le DataSet à votre DataGrid pour afficher les données.
            dataGrid.ItemsSource = _process.Display("users").Tables["users"].DefaultView;
        }
    }
}