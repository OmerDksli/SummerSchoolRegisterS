using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayers
{
    public class Connection
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-STOKBJ0;Initial Catalog=DbSummerSchool;Integrated Security=True");
    }
}
