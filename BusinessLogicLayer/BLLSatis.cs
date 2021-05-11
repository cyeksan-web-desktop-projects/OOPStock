using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using EntityLayer;
namespace BusinessLogicLayer
{
    public class BLLSatis
    {
        public static List<EntitySatis> SatisListele()
        {
            return DALSatis.SatisListesi();
        }

        public static int SatisEkle(EntitySatis entitySatis)
        {
            if (entitySatis.UrunId > 0 &&
                entitySatis.PersonelId > 0 &&
                entitySatis.MusteriId > 0 &&
                entitySatis.Tutar > 0)
            {
                return DALSatis.SatisEkle(entitySatis);
            }

            return -1;
        }

        public static bool SatisSil(int? id)
        {
            if (id != null && id > 0)
            {
                return DALSatis.SatisSil(id);
            }

            return false;
        }
        public static EntitySatis SatisGetirById(int? id)
        {
            if (id != null && id > 0)
            {
                return DALSatis.SatisGetirById(id);
            }

            return null;
        }
        public static int SatisGuncelle(EntitySatis entitySatis)
        {
            if (entitySatis.UrunId > 0 &&
                entitySatis.PersonelId > 0 &&
                entitySatis.MusteriId > 0 &&
                entitySatis.Tutar > 0)
            {
                return DALSatis.SatisGuncelle(entitySatis);
            }
            return -1;
        }
    }
}
