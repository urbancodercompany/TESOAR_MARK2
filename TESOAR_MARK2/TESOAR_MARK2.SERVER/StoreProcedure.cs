using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESOAR_MARK2.SERVER
{
    public class StoreProcedure
    {
        static SqlConnection sqlCon;
        static SqlCommand sqlCmd;

        public static void InitializeSql( string source, string catalog )
        {
            // string conString = "Data Source=.; Initial Catalog=DemoTest; User Id=sa; Password=appcloud;";
            string conString = $"Data Source={source}; Initial Catalog={catalog}; Integrated Security=SSPI;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
        }

        public static DataTable FetchDetails( string spName )
        {
            if ( sqlCon.State == ConnectionState.Closed )
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCmd = new SqlCommand(spName, sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "FetchData");
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            sqlSda.Fill(dtData);
            return dtData;
        }

        public static DataTable FetchDetailsCBO( string spName, string fetchName )
        {
            if ( sqlCon.State == ConnectionState.Closed )
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCmd = new SqlCommand(spName, sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", fetchName);
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            sqlSda.Fill(dtData);
            return dtData;
        }

        public static DataTable FetchRecords( string spName, string id )
        {
            if ( sqlCon.State == ConnectionState.Closed )
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCmd = new SqlCommand(spName, sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "FetchRecord");
            sqlCmd.Parameters.AddWithValue("@Id", id);
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            sqlSda.Fill(dtData);
            return dtData;
        }

        public static void SaveData( string spName, List<string> spVar, List<string> txtVar )
        {
            try
            {
                if ( sqlCon.State == ConnectionState.Closed )
                {
                    sqlCon.Open();
                }
                sqlCmd = new SqlCommand(spName, sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");

                for ( int i = 0; i < txtVar.Count; i++ )
                {
                    sqlCmd.Parameters.AddWithValue(spVar [ i ], txtVar [ i ]);
                }

                int numRes = sqlCmd.ExecuteNonQuery();
                if ( numRes > 0 )
                {
                    MessageBox.Show("¡Registro guardado con éxito!");
                }
                else
                    MessageBox.Show("¡Inténtalo de nuevo!");
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        public static void DeleteData( string spName, string id )
        {
            if ( !string.IsNullOrEmpty(id) )
            {
                try
                {
                    if ( sqlCon.State == ConnectionState.Closed )
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand(spName, sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "DeleteData");
                    sqlCmd.Parameters.AddWithValue("@Id", id);
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if ( numRes > 0 )
                    {
                        MessageBox.Show("¡Registro eliminado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("¡Inténtalo de nuevo!");
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("¡Por favor seleccione un registro!");
            }
        }
    }
}
