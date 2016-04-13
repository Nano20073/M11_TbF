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
    public partial class Form_Game_Over : Form
    {
        Form Jogo;
        Form Owner;

        public Form_Game_Over(Form f, Form f2)
        {
            Owner = f2;
            Jogo = f;
            InitializeComponent();
        }

        private void Form_Game_Over_Load(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Jogo.Close();
            //Owner.Show();
        }

        
    }
}
