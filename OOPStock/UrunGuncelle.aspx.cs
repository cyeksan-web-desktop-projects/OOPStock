using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using Utility;
using System.Windows.Forms;

namespace OOPStock
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntityUrun entityUrun = BLLUrun.UrunGetirById(Convert.ToByte(Request.QueryString["id"]));
            if (Page.IsPostBack == false)
            {
                txtUrunId.Text = entityUrun.UrunId.ToString();
                txtUrunAd.Text = entityUrun.UrunAd;
                txtUrunFiyat.Text = entityUrun.UrunFiyat.ToString();
                txtUrunAdet.Text = entityUrun.UrunAdet.ToString();
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityUrun entityUrun = new EntityUrun();
            entityUrun.UrunId = Convert.ToInt32(txtUrunId.Text);
            entityUrun.UrunAd = txtUrunAd.Text;
            entityUrun.UrunFiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            entityUrun.UrunAdet = Convert.ToInt32(txtUrunAdet.Text);

            int sonuc = BLLUrun.UrunGuncelle(entityUrun);
            MyPresentationExtensions.ShowErrorMessageOrRedirect(sonuc, ResourceUrun.UrunlerSayfasi, ResourceUrun.UrunGuncelleError);
        }
    }
}