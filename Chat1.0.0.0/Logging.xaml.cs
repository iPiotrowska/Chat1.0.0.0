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

namespace Chat1._0._0._0
{
    /// <summary>
    /// Interaction logic for Logging.xaml
    /// </summary>
    public partial class Logging : Window
    {
        public Logging()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Joanna" && txtPassword.Password == "Joanna")
            {
                MainWindow chat = new MainWindow();
                chat.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }
        }
    }
}
