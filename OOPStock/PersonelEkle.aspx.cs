using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class PersonelEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (cmbPersonelDepartman.Items.Count == 0)
            {
                List<EntityDepartman> departmanList = BLLDepartman.BLLDepartmanListele();

                cmbPersonelDepartman.Items.Add(new ListItem(ResourcePersonel.cmbDepartmanDefaultValue, ResourcePersonel.Zero.ToString()));
                foreach (var item in departmanList)
                {
                    cmbPersonelDepartman.Items.Add(new ListItem(item.DepartmanAd, item.DepartmanId.ToString()));

                }
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityPersonel entityPersonel = new EntityPersonel{
                PersonelAd = txtPersonelAd.Text,
                PersonelSoyad = txtPersonelSoyad.Text,
                PersonelMaas = Convert.ToDecimal(txtPersonelMaas.Text),
                PersonelDepartmanId = Convert.ToByte(cmbPersonelDepartman.SelectedValue)
            };

            int sonuc = BLLPersonel.PersonelEkle(entityPersonel);
            MyPresentationExtensions.ShowErrorMessageOrRedirect(sonuc, ResourcePersonel.PersonellerSayfasi, ResourcePersonel.PersonelEkleError);

        }

    }
}