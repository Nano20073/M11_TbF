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
    public partial class Form_Time_Out : System.Windows.Forms.Form
    {
        System.Windows.Forms.Form Jogo;
        System.Windows.Forms.Form Owner;

        public Form_Time_Out(System.Windows.Forms.Form f, System.Windows.Forms.Form f2)
        {
            Owner = f2;
            Jogo = f;
            InitializeComponent();
        }
        
        private void Form_Time_Out_Load(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
            Jogo.Close();
            Owner.Show();
        }
    }
}
