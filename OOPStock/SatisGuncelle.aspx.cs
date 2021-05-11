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
    public partial class SatisGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntitySatis entitySatis = BLLSatis.SatisGetirById(Convert.ToByte(Request.QueryString["id"]));
            txtSatisId.Text = entitySatis.SatisId.ToString();
            txtSatisTutar.Text = entitySatis.Tutar.ToString();
            SetUrunlerToDropdown(entitySatis);
            SetPersonellerToDropdown(entitySatis);
            SetMusterilerToDropdown(entitySatis);

        }

        private void SetUrunlerToDropdown(EntitySatis entitySatis)
        {
            if (cmbUrun.Items.Count == 0)
            {
                List<EntityUrun> urunList = BLLUrun.UrunListele();

                foreach (var item in urunList)
                {
                    cmbUrun.Items.Add(new ListItem(item.UrunAd, item.UrunId.ToString()));

                }
                cmbUrun.SelectedValue = entitySatis.UrunId.ToString();

            }
        }

        private void SetPersonellerToDropdown(EntitySatis entitySatis)
        {
            if (cmbPersonel.Items.Count == 0)
            {
                List<EntityPersonel> personelList = BLLPersonel.PersonelListele();

                foreach (var item in personelList)
                {
                    cmbPersonel.Items.Add(new ListItem(item.PersonelAd + ' ' + item.PersonelSoyad, item.PersonelId.ToString()));

                }
                cmbPersonel.SelectedValue = entitySatis.PersonelId.ToString();

            }
        }

        private void SetMusterilerToDropdown(EntitySatis entitySatis)
        {
            if (cmbMusteri.Items.Count == 0)
            {
                List<EntityMusteri> musteriList = BLLMusteri.BLLMusteriListele();

                foreach (var item in musteriList)
                {
                    cmbMusteri.Items.Add(new ListItem(item.MusteriAd + ' ' + item.MusteriSoyad, item.MusteriId.ToString()));

                }
                cmbMusteri.SelectedValue = entitySatis.MusteriId.ToString();
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntitySatis entitySatis = new EntitySatis();
            entitySatis.SatisId = Convert.ToInt32(txtSatisId.Text);
            entitySatis.UrunId = Convert.ToInt32(cmbUrun.SelectedValue);
            entitySatis.PersonelId = Convert.ToInt32(cmbPersonel.SelectedValue);
            entitySatis.MusteriId = Convert.ToInt32(cmbMusteri.SelectedValue);
            entitySatis.Tutar = Convert.ToDecimal(txtSatisTutar.Text);

            int sonuc = BLLSatis.SatisGuncelle(entitySatis);
            MyPresentationExtensions.ShowErrorMessageOrRedirect(sonuc, ResourceSatis.SatislarSayfasi, ResourceSatis.SatisGuncelleError);

        }
    }
}