using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLUrun
    {
        public static List<EntityUrun> UrunListele()
        {
            return DALUrun.UrunListesi();
        }

        public static int UrunEkle(EntityUrun entityUrun)
        {
            if(entityUrun.UrunAd != "" && entityUrun.UrunFiyat > 0 && entityUrun.UrunAdet >= 0)
            {
                return DALUrun.UrunEkle(entityUrun);
            }

            return -1;
        }
        public static bool UrunSil(int? id)
        {
            if (id != null && id > 0)
            {
                return DALUrun.UrunSil(id);
            }

            return false;
        }
        public static EntityUrun UrunGetirById(int? id)
        {
            if (id != null && id > 0)
            {
                return DALUrun.UrunGetirById(id);
            }

            return null;
        }
        public static int UrunGuncelle(EntityUrun entityUrun)
        {
            if (entityUrun.UrunAd != "" && entityUrun.UrunFiyat > 0 && entityUrun.UrunAdet >= 0)
            {
                return DALUrun.UrunGuncelle(entityUrun);
            }
            return -1;
        }

    }
}
