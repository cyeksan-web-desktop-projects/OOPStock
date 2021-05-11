using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class BLLMusteri
    {
        public static List<EntityMusteri> BLLMusteriListele()
        {

            return DALMusteri.MusteriListesi();

        }

        public static int BLLMusteriEkle(EntityMusteri entityMusteri)
        {
            if(entityMusteri.MusteriAd != "" && entityMusteri.MusteriSoyad != "")
            {
                return DALMusteri.MusteriEkle(entityMusteri);
            }

            return -1;
        }

        public static bool BLLMusteriSil(int? id)
        {
            if(id != null && id > 0)
            {
                return DALMusteri.MusteriSil(id);
            }

            return false;
        }

        public static EntityMusteri BLLMusteriGetirById(int? id)
        {
            if (id != null && id > 0)
            {
                return DALMusteri.MusteriGetirById(id);
            }

            return null;
        }

        public static int BLLMusteriGuncelle(EntityMusteri entityMusteri)
        {
            if (entityMusteri.MusteriAd != "" && entityMusteri.MusteriSoyad != "")
            {
                return DALMusteri.MusteriGuncelle(entityMusteri);
            }

            return -1;
        }
    }
}
