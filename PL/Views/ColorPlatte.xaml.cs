using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ColorPlatte.xaml
    /// </summary>
    public partial class ColorPlatte : UserControl
    {
        public static BE.colors color = BE.colors.YELLOW;
        public ColorPlatte()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Color = BE.colors.RED;
            color = BE.colors.RED;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Color = BE.colors.YELLOW;
            color = BE.colors.YELLOW;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Color = BE.colors.GREEN;
            color = BE.colors.GREEN;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Color = BE.colors.PURPLE;
            color = BE.colors.PURPLE;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Color = BE.colors.BLUE;
            color = BE.colors.BLUE;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Color = BE.colors.PINK;
            color = BE.colors.PINK;
        }

        public BE.colors getColor()
        {
            return Color;
        }

        public BE.colors Color
        {
            get { return (BE.colors)GetValue(ColorColor); }
            set { SetValue(ColorColor, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorColor =
            DependencyProperty.Register("Color", typeof(BE.colors), typeof(ColorPlatte));
    }
}
