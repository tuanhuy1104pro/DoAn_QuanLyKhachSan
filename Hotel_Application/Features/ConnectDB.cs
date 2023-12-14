using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hotel_Application.Features
{
    public class ConnectDB
    {
        public static SqlConnection connectstring = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=QLKS;Integrated Security=True;"); //put your connectionstring from database here
    }
}
