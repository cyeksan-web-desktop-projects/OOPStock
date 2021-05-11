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
    public partial class Satislar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SatislariGetir();
        }
        private void SatislariGetir()
        {
            List<EntitySatis> satisListesi = BLLSatis.SatisListele();
            Repeater1.DataSource = satisListesi;
            Repeater1.DataBind();
        }

        protected void MySilBtnHandler(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SatisSil(Convert.ToInt32(btn.CommandArgument));

        }
        protected void SatisSil(int id)
        {
            BLLSatis.SatisSil(id);
            SatislariGetir();
        }
        protected void lnkEdit_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("SatisGuncelle.aspx?id=" + e.CommandArgument);
        }
    }
}