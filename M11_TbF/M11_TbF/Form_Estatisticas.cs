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
            label_utilizador.Text = Username_Atual;
            //label_NivelMaximo.Text
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }
    }
}
