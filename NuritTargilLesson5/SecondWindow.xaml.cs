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

namespace NuritTargilLesson5
{
   /// <summary>
   /// Interaction logic for SecondWindow.xaml
   /// </summary>
   public partial class SecondWindow : Window
   {
      public SecondWindow()
      {
         InitializeComponent();
      }





      private void RadioButtonYellow_Checked(object sender, RoutedEventArgs e)
      {
         MessageBox.Show("Yellow light");
      }

      private void RadioButtonRed_Checked(object sender, RoutedEventArgs e)
      {
         MessageBox.Show("REd light");
      }

      private void RadioButtonGreen_Checked(object sender, RoutedEventArgs e)
      {
         MessageBox.Show("Green light");
      }

      private void ButtonThirdWindow_Click(object sender, RoutedEventArgs e)
      {

         ThirdWindow thirdWindow = new ThirdWindow();
         thirdWindow.Show();
         this.Close();
      }


      private void ButtonFirstWindow_Click(object sender, RoutedEventArgs e)
      {
         MainWindow firstWindow = new MainWindow();
         firstWindow.Show();
         this.Close();

      }
   }
}
