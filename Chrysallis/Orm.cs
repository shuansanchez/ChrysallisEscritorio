using System;
using System.Data.SqlClient;

namespace Chrysallis
{
    class Orm
    {
        public static CHRYSALLISEntities bdconnection = new CHRYSALLISEntities();

        public static String MissatgeError(SqlException sqlException)
        {
            String missatge = "";
            switch (sqlException.Number)
            {
                case 2:
                    missatge = "El servidor no està operatiu";
                    break;
                case 547:
                    missatge = "El registre té dades relacionades";
                    break;
                case 2601:
                    missatge = "Registre duplicat";
                    break;
                case 2627:
                    missatge = "Registre duplicat";
                    break;
                case 4060:
                    missatge = "No es pot obrir la base de dades";
                    break;
                case 18456:
                    missatge = "Error al iniciar la sessió";
                    break;
                default:
                    missatge = sqlException.Number + " - " + sqlException.Message;
                    break;
            }
            return missatge;
        }

    }
}
