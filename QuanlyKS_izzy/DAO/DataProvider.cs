using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;


namespace DAO
{
    public class DataProvider
    {
        public string strConnection = "Server = .\\SQLEXPRESS;Integrated Security = True;Database = quanlykhachsan";
        //public string strConnection = "Server = localhost;Integrated Security = True;Database = quanlykhachsan";
        //public string strConnection = ConfigurationManager.ConnectionStrings["AppDatabase"].ConnectionString;
        protected SqlConnection cnn;
        protected SqlCommand cmd;
        protected SqlDataAdapter da;

        

        public void Connect(){
            cnn = new SqlConnection(@strConnection);
            cnn.Open();
        }
        protected void disConnect(){
            cnn.Close();
        }
        public bool ExecuteNonQuery(string sqlStatement){
            try
            {
                Connect();
                cmd = new SqlCommand(@sqlStatement,cnn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                disConnect();
                return true;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public void ExecuteUpdateQuery(string sqlStatement)
        {
            ExecuteNonQuery(sqlStatement);
        }
        public DataSet ExecuteQuery(string sqlStatement)
        {
            Connect();

            DataSet dataset = new DataSet();
            cmd = new SqlCommand();
            cmd.Connection = this.cnn;
            da = new SqlDataAdapter(sqlStatement, cnn);
            try{
                da.Fill(dataset);
            }catch (SqlException ex){ 
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

            disConnect();
            return dataset;
        }
        public DataTable ExecuteQuery_DataTble(string sqlStatement)
        {
            Connect();

            DataTable dt = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = this.cnn;
            da = new SqlDataAdapter(sqlStatement, cnn);
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

            disConnect();
            return dt;
        }
    }
}
