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
    public partial class Form_Estatisticas : Form
    {
        Utilizador User;
        string Username_Atual;
        Form Owner;

        public Form_Estatisticas(string Username, Form f)
        {
            Owner = f;
            Username_Atual = Username;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
            label_NivelMaximo.Text = User.get_nivel_maximo(Username_Atual);
            label_utilizador.Text = Username_Atual;
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }
    }
}
