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

namespace WPFUserControlsClickButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void SetActiveUserControlClick(UserControl control)
        {

            /*  VISIBILITY COLLAPSED ALL CONTROLS   */

            home.Visibility     = Visibility.Collapsed;
            music.Visibility    = Visibility.Collapsed;
            news.Visibility     = Visibility.Collapsed;
            games.Visibility    = Visibility.Collapsed;

            /*  ACTIVATE VISIBILITY IN ONE CONTROL  */
            control.Visibility = Visibility.Visible;
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControlClick(home);
        }

        private void BtnGames_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControlClick(games);
        }

        private void BtnMusic_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControlClick(music);
        }

        private void BtnNews_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControlClick(news);
        }
    }
}
