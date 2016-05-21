using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace DTO
{
    public abstract class DTObject
    {
        public static DataTable getAll(string name_table)
        {
            DataTable data;
            try
            {
                DataProvider provider = new DataProvider();
                string sql = "select * from " + name_table;
                data = provider.ExecuteQuery_DataTble(sql);
            }
            catch (Exception)
            {
                data = new DataTable();
                throw;
            }
            return data;
        }
        public static bool insert(string name_table, string[] array_columns, string[] array_values)
        {
            try
            {
                DataProvider provider = new DataProvider();
                string sql = "insert into " + name_table + "(" + String.Join(",", array_columns) + ") values(" + String.Join(",", array_values) + ")";
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
