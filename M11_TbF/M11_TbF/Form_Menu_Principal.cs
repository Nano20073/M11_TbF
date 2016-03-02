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
    public partial class Form_Menu_Principal : Form
    {
        Utilizador User;
        string Username_Atual;
        private Image defaultBackground;

        public Form_Menu_Principal(string Username)
        {
            Username_Atual = Username;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login F1 = new Form_Login();
            F1.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
            label_utilizador.Text = Username_Atual;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Jogo F5 = new Form_Jogo(this);
            F5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Opcoes F3 = new Form_Opcoes(this);
            F3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Estatisticas F4 = new Form_Estatisticas(label_utilizador.Text);
            F4.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = (System.Drawing.Image)(Properties.Resources.IMG1);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = defaultBackground;
        }
    }
}
