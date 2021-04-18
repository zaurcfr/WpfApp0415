﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfApp0415
{
    /// <summary>
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class Info : Window //, INotifyPropertyChanged
    {
        //private Car car;

        //public event PropertyChangedEventHandler PropertyChanged;
        //protected void OnPropertyChanged([CallerMemberName] string name = null)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(name));
        //    }
        //}

        //public Car InfoCar { get { return car; } set { car = value; OnPropertyChanged(); } }




        public Car Car
        {
            get { return (Car)GetValue(CarProperty); }
            set { SetValue(CarProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Car.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CarProperty =
            DependencyProperty.Register("Car", typeof(Car), typeof(Info));





        public Info()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
