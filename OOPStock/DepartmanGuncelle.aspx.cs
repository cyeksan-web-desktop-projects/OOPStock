using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BusinessLogicLayer;
using EntityLayer;
using Utility;
namespace OOPStock
{
    public partial class DepartmanGuncelle : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            EntityDepartman entityDepartman = BLLDepartman.BLLDepartmanGetirById(Convert.ToByte(Request.QueryString["id"]));
            if (Page.IsPostBack == false) {
                txtDepartmanId.Text = entityDepartman.DepartmanId.ToString();
                txtDepartmanAd.Text = entityDepartman.DepartmanAd;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityDepartman entityDepartman = new EntityDepartman();
            entityDepartman.DepartmanId = Convert.ToByte(txtDepartmanId.Text);
            entityDepartman.DepartmanAd = txtDepartmanAd.Text;
            int sonuc = BLLDepartman.BLLDepartmanGuncelle(entityDepartman);
            MyPresentationExtensions.ShowErrorMessageOrRedirect(sonuc, ResourceDepartman.DepartmanlarSayfasi, ResourceDepartman.DepartmanGuncelleError);

        }
    }
}