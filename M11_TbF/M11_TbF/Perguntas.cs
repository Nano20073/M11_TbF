using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace M11_TbF
{
    class Perguntas
    {


        private int Nivel_da_Pergunta = 1;
        private int Vitorias_consecutivas = 0;
        private int NPergunta = 0;

        private string Pergunta;
        private string Resposta1;
        private string Resposta2;
        private string Resposta3;
        private string Resposta4;
        private string Resposta_Correta;



        public void Pergunta_Set()
        {
            var rand = new System.Random();
            var exclude = new HashSet<int>() {};
            var range = Enumerable.Range(1, 5).Where(i => !exclude.Contains(i));


            if (Vitorias_consecutivas % 3 == 0 && Vitorias_consecutivas != 0)
            {
                Nivel_da_Pergunta++;
            }

            if (Nivel_da_Pergunta == 1)
            {
                NPergunta = rand.Next(0, 100 - exclude.Count);
            }


            
            // Connection string for ADO.NET via OleDB
            OleDbConnection cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            // Prepare SQL query
            string query = "SELECT Perguntas.ID_Pergunta, Perguntas.Pergunta, Perguntas.Resposta1, Perguntas.Resposta2, Perguntas.Resposta3, Perguntas.Resposta4, Perguntas.Resposta_Correta, Perguntas.Nivel FROM Perguntas WHERE (((Perguntas.Nivel)=" + Nivel_da_Pergunta.ToString() + "));";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {

                cn.Open();

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.GetValue(0).ToString() == NPergunta.ToString())
                    {
                        Pergunta = dr.GetValue(1).ToString();
                        Resposta1 = dr.GetValue(2).ToString();
                        Resposta2 = dr.GetValue(3).ToString();
                        Resposta3 = dr.GetValue(4).ToString();
                        Resposta4 = dr.GetValue(5).ToString();
                        Resposta_Correta = dr.GetValue(6).ToString();
                    }

                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("{0}: OleDbException: Unable to connect or retrieve data from data source: {1}.",
                     ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                cn.Close();
            }
        }

        public bool Pergunta_Verificar(string Resposta)
        {
            return false;
            Random rnd = new Random();
            int NPergunta = 0;


            if (Vitorias_consecutivas % 3 == 0 && Vitorias_consecutivas != 0)
            {
                Nivel_da_Pergunta++;
            }

            if (Nivel_da_Pergunta == 1)
            {
                NPergunta = rnd.Next(1, 6);
            }



            // Connection string for ADO.NET via OleDB
            OleDbConnection cn =
                //  new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\M11_TbF_DB.accdb;Jet OLEDB:Database");
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            // Prepare SQL query
            string query = "SELECT Perguntas.ID_Pergunta, Perguntas.Resposta_Correta FROM Perguntas WHERE(((Perguntas.ID_Pergunta) =" + NPergunta.ToString() + ")); ";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {

                cn.Open();

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.GetValue(0).ToString() == NPergunta.ToString())
                    {
                        if (dr.GetValue(1).ToString() == Resposta)
                        {
                            Vitorias_consecutivas++;
                            return true;

                        }


                    }

                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("{0}: OleDbException: Unable to connect or retrieve data from data source: {1}.",
                     ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                cn.Close();
            }
        }

        public int Nivel_Get()
        {
            return Nivel_da_Pergunta;
        }

        public string Pergunta_Get()
        {
            return Pergunta;
        }

        public string Resposta1_Get()
        {
            return Resposta1;
        }

        public string Resposta2_Get()
        {
            return Resposta2;
        }

        public string Resposta3_Get()
        {
            return Resposta3;
        }

        public string Resposta4_Get()
        {
            return Resposta4;
        }

        public string Resposta_Correta_Get()
        {
            return Resposta_Correta;
        }
    }
}
