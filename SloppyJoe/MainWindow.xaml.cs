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

namespace SloppyJoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5]; // kinda confused what's going on here? 5 instances of the MenuItem class??
            string guacamolePrice;

            for (int i = 0; i < 5; i++) // this is iterating through all the instances or objects or whatever
            {
                menuItems[i] = new MenuItem(); // pretty sure these are actually creating the instances or objects
                if (i >=3)
                {
                    menuItems[i].Breads = new string[] { "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel" };
                }
                menuItems[i].Generate(); // this actually picks the menu items and groups em into the the .Description below
            }

            item1.Text = menuItems[0].Description;
            price1.Text = menuItems[0].Price;

            item2.Text = menuItems[1].Description;
            price2.Text = menuItems[1].Price;

            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Price;

            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Price;

            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Price;

            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };

            specialMenuItem.Generate();

            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamolePrice = guacamoleMenuItem.Price;

            guacamole.Text = "Add guacamole for " + guacamolePrice;
        }
    }
}
