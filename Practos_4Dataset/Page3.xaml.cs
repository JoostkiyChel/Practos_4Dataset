using Practos_4Dataset.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Practos_4Dataset
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        AddressesTableAdapter Addresses = new AddressesTableAdapter();
        public Page3()
        {
            InitializeComponent();
            datasetik.ItemsSource = Addresses.GetData();
            Combo_datasetik.ItemsSource = Addresses.GetData();
            Combo_datasetik.DisplayMemberPath = "City";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datasetik.ItemsSource = Addresses.GetData();
        }

        private void Combo_datasetik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Combo_datasetik.SelectedItem != null)
            {
                var id = (int)(Combo_datasetik.SelectedItem as DataRowView).Row[0];
                datasetik.ItemsSource = Addresses.FilterData(id);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            datasetik.ItemsSource = Addresses.GetDataBy(search.Text);
        }
    }
}
