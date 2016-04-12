using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11_TbF
{
    public partial class Form_Ajuda_Publico : Form
    {
        string Pergunta1, Pergunta2, Pergunta3, Pergunta4;

        private void Form_Ajuda_Publico_Load(object sender, EventArgs e)
        {
            label_Resposta1.Text = Pergunta1 + ": " + Resposta1 + "%";
            label_Resposta2.Text = Pergunta2 + ": " + Resposta2 + "%";
            label_Resposta3.Text = Pergunta3 + ": " + Resposta3 + "%";
            label_Resposta4.Text = Pergunta4 + ": " + Resposta4 + "%";
        }

        int Resposta1, Resposta2, Resposta3, Resposta4;
        public Form_Ajuda_Publico(string P1, string P2, string P3, string P4, int R1, int R2, int R3, int R4)
        {
            Pergunta1 = P1;
            Pergunta2 = P2;
            Pergunta3 = P3;
            Pergunta4 = P4;
            Resposta1 = R1;
            Resposta2 = R2;
            Resposta3 = R3;
            Resposta4 = R4;
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
