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
    public partial class SatisEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            UrunleriGetir();
            PersonelleriGetir();
            MusterileriGetir();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            EntitySatis entitySatis = new EntitySatis();
            entitySatis.UrunId = Convert.ToByte(cmbUrun.SelectedValue);
            entitySatis.PersonelId = Convert.ToByte(cmbPersonel.SelectedValue);
            entitySatis.MusteriId = Convert.ToByte(cmbMusteri.SelectedValue);
            entitySatis.Tutar = Convert.ToDecimal(txtSatisTutar.Text);

            int sonuc = BLLSatis.SatisEkle(entitySatis);
            MyPresentationExtensions.ShowErrorMessageOrRedirect(sonuc, ResourceSatis.SatislarSayfasi, ResourceSatis.SatisEkleError);
        }

        private void UrunleriGetir()
        {
            if (cmbUrun.Items.Count == 0) {
                List<EntityUrun> urunList = BLLUrun.UrunListele();
                cmbUrun.Items.Add(new ListItem(ResourceSatis.cmbUrunDefaultValue, ResourceSatis.Zero.ToString()));

                foreach (var item in urunList)
                {
                    cmbUrun.Items.Add(new ListItem(item.UrunAd, item.UrunId.ToString()));

                }
            }
        }

        private void PersonelleriGetir()
        {
            if (cmbPersonel.Items.Count == 0)
            {
                List<EntityPersonel> personelList = BLLPersonel.PersonelListele();
                cmbPersonel.Items.Add(new ListItem(ResourceSatis.cmbPersonelDefaultValue, ResourceSatis.Zero.ToString()));

                foreach (var item in personelList)
                {
                    cmbPersonel.Items.Add(new ListItem(item.PersonelAd + ' ' + item.PersonelSoyad, item.PersonelId.ToString()));

                }
            }
        }

        private void MusterileriGetir()
        {
            if (cmbMusteri.Items.Count == 0)
            {
                List<EntityMusteri> musteriList = BLLMusteri.BLLMusteriListele();
                cmbMusteri.Items.Add(new ListItem(ResourceSatis.cmbMusteriDefaultValue, ResourceSatis.Zero.ToString()));

                foreach (var item in musteriList)
                {
                    cmbMusteri.Items.Add(new ListItem(item.MusteriAd + ' ' + item.MusteriSoyad, item.MusteriId.ToString()));

                }
            }
        }
    }
}