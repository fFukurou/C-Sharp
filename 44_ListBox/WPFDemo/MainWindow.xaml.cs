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
using WPFDemo.Data;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Person> People = new List<Person>
        {
            new Person {Name="Kratos", Age=1765},
            new Person {Name="Mark", Age=46},
            new Person {Name="D.VA", Age=19},
            new Person {Name="Eren", Age=19},
            new Person {Name="Bruh", Age=9999},
        };

        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;

            foreach(var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show($"Name: {person.Name}\nAge: {person.Age}");
            }
        }
    }

}
