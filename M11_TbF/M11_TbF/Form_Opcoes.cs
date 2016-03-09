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
    public partial class Form_Opcoes : Form
    {
        string Username_Atual;
        string password;
        public Form_Opcoes(string Username, string pass)
        {
            Username_Atual = Username;
            password = pass;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form_MudarPassword F7 = new Form_MudarPassword(Username_Atual);
            F7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_MudarNome FMN = new Form_MudarNome(Username_Atual);
            FMN.ShowDialog();
        }
    }
}
