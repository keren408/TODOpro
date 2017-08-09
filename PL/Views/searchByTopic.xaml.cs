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

namespace PL.Views
{
    /// <summary>
    /// Interaction logic for searchByTopic.xaml
    /// </summary>
    public partial class searchByTopic : Window
    {
        BE.StringWrapper wrapper;
        public searchByTopic(BE.StringWrapper topic)
        {
            InitializeComponent();
            wrapper = topic;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.wrapper.topic = TextBox.Text;
        }
    }
}
