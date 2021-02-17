using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo._3.Programa._2
{
    class Individuo
    {
        public string nome;
        public int dinheiro;

        public int DarDinheiro(int quantidade)
        {
            if (quantidade <= dinheiro && quantidade > 0)
            {
                dinheiro -= quantidade;
                return quantidade;
            }
            else
            {
                MessageBox.Show("Eu não tenho dinheiro suficiente para te dar " + quantidade, nome + " falou...");
                return 0;
            }
        }

        public int ReceberDinheiro(int quantidade)
        {
            if (quantidade > 0)
            {
                dinheiro += quantidade;
                return quantidade;
            }
            else
            {
                MessageBox.Show(quantidade + " não é uma qu0antia que vou aceitar", nome + " disse...");
                return 0;
            }
        }
    }
}
