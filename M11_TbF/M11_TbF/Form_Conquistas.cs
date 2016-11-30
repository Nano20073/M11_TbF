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
    public partial class Form_Conquistas : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Conquista Conq;
        Utilizador User;
        string Username_Atual;
        Form Owner;
        int ID_Utilizador;
        public Form_Conquistas(string Username, Form f, int ID_User)
        {
            ID_Utilizador = ID_User;
            Owner = f;
            Username_Atual = Username;
            InitializeComponent();
        }

        private void Form_Conquistas_Load(object sender, EventArgs e)
        {
            Connections.con.Open();
            label_utilizador.Select();
            label_utilizador.Text = Username_Atual;
            panel_layout.VerticalScroll.Value = 0;
            panel_layout.HorizontalScroll.Maximum = 0;
            panel_layout.VerticalScroll.Maximum = 0;
            panel_layout.AutoScroll = false;
            panel_layout.VerticalScroll.Visible = false;
            panel_layout.HorizontalScroll.Visible = false;
            panel_layout.AutoScroll = true;

            User = new Utilizador();
            Conq = new Conquista();
            for(int ID_Conquista=1; ID_Conquista <= 5; ID_Conquista++)
            {
                if(Conq.Verificar_Conquista(ID_Utilizador, ID_Conquista) == true)
                {
                    if (ID_Conquista == 1)
                    {
                        pictureBox_Conquistas_1milhao.BackgroundImage = Image.FromFile(@"..\..\Resources\Conquistas_1milhao.png");
                    }

                    if (ID_Conquista == 2)
                    {
                        pictureBox_Conquistas_10milhoes.BackgroundImage = Image.FromFile(@"..\..\Resources\Conquistas_10milhoes.png");
                    }

                    if (ID_Conquista == 3)
                    {
                        pictureBox_Conquistas_100milhoes.BackgroundImage = Image.FromFile(@"..\..\Resources\Conquistas_100milhoes.png");
                    }

                    if (ID_Conquista == 4)
                    {
                        pictureBox_Conquistas_Nivel10.BackgroundImage = Image.FromFile(@"..\..\Resources\Conquistas_Nivel10.png");
                    }

                    if (ID_Conquista == 5)
                    {
                        pictureBox_Conquistas_NivelMax.BackgroundImage = Image.FromFile(@"..\..\Resources\Conquistas_NivelMax.png");
                    }
                }
            }
            Connections.con.Close();
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

        private void panel_MiniSair_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel_MiniSair_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel_MiniSair_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void label_lgout_Click(object sender, EventArgs e)
        {
            Owner.Close();
            this.Close();
            Form_Login FLOGIN = new Form_Login();
            FLOGIN.Show();
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
