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
using Films._1;

namespace Films
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DBFilmsContext dbFilmsContext = new DBFilmsContext();
        public MainWindow()
        {
            InitializeComponent();

            DataGrid_Films.ItemsSource = ConclusionDataGrid.GridData();
            ComboBox.ItemsSource = ConclusionDataGrid.ComboBox();
        }

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox.SelectedItem == null)
            {
                return;
            }

            var selectComboBox = ComboBox.SelectedItem as Genre;
            DataGrid_Films.ItemsSource = Selection.SelectionComboBox(selectComboBox);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            DataGrid_Films.ItemsSource = ConclusionDataGrid.GridData();
            ComboBox.ItemsSource = null;
            ComboBox.ItemsSource = ConclusionDataGrid.ComboBox();
        }
        
        private void Click_Yes(object sender, RoutedEventArgs e)
        {

            var selectFilm = DataGrid_Films.SelectedItem as Movie;
            DataGrid_Films.ItemsSource = ChangeStatus.ChangeStatusYes(selectFilm);
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            DataGrid_Films.ItemsSource = Search.SearchText(TextBox.Text);

        }
    }
}
