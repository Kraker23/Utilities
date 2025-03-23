using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UtilitiesNet.Extensiones
{

    public class Validaciones
    {
        /*
        Validar una URL: /^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \?=.-]*)*\/?$/  
        Validar un Email: \w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)* 
        Validar un numero de Telefono: ^[+-]?\d+(\.\d+)?$
        Validar una tarjeta de credito ^((67\d{2})|(4\d{3})|(5[1-5]\d{2})|(6011))(-?\s?\d{4}){3}|(3[4,7])\ d{2}-?\s?\d{6}-?\s?\d{5}$  
        Validar un codigo postal ^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$  
        Validar un Nombre [a-zA-ZñÑ\s]{2,50}
        Validar Domicilio: ^.*(?=.*[0-9])(?=.*[a-zA-ZñÑ\s]).*$
        Validar IFE ^.*(?=.{13})[+-]?\d+(\.\d+)?$
        Validar CURP ^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$
        Solo Numeros [0-9]{1,9}(\.[0-9]{0,2})?$
        Solo Letras [a-zA-ZñÑ\s] 
         * 
         * 
        Formato dd/mm/yyyy
        ^(0?[1-9]|[12][0-9]|3[01])[\/](0?[1-9]|1[012])[\/](19|20)\d{2}$
        
        Formato (MM/dd/yyyy):
        ^(?:(?:(?:0?[13578]|1[02])(\/|-)31)|(?:(?:0?[1,3-9]|1[0-2])(\/|-)(?:29|30)))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(?:(?:0?[1-9]|1[0-2])(\/|-)(?:0?[1-9]|1\d|2[0-8]))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(0?2(\/|-)29)(\/|-)(?:(?:0[48]00|[13579][26]00|[2468][048]00)|(?:\d\d)?(?:0[48]|[2468][048]|[13579][26]))$

        Formato (dd/MM/yyyy):
        ^(?:(?:0?[1-9]|1\d|2[0-8])(\/|-)(?:0?[1-9]|1[0-2]))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(?:(?:31(\/|-)(?:0?[13578]|1[02]))|(?:(?:29|30)(\/|-)(?:0?[1,3-9]|1[0-2])))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(29(\/|-)0?2)(\/|-)(?:(?:0[48]00|[13579][26]00|[2468][048]00)|(?:\d\d)?(?:0[48]|[2468][048]|[13579][26]))$
         */


        public static bool validarPassword(string pass, int minLength, int numUpper, int numLower, int numNumbers, int numSpecial)
        {
            System.Text.RegularExpressions.Regex upper = new System.Text.RegularExpressions.Regex("[A-Z]");
            System.Text.RegularExpressions.Regex lower = new System.Text.RegularExpressions.Regex("[a-z]");
            System.Text.RegularExpressions.Regex number = new System.Text.RegularExpressions.Regex("[0-9]");
            System.Text.RegularExpressions.Regex special = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");

            if (pass.Length < minLength) return false;
            if (upper.Matches(pass).Count < numUpper) return false;
            if (lower.Matches(pass).Count < numLower) return false;
            if (number.Matches(pass).Count < numNumbers) return false;
            if (special.Matches(pass).Count < numSpecial) return false;

            return true;
        }


        public static bool validarMails(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (System.Text.RegularExpressions.Regex.IsMatch(email, expresion))
            {
                if (System.Text.RegularExpressions.Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
