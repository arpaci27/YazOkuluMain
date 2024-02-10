using System.Data;
using System.Data.SqlClient;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace DataAccesLayer
{
    public class Connection
    {
        public static SqlConnection connector = 
            new SqlConnection(@"Data Source=ARPACI;Initial Catalog=YazOkuluDB;Integrated Security=True;Encrypt=False;");
    }
}
