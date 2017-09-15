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

namespace Working_Paracticle_1
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


        private void SaveBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (Name_Text.Text == "")
                MessageBox.Show("your name is blank please enter a name ");

            if (Address_Text.Text == "")
                MessageBox.Show("your address is blank please enter an adress");
            int x = 0;

            try
            {
                x = Convert.ToInt32(Age_Text.Text);

            } catch (Exception ex)
            {
                MessageBox.Show("that is not a number");
            }

            if (x < 0 || x > 100)
            {
                MessageBox.Show("ages got to be 1-100 ");
            }


            string a = $"{Age_Text.Text},{Address_Text.Text},{Name_Text.Text}"; 
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\40322185\\Desktop\\test\\test.txt", true);
            file.WriteLine(a);
            file.Close();









        }



        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            Name_Text.Text = string.Empty;
            Age_Text.Text = string.Empty;
            Address_Text.Text = string.Empty;
        }
    }
}
