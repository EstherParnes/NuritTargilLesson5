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

namespace NuritTargilLesson5
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

      private void WindowLoad(object sender, RoutedEventArgs e)
      {
         //open second window

         SecondWindow secondWindow = new SecondWindow();
         secondWindow.Show();
      }
      private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {
         if  (((ListBox)sender).SelectedItem == "") //check if nothing was selected
         {
            TextBoxAdd.Visibility = Visibility.Visible;
            ButtonAdd.Visibility = Visibility.Visible;
            ButtonAdd.IsEnabled = false;
         }
         else
         //chose something so hide the controls
         {
            TextBoxAdd.Visibility = Visibility.Hidden;
            ButtonAdd.Visibility = Visibility.Hidden;
            MessageBox.Show("you have chosen " + ListBoxCities.SelectedItem);

         }
      }

      private void TextChanged_Event(object sender, TextChangedEventArgs e)
      {
         
         ButtonAdd.IsEnabled = true;//make button visible then there is text changed
      }

      private void ButtonClick_Event(object sender, RoutedEventArgs e)
      {
         //button click adds the name to the list
          ListBoxCities.Items.Add(TextBoxAdd.Text);
         // ListBoxCities = word;
      }

      private void closeButton_Click(object sender, RoutedEventArgs e)
      {
         this.Close();
      }

   }
}