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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_ISRPO_PR6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Data_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            string log = "konina";
            string por = "123";

            if (login.Text == log)
            {
                
            }
            else
            {
                MessageBox.Show("Не верный логин");
            }

            if (parol.Text == por)
            {
                
            }
            else
            {
                MessageBox.Show("Не верный пароль");
            }
        }
    }
}
