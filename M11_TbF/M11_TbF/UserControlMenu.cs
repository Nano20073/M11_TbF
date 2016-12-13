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
    public partial class UserControlMenu : UserControl
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Utilizador User;
        string Username_Atual;
        string pass;
        int ID_Utilizador;
        bool IsAdmin = false;
        Form frm;

        public UserControlMenu(string Username, string password, int ID_User, bool isadmin, Form Frm)
        {
            IsAdmin = isadmin;
            ID_Utilizador = ID_User;
            pass = password;
            Username_Atual = Username;
            frm = Frm;
            InitializeComponent();

            if (isadmin == true)
                button_gestao.Visible = true;
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            frm.Close();
            Form F1 = new Form();
            F1.Show();
        }

        private void UserControlMenu_Load(object sender, EventArgs e)
        {

        }

        private void button_Jogar_Click(object sender, EventArgs e)
        {
            frm.Hide();
            Form_Jogo FJOGO = new Form_Jogo(frm, Username_Atual, ID_Utilizador);
            FJOGO.Show();
        }

        private void button_Estatisticas_Click(object sender, EventArgs e)
        {
            frm.Hide();
            Form_Estatisticas FEst = new Form_Estatisticas(label_utilizador.Text, frm);
            FEst.Show();
        }

        private void button_Conquistas_Click(object sender, EventArgs e)
        {
            frm.Hide();
            Form_Conquistas FC = new Form_Conquistas(label_utilizador.Text, frm, ID_Utilizador);
            FC.Show();
        }

        private void button_Opcoes_Click(object sender, EventArgs e)
        {
            //frm.Hide();
            //Form_Opcoes FOPCOES = new Form_Opcoes(Username_Atual, pass, frm, ID_Utilizador);
            //FOPCOES.Show();

            frm.MudarUserControl(new UserControlOpção(Username_Atual, pass, frm, ID_Utilizador));
        }

        private void button_gestao_Click(object sender, EventArgs e)
        {
            Form_gestao FG = new Form_gestao(frm);
            frm.Hide();
            FG.Show();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Minimized;
        }
    }
}
