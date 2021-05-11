using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;
namespace OOPStock
{
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        protected void UrunSil(int id)
        {
            BLLUrun.UrunSil(id);
            UrunleriGetir();
        }
        protected void MySilBtnHandler(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            UrunSil(Convert.ToInt32(btn.CommandArgument));

        }

        private void UrunleriGetir()
        {
            List<EntityUrun> urunListesi = BLLUrun.UrunListele();
            Repeater1.DataSource = urunListesi;
            Repeater1.DataBind();
        }
        protected void lnkEdit_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("UrunGuncelle.aspx?id=" + e.CommandArgument);
        }
    }
}