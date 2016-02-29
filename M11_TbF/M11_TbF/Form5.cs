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
    public partial class Form5 : Form
    {
        Perguntas Per;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Per = new Perguntas();
            label_nivel.Text = Per.Nivel_Get().ToString();
            label_pergunta.Text = Per.Pergunta_Get();
            radioButton_r1.Text = Per.Resposta1_Get();
            radioButton_r2.Text = Per.Resposta2_Get();
            radioButton_r3.Text = Per.Resposta3_Get();
            radioButton_r4.Text = Per.Resposta4_Get();
        }
    }
}
