using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using System.Data.SqlClient;
using Utility;
namespace DataAccessLayer
{
    public class DALUrun
    {
        public static List<EntityUrun> UrunListesi()
        {
            List<EntityUrun> urunListesi = new List<EntityUrun>();
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceUrun.SelectUrunSorgu, Baglanti.connection);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                urunListesi.Add(new EntityUrun {
                    UrunId = Convert.ToInt32(dr[ResourceUrun.URUNID]),
                    UrunAd = dr[ResourceUrun.URUNAD].ToString(),
                    UrunFiyat = Convert.ToDecimal(dr[ResourceUrun.URUNFIYAT]),
                    UrunAdet = Convert.ToInt32(dr[ResourceUrun.URUNADET])
                });
            }

            dr.Close();
            return urunListesi;
            
        }

        public static int UrunEkle(EntityUrun urunDeger)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceUrun.InsertUrunSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceUrun.Parameter1, urunDeger.UrunAd);
            command.Parameters.AddWithValue(ResourceUrun.Parameter2, urunDeger.UrunFiyat);
            command.Parameters.AddWithValue(ResourceUrun.Parameter3, urunDeger.UrunAdet);

            return command.ExecuteNonQuery();
        }

        public static bool UrunSil(int? id)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceUrun.DeleteUrunSorgu, Baglanti.connection);

            command.Parameters.AddWithValue(ResourceUrun.IdParameter, id);

            return command.ExecuteNonQuery() > 0;
        }

        public static EntityUrun UrunGetirById(int? id)
        {
            EntityUrun entityUrun = new EntityUrun();
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceUrun.SelectUrunByIdSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceUrun.IdParameter, id);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                entityUrun.UrunId = Convert.ToInt32(dr[ResourceUrun.URUNID]);
                entityUrun.UrunAd = dr[ResourceUrun.URUNAD].ToString();
                entityUrun.UrunFiyat = Convert.ToDecimal(dr[ResourceUrun.URUNFIYAT]);
                entityUrun.UrunAdet = Convert.ToInt32(dr[ResourceUrun.URUNADET]);
            }

            dr.Close();
            return entityUrun;
        }
        public static int UrunGuncelle(EntityUrun urunDeger)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceUrun.UpdateUrunSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceUrun.IdParameter, urunDeger.UrunId);
            command.Parameters.AddWithValue(ResourceUrun.AdParam, urunDeger.UrunAd);
            command.Parameters.AddWithValue(ResourceUrun.FiyatParam, urunDeger.UrunFiyat);
            command.Parameters.AddWithValue(ResourceUrun.AdetParam, urunDeger.UrunAdet);

            return command.ExecuteNonQuery();

        }
    }
}
