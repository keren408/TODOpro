using PL.ViewModel;
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
    /// Interaction logic for DisplayMyTodo.xaml
    /// </summary>
    public partial class DisplayMyTodo : Page
    {
        DisplayMyTodoViewModel vm;
        public DisplayMyTodo()
        {
            InitializeComponent();
            DataContext = vm = new ViewModel.DisplayMyTodoViewModel();

        }

        public DisplayMyTodo(string topi)
        {
            InitializeComponent();
            DataContext = vm = new ViewModel.DisplayMyTodoViewModel(topi);

        }
        public DisplayMyTodo(DateTime start, DateTime end)
        {
            InitializeComponent();
            DataContext = vm = new ViewModel.DisplayMyTodoViewModel(start, end);

        }

        public DisplayMyTodoViewModel getViewModel()
        {
            return vm;
        }

    }
}
