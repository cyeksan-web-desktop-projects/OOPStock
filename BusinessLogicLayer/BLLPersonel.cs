using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class BLLPersonel
    {
        public static List<EntityPersonel> PersonelListele()
        {
            return DALPersonel.PersonelListesi();
        }

        public static int PersonelEkle(EntityPersonel entityPersonel)
        {
            if(entityPersonel.PersonelAd != "" &&
                entityPersonel.PersonelSoyad != "" &&
                entityPersonel.PersonelDepartmanId > 0 &&
                entityPersonel.PersonelMaas > 0)
            {
                return DALPersonel.PersonelEkle(entityPersonel);
            }

            return -1;
        }

        public static bool PersonelSil(int? id)
        {
            if(id != null && id > 0)
            {
                return DALPersonel.PersonelSil(id);
            }

            return false;
        }
        public static EntityPersonel PersonelGetirById(int? id)
        {
            if (id != null && id > 0)
            {
                return DALPersonel.PersonelGetirById(id);
            }

            return null;
        }
        public static int PersonelGuncelle(EntityPersonel entityPersonel)
        {
            if(entityPersonel.PersonelAd != "" &&
                entityPersonel.PersonelSoyad != "" &&
                entityPersonel.PersonelDepartmanId > 0 &&
                entityPersonel.PersonelMaas > 0)
            {
                return DALPersonel.PersonelGuncelle(entityPersonel);
            }

            return -1;
        }
    }
}
