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

namespace GamesCharacters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static ComputerGameData db = new ComputerGameData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from g in db.ComputerGames
                select g;

            LBX_ComputerGameData.ItemsSource = query.ToList();
        }

        private void LBX_ComputerGameData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox box = (ListBox) sender;
            ComputerGame game = (ComputerGame) box.SelectedItem;

            var query = from c in db.Characters
                        where c.ComputerGameID == game.ComputerGameID
                        select c;

            LBX_CharacterData.ItemsSource = query.ToList();
        }

        private void LBX_CharacterData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox box = (ListBox) sender;
            Character character = (Character) box.SelectedItem;

            if (character!= null)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri($"{character.Image}", UriKind.Relative);
                image.EndInit();

                IMG_Character.Source = image;
            }
           
        }
    }
}
