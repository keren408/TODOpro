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
using GoogleMaps.LocationServices;
using Microsoft.Maps.MapControl.WPF;

namespace PL.Views
{
    /// <summary>
    /// Interaction logic for MapWindow.xaml
    /// </summary>
    public partial class MapWindow : Window
    {
       
        public MapWindow(string addr)
        {
            InitializeComponent();
            var point = GetLatLongFromAddress(addr);
            map.Center = new Location(point.Latitude, point.Longitude);
            map.ZoomLevel = 16;
        }
        public MapPoint GetLatLongFromAddress(string address)
        {
            if (string.IsNullOrEmpty(address)) return new MapPoint();

            GoogleLocationService locationService = new GoogleLocationService();
            MapPoint point = locationService.GetLatLongFromAddress(address);
            return point;
        }
    }
}
