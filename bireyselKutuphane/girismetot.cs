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
        public int kullaniciKontrolOgrenci(string mail,string parola)
        {   int sonuc = 0;
            using(var con=new MySqlConnection(conStr))
            {  using (var cmd = new MySqlCommand($"SELECT mail,parola FROM ogrenci WHERE mail='{mail}'AND parola='{parola}'", con))
                {  try
                    { cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {  string dKart_id = dtr["mail"].ToString();
                            string dParola = dtr["parola"].ToString();
                            if (dKart_id == mail && dParola == parola)
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
        public int kullaniciKontrolOgretmen(string mail, string parola)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(conStr))
            {
                using (var cmd = new MySqlCommand($"SELECT mail,parola FROM ogretmen WHERE mail='{mail}'AND parola='{parola}'", con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string dKart_id = dtr["ogretmen_id"].ToString();
                            string dParola = dtr["parola"].ToString();
                            if (dKart_id == mail && dParola == parola)
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

        public int kullaniciKontrolPersonel(string mail, string parola)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(conStr))
            {
                using (var cmd = new MySqlCommand($"SELECT mail,parola FROM personel WHERE mail='{mail}'AND parola='{parola}'", con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string dKart_id = dtr["personel_id"].ToString();
                            string dParola = dtr["parola"].ToString();
                            if (dKart_id ==mail && dParola == parola)
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
