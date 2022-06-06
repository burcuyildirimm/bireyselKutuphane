using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace bireyselKutuphane
{
    class girismetot
    {   string conStr = "Server = 172.21.54.3; uid = BurcuNYP; pwd =Burcu12345.; database = BurcuNYP";
        public int kullaniciKontrolOgrenci(int id,string parola)
        {   int sonuc = 0;
            using(var con=new MySqlConnection(conStr))
            {  using (var cmd = new MySqlCommand($"SELECT ogrenci_id,parola FROM ogrenci WHERE ogrenci_id='{id}'AND parola='{parola}'", con))
                {  try
                    { cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {  int dKart_id = Convert.ToInt32(dtr["ogrenci_id"]);
                            string dParola = dtr["parola"].ToString();
                            if (dKart_id == id && dParola == parola)
                            { sonuc = 1;
                            }
                            else
                            {  sonuc = 0;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        sonuc = 0;
                    }
                }
            }
            return sonuc;
        }
        public int kullaniciKontrolOgretmen(int id, string parola)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(conStr))
            {
                using (var cmd = new MySqlCommand($"SELECT ogretmen_id,parola FROM ogretmen WHERE ogretmen_id='{id}'AND parola='{parola}'", con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            int dKart_id = Convert.ToInt32(dtr["ogretmen_id"]);
                            string dParola = dtr["parola"].ToString();
                            if (dKart_id == id && dParola == parola)
                            {  sonuc = 1;
                            }
                            else
                            { sonuc = 0;
                            }
                        }
                    }
                    catch (Exception)
                    { sonuc = 0;
                    }
                }
            }
            return sonuc;
        }

        public int kullaniciKontrolPersonel(int id, string parola)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(conStr))
            {
                using (var cmd = new MySqlCommand($"SELECT personel_id,parola FROM personel WHERE personel_id='{id}'AND parola='{parola}'", con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            int dKart_id = Convert.ToInt32(dtr["personel_id"]);
                            string dParola = dtr["parola"].ToString();
                            if (dKart_id == id && dParola == parola)
                            {
                                sonuc = 1;
                            }
                            else
                            {
                                sonuc = 0;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        sonuc = 0;
                    }
                }
            }
            return sonuc;
        }
    }
}
