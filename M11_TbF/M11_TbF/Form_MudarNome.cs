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
    public partial class Form_MudarNome : Form
    {
        Utilizador User;
        string Utilizador_Antigo;
        public Form_MudarNome(string Utilizador)
        {
            Utilizador_Antigo = Utilizador;
            InitializeComponent();
        }

        private void button_Alterar_Click(object sender, EventArgs e)
        {
            if(textBox_NovoUtilizador.Text == textBox_ConfirmarNovoUsername.Text)
            {
                User.Alterar_Nome_de_Utilizador(Utilizador_Antigo, textBox_NovoUtilizador.Text);
            }
        }

        private void Form_MudarNome_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
        }
    }
}
