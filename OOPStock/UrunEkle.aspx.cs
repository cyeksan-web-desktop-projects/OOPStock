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
    public partial class UrunEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityUrun entityUrun = new EntityUrun();
            entityUrun.UrunAd = txtUrunAd.Text;
            entityUrun.UrunFiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            entityUrun.UrunAdet = Convert.ToInt32(txtUrunAdet.Text);

            int sonuc = BLLUrun.UrunEkle(entityUrun);
            MyPresentationExtensions.ShowErrorMessageOrRedirect(sonuc, ResourceUrun.UrunlerSayfasi, ResourceUrun.UrunEkleError);

        }
    }
}