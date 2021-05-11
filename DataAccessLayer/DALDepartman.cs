using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;
using Utility;
namespace DataAccessLayer
{
    public class DALDepartman
    {
        public static List<EntityDepartman> DepartmanListesi()
        {
            List<EntityDepartman> departmanListesi = new List<EntityDepartman>();
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceDepartman.SelectDepartmanSorgu, Baglanti.connection);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                departmanListesi.Add(new EntityDepartman
                {
                    DepartmanId = Convert.ToByte(dr[ResourceDepartman.DEPARTMANID].ToString()),
                    DepartmanAd = dr[ResourceDepartman.DEPARTMANAD].ToString()
                });
            }

            dr.Close();
            return departmanListesi;
        }

        public static int DepartmanEkle(EntityDepartman departmanDeger)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceDepartman.InsertDepartmanSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceDepartman.Parameter, departmanDeger.DepartmanAd);

            return command.ExecuteNonQuery();

        }

        public static bool DepartmanSil(int? id)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceDepartman.DeleteDepartmanSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceDepartman.IdParameter, id);

            return command.ExecuteNonQuery() > 0;
        }

        public static EntityDepartman DepartmanGetirById(byte? id)
        {
            EntityDepartman entityDepartman = new EntityDepartman();
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceDepartman.SelectDepartmanByIdSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceDepartman.IdParameter, id);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                entityDepartman.DepartmanId = Convert.ToByte(dr[ResourceDepartman.DEPARTMANID]);
                entityDepartman.DepartmanAd = dr[ResourceDepartman.DEPARTMANAD].ToString();
            }

            dr.Close();
            return entityDepartman;
        }

        public static int DepartmanGuncelle(EntityDepartman departmanDeger)
        {
            SqlCommand command = MyExtensions.CreateCommandAndOpenConnection(ResourceDepartman.UpdateDepartmanSorgu, Baglanti.connection);
            command.Parameters.AddWithValue(ResourceDepartman.AdParameter, departmanDeger.DepartmanAd);
            command.Parameters.AddWithValue(ResourceDepartman.IdParameter, departmanDeger.DepartmanId);

            return command.ExecuteNonQuery();

        }
    }

}
