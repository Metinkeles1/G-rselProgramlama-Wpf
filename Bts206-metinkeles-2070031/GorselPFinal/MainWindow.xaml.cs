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

namespace GorselPFinal
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }


        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + "                             " + textBox2.Text + "                             " + textBox3.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
    
        }
    }
}
