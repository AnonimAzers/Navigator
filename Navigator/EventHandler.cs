using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace Navigator
{
    internal class Events
    {
        private MainWindow _Window { get; set; }
        private DrawRoadClass _DrawRoadClass;

        public Events(MainWindow Window)
        {
            this._Window = Window;
            _DrawRoadClass = new DrawRoadClass(Window);
        }

        public void TopRootMouseDown_Event(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                _Window.DragMove();
            }
        }

        public void CloseWindowButton_Click(object sender, RoutedEventArgs e)
        {
            _Window.Close();
        }

        public void RoadButtonClick_Event(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content.ToString())
            {
                case "Car":
                    _DrawRoadClass.SetRoadType(RoadType.CAR_ROAD);
                    break;
                case "Cyrcle":
                    _DrawRoadClass.SetRoadType(RoadType.CYRCLE_ROAD);
                    break;
                case "Train":
                    _DrawRoadClass.SetRoadType(RoadType.TRAIN_ROAD);
                    break;
                case "Walker":
                    _DrawRoadClass.SetRoadType(RoadType.WALKER_ROAD);
                    break;

            }
        }

        public void MapClick_Event(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(_Window.MapCanvas);
            _DrawRoadClass.SetNode(point);
        }

        public void ClearRoadButton_Event(object sender, RoutedEventArgs e)
        {
            _DrawRoadClass.ClearRoads();
        }
    }
}
