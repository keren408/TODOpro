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
using BE;
using PL.ViewModel;

namespace PL.Views
{
    /// <summary>
    /// Interaction logic for DisplayOneTodoPage.xaml
    /// </summary>
    public partial class DisplayOneTodoPage : Page
    {
        public DisplayOneTodoPage(TodoItem item)
        {
            InitializeComponent();
           // this.DataContext = item;
            this.DataContext = new DisplayOneTodoViewModel(item);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window m = new MapWindow(this.addressText.Text);
            m.ShowDialog();
        }
    }
}
