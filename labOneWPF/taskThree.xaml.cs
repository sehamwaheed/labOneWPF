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

namespace labOneWPF
{
    /// <summary>
    /// Interaction logic for taskThree.xaml
    /// </summary>
    public partial class taskThree : Window
    {
        public taskThree()
        {
            InitializeComponent();
            content.Text = "Starting Default Text";
        }

        private void setText(object sender, RoutedEventArgs e)
        {
            content.Text = "Starting Default Text Set Text";
        }

        private void selectAll(object sender, RoutedEventArgs e)
        {
            content.Focus();
            content.SelectAll();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            content.Text = string.Empty;
        }

        private void Prepand(object sender, RoutedEventArgs e)
        {
          content.Text= $" 'Prepand Text '  {content.Text}";
        }

        private void Insert(object sender, RoutedEventArgs e)
        {
            if (content.CaretIndex == 0)
            {
                content.SelectionStart = content.Text.Length;
                content.Text = $"{content.Text}  ** inserted text ** ";
            }
            else
            {
                content.Text = content.Text.Insert(content.CaretIndex, "** inserted text **");
            }

        }

        private void Append(object sender, RoutedEventArgs e)
        {
            content.Text = $"   {content.Text}  'Append Text '";
        }

        private void Cut(object sender, RoutedEventArgs e)
        {
            content.Focus();
            content.Cut();
        }

        private void Past(object sender, RoutedEventArgs e)
        {
            content.Focus();
            content.Paste();
        }

        private void Undo(object sender, RoutedEventArgs e)
        {
            content.Focus();
            content.Undo();
        }

        private void edit(object sender, RoutedEventArgs e)
        {
            content.IsReadOnly = false;
        }

        private void readOnly(object sender, RoutedEventArgs e)
        {
            content.IsReadOnly = true;
        }

        private void leftAline(object sender, RoutedEventArgs e)
        {
            content.TextAlignment = TextAlignment.Left;
        }

        private void centerAline(object sender, RoutedEventArgs e)
        {
            content.TextAlignment = TextAlignment.Center;
        }

        private void rightAline(object sender, RoutedEventArgs e)
        {
            content.TextAlignment = TextAlignment.Right;
        }
    }
}
