using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DAO
{
    public class DataProvider
    {
        public string strConnection = "Server = .\\SQLEXPRESS;Integrated Security = True;Database = quanlykhachsan";
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
        protected void ExecuteNonQuery(string sqlStatement){
            cmd = new SqlCommand(sqlStatement);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        protected void ExecuteUpdateQuery(string sqlStatement){
            Connect();
            ExecuteNonQuery(sqlStatement);
            disConnect();
        }
        public DataSet ExecuteQuery(string sqlStatement)
        {
            DataSet dataset = new DataSet();
            cmd = new SqlCommand();
            cmd.Connection = this.cnn;
            da = new SqlDataAdapter(sqlStatement, cnn);
            try{
                da.Fill(dataset);
            }catch (SqlException ex){ 
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            return dataset;
        }
        public DataTable ExecuteQuery_DataTble(string sqlStatement)
        {
            return ExecuteQuery(sqlStatement).Tables[0]; 
        }
    }
}
