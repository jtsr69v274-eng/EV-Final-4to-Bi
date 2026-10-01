using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV_Final_4to_Bi

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (TextUsuario.Text == "5toPCP" && TextClave.Text == "Ejercicio1")
        {
            this.Hide();
            Form1 app = new Form1();
            app.Show();
        }
        else
        {
            MessageBox.Show("Inténtalo de nuevo");
        }
    }
}



               