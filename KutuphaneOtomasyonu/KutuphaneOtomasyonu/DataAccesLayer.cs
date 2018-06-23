using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    class DataAccesLayer
    {


        public SqlConnection cnn = null;


        string scnn = "Server=DESKTOP-J3NQLPF\\SQLEXPRESS;Database=KutuphaneOtomasyonu;Trusted_Connection=True;";
        public void cnnOpen()
        {
            cnn = new SqlConnection(scnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cnnClose()
        {
            if (cnn.State == ConnectionState.Open | cnn != null)
            {
                cnn.Close();

            }
        }
        public DataTable ExecuteDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cnnOpen();
            cmd.Connection = cnn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cnnClose();
            return dt;
        }
        public bool Exist(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cnnOpen();
            cmd.Connection = cnn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cnnClose();
            if (dt.Rows.Count < 1)
            {
                return false;
            }
            return true;
        }
        public int Execute(string sql)
        {
            cnnOpen();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public int ExecuteParam(string sql, System.Collections.ArrayList prm)
        {
            cnnOpen();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            if (prm != null)
            {
                if (prm.Count > 0)
                {
                    for (int i = 0; i < prm.Count; i++)
                    {
                        cmd.Parameters.Add(prm[i]);
                    }
                }
            }
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        public DataSet ExecuteDataSet(string[] sql, string[] name)
        {
            DataSet ds = new DataSet();
            cnnOpen();
            if (sql.Length != name.Length)
            {
                MessageBox.Show("Gelen veriler uyuşmuyor.");
                return null;
            }
            SqlDataAdapter da = null;
            for (int i = 0; i < sql.Length; i++)
            {
                da = new SqlDataAdapter(sql[i], cnn);
                da.Fill(ds, name[i]);
            }
            cnnClose();
            return ds;
        }
        public string[,] CumleGetir(string sSQL, ArrayList prm)
        {
            string[,] retV;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cnnOpen();
                cmd.Connection = cnn;
                cmd.CommandText = sSQL;
                cmd.CommandType = CommandType.Text;
                if (prm != null)
                {
                    if (prm.Count > 0)
                    {
                        for (int i = 0; i < prm.Count; i++)
                        {
                            cmd.Parameters.Add(prm[i]);
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cnnClose();
                string[,] stringArray = new string[dt.Rows.Count, dt.Columns.Count];
                int row;
                for (row = 0; row < dt.Rows.Count; ++row)
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        stringArray[row, col] = dt.Rows[row][col].ToString();
                    }
                }
                return retV = stringArray;
            }
            catch (Exception )
            {
                return null;
            }
        }
        public int ExecuteScaler(string sql)
        {
            cnnOpen();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            try
            {
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

    }
}
