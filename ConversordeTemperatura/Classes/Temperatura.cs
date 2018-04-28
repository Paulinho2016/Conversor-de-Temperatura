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

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        /// <param name="g">Decimal contendo o valor do grau a ser convertido.</param>
        public Temperatura(decimal g)
        {
            graus = g;
        }

        #endregion



        #region MÉTODOS

        /// <summary>
        /// Método estático que faz a conversão de Celsuis para Kelvin.
        /// </summary>
        /// <returns>Retorna um Decimal contendo o valor da conversão.</returns>
        public static decimal CelsiusParaKelvin()
        {
            return graus + ZeroKelvin;
        }

        /// <summary>
        /// Método estático que faz a conversão de Kelvin para Celsius.
        /// </summary>
        /// <returns>Retorna um Decimal contendo o valor da conversão.</returns>
        public static decimal KelvinParaCelsius()
        {
            return graus - ZeroKelvin;
        }

        /// <summary>
        /// Método estático que faz a conversão de Fahrenheit para Celsius.
        /// </summary>
        /// <returns>Retorna um Decimal contendo o valor da conversão.</returns>
        public static decimal FahrenheitParaCelsius()
        {
            return (1.8m * graus) + 32;
        }

        /// <summary>
        /// Método estático que faz a conversão de Celsuis para Fahrenheit.
        /// </summary>
        /// <returns>Retorna um Decimal contendo o valor da conversão.</returns>
        public static decimal CelsiusParaFahrenheit()
        {
            return (graus - 32) / 1.8m;
        }

        /// <summary>
        /// Método estático que faz a conversão de Kelvin para Fahrenheit.
        /// </summary>
        /// <returns>Retorna um Decimal contendo o valor da conversão.</returns>
        public static decimal KelvinParaFahrenheit()
        {
            return (KelvinParaCelsius() - 32) / 1.8m;
        }

        /// <summary>
        /// Método estático que faz a conversão de Fahrenheit para Kelvin.
        /// </summary>
        /// <returns>Retorna um Decimal contendo o valor da conversão.</returns>
        public static decimal FahrenheitParaKelvin()
        {
            return FahrenheitParaCelsius() + ZeroKelvin;
        }

        #endregion
    }
}