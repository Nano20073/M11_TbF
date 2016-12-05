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
    public partial class Form_Ajuda_Telefone : System.Windows.Forms.Form
    {
        string Resposta;
        public Form_Ajuda_Telefone(string resposta)
        {
            Resposta = resposta;
            InitializeComponent();
        }

        private void Form_Ajuda_Telefone_Load(object sender, EventArgs e)
        {
            label_RESPOSTA.Text = Resposta;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
