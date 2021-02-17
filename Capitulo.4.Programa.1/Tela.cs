using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo._4.Programa._1
{
    public partial class Tela : Form
    {
        int milhaInicial;
        int milhaFinal;

        double milesTreveled;
        double reimburseRate = 0.39;
        double amountOwed;

        public Tela()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            milhaInicial = (int)upDownInicial.Value;
            milhaFinal = (int)upDownFinal.Value;

            if (upDownInicial.Value > upDownFinal.Value)
            {
                MessageBox.Show("A quilometragem inicial deve ser menor do que a final.", "Impossivel calcular");

            }
            else
            {
                milesTreveled = milhaFinal - milhaInicial;

                amountOwed = milesTreveled * reimburseRate;

                reembolsoLabel.Text = "$" + amountOwed;
            }
        }

        private void btnMilhasViajadas_Click(object sender, EventArgs e)
        {
            milhaInicial = (int)upDownInicial.Value;
            milhaFinal = (int)upDownFinal.Value;

            milesTreveled = milhaFinal - milhaInicial;

            MessageBox.Show("Viajou " + milesTreveled + " milhas", "Milhas Viajadas");
        }
    }
}
