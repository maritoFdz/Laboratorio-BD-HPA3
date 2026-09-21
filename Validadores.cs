using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSProyBD
{
    //La clase ValidadorTexto implementa la interfaz IValidatorCampo
    public class ValidadorTexto : IValidatorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;
        public bool EsValido(string? valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                MensajeError = "El campo de Texto no puede estar vacío";
                return false;
            }//Fin de IsNullOrWhiteSpaces

            return true;
        }//Fin del método EsValido
    }

    public class ValidadorEntero : IValidatorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;
        public bool EsValido(string? valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || !int.TryParse(valor, out int resultado) || resultado < 0)
            {
                MensajeError = "Debe ingresar un número entero válido";
                return false;
            }//Fin de IsNullOrWhiteSpaces

            return true;
        }//Fin del método EsValido
    }

    public class ValidadorDecimal : IValidatorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;
        public bool EsValido(string? valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || !decimal.TryParse(valor, out decimal resultado) || resultado < 0)
            {
                MensajeError = "Debe ingresar un número decimal válido";
                return false;
            }//Fin de IsNullOrWhiteSpaces

            return true;
        }//Fin del método EsValido
    }
}
