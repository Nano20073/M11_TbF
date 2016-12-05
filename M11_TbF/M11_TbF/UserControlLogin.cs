using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11_TbF
{
    public partial class UserControlLogin : UserControl
    {
        private Point _start_point = new Point(0, 0);
        Utilizador User;
        string Username, Password;
        Form frm;
        public UserControlLogin(Form Frm)
        {
            frm = Frm;
            InitializeComponent();
            User = new Utilizador();
            textBox_UserName.Select();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Minimized;
        }

        private void button_Logar_Click(object sender, EventArgs e)
        {
            Username = textBox_UserName.ToString().Substring(36, textBox_UserName.TextLength);
            Password = textBox_PassWord.ToString().Substring(36, textBox_PassWord.TextLength);
            User.Utilizador_login(Username, Password);
            if (User.Utilizador_login_get() == "")
            {
                MessageBox.Show("Erro de Login");
            }
            else
            {
                frm.Hide();
                Form_Menu_Principal F2 = new Form_Menu_Principal(Username, Password, User.ID_Utilizador_get(), User.isadmin_get());

                F2.Show();
            }
        }

        private void label_SignUP_Click(object sender, EventArgs e)
        {
            frm.MudarUserControl(new UserControlSignUP(frm));
            //frm.Hide();
            //Form_SignUp FS = new Form_SignUp();
            //FS.Show();
        }
    }
}
