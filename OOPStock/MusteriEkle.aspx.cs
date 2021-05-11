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
    public partial class MusteriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityMusteri entityMusteri = new EntityMusteri();
            entityMusteri.MusteriAd = txtMusteriAd.Text;
            entityMusteri.MusteriSoyad = txtMusteriSoyad.Text;
            int sonuc = BLLMusteri.BLLMusteriEkle(entityMusteri);
            MyPresentationExtensions.ShowErrorMessageOrRedirect(sonuc, ResourceMusteri.MusterilerSayfasi, ResourceMusteri.MusteriEkleError);

        }
    }
}