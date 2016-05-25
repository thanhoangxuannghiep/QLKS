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
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable getAllWhere(string name_table, string where)
        {
            DataTable data;
            try
            {
                DataProvider provider = new DataProvider();
                string sql = "select * from " + name_table + " WHERE " + where;
                data = provider.ExecuteQuery_DataTble(sql);
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool insert(string name_table, string[] array_columns, string[] array_values)
        {
            try
            {
                DataProvider provider = new DataProvider();
                string _values = "";
                for (int i = 0; i < array_values.Length; i++)
                {
                    _values += "N'";
                    _values += array_values[i];
                    _values += "'";
                    if (i < array_values.Length -1)
                        _values += ",";
                }
                string sql = "INSERT INTO " + name_table + "(" + String.Join(",", array_columns) + ") VALUES(" + _values + ")";
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool update(string _table, string _set, string _where)
        {

            try
            {
                DataProvider provider = new DataProvider();

                string sql = "UPDATE "+ _table +" SET " + _set + " WHERE " + _where;
                return provider.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable exec(string query)
        {
            try
            {
                DataProvider provider = new DataProvider();

                return provider.ExecuteQuery_DataTble(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
