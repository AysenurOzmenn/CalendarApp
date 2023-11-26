using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EczasistanCsharp2.Classes
{
    public class uc_cagir
    {
        public static void uc_Ekle(Grid grd, UserControl uc)
        {
            if (grd.Children.Count > 0)  //gridin içerisi usercontrol çöplüğü olmasın diye butonlara tıklanıldığında 
            {                            //gridin içersinde bir userkontrol varsa onu temizleyip daha sonra ekleme yaptık.
                grd.Children.Clear();
                grd.Children.Add(uc);
            }
            else
            {
                grd.Children.Add(uc);
            }
        }
    }
}
