using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Windows.Forms;
using Utility;
using System.Web.UI.WebControls;

namespace OOPStock
{
    public static class MyPresentationExtensions
    {
        public static void ShowErrorMessageOrRedirect(int sonuc, string sayfaAdi, string ErrorMesaj)
        {

            if (sonuc > 0)
            {
                HttpContext.Current.Response.Redirect(sayfaAdi);
            }
            else
            {
                MessageBox.Show(ErrorMesaj);
            }
        }
    }
}