using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversordeTemperatura.Classes
{
    class Temperatura
    {
        #region DECLARAÇÔES

        //--> Constantes
        const decimal ZeroCelsius = 0;
        const decimal ZeroKelvin = 273;
        const decimal ZeroFahrenheit = -459.67m;

        //--> Variáveis
        static decimal graus;

        #endregion


        #region CONSTRUTORES

        public Temperatura(decimal g)
        {
            graus = g;
        }

        #endregion



        #region MÉTODOS

        public static decimal CelsiusParaKelvin()
        {
            return graus + ZeroKelvin;
        }

        public static decimal KelvinParaCelsius()
        {
            return graus - ZeroKelvin;
        }

        public static decimal FahrenheitParaCelsius()
        {
            return (1.8m * graus) + 32;
        }

        public static decimal CelsiusParaFahrenheit()
        {
            return (graus - 32) / 1.8m;
        }

        public static decimal KelvinParaFahrenheit()
        {
            return (KelvinParaCelsius() - 32) / 1.8m;
        }

        public static decimal FahrenheitParaKelvin()
        {
            return FahrenheitParaCelsius() + ZeroKelvin;
        }

        #endregion
    }
}