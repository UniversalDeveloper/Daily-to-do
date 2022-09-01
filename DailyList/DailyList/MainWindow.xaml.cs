using DailyList.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DailyList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<DataModelOfDailyList> containerForListCases;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dgToDoList_Loaded(object sender, RoutedEventArgs e)// here will be loaded tascs from file created before
        {
            containerForListCases = new BindingList<DataModelOfDailyList>()
            {
                new DataModelOfDailyList() { TextOfTasc= "kmfksfk" },
                new DataModelOfDailyList() { TextOfTasc = "sffsfd" }
            };
            dgToDoList.ItemsSource = containerForListCases;// create link of our containerList with vive of Window forme

        }
    }
}
