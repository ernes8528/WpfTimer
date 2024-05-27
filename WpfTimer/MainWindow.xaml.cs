using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Timer _timer;
        public MainWindow()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.OnTimeChanged += Time_OnTimeChanged;
        }

        private void Time_OnTimeChanged(object sender, TimeSpan e)
        {
            TimeDisplay.Text = e.ToString(@"hh\:mm\:ss");
        }

        private void StarButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Star();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
        }
    }
}