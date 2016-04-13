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

        private void Form_Jogo_Load(object sender, EventArgs e)
        {
            label_utilizador.Select();
            User = new Utilizador();
            Per = new Pergunta();

            label_utilizador.Text = Username_Atual;
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

        private void AdicionarTotalGanho()
        {
            if (Per.Nivel_Get().ToString() == "1") { User.AdicionarTotalGanho(0, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "2") { User.AdicionarTotalGanho(0, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "3") { User.AdicionarTotalGanho(0, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "4") { User.AdicionarTotalGanho(0, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "5") { User.AdicionarTotalGanho(3000, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "6") { User.AdicionarTotalGanho(5000, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "7") { User.AdicionarTotalGanho(7500, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "8") { User.AdicionarTotalGanho(10000, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "9") { User.AdicionarTotalGanho(15000, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "10") { User.AdicionarTotalGanho(25000, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "11") { User.AdicionarTotalGanho(50000, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "12") { User.AdicionarTotalGanho(75000, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "13") { User.AdicionarTotalGanho(150000, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "14") { User.AdicionarTotalGanho(250000, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "15") { User.AdicionarTotalGanho(500000, Username_Atual); }
            if (Per.Nivel_Get().ToString() == "16") { User.AdicionarTotalGanho(1000000, Username_Atual); }
        }

        private void timer_tempo_Tick(object sender, EventArgs e)
        {
            if (tempo == 0)
            {
                timer_tempo.Stop();
                User.Atualizar_Estatisticas(Per.Nivel_Get(), Username_Atual);
                AdicionarTotalGanho();
                Form_Time_Out FTO = new Form_Time_Out(this, Owner);
                FTO.ShowDialog();
            }
            else
            {
                tempo--;
                label_tempo.Text = "Tempo Restante - " + tempo.ToString();
            }
        }

        private void Acertou_a_Pergunta()
        {
            label_r1.Enabled = false;
            label_r2.Enabled = false;
            label_r3.Enabled = false;
            label_r4.Enabled = false;

            if (Per.Nivel_Get().ToString() == "16")
            {
                User.Atualizar_Estatisticas(Per.Nivel_Get(), Username_Atual);
                AdicionarTotalGanho();
                Form_Game_Win FGW = new Form_Game_Win(this, Owner);
                FGW.ShowDialog();
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
                label_r1.Enabled = true;
                label_r2.Enabled = true;
                label_r3.Enabled = true;
                label_r4.Enabled = true;
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



        private void Errou_a_Pergunta()
        {
            label_r1.Enabled = false;
            label_r2.Enabled = false;
            label_r3.Enabled = false;
            label_r4.Enabled = false;

            timer_tempo.Stop();
            User.Atualizar_Estatisticas(Per.Nivel_Get(), Username_Atual);
            AdicionarTotalGanho();
            timer_background_errou.Start();
            this.Hide();
            Form_Game_Over FGO = new Form_Game_Over(this, Owner);
            FGO.ShowDialog();
        }

        private void timer_background_errou_Tick(object sender, EventArgs e)
        {
            background_time++;
            if (background_time == 3)
            {
                timer_background_errou.Stop();
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


        private void label_r1_Click(object sender, EventArgs e)
        {
            if (Per.Resposta_Verificar(label_r1.Text) == true)
            {
                Acertou_a_Pergunta();
            }
            else
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
                Errou_a_Pergunta();                                                                                           
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
                Errou_a_Pergunta();                                    
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
                Errou_a_Pergunta();              
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
                Errou_a_Pergunta();
            }
        }

        private void button_50_50_Click(object sender, EventArgs e)
        {
            button_50_50.Enabled = false;
            button_50_50.BackgroundImage = Image.FromFile(@"..\..\Resources\50_50_off.png");

            if(label_r1.Text == Per.Resposta_Correta_Get())
            {
                label_r2.Enabled = false;
                label_r3.Enabled = false;
            }

            if (label_r2.Text == Per.Resposta_Correta_Get())
            {
                label_r1.Enabled = false;
                label_r4.Enabled = false;
            }

            if (label_r3.Text == Per.Resposta_Correta_Get())
            {
                label_r2.Enabled = false;
                label_r4.Enabled = false;
            }

            if (label_r4.Text == Per.Resposta_Correta_Get())
            {
                label_r1.Enabled = false;
                label_r3.Enabled = false;
            }
        }

        private void button_Telefone_Click(object sender, EventArgs e)
        {
            button_Telefone.Enabled = false;
            button_Telefone.BackgroundImage = Image.FromFile(@"..\..\Resources\Telefone_off.png");
            int resposta;
            var rand = new System.Random();
            resposta = rand.Next(1, 5);

            if (resposta == 1)
            {
                Form_Ajuda_Telefone FAjdTel = new Form_Ajuda_Telefone(label_r1.Text);
                FAjdTel.ShowDialog();
            }

            if (resposta == 2)
            {
                Form_Ajuda_Telefone FAjdTel = new Form_Ajuda_Telefone(label_r2.Text);
                FAjdTel.ShowDialog();
            }

            if (resposta == 3)
            {
                Form_Ajuda_Telefone FAjdTel = new Form_Ajuda_Telefone(label_r3.Text);
                FAjdTel.ShowDialog();
            }

            if (resposta == 4)
            {
                Form_Ajuda_Telefone FAjdTel = new Form_Ajuda_Telefone(label_r4.Text);
                FAjdTel.ShowDialog();
            }
            
        }

        private void button_ajuda_a_pessoas_Click(object sender, EventArgs e)
        {
            button_ajuda_a_pessoas.Enabled = false;
            button_ajuda_a_pessoas.BackgroundImage = Image.FromFile(@"..\..\Resources\Ajuda_a_publico_off.png");
            int resposta1=0, resposta2=0, resposta3=0, resposta4=0;
            var rand = new System.Random();
            
            if (label_r1.Text == Per.Resposta_Correta_Get())
            {
                resposta1 = rand.Next(30,71);
                resposta2 = rand.Next(0, 100 - resposta1);
                resposta3 = rand.Next(0, 100 - resposta1 - resposta2);
                resposta4 = 100 - resposta1 - resposta2 - resposta3;                
            }

            if (label_r2.Text == Per.Resposta_Correta_Get())
            {
                resposta2 = rand.Next(30, 71);
                resposta1 = rand.Next(0, 100 - resposta2);                
                resposta3 = rand.Next(0, 100 - resposta1 - resposta2);
                resposta4 = 100 - resposta1 - resposta2 - resposta3;                
            }

            if (label_r3.Text == Per.Resposta_Correta_Get())
            {
                resposta3 = rand.Next(30, 71);
                resposta1 = rand.Next(0, 100 - resposta3);
                resposta2 = rand.Next(0, 100 - resposta3 - resposta1);
                resposta4 = 100 - resposta1 - resposta2 - resposta3;                
            }

            if (label_r4.Text == Per.Resposta_Correta_Get())
            {
                resposta4 = rand.Next(30, 71);
                resposta1 = rand.Next(0, 100 - resposta4);
                resposta2 = rand.Next(0, 100 - resposta4 - resposta1);
                resposta3 = 100 - resposta4 - resposta1 - resposta2;               
            }

            Form_Ajuda_Publico FAjdPub = new Form_Ajuda_Publico(label_r1.Text, label_r2.Text, label_r3.Text, label_r4.Text, resposta1, resposta2, resposta3, resposta4);
            FAjdPub.ShowDialog();
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

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }
    }
}
