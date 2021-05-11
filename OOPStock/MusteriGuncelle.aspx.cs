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
    public partial class MusteriGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntityMusteri entityMusteri = BLLMusteri.BLLMusteriGetirById(Convert.ToByte(Request.QueryString["id"]));
            if (Page.IsPostBack == false)
            {
                txtMusteriId.Text = entityMusteri.MusteriId.ToString();
                txtMusteriAd.Text = entityMusteri.MusteriAd;
                txtMusteriSoyad.Text = entityMusteri.MusteriSoyad;
            }

        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {

            EntityMusteri entityMusteri = new EntityMusteri();
            entityMusteri.MusteriId = Convert.ToInt32(txtMusteriId.Text);
            entityMusteri.MusteriAd = txtMusteriAd.Text;
            entityMusteri.MusteriSoyad = txtMusteriSoyad.Text;

            int sonuc = BLLMusteri.BLLMusteriGuncelle(entityMusteri);
            MyPresentationExtensions.ShowErrorMessageOrRedirect(sonuc, ResourceMusteri.MusterilerSayfasi, ResourceMusteri.MusteriGuncelleError);

        }
    }
}