using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public static class SystemParameters
    {
        private static Credencial _credencial;

        public static void Authenticate(Credencial credencial)
        {
            _credencial = credencial;
        }

        public static Credencial GetCurrrentCredencial()
        {
            return _credencial;
        }
    }
}
