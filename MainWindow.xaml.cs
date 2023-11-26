using EczaneTakvim.Usercontrols;
using EczasistanCsharp2.Classes;
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
using System.Windows.Threading;

namespace EczaneTakvim
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();  //WPF'de timer kullanmak için gerekli tanım
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);  //timer'ı sayfaya ekledik
            timer.IsEnabled = true;
            timer.Tick += timersay;
        }

        private void timersay(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            lbl_time.Content = simdi.ToLongTimeString(); //lbl_time içerisine anlık time yazdırma(Stringe çevirerek)
        }

        private void Btn_gun_Click(object sender, RoutedEventArgs e)
        {
            //uc_cagir classıyla dayView usercontrolüne ilgili yere çağırma işlemi
            uc_cagir.uc_Ekle(Icerik_takvim, new dayView());
        }

        private void Btn_ay_Click(object sender, RoutedEventArgs e)
        {
            //uc_cagir classıyla monthView usercontrolüne ilgili yere çağırma işlemi
            uc_cagir.uc_Ekle(Icerik_takvim, new monthView());
        }

        private void Btn_yil_Click(object sender, RoutedEventArgs e)
        {
            //uc_cagir classıyla yearView usercontrolüne ilgili yere çağırma
            uc_cagir.uc_Ekle(Icerik_takvim, new yearView());
        }

        private void Button_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        //pencere yüklendiğinde ilgili labeller içerisine time bilgileri yazıldı.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_date.Content = DateTime.Now.ToString("dd");
            lbl_monthY.Content = DateTime.Now.ToString("MMMM yyyy" + ",");
            lbl_day.Content = DateTime.Now.ToString("dddd");
            lbl_time.Content = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Btn_takvimKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();  //pencereyi kapatma işlemi
        }
    }
}
