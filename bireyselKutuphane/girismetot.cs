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
        public int kullaniciKontrolOgrenci(int kart_id,string parola)
        {   int sonuc = 0;
            using(var con=new MySqlConnection(conStr))
            {  using (var cmd = new MySqlCommand($"SELECT kart_id,parola FROM ogrenci WHERE kart_id='{kart_id}'AND parola='{parola}'", con))
                {  try
                    { cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {  int dKart_id = Convert.ToInt32(dtr["kart_id"]);
                            string dParola = dtr["parola"].ToString();
                            if (dKart_id == kart_id && dParola == parola)
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
        public int kullaniciKontrolOgretmen(int kart_id, string parola)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(conStr))
            {
                using (var cmd = new MySqlCommand($"SELECT kart_id,parola FROM ogretmen WHERE kart_id='{kart_id}'AND parola='{parola}'", con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            int dKart_id = Convert.ToInt32(dtr["kart_id"]);
                            string dParola = dtr["parola"].ToString();
                            if (dKart_id == kart_id && dParola == parola)
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

        public int kullaniciKontrolPersonel(int kart_id, string parola)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(conStr))
            {
                using (var cmd = new MySqlCommand($"SELECT kart_id,parola FROM personel WHERE kart_id='{kart_id}'AND parola='{parola}'", con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            int dKart_id = Convert.ToInt32(dtr["kart_id"]);
                            string dParola = dtr["parola"].ToString();
                            if (dKart_id == kart_id && dParola == parola)
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
