using System;
using System.Data.SqlClient;

namespace Chrysallis
{
    class bdconnection
    {
        SqlConnection connection =new SqlConnection("Data Source=localhost;DATABASE=chrysallis;User ID=sa; Password=Informatica_2020;");
    }
}
