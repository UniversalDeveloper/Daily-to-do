using DailyList.DataModel;
using DailyList.DataSaving;
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
        private FileIOService fileIOService;
        private readonly string PATH = $"{Environment.CurrentDirectory}.\\DalyDataList.json";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dgToDoList_Loaded(object sender, RoutedEventArgs e)// here will be loaded tascs from file created before
        {
            fileIOService = new FileIOService(PATH);
            try
            {
                containerForListCases = fileIOService.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                
            }
            

            dgToDoList.ItemsSource = containerForListCases;// create link of our containerList with vive of Window forme
            containerForListCases.ListChanged += ContainerForListCases_ListChanged;


        }

        private void ContainerForListCases_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged) 
            { }
            
            }
        }
    }
}
