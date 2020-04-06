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
using Controller.Controllers;

namespace Viev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void MyDel(string name, string oneCCode, string articl, int quant, string si, string address, string coment);
        public MainWindow()
        {


            
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ProductController productController = new ProductController();
            double.TryParse(Quantity.Text, out double quant);
            productController.Add(NameText.Text, CodeOneC.Text, Articul.Text, quant, QuantSI.Text, Address.Text, ComentText.Text);
        }
    }
}
