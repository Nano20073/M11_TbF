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
    public partial class Form_Menu_Principal : System.Windows.Forms.Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Utilizador User;
        string Username_Atual;
        string pass;
        int ID_Utilizador;
        bool IsAdmin = false;



        public Form_Menu_Principal(string Username, string password, int ID_User, bool isadmin)
        {
            IsAdmin = isadmin;
            ID_Utilizador = ID_User;
            pass = password;
            Username_Atual = Username;
            InitializeComponent();

            if (isadmin == true)
                button_gestao.Visible=true;
        }

        private void Form_Menu_Principal_Load(object sender, EventArgs e)
        {
            label_utilizador.Select();
            User = new Utilizador();
            label_utilizador.Text = Username_Atual;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FLOGIN = new Form();
            FLOGIN.Show();
        }

        private void button_Jogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Jogo FJOGO = new Form_Jogo(this, Username_Atual, ID_Utilizador);
            FJOGO.Show();
        }

        private void button_Estatisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Estatisticas FEst = new Form_Estatisticas(label_utilizador.Text, this);
            FEst.Show();
        }

        private void button_Conquistas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Conquistas FC = new Form_Conquistas(label_utilizador.Text, this, ID_Utilizador);
            FC.Show();
        }

        private void button_Opcoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Opcoes FOPCOES = new Form_Opcoes(Username_Atual, pass, this, ID_Utilizador);
            FOPCOES.Show();
        }

        private void panel_Drag_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel_Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel_Drag_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form F1 = new Form();
            F1.Show();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Gestao_Click(object sender, EventArgs e)
        {
            Form_gestao FG = new Form_gestao(this);
            this.Hide();
            FG.Show();
            //if (label_utilizador.Text = Admin)
            //    button_gestao.Show();
        }

        private void label_utilizador_Click(object sender, EventArgs e)
        {

        }
    }
}
