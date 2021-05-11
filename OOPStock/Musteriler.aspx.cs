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
    public partial class Musteriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MusterileriGetir();
        }

        protected void MusteriSil(int id)
        {
            BLLMusteri.BLLMusteriSil(id);
            MusterileriGetir();
        }

        private void MusterileriGetir()
        {
            List<EntityMusteri> musteriList = BLLMusteri.BLLMusteriListele();
            Repeater1.DataSource = musteriList;
            Repeater1.DataBind();
        }

        protected void MySilBtnHandler(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MusteriSil(Convert.ToInt32(btn.CommandArgument));
            
        }
        protected void lnkEdit_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("MusteriGuncelle.aspx?id=" + e.CommandArgument);
        }

    }
}