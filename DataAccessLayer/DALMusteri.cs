using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
using Utility;

namespace DataAccessLayer
{
    public class DALMusteri
    {
        public static List<EntityMusteri> MusteriListesi()
        {
            List<EntityMusteri> musteriListesi = new List<EntityMusteri>();
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceMusteri.SelectMusteriSorgu, Baglanti.connection);

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                musteriListesi.Add(new EntityMusteri
                {
                    MusteriId = Convert.ToInt32(dr[ResourceMusteri.MUSTERIID]),
                    MusteriAd = dr[ResourceMusteri.MUSTERIAD].ToString(),
                    MusteriSoyad = dr[ResourceMusteri.MUSTERISOYAD].ToString(),
                });

            }

            dr.Close();
            return musteriListesi;
        }

        public static int MusteriEkle(EntityMusteri musteriDeger)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceMusteri.InsertMusteriSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceMusteri.Parameter1, musteriDeger.MusteriAd);
            command.Parameters.AddWithValue(ResourceMusteri.Parameter2, musteriDeger.MusteriSoyad);
            return command.ExecuteNonQuery();
        }

        public static bool MusteriSil(int? id)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceMusteri.DeleteMusteriSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceMusteri.IdParameter, id);

            return command.ExecuteNonQuery() > 0;
        }

        public static EntityMusteri MusteriGetirById(int? id)
        {
            EntityMusteri entityMusteri = new EntityMusteri();
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceMusteri.SelectMusteriByIdSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceMusteri.IdParameter, id);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                entityMusteri.MusteriId = Convert.ToInt32(dr[ResourceMusteri.MUSTERIID]);
                entityMusteri.MusteriAd = dr[ResourceMusteri.MUSTERIAD].ToString();
                entityMusteri.MusteriSoyad = dr[ResourceMusteri.MUSTERISOYAD].ToString();
            }

            dr.Close();
            return entityMusteri;
        }

        public static int MusteriGuncelle(EntityMusteri musteriDeger)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceMusteri.UpdateMusteriSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceMusteri.AdParam, musteriDeger.MusteriAd);
            command.Parameters.AddWithValue(ResourceMusteri.SoyadParam, musteriDeger.MusteriSoyad);
            command.Parameters.AddWithValue(ResourceDepartman.IdParameter, musteriDeger.MusteriId);

            return command.ExecuteNonQuery();

        }
    }
}
