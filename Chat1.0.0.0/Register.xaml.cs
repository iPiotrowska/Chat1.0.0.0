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
using System.Windows.Shapes;

namespace Chat1._0._0._0
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(txtPassword.Password==txtPassword2.Password)
            {
                Logging logging = new Logging();
                logging.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Repeated password is incorrect.");
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Logging logging = new Logging();
            logging.Show();
            this.Close();
        }
    }
}
