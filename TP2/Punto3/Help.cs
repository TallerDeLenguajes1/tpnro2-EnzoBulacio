using System;
using System.Collections.Generic;
using System.Text;

namespace Punto3
{
    static class Help
    {
        public static DateTime FechaA(int anio)
        {
            Random gen = new Random();
            DateTime st = DateTime.Today.AddDays(- anio);
            int ran = (DateTime.Today - st).Days;
            return st.AddDays(gen.Next(ran));
        }
    }
}
