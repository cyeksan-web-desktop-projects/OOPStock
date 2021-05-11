using System;
using EntityLayer;
using DataAccessLayer;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class BLLDepartman
    {
        public static List<EntityDepartman> BLLDepartmanListele()
        {
            return DALDepartman.DepartmanListesi();
        }

        public static int BLLDepartmanEkle(EntityDepartman entityDepartman)
        {
            if (entityDepartman.DepartmanAd != "")
            {
                return DALDepartman.DepartmanEkle(entityDepartman);
            }

            return -1;
        }

        public static bool BLLDepartmanSil(int? id)
        {
            if (id != null && id > 0)
            {
                return DALDepartman.DepartmanSil(id);
            }

            return false;
        }

        public static EntityDepartman BLLDepartmanGetirById(byte? id)
        {
            if (id != null && id > 0)
            {
                return DALDepartman.DepartmanGetirById(id);
            }

            return null;
        }

        public static int BLLDepartmanGuncelle(EntityDepartman entityDepartman)
        {
            if (entityDepartman.DepartmanAd != "")
            {
                return DALDepartman.DepartmanGuncelle(entityDepartman);
            }

            return -1;
        }
    }
}
