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
using Practos_4Dataset.DataSet1TableAdapters;

namespace Practos_4Dataset
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        UsersTableAdapter users = new UsersTableAdapter();

        public Page1()
        {
            InitializeComponent();
            datasetik.ItemsSource = users.GetData();
            Combo_datasetik.ItemsSource = users.GetData();
            Combo_datasetik.DisplayMemberPath = "UserName";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datasetik.ItemsSource = users.GetData();
        }

        private void Combo_datasetik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Combo_datasetik.SelectedItem != null)
            {
                var id = (int)(Combo_datasetik.SelectedItem as DataRowView).Row[0];
                datasetik.ItemsSource = users.FilterData(id);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            datasetik.ItemsSource = users.GetDataBy(search.Text);
        }
    }
}
