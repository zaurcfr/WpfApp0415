using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp0415
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string sometext;
        public Car MyCar { get; set; }
        public ObservableCollection<Car> Cars { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public string SomeText
        {
            get { return sometext; }
            set
            {
                sometext = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            //SomeText = "text";

            //MyCar = new Car
            //{
            //    Model = "X5",
            //    Vendor = "BMW",
            //    Year = 2015
            //};

            Cars = new ObservableCollection<Car>
            {
                new Car
                {
                    Model = "X5",
                    Vendor = "BMW",
                    Year = 2015
                },
                new Car
                {
                    Model = "E200",
                    Vendor = "Mercedes",
                    Year = 2018
                },
                new Car
                {
                    Model = "525",
                    Vendor = "BMW",
                    Year = 2019
                },
                new Car
                {
                    Model = "Camaro",
                    Vendor = "Chevrolet",
                    Year = 2020
                },
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["PrimaryColor"] = Brushes.Goldenrod;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyCar.Model = "Best model";
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var car = new Car
            {
                Model = "Cruze",
                Vendor = "Chevrolet",
                Year = 2020
            };
            Cars.Add(car);
        }

        private void listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var info = new Info();
            info.InfoCar = (sender as ListBox).SelectedItem as Car;
            info.ShowDialog();
        }
    }


    public class Car : INotifyPropertyChanged
    {

        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                OnPropertyChanged();
            }
        }

        private string vendor;
        public string Vendor
        {
            get { return vendor; }
            set
            {
                vendor = value;
                OnPropertyChanged();
            }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                year = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }

}
