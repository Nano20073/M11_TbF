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
    public partial class Form_Jogo : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        Utilizador User;
        Pergunta Per;
        Form Owner;

        int MoneyTree = 1;
        int tempo = 15;
        int background_time = 0;
        int background = 0;

        string Username_Atual;

        public Form_Jogo(Form f, string Username)
        {
            Owner = f;
            Username_Atual = Username;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
            Per = new Pergunta();


            label_tempo.Text = "Tempo Restante - " + tempo.ToString();
            label_nivel.Text = "Nivel atual: " + Per.Nivel_Get().ToString();
            Per.Pergunta_Set();
            label_pergunta.Text = Per.Pergunta_Get();
            label_r1.Text = Per.Resposta1_Get();
            label_r2.Text = Per.Resposta2_Get();
            label_r3.Text = Per.Resposta3_Get();
            label_r4.Text = Per.Resposta4_Get();
            timer_tempo.Start();




        }

        public void AdicionarTotalGanho()
        {
            if (Per.Nivel_Get().ToString() == "1")
            {
                User.AdicionarTotalGanho(0, Username_Atual);
            }

            if (Per.Nivel_Get().ToString() == "2")
            {
                User.AdicionarTotalGanho(0, Username_Atual);
            }

            if (Per.Nivel_Get().ToString() == "3")
            {
                User.AdicionarTotalGanho(0, Username_Atual);
            }

            if (Per.Nivel_Get().ToString() == "4")
            {
                User.AdicionarTotalGanho(3000, Username_Atual);
            }

            if (Per.Nivel_Get().ToString() == "5")
            {
                User.AdicionarTotalGanho(5000, Username_Atual);
            }

            if (Per.Nivel_Get().ToString() == "6")
            {
                User.AdicionarTotalGanho(7500, Username_Atual);
            }

        }

        public void Acertou_a_Pergunta()
        {
            
            if (Per.Nivel_Get().ToString() == "6")
            {
                User.Atualizar_Estatisticas(Per.Nivel_Get(), Username_Atual);
                AdicionarTotalGanho();
                MessageBox.Show("Tu Ganhaste!");
                Owner.Show();
                this.Close();
            }
            else
            {
                timer_tempo.Stop();
                tempo = 15;
                MoneyTree++;
                timer_background_acertou.Start();
                
            }
        }

        

        public void Errou_a_Pergunta()
        {
            timer_tempo.Stop();
            User.Atualizar_Estatisticas(Per.Nivel_Get(), Username_Atual);
            AdicionarTotalGanho();
            timer_background_errou.Start();
            //MessageBox.Show("Perdeu");
            
        }



        private void label_r1_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(label_r1.Text) == true)
            {
                Acertou_a_Pergunta();
            }
            else
            {
                Errou_a_Pergunta();

                background_time++;
                if (background_time == 3)
                {

                    timer_background_acertou.Stop();
                    background_time = 0;

                    Owner.Show();
                    this.Close();

                }
                else
                {
                    if (background == 0)
                    {

                        if (label_r1.Text != Per.Resposta_Correta_Get() && label_r2.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R2" + ".png");
                        }

                        if (label_r1.Text != Per.Resposta_Correta_Get() && label_r3.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R1" + ".png");
                        }

                        if (label_r1.Text != Per.Resposta_Correta_Get() && label_r4.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R3" + ".png");
                        }
                    }
                }
            }
        }

        private void label_r2_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(label_r2.Text) == true)
            {
                Acertou_a_Pergunta();
            }
            else
            {
                Errou_a_Pergunta();

                background_time++;
                if (background_time == 3)
                {

                    timer_background_acertou.Stop();
                    background_time = 0;

                    Owner.Show();
                    this.Close();

                }
                else
                {
                    if (background == 0)
                    {


                        if (label_r2.Text != Per.Resposta_Correta_Get() && label_r1.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R7" + ".png");
                        }

                        if (label_r2.Text != Per.Resposta_Correta_Get() && label_r3.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R8" + ".png");
                        }

                        if (label_r2.Text != Per.Resposta_Correta_Get() && label_r4.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R9" + ".png");
                        }

                    }
                }
            }
        }

        private void label_r3_Click(object sender, EventArgs e)
        {

            if (Per.Resposta_Verificar(label_r3.Text) == true)
            {
                Acertou_a_Pergunta();
            }
            else
            {
                Errou_a_Pergunta();

                background_time++;
                if (background_time == 3)
                {

                    timer_background_acertou.Stop();
                    background_time = 0;

                    Owner.Show();
                    this.Close();

                }
                else
                {
                    if (background == 0)
                    {




                        if (label_r3.Text != Per.Resposta_Correta_Get() && label_r1.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R4" + ".png");
                        }

                        if (label_r3.Text != Per.Resposta_Correta_Get() && label_r2.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R5" + ".png");
                        }

                        if (label_r3.Text != Per.Resposta_Correta_Get() && label_r4.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R6" + ".png");
                        }
                    }
                }
            }
        }

        private void label_r4_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(label_r4.Text) == true)
            {
                Acertou_a_Pergunta();
            }
            else
            {
                Errou_a_Pergunta();

                background_time++;
                if (background_time == 3)
                {

                    timer_background_acertou.Stop();
                    background_time = 0;

                    Owner.Show();
                    this.Close();

                }
                else
                {
                    if (background == 0)
                    {

                        if (label_r4.Text != Per.Resposta_Correta_Get() && label_r1.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R11" + ".png");
                        }

                        if (label_r4.Text != Per.Resposta_Correta_Get() && label_r2.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R10" + ".png");
                        }

                        if (label_r4.Text != Per.Resposta_Correta_Get() && label_r3.Text == Per.Resposta_Correta_Get())
                        {
                            this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG_R12" + ".png");
                        }
                    }
                }
            }
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_tempo_Tick(object sender, EventArgs e)
        {
            if (tempo == 0)
            {
                timer_tempo.Stop();
                User.Atualizar_Estatisticas(Per.Nivel_Get(), Username_Atual);
                AdicionarTotalGanho();
                MessageBox.Show("Acabou o tempo. Perdeu.");
                Owner.Show();
                this.Close();

            }
            else
            {
                tempo--;
                label_tempo.Text = "Tempo Restante - " + tempo.ToString();
            }
        }

        private void timer_background_acertou_Tick(object sender, EventArgs e)
        {
            background_time++;
            if (background_time == 3)
            {
                timer_background_acertou.Stop();
                background_time = 0;
                

                label_nivel.Text = "Nivel atual: " + Per.Nivel_Get().ToString();
                label_tempo.Text = "Tempo Restante - " + tempo.ToString();
                Per.Pergunta_Set();
                label_pergunta.Text = Per.Pergunta_Get();
                label_r1.Text = Per.Resposta1_Get();
                label_r2.Text = Per.Resposta2_Get();
                label_r3.Text = Per.Resposta3_Get();
                label_r4.Text = Per.Resposta4_Get();
                pictureBox_MoneyTree.BackgroundImage = Image.FromFile(@"..\..\Resources\nivel" + MoneyTree.ToString() + ".jpg");
                timer_tempo.Start();
            }
            else
            {
                if (background == 0)
                {
                    if (label_r1.Text == Per.Resposta_Correta_Get())
                    {
                        this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG1G" + ".png");
                    }

                    if (label_r2.Text == Per.Resposta_Correta_Get())
                    {
                        this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG3G" + ".png");
                    }

                    if (label_r3.Text == Per.Resposta_Correta_Get())
                    {
                        this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG2G" + ".png");
                    }

                    if (label_r4.Text == Per.Resposta_Correta_Get())
                    {
                        this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG4G" + ".png");
                    }

                    background++;

                }
                else
                {
                    background--;
                    this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG" + ".png");
                }
            }
        }

        private void timer_background_errou_Tick(object sender, EventArgs e)
        {
            background_time++;
            if (background_time == 3)
            {

                timer_background_acertou.Stop();
                background_time = 0;

                Owner.Show();
                this.Close();

            }
            else
            {
                if (background == 0)
                { 

                    background++;

                }
                else
                {
                    background--;
                    this.BackgroundImage = Image.FromFile(@"..\..\Resources\GameBG" + ".png");
                }
            }
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
