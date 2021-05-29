using System;
using System.Collections.Generic;
using System.Text;

namespace EscreveCaracterNumero
{
    public class EscreveMensagemComNumero
    {
        TrocaLetraPorNumero troca = new TrocaLetraPorNumero();
        public string RetornaLetra(string texto)
        {
            //texto = texto.Replace(" ",";");
            string retorna = null;
            int quantidadeLetra = texto.Length;
            if (quantidadeLetra > 255)
                return "Texto maior que 255 caracteres";

            for (int i = 0; i < quantidadeLetra; i++)
            {
                string letra = texto.Substring(i, 1);

                if (letra == "A" || letra == "B" || letra == "C")
                {
                    if (retorna == null)
                        retorna += troca.RetornaLetraABC(letra);
                    else if (retorna.Substring(retorna.Length - 1, 1) == "2")
                    {
                        retorna += "_";
                        retorna += troca.RetornaLetraABC(letra);
                    }
                    else if (retorna.Substring(retorna.Length - 1, 1) != "2")
                    {
                        retorna += troca.RetornaLetraABC(letra);
                    }

                }

                else if (letra == "D" || letra == "E" || letra == "F")
                {
                    if (retorna == null)
                        retorna += troca.RetornaLetraDEF(letra);
                    else if (retorna.Substring(retorna.Length-1, 1) == "3")
                    {
                        retorna += "_";
                        retorna += troca.RetornaLetraDEF(letra);
                    }
                    else if (retorna.Substring(retorna.Length - 1, 1) != "3")
                    {
                        retorna += troca.RetornaLetraDEF(letra);
                    }

                }

                else if (letra == "G" || letra == "H" || letra == "I")
                {
                    if (retorna == null)
                        retorna += troca.RetornaLetraGHI(letra);

                    else if (retorna.Substring(retorna.Length - 1, 1) == "4")
                    {
                        retorna += "_";
                        retorna += troca.RetornaLetraGHI(letra);
                    }
                    else if (retorna.Substring(retorna.Length - 1, 1) != "4")
                    {
                        retorna += troca.RetornaLetraGHI(letra);
                    }
                }

                else if (letra == "J" || letra == "K" || letra == "L")
                {
                    if (retorna == null)
                        retorna += troca.RetornaLetraJKL(letra);
                    else if (retorna.Substring(retorna.Length - 1, 1) == "5")
                    {
                        retorna += "_";
                        retorna += troca.RetornaLetraJKL(letra);
                    }
                    else if (retorna.Substring(retorna.Length - 1, 1) != "5")
                    {
                        retorna += troca.RetornaLetraJKL(letra);
                    }

                }

                else if (letra == "M" || letra == "N" || letra == "O")
                {
                    if (retorna == null)
                        retorna += troca.RetornaLetraMNO(letra);
                    else if (retorna.Substring(retorna.Length-1, 1) == "6")
                    {
                        retorna += "_";
                        retorna += troca.RetornaLetraMNO(letra);
                    }
                    else if (retorna.Substring(retorna.Length - 1, 1) != "6")
                    {
                        retorna += troca.RetornaLetraMNO(letra);
                    }

                }

                else if (letra == "P" || letra == "Q" || letra == "R" || letra == "S")
                {
                    if (retorna == null)
                        retorna += troca.RetornaLetraPQRS(letra);
                    else if (retorna.Substring(retorna.Length - 1, 1) == "7")
                    {
                        retorna += "_";
                        retorna += troca.RetornaLetraPQRS(letra);
                    }

                    else if (retorna.Substring(retorna.Length - 1, 1) != "7")
                    {
                        retorna += troca.RetornaLetraPQRS(letra);
                    }
                }

                else if (letra == "T" || letra == "U" || letra == "V")
                {
                    if (retorna == null)
                        retorna += troca.RetornaLetraTUV(letra);
                    else if (retorna.Substring(retorna.Length - 1, 1) == "8")
                    {
                        retorna += "_";
                        retorna += troca.RetornaLetraTUV(letra);
                    }
                    else if (retorna.Substring(retorna.Length - 1, 1) != "8")
                    {
                        retorna += troca.RetornaLetraTUV(letra);
                    }

                }
                else if (letra == "W" || letra == "X" || letra == "Y" || letra == "Z")
                {
                    if (retorna == null)
                        retorna += troca.RetornaLetraWXYZ(letra);
                    else if (retorna.Substring(retorna.Length - 1, 1) == "9")
                    {
                        retorna += "_";
                        retorna += troca.RetornaLetraWXYZ(letra);
                    }
                    else if (retorna.Substring(retorna.Length - 1, 1) != "9")
                    {
                        retorna += troca.RetornaLetraWXYZ(letra);
                    }

                }
                else if (letra == " ")
                {
                    if (retorna == null)
                        retorna += troca.RetornaLetraEspaco(letra);
                    else if (retorna.Substring(retorna.Length - 1, 1) == " ")
                    {
                        retorna += "_";
                        retorna += troca.RetornaLetraEspaco(letra);
                    }
                    else if (retorna.Substring(retorna.Length - 1, 1) != " ")
                    {
                        retorna += troca.RetornaLetraEspaco(letra);
                    }

                }
                
            }
            return retorna;
        }
        
    }
}

