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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DepartmanlariGetir();
        }

        protected void DepartmanSil(int id)
        {
            BLLDepartman.BLLDepartmanSil(id);
            DepartmanlariGetir();
        }
        protected void MySilBtnHandler(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DepartmanSil(Convert.ToInt32(btn.CommandArgument));

        }

        private void DepartmanlariGetir()
        {
            List<EntityDepartman> departmanList = BLLDepartman.BLLDepartmanListele();
            Repeater1.DataSource = departmanList;
            Repeater1.DataBind();
        }

        protected void lnkEdit_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("DepartmanGuncelle.aspx?id=" + e.CommandArgument);
        }
    }
}