using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RestoranProje.utils
{
    class SepetDetaylari
    {
        public int Sepet_Id = -1;
        public int Masa_Id = -1;
        public int Yemek_Id = -1;
        public string Yemek_adi = "";
        public int Yemek_fiyat = -1;
    }
    internal class Database
    {
        private string connectionString = "Data Source=./veritabani.db";
        public SqliteConnection Connection { get; private set; }
        public Database() {
            this.Connection = new SqliteConnection(connectionString);
            this.Connection.Open();
        }

        public List<SepetDetaylari> SepetiGetir(int masaId)
        {
            SqliteCommand cmd = new SqliteCommand();

            cmd.Connection = this.Connection;
            cmd.CommandText = @"
                SELECT sepet.Sepet_Id, sepet.Masa_Id, sepet.Yemek_Id, sepet.Yemek_fiyat, menu.Yemek_Id, menu.Yemek_adi, menu.Yemek_fiyat
                FROM sepet
                INNER JOIN menu ON menu.Yemek_Id = sepet.Yemek_Id WHERE sepet.Masa_Id="+masaId;

            var _reader = cmd.ExecuteReader();

            List<SepetDetaylari> sd = new List<SepetDetaylari>();

            Console.WriteLine(masaId.ToString());

            while (_reader.Read())
            {
                SepetDetaylari nsd = new SepetDetaylari();
                    
                nsd.Sepet_Id = _reader.GetInt32(0);
                nsd.Masa_Id = _reader.GetInt32(1);
                nsd.Yemek_Id = _reader.GetInt32(2);
                nsd.Yemek_adi = _reader.GetString(5);
                nsd.Yemek_fiyat = _reader.GetInt32(6);

                sd.Add(nsd);
            }

            _reader.Close();

            return sd;
        }

        public bool SepeteEkle(int masaId, int yemekId, int yemekFiyat)
        {
            SqliteCommand cmd = new SqliteCommand();
            Console.WriteLine(masaId.ToString() + "SEPETE EKLE İŞLEMİ");
            cmd.Connection = this.Connection;
            cmd.CommandText = "INSERT INTO sepet(Masa_Id, Yemek_Id, Yemek_fiyat) VALUES (" + masaId + ", " + yemekId + ", " + yemekFiyat + ")";

            cmd.ExecuteNonQuery();
            return true;
        }

        public bool MasaSepetVerisiSil(int masaId)
        {
            SqliteCommand cmd = new SqliteCommand();
            Console.WriteLine(masaId.ToString() + "SEPETE EKLE İŞLEMİ");
            cmd.Connection = this.Connection;
            cmd.CommandText = "DELETE FROM sepet WHERE Masa_Id="+masaId.ToString();

            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
