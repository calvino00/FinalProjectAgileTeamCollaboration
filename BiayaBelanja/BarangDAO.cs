using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BelanjaLibrary
{
    public class BarangDAO : IDisposable
    {
        SqlConnection _conn = null;
       
        public BarangDAO(string connectionString)
        {
            try
            {
                _conn = new SqlConnection(connectionString);
                _conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(Barang barang)
        {
            int result = 0;
            SqlTransaction trans = null;
            try
            {
                trans = _conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.Transaction = trans;
                    cmd.CommandText = @"Insert into TambahBarang values (@KodeBarang, @NamaBarang, @Pajak, @Harga)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@KodeBarang",barang.KodeBarang);
                    cmd.Parameters.AddWithValue("@NamaBarang",barang.NamaBarang);
                    cmd.Parameters.AddWithValue("@Pajak", barang.PajakBarang);
                    cmd.Parameters.AddWithValue("@Harga", barang.HargaBarang);
                    result = cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
                throw ex;
            }
            finally
            {
                if (trans != null) trans.Dispose();
            }
            return result;
        }

        public string GetKodeBarangBerikutnya()
        {
            string result = "";
            try
            {
                string nomorBarangTerakhir = "";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText =
                        @"Select Top 1 KodeBarang From TambahBarang              
                            order by KodeBarang desc";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                nomorBarangTerakhir = reader["KodeBarang"].ToString();
                            }
                        }
                    }
                }
                if (nomorBarangTerakhir == "")
                {
                    result = "N0001";
                }
                else
                {
                    int lastNumber = Convert.ToInt32(nomorBarangTerakhir.Substring(9));
                    result = $"N{(lastNumber + 1).ToString("0000")}";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public int DeleteBarang(string kode)
        {
            int result = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"delete barang where kode = @kode", _conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", kode);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public void Dispose()
        {
            if (_conn != null) _conn.Close();
        }
    }

}
