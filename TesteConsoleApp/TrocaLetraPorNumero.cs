using System;
using System.Collections.Generic;
using System.Text;

namespace EscreveCaracterNumero
{
    class TrocaLetraPorNumero
    {
        public string RetornaLetraABC(string letra)
        {
            string retorna = "";
            if (letra == "A")
                retorna = "2";
            else if (letra == "B")
                retorna = "22";
            else if (letra == "C")
                retorna = "222";
            return retorna;
        }
        public string RetornaLetraDEF(string letra)
        {
            string retorna = "";
            if (letra == "D")
                retorna = "3";
            else if (letra == "E")
                retorna = "33";
            else if (letra == "F")
                retorna = "333";
            return retorna;
        }
        public string RetornaLetraGHI(string letra)
        {
            string retorna = "";
            if (letra == "G")
                retorna = "4";
            else if (letra == "H")
                retorna = "44";
            else if (letra == "I")
                retorna = "444";
            return retorna;
        }
        public string RetornaLetraJKL(string letra)
        {
            string retorna = "";
            if (letra == "J")
                retorna = "5";
            else if (letra == "K")
                retorna = "55";
            else if (letra == "L")
                retorna = "555";
            return retorna;
        }
        public string RetornaLetraMNO(string letra)
        {
            string retorna = "";
            if (letra == "M")
                retorna = "6";
            else if (letra == "N")
                retorna = "66";
            else if (letra == "O")
                retorna = "666";
            return retorna;
        }
        public string RetornaLetraPQRS(string letra)
        {
            string retorna = "";
            if (letra == "P")
                retorna = "7";
            else if (letra == "Q")
                retorna = "77";
            else if (letra == "R")
                retorna = "777";
            else if (letra == "S")
                retorna = "7777";
            return retorna;
        }
        public string RetornaLetraTUV(string letra)
        {
            string retorna = "";
            if (letra == "T")
                retorna = "8";
            else if (letra == "U")
                retorna = "88";
            else if (letra == "V")
                retorna = "888";

            return retorna;
        }
        public string RetornaLetraWXYZ(string letra)
        {
            string retorna = "";
            if (letra == "W")
                retorna = "9";
            else if (letra == "X")
                retorna = "99";
            else if (letra == "Y")
                retorna = "999";
            else if (letra == "Z")
                retorna = "9999";

            return retorna;
        }
        public string RetornaLetraEspaco(string letra)
        {
            return "0";
        }
    }
}
