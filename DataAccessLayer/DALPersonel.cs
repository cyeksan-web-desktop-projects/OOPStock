using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using System.Data.SqlClient;
using Utility;
using System.Data;
namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> personelListesi = new List<EntityPersonel>();
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourcePersonel.spSelectPersonelwithDepartmanAd, Baglanti.connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                personelListesi.Add(new EntityPersonel
                {
                    PersonelId = Convert.ToInt32(dr[ResourcePersonel.PERSONELID]),
                    PersonelAd = dr[ResourcePersonel.PERSONELAD].ToString(),
                    PersonelSoyad = dr[ResourcePersonel.PERSONELSOYAD].ToString(),
                    PersonelDepartman = dr[ResourcePersonel.DEPARTMANAD].ToString(),
                    PersonelMaas = Convert.ToDecimal(dr[ResourcePersonel.PERSONELMAAS]),
                });
            }

            dr.Close();
            return personelListesi;
        }

        public static int PersonelEkle(EntityPersonel personelDeger)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourcePersonel.InsertPersonelSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourcePersonel.Parameter1, personelDeger.PersonelAd);
            command.Parameters.AddWithValue(ResourcePersonel.Parameter2, personelDeger.PersonelSoyad);
            command.Parameters.AddWithValue(ResourcePersonel.Parameter3, personelDeger.PersonelDepartmanId);
            command.Parameters.AddWithValue(ResourcePersonel.Parameter4, personelDeger.PersonelMaas);

            return command.ExecuteNonQuery();

        }

        public static bool PersonelSil(int? id)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourcePersonel.DeletePersonelSorgu, Baglanti.connection);

            command.Parameters.AddWithValue(ResourcePersonel.IdParameter, id);

            return command.ExecuteNonQuery() > 0;
        }

        public static EntityPersonel PersonelGetirById(int? id)
        {
            EntityPersonel entityPersonel = new EntityPersonel();
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourcePersonel.SelectPersonelByIdSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourcePersonel.IdParameter, id);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                entityPersonel.PersonelId = Convert.ToInt32(dr[ResourcePersonel.PERSONELID].ToString());
                entityPersonel.PersonelAd = dr[ResourcePersonel.PERSONELAD].ToString();
                entityPersonel.PersonelSoyad = dr[ResourcePersonel.PERSONELSOYAD].ToString();
                entityPersonel.PersonelDepartmanId = Convert.ToByte(dr[ResourcePersonel.PERSONELDEPARTMAN]);
                entityPersonel.PersonelMaas = Convert.ToDecimal(dr[ResourcePersonel.PERSONELMAAS]);
            }

            dr.Close();
            return entityPersonel;
        }

        public static int PersonelGuncelle(EntityPersonel personelDeger)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourcePersonel.UpdatePersonelSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourcePersonel.IdParameter, personelDeger.PersonelId);
            command.Parameters.AddWithValue(ResourcePersonel.AdParam, personelDeger.PersonelAd);
            command.Parameters.AddWithValue(ResourcePersonel.SoyadParam, personelDeger.PersonelSoyad);
            command.Parameters.AddWithValue(ResourcePersonel.DepartmanParam, personelDeger.PersonelDepartmanId);
            command.Parameters.AddWithValue(ResourcePersonel.MaasParam, personelDeger.PersonelMaas);

            return command.ExecuteNonQuery();

        }
    }
}
