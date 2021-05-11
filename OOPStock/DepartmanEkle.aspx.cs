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
    public partial class DepartmanEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityDepartman entityDepartman = new EntityDepartman();
            entityDepartman.DepartmanAd = txtDepartmanAd.Text;
            int sonuc = BLLDepartman.BLLDepartmanEkle(entityDepartman);
            MyPresentationExtensions.ShowErrorMessageOrRedirect(sonuc, ResourceDepartman.DepartmanlarSayfasi, ResourceDepartman.DepartmanEkleError);

        }
    }
}