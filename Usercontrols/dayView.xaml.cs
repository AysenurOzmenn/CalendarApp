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

namespace EczaneTakvim.Usercontrols
{
    /// <summary>
    /// dayView.xaml etkileşim mantığı
    /// </summary>
    public partial class dayView : UserControl
    {
        public dayView()
        {
            InitializeComponent();
        }

        int sayi = DateTime.Now.Day;
        private void Btn_geri_Click(object sender, RoutedEventArgs e)
        {
            sayi -= 1;
            label1.Content = sayi.ToString();
            
        }

        private void Btn_ileri_Click(object sender, RoutedEventArgs e)
        {
            sayi += 1;
            label1.Content = sayi.ToString();
            label1.Content = (sayi + DateTime.Now.ToString("MMMM"));
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            label1.Content = DateTime.Now.ToString("dd MMMM");
        }
    }
}
