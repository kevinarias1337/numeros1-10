using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numero1_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            int numero2 = int.Parse(numero.Text); 
            int total;
            int i;
            for (i = 1; i <= 10; i ++) {
                total = (numero2 * i);
                tabla.Rows.Add(numero2, i , total );

            }
        }
    }
}

