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
    public partial class Form_Jogo : Form
    {
        Utilizador User;
        Pergunta Per;
        Form Owner;
        int MoneyTree = 1;
        string Username_Atual;
        public Form_Jogo(Form f, string Username)
        {
            Owner = f;
            Username_Atual = Username;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
            Per = new Pergunta();
            label_nivel.Text = "Nivel atual: " + Per.Nivel_Get().ToString();
            Per.Pergunta_Set();
            label_pergunta.Text = Per.Pergunta_Get();
            label_r1.Text = Per.Resposta1_Get();
            label_r2.Text = Per.Resposta2_Get();
            label_r3.Text = Per.Resposta3_Get();
            label_r4.Text = Per.Resposta4_Get();


            
            
        }

        public void Acertou_a_Pergunta()
        {
            if (Per.Nivel_Get().ToString() == "6")
            {
                User.Atualizar_Estatisticas(Per.Nivel_Get(), Username_Atual);
                MessageBox.Show("Tu Ganhaste!");
                Owner.Show();
                this.Close();
            }
            else
            {
                MoneyTree++;
                MessageBox.Show("Acertou");
                label_nivel.Text = "Nivel atual: " + Per.Nivel_Get().ToString();
                Per.Pergunta_Set();
                label_pergunta.Text = Per.Pergunta_Get();
                label_r1.Text = Per.Resposta1_Get();
                label_r2.Text = Per.Resposta2_Get();
                label_r3.Text = Per.Resposta3_Get();
                label_r4.Text = Per.Resposta4_Get();
                //pictureBox_MoneyTree.BackgroundImage = M11_TbF.Properties.Resources."nivel" + MoneyTree.ToString();
            }
        }

        public void Errou_a_Pergunta()
        {
            User.Atualizar_Estatisticas(Per.Nivel_Get(), Username_Atual);
            MessageBox.Show("Perdeu");
            Owner.Show();
            this.Close();
        }

        private void label_r1_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(label_r1.Text) == true)
            {
                Acertou_a_Pergunta();
            }
            else
            {
                Errou_a_Pergunta();
            }
        }

        private void label_r2_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(label_r2.Text) == true)
            {
                Acertou_a_Pergunta();
            }
            else
            {
                Errou_a_Pergunta();
            }
        }

        private void label_r3_Click(object sender, EventArgs e)
        {

            if (Per.Resposta_Verificar(label_r3.Text) == true)
            {
                Acertou_a_Pergunta();
            }
            else
            {
                Errou_a_Pergunta();
            }
        }

        private void label_r4_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(label_r4.Text) == true)
            {
                Acertou_a_Pergunta();
            }
            else
            {
                Errou_a_Pergunta();
            }
        }
    }
}
