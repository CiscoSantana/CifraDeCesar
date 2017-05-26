/*********************************************************************************************************
 *********************************************************************************************************
 ** Autor: Francisco Jesus Sant'Ana                                                                     **
 ** Bacharel em Ciência da Computação pela Faculdade Anhanguera Educacional de São José dos Campos SP.  **
 ** e-mail: tkdsantana@gmail.com                                                                        **
 **                                                                                                     **
 ** Esta classe foi desenvolvida com o objetivo de estudo de criptografia.                              **
 ** Aqui é adaptado o método "Cifra de César".                                                          **
 ** É substituida a letra pela correspondente à sua posição na palavra, Ex:                             **
 **      "aaaa => bcde" onde o sistema soma ao código ASCII da letra o valor de i mais 1.               **
 **                                                                                                     **
 **  Posição    Letra   Valor ASCII da letra   Valor de i      Valor ASCII resultante                   **
 **      1ª      "a"             97              i = 0             97+0+1 = 98                          **
 **      2ª      "a"             97              i = 1             97+1+1 = 99                          **
 **      3ª      "a"             97              i = 2             97+2+1 = 100                         **
 **      4ª      "a"             97              i = 3             97+3+1 = 101                         **
 *********************************************************************************************************
 *********************************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cifraDeCesar
{
    class Cifrar
    {
        public string Codificar(string sTexto)
        {
            string sTextoCodigidado = "";
            string[] sArrayTexto = sTexto.Split(' ');

            for (int j = 0; j < sArrayTexto.Length;j++ )
            {
                for (int i = 0; i < sArrayTexto[j].Length; i++)
                {
                    sTextoCodigidado += RetornaDecodificadoASCII(RetornaCodigoASCII(sArrayTexto[j].Substring(i, 1)) + (i + 1));
                }
                sTextoCodigidado += " ";
            }       
            return sTextoCodigidado;
        }

        public string Decodificar(string sTexto)
        {
            string StextoDecodificado = "";
             string[] sArrayTexto = sTexto.Split(' ');

             for (int j = 0; j < sArrayTexto.Length; j++)
             {

                 for (int i = 0; i < sArrayTexto[j].Length; i++)
                 {
                     StextoDecodificado += RetornaDecodificadoASCII(RetornaCodigoASCII(sArrayTexto[j].Substring(i, 1)) - (i + 1));
                 }
                 StextoDecodificado += " ";
             }
            return StextoDecodificado;
        }

        private int RetornaCodigoASCII(string cLetra)
        {
            int asciiChars;

            byte[] asciiBytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(cLetra);
            asciiChars = Convert.ToInt32(asciiBytes[0]);
            return asciiChars;
        }

        private string RetornaDecodificadoASCII(int iValorASCII)
        {

            string s = Encoding.GetEncoding("ISO-8859-1").GetString(new byte[] { (byte)iValorASCII });
            
            return s;
        }
    }
}
