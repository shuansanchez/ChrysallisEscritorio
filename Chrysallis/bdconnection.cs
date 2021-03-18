using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis
{
    class bdconnection
    {
        public static SqlConnection connection =
            new SqlConnection("Data Source=localhost\\sqlexpress;DATABASE=chrysallis;User ID=sa; Password=misteryatu;");
    }
}
