using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis
{
   public static class ComunidadesOrm
    {
        public static List<comunitats> Select()
        {
            List<comunitats> _comunidades =
            (
                from c in Orm.bdconnection.comunitats select c
            ).ToList();
            return _comunidades;
        }
    }
}
