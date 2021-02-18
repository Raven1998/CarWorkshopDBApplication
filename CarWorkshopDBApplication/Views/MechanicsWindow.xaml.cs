﻿using System;
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
using System.Windows.Shapes;
using CarWorkshopDBApplication.ViewModel;

namespace CarWorkshopDBApplication.Views
{
    /// <summary>
    /// Interaction logic for MechanicsWindow.xaml
    /// </summary>
    public partial class MechanicsWindow : Window
    {
        public MechanicsWindow(MechanicViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
