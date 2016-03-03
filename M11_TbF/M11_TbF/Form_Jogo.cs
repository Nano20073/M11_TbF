﻿using System;
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
        Pergunta Per;
        Form Owner;
        public Form_Jogo(Form f)
        {
            Owner = f;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            Per = new Pergunta();
            label_nivel.Text = "Nivel atual: " + Per.Nivel_Get().ToString();
            Per.Pergunta_Set();
            label_pergunta.Text = Per.Pergunta_Get();
            button_R1.Text = Per.Resposta1_Get();
            button_R2.Text = Per.Resposta2_Get();
            button_R3.Text = Per.Resposta3_Get();
            button_R4.Text = Per.Resposta4_Get();


            
            
        }

        private void button_R1_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(button_R1.Text) == true)
            {
                if (Per.Nivel_Get().ToString() == "6")
                {
                    MessageBox.Show("Tu Ganhaste!");

                    // Form_Menu_Principal FMP = new Form_Menu_Principal();
                    Owner.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Acertou");
                    label_nivel.Text = "Nivel atual: " + Per.Nivel_Get().ToString();
                    Per.Pergunta_Set();
                    label_pergunta.Text = Per.Pergunta_Get();
                    button_R1.Text = Per.Resposta1_Get();
                    button_R2.Text = Per.Resposta2_Get();
                    button_R3.Text = Per.Resposta3_Get();
                    button_R4.Text = Per.Resposta4_Get();
                }
            }
            else
            {
                MessageBox.Show("Perdeu");
                Owner.Show();
                this.Close();
            }
        }

        private void button_R2_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(button_R2.Text) == true)
            {
                if (Per.Nivel_Get().ToString() == "6")
                {
                    MessageBox.Show("Tu Ganhaste!");

                    // Form_Menu_Principal FMP = new Form_Menu_Principal();
                    Owner.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Acertou");
                    label_nivel.Text = "Nivel atual: " + Per.Nivel_Get().ToString();
                    Per.Pergunta_Set();
                    label_pergunta.Text = Per.Pergunta_Get();
                    button_R1.Text = Per.Resposta1_Get();
                    button_R2.Text = Per.Resposta2_Get();
                    button_R3.Text = Per.Resposta3_Get();
                    button_R4.Text = Per.Resposta4_Get();
                }
            }
            else
            {
                MessageBox.Show("Perdeu");
                Owner.Show();
                this.Close();
            }
        }

        private void button_R3_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(button_R3.Text) == true)
            {
                if (Per.Nivel_Get().ToString() == "6")
                {
                    MessageBox.Show("Tu Ganhaste!");

                    // Form_Menu_Principal FMP = new Form_Menu_Principal();
                    Owner.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Acertou");
                    label_nivel.Text = "Nivel atual: " + Per.Nivel_Get().ToString();
                    Per.Pergunta_Set();
                    label_pergunta.Text = Per.Pergunta_Get();
                    button_R1.Text = Per.Resposta1_Get();
                    button_R2.Text = Per.Resposta2_Get();
                    button_R3.Text = Per.Resposta3_Get();
                    button_R4.Text = Per.Resposta4_Get();
                }
            }
            else
            {
                MessageBox.Show("Perdeu");
                Owner.Show();
                this.Close();
            }
        }

        private void button_R4_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(button_R4.Text) == true)
            {
                if (Per.Nivel_Get().ToString() == "6")
                {
                    MessageBox.Show("Tu Ganhaste!");

                    // Form_Menu_Principal FMP = new Form_Menu_Principal();
                    Owner.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Acertou");
                    label_nivel.Text = "Nivel atual: " + Per.Nivel_Get().ToString();
                    Per.Pergunta_Set();
                    label_pergunta.Text = Per.Pergunta_Get();
                    button_R1.Text = Per.Resposta1_Get();
                    button_R2.Text = Per.Resposta2_Get();
                    button_R3.Text = Per.Resposta3_Get();
                    button_R4.Text = Per.Resposta4_Get();
                }
            }
            else
            {
                MessageBox.Show("Perdeu");
                Owner.Show();
                this.Close();
            }
        }
    }
}
