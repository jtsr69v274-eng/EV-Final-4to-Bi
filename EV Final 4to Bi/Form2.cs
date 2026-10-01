using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EV_Final_4to_Bi
{
    private void Factorial_Click(object sender, EventArgs e)
    {
        int num1 = int.Parse(TextVar1. Text);
        int num2 = 1;
for (int num3 = 0; num3 == num1; num3++)
        {
            num2 = num2 * num3;
        }

        MessageBox.Show("el resultado del factorial es" + num2);
    }
    private void Producto_Click(object sender, EventArgs e)
    {
        int num1 = int.Parse(TextVar1.Text);
        int num2 = int.Parse(TextVar2.Text);
        int Multiplicacion = num1 * num2;

        MessageBox.Show("el resultado de la multiplicacion es" + Multiplicacion);
    }

    internal class TextVar2
    {
        internal static string Text;
        private readonly object TextContraseña;

        private void Potencia_Click(object sender, EventArgs e)
    {
        int num1 = int.Parse(TextVar1.Text);
        int num2 = int.Parse(TextVar2.Text);
        int num3 = 1;
        int Potencia = 1;

        while (num3 != num2)
        {
            Potencia = Potencia * num1;
            num3++;
        }

        MessageBox.Show("el resultado es " + Potencia);
    }
 private void Division_Click(object sender, EventArgs e)
    {
        float num1 = float.Parse(TextVar1.Text);
        float num2 = float.Parse(TextVar2.Text);

        if (num2 > 0)
        {
            float division = num1 / num2;
            MessageBox.Show("el resultado es" + division);
        }
        else
        {
            MessageBox.Show("la division es infinita");
        }
    
      
 






