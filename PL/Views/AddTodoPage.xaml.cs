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

namespace PL.Views
{
    /// <summary>
    /// Interaction logic for AddTodoPage.xaml
    /// </summary>
    public partial class AddTodoPage : Page
    {
        Frame thisFrame;
        private Frame mainFrame;

        public AddTodoPage()
        {
            InitializeComponent();
            this.DataContext = new PL.ViewModel.AddTodoViewModel();
        }

        public AddTodoPage(Frame mainFrame)
        {
            this.mainFrame = mainFrame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window m = new MapWindow(this.addressText.Text);
            m.ShowDialog();
        }
    }
}
