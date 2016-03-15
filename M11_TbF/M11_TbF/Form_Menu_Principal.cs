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
    public partial class Form_Menu_Principal : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        Utilizador User;
        string Username_Atual;
        string pass;
        private Image defaultBackground;
        public Form_Menu_Principal(string Username, string password)
        {
            pass = password;
            Username_Atual = Username;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login F1 = new Form_Login();
            F1.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
            label_utilizador.Text = Username_Atual;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Jogo F5 = new Form_Jogo(this, Username_Atual);
            F5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Opcoes F3 = new Form_Opcoes(Username_Atual, pass);
            F3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Estatisticas F4 = new Form_Estatisticas(label_utilizador.Text, this);
            F4.Show();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
