using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sincronizador.Controller
{
    public class OracleContext
    {
        public OracleConnection Connection { get; set; }
        public OracleCommand Command { get; set; }
        public OracleDataAdapter DataAdapter { get; set; }
        public OracleDataReader DataReader { get; set; }

        public OracleContext(string stringConnection)
        {
            try
            {
                Connection = new OracleConnection(stringConnection);
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + "\n" + ex.ToString());
            }
        }



        public DataTable Select(string sql)
        {
            DataTable table = new DataTable();
            try
            {

                Connection.Open();

                using (Command = new OracleCommand())
                {
                    Command.CommandText = Regex.Replace(sql, @"\s+", " ");
                    Command.Connection = Connection;

                    using (DataAdapter = new OracleDataAdapter(Command))
                    {
                        DataAdapter.Fill(table);
                        Connection.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Connection.Close();
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + "\n" + e.ToString());
                return null;
            }
            Connection.Close();
            return table;
        }
        public bool Probar(string sql)
        {

            try
            {
                Connection.Open();
                using (Command = new OracleCommand())
                {
                    Command.CommandText = Regex.Replace(sql, @"\s+", " ");
                    Command.Connection = Connection;
                    var reader = Command.ExecuteReader();
                    if (Connection.State == ConnectionState.Open)
                        Connection.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + e.Message);
                return false;
            }

        }
    }

}
