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
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Utilizador User;
        Form Owner;
        string Username_Atual;
        string password;
        public Form_Opcoes(string Username, string pass, Form f)
        {
            Username_Atual = Username;
            password = pass;
            Owner = f;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            Owner.Close();
            this.Close();
            Form_Login FLOGIN = new Form_Login();
            FLOGIN.Show();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer fazer reset? \n Se clicar sim a aplicação irá fechar ", "Reset", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                User.Reset(Username_Atual);
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button_MudarUsername_Click(object sender, EventArgs e)
        {
            Form_MudarNome FMN = new Form_MudarNome(Username_Atual, password, Owner);
            this.Close();
            FMN.Show();
        }

        private void button_MudarPassword_Click(object sender, EventArgs e)
        {
            Form_MudarPassword FMP = new Form_MudarPassword(Username_Atual, password, Owner);
            this.Close();
            FMP.Show();
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
