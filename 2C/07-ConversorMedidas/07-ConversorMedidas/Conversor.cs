﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    public static class Conversor
    {
        public static string KgParaG(double kg) //inicio da conversão das massas.
        {
            double g = kg / 1000;
            return string.Format("{0} kg são {1} g", kg, g);
        }
        public static string GParaKg(double g)
        {
            double kg = g / 1000;
            return string.Format("{0} g são {1} kg", g, kg);
        }
        public static string KgParaT(double kg)
        {
            double t = kg / 1000;
            return string.Format("{0} kg são {1} t", kg, t);
        }
        public static string TParaKg(double t)
        {
            double kg = t * 1000;
            return string.Format("{0} t são {1} kg", t, kg);
        }
        public static string KgParaLbs(double kg)
        {
            double lbs = kg * 2.2046;
            return string.Format("{0} kg são {1} lbs", kg, lbs);
        }
        public static string LbsParaKg(double lbs)
        {
            double kg = lbs / 2.2046;
            return string.Format("{0} lbs são {1} kg", lbs, kg);
        }
        public static string CParaF(double c) //inicio da conversão de temperaturas
        {
            double f = (9 * c + 160) / 5;
            return string.Format("{0} ºC são {1} ºF", c, f);
        }
        public static string FParaC(double f)
        {
            double c = (5 * f - 160) / 9;
            return string.Format("{0} ºF são {1} ºC", f, c);
        }
        public static string FParaK(double f)
        {
            double k = (f - 32) / 1.8000 + 273.15;
            return string.Format("{0} ºF são {1} ºK", f, k);
        }
        public static string KParaF(double k)
        {
            double f = (k - 273.15) * 1.8000 + 32.00;
            return string.Format("{0} ºK são {1} ºF", k, f);
        }
        public static string KParaC(double k)
        {
            double c = k - 273.15;
            return string.Format("{0} ºK são {1} ºC", k, c);
        }
        public static string CParaK(double c)
        {
            double k = c + 273.15;
            return string.Format("{0} ºC são {1} ºK", c, k);
        }
        public static string MParaKm(double m) //inicio da conversão de distância
        {
            double km = m / 1000;
            return string.Format("{0} m são {1} km", m, km);
        }
        public static string KmParaM(double km)
        {
            double m = km * 1000;
            return string.Format("{0} km são {1} m", km, m);
        }
        public static string KmParaMi(double km)
        {
            double mi = km * 0.62137;
            return string.Format("{0} km são {1} mi", km, mi);
        }
        public static string MiParaKm(double mi)
        {
            double km = mi / 0.62137;
            return string.Format("{0} mi são {1} km", mi, km);
        }
        public static string MParaFt(double m)
        {
            double ft = m * 3.2808;
            return string.Format("{0} m são {1} ft", m, ft);
        }
        public static string FtParaM(double ft)
        {
            double m = ft / 3.2808;
            return string.Format("{0} ft são {1} m", ft, m);
        }
        public static string MParaIn(double m)
        {
            double In = m * 39.370;
            return string.Format("{0} m são {1} in", m, In);
        }
        public static string InParaM(double In)
        {
            double m = In / 39.370;
            return string.Format("{0} in são {1} m", In, m);
        }
        public static string InParaFt(double In)
        {
            double ft = In * 0.083333;
            return string.Format("{0} in são {1} ft", In, ft);
        }
        public static string FtParaIn(double ft)
        {
            double In = ft * 12.000;
            return string.Format("{0} ft são {1} in", ft, In);
        }
    }
}
