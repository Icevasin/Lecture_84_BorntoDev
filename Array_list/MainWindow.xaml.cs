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

namespace Array_list
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Add Data
           // arrayList.Add(10);
           // arrayList.Add(11);
           // arrayList.Add(12);
           // arrayList.Add(13);

            //sort
           // arrayList.Sort();

            //Show Data
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }

            //count
          //  MessageBox.Show("Count "+arrayList.Count.ToString());

            //delete
           // arrayList.RemoveAt(0);

           // arrayList.Clear();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            arrayList.Add(int.Parse(txtAdd.Text));

            txtAdd.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(int.Parse(txtAdd.Text));

            txtAdd.Text = "";
        }
    }
}
