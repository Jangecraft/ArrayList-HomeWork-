using System;
using System.Collections;
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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList MyData;
        public MainWindow()
        {
            InitializeComponent();
            MyData = new ArrayList();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            MyData.Add(txtData.Text);
            MessageBox.Show("Success");
        }
        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            MyData.Remove(txtData.Text);
            MessageBox.Show("Success");
        }
        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (string data in MyData)
            {
                MessageBox.Show(data);
            }
        }
    }
}
