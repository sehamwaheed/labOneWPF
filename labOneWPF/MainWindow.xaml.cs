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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace labOneWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void okSaved(object sender, RoutedEventArgs e)
        {
            string message = $"FirstName:{fname.Text}\nLastName:{lname.Text}\nGender:{Gender.Text}\nAddress:{Address.Text}\nPhone:{Phone.Text}\nMobile:{Mobile.Text}\nEmail:{Email.Text}\nJobTitele:{JobTitel.Text}\n";
          
            string caption = "Confirmation";
            MessageBoxButton buttons = MessageBoxButton.OKCancel;
            MessageBoxImage icon = MessageBoxImage.Question;
            if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
            {
                // OK code here  
                MessageBox.Show("saved successfully");
            }
            else
            {
                fname.Text = lname.Text = Gender.Text = Address.Text = Phone.Text = Mobile.Text = Email.Text = JobTitel.Text = string.Empty;
            }
        }

        private void cancelEvent(object sender, RoutedEventArgs e)
        {
            fname.Text = lname.Text = Gender.Text = Address.Text = Phone.Text = Mobile.Text = Email.Text = JobTitel.Text = string.Empty;
        }
    }
}
