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
        Form Owner;
        public Form_Opcoes(Form f)
        {
            Owner = f;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form2 F2 = new Form2();
            F2.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            /*this.Hide();            
            Form7 F7 = new Form7();
            F7.Show();*/
        }
    }
}
