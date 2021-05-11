using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using System.Data.SqlClient;
using Utility;
using System.Data;
namespace DataAccessLayer
{
    public class DALSatis
    {
        public static List<EntitySatis> SatisListesi()
        {
            List<EntitySatis> satisListesi = new List<EntitySatis>();
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceSatis.spSatislar, Baglanti.connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                satisListesi.Add(new EntitySatis { 
                SatisId = Convert.ToInt32(dr[ResourceSatis.SATISID]),
                Urun = dr[ResourceSatis.URUNAD].ToString(),
                Personel = dr[ResourceSatis.PERSONEL].ToString(),
                Musteri = dr[ResourceSatis.MUSTERI].ToString(),
                Tutar = Convert.ToDecimal(dr[ResourceSatis.TUTAR])
                });
            }

            dr.Close();
            return satisListesi;

        }

        public static int SatisEkle(EntitySatis satisDeger)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceSatis.InsertSatisSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceSatis.Parameter1, satisDeger.UrunId);
            command.Parameters.AddWithValue(ResourceSatis.Parameter2, satisDeger.PersonelId);
            command.Parameters.AddWithValue(ResourceSatis.Parameter3, satisDeger.MusteriId);
            command.Parameters.AddWithValue(ResourceSatis.Parameter4, satisDeger.Tutar);

            return command.ExecuteNonQuery();
        }

        public static bool SatisSil(int? id)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceSatis.DeleteSatisSorgu, Baglanti.connection);

            command.Parameters.AddWithValue(ResourceSatis.IdParameter, id);

            return command.ExecuteNonQuery() > 0;
        }

        public static EntitySatis SatisGetirById(int? id)
        {
            EntitySatis entitySatis = new EntitySatis();
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceSatis.spSatislarById, Baglanti.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p1", id);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                entitySatis.SatisId = Convert.ToInt32(dr[ResourceSatis.SATISID]);
                entitySatis.Urun = dr[ResourceSatis.URUNAD].ToString();
                entitySatis.Personel = dr[ResourceSatis.PERSONEL].ToString();
                entitySatis.Musteri = dr[ResourceSatis.MUSTERI].ToString();
                entitySatis.Tutar = Convert.ToDecimal(dr[ResourceSatis.TUTAR]);
                entitySatis.MusteriId = Convert.ToInt32(dr[ResourceSatis.MUSTERIID]);
                entitySatis.UrunId = Convert.ToInt32(dr[ResourceSatis.URUNID]);
                entitySatis.PersonelId = Convert.ToInt32(dr[ResourceSatis.PERID]);

            }

            dr.Close();
            return entitySatis;
        }

        public static int SatisGuncelle(EntitySatis satisDeger)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceSatis.UpdateSatisSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceSatis.IdParameter, satisDeger.SatisId);
            command.Parameters.AddWithValue(ResourceSatis.PersonelParam, satisDeger.PersonelId);
            command.Parameters.AddWithValue(ResourceSatis.MusteriParam, satisDeger.MusteriId);
            command.Parameters.AddWithValue(ResourceSatis.UrunParam, satisDeger.UrunId);
            command.Parameters.AddWithValue(ResourceSatis.TutarParam, satisDeger.Tutar);

            return command.ExecuteNonQuery();

        }
    }
}
