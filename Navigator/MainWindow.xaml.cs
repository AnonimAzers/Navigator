using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows;


namespace Navigator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Events events = new Events(this);
            TopRoot.MouseDown += events.TopRootMouseDown_Event;
            CloseWindowButton.Click += events.CloseWindowButton_Click;
            DrawCarRoadButton.Click += events.RoadButtonClick_Event;
            DrawCyrcleRoadButton.Click += events.RoadButtonClick_Event;
            DrawTrainRoadButton.Click += events.RoadButtonClick_Event;
            DrawWalkerRoadButton.Click += events.RoadButtonClick_Event;
            Map.MouseLeftButtonDown += events.MapClick_Event;
            ClearRoadsButton.Click += events.ClearRoadButton_Event;
        }

    }
}
