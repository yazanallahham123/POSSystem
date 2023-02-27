using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem.Common
{
    public class Connection
    {
        public static SqlConnection Con_instance = null;
        //TODO: Handle change for connection string from ConnectionString
        public static string DatabaseName = string.Empty;

        // Lock synchronization object
        private static object syncLock = new object();

        public static SqlConnection GetDataConnection()
        {           

            if (Con_instance == null)
            {
                lock (syncLock)
                {
                    if (Con_instance == null)
                    {
                        return new SqlConnection(Settings.connectionString());
                    }

                }
            }

            return Con_instance;
        }
    }
}
