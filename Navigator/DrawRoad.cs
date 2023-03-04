using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media.Media3D;

namespace Navigator
{
    enum RoadType
    {
        CAR_ROAD = 0,
        CYRCLE_ROAD,
        TRAIN_ROAD,
        WALKER_ROAD
    }

    internal class DrawRoadClass
    {
        private RoadType _RealRoadType;
        private Dictionary<Ellipse, int[]> _Nodes; // Вершины
        private Dictionary<Ellipse[], int> _RoadWeight; // Веса
        private Dictionary<RoadType, string> _RoadColor;
        private MainWindow _Window { get; set; }

        public DrawRoadClass(MainWindow window)
        {
            _RealRoadType = RoadType.CAR_ROAD;
            _Nodes = new Dictionary<Ellipse, int[]>();
            _RoadWeight = new Dictionary<Ellipse[], int>();
            _RoadColor = new Dictionary<RoadType, string>()
            {
                {RoadType.CAR_ROAD, "#FFFF0000" },
                {RoadType.CYRCLE_ROAD, "#FFFFFF00" },
                {RoadType.TRAIN_ROAD, "#FF00FF00" },
                {RoadType.WALKER_ROAD, "#FF00FFFF" }
            };
            _Window = window;
        }

        public void DrawRoad(int FirstNode, int SecondNode)
        {

        }

        public void ClearRoads()
        {
            _Window.MapCanvas.Children.Clear();
        }

        public void SetNode(Point ClickPosition)
        {
            Ellipse ellipse = new Ellipse();

            ellipse.Width = 10;
            ellipse.Height = 10;

            SolidColorBrush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(_RoadColor[_RealRoadType]));
            ellipse.Fill = brush;

            Canvas.SetLeft(ellipse, ClickPosition.X - ellipse.Width / 2);
            Canvas.SetTop(ellipse, ClickPosition.Y - ellipse.Height / 2);

            _Window.MapCanvas.Children.Add(ellipse);
        }

        public void SetRoadType(RoadType TYPE) {
            _RealRoadType = TYPE;
        }

    }
}
