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
    public partial class PersonelGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntityPersonel entityPersonel = BLLPersonel.PersonelGetirById(Convert.ToByte(Request.QueryString["id"]));
            if (Page.IsPostBack == false) {
                txtPersonelId.Text = entityPersonel.PersonelId.ToString();
                txtPersonelAd.Text = entityPersonel.PersonelAd;
                txtPersonelSoyad.Text = entityPersonel.PersonelSoyad;
                txtPersonelMaas.Text = entityPersonel.PersonelMaas.ToString();
                SetPersonelDepartmanToDropdown(entityPersonel);

            }
        }

        private void SetPersonelDepartmanToDropdown(EntityPersonel entityPersonel)
        {
            if (cmbPersonelDepartman.Items.Count == 0)
            {
                List<EntityDepartman> departmanList = BLLDepartman.BLLDepartmanListele();

                foreach (var item in departmanList)
                {
                    cmbPersonelDepartman.Items.Add(new ListItem(item.DepartmanAd, item.DepartmanId.ToString()));
                }

                cmbPersonelDepartman.SelectedValue = entityPersonel.PersonelDepartmanId.ToString();
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel entityPersonel = new EntityPersonel();
            entityPersonel.PersonelId = Convert.ToInt32(txtPersonelId.Text);
            entityPersonel.PersonelAd = txtPersonelAd.Text;
            entityPersonel.PersonelSoyad = txtPersonelSoyad.Text;
            entityPersonel.PersonelDepartmanId = Convert.ToByte(cmbPersonelDepartman.SelectedValue);
            entityPersonel.PersonelMaas = Convert.ToDecimal(txtPersonelMaas.Text);

            int sonuc = BLLPersonel.PersonelGuncelle(entityPersonel);
            MyPresentationExtensions.ShowErrorMessageOrRedirect(sonuc, ResourcePersonel.PersonellerSayfasi, ResourcePersonel.PersonelGuncelleError);
        }
    }
}