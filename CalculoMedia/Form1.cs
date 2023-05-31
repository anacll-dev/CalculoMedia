using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class Form1 : Form
    {
        double media = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);
            double nota3 = double.Parse(txtNota3.Text);

            media = (nota1 + nota2 + nota3)/3;

            lblMedia.Text = media.ToString("F3");
            lblMedia.Visible = true;

        }

        private void btnSituacao_Click(object sender, EventArgs e)
        {
            if (media >= 6)
            {
                lblSituacao.Text = "APROVADO";
                lblSituacao.ForeColor = Color.Green;
            } else
            {
                lblSituacao.Text = "REPROVADO";
                lblSituacao.ForeColor = Color.Red;
            }
            lblSituacao.Visible = true;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            lblSituacao.Visible = false;
            lblMedia.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
