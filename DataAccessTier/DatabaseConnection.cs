using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessTier
{
    public class DatabaseConnection
    {
        protected SqlConnection connection;

        protected bool KiemTraKetNoi()
        {
            return connection.State == ConnectionState.Open;
        }

        public DatabaseConnection()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=.\MINHHIEU;Initial Catalog=DB_BANVEMAYBAY;Integrated Security=True");
            }
            catch (Exception)
            {                
            }
        }
        protected DataTable ExecuteQuery(string StoreProcedure, Dictionary<string, object> parameters = null)
        {
            if (!KiemTraKetNoi())
            {
                connection.Open();
            }
            try
            {
                SqlCommand command = new SqlCommand(StoreProcedure, connection);
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> entry in parameters)
                    {
                        command.Parameters.AddWithValue(entry.Key, entry.Value);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);             
                return table;
            }
            catch (Exception)
            {                
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        protected void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            if (!KiemTraKetNoi())
            {
                connection.Open();
            }
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> entry in parameters)
                        command.Parameters.AddWithValue(entry.Key, entry.Value);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connection.Close();
            }
        }

        protected void ExcuteStoreProcedure(string sp, Dictionary<string, object> parameters = null){
            if (!KiemTraKetNoi())
            {
                connection.Open();
            }
            try
            {
                SqlCommand command = new SqlCommand(sp, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> entry in parameters)
                        command.Parameters.AddWithValue(entry.Key, entry.Value);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connection.Close();
            }
        }
        protected DataTable ExcuteStoreProcedureReturnRecord(string sp, Dictionary<string, object> parameters = null){
            if (!KiemTraKetNoi())
            {
                connection.Open();
            }
            try
            {
                 SqlCommand command = new SqlCommand(sp, connection);
                 command.CommandType = CommandType.StoredProcedure;
                 if (parameters != null)
                 {
                     foreach (KeyValuePair<string, object> entry in parameters)
                         command.Parameters.AddWithValue(entry.Key, entry.Value);
                 }
                 SqlDataAdapter adapter = new SqlDataAdapter();
                 adapter.SelectCommand = command;
                 DataTable table = new DataTable();
                 adapter.Fill(table);
                 return table;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
      
    }
}
