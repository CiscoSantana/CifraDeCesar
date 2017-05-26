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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cifraDeCesar
{
    public partial class Form1 : Form
    {
        Cifrar objCifrar = new Cifrar();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
           textBoxCifrado.Text = objCifrar.Codificar(textBoxOriginal.Text);
        }

        private void btnDecifrar_Click(object sender, EventArgs e)
        {
            textBoxCifrado.Text = objCifrar.Decodificar(textBoxOriginal.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
