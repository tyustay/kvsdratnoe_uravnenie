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

namespace kvsdratnoe_uravnenie
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void vichislit(object sender, RoutedEventArgs e)
        {
            double a = Int32.Parse(textBox1.Text);
            double b = Int32.Parse(textBox2.Text);
            double c = Int32.Parse(textBox3.Text);
            double D = b * b - 4 * a * c;

            if (D < 0)
            {
                textBox4.Text = "Корней нет";
            }
            if (D == 0)
            {
                double x = (-b / (2 * a));
                textBox4.Text = x.ToString();
            }
            if (D > 0)
            {
                double x1 = ((-b - Math.Sqrt(D)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(D)) / (2 * a));
                textBox4.Text = "x1 = " + x1 + Environment.NewLine + "x2 = " + x2;
            }
        }
    }
}
