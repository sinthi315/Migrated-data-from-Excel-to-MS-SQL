using MySql.Data.MySqlClient;

namespace FPMG
{
    public class MySqlHelper
    {
        public static MySqlConnection cn;
        public MySqlHelper(string connectionString)
        {
            cn = new MySqlConnection(connectionString);
        }
        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
