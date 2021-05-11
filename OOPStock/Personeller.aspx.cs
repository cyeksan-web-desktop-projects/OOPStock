using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
namespace OOPStock
{
    public partial class Personeller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }

        protected void MySilBtnHandler(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            PersonelSil(Convert.ToInt32(btn.CommandArgument));

        }

        protected void PersonelSil(int id)
        {
            BLLPersonel.PersonelSil(id);
            PersonelleriGetir();
        }

        private void PersonelleriGetir()
        {
            List<EntityPersonel> personelListesi = BLLPersonel.PersonelListele();
            Repeater1.DataSource = personelListesi;
            Repeater1.DataBind();
        }

        protected void lnkEdit_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("PersonelGuncelle.aspx?id=" + e.CommandArgument);
        }
    }
}