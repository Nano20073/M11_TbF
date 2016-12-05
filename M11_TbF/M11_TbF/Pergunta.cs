using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace M11_TbF
{
    class Pergunta
    {

        MySqlConnection con = Connections.con;

        private int Nivel_da_Pergunta = 1;
        private int NPergunta = 0;
        

        private string Pergunta_Atual;
        private string Resposta1;
        private string Resposta2;
        private string Resposta3;
        private string Resposta4;
        private string Resposta_Correta;


        public void Pergunta_Set()
        {


            string query = "SELECT ID_Pergunta, Pergunta, Resposta1, Resposta2, Resposta3, Resposta4, Resposta_Correta, Nivel FROM Perguntas WHERE Nivel=" + Nivel_da_Pergunta.ToString() + " Order By RAND() LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    
                        Pergunta_Atual = dr.GetValue(1).ToString();
                        Resposta1 = dr.GetValue(2).ToString();
                        Resposta2 = dr.GetValue(3).ToString();
                        Resposta3 = dr.GetValue(4).ToString();
                        Resposta4 = dr.GetValue(5).ToString();
                        Resposta_Correta = dr.GetValue(6).ToString();
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        //
        //
        //
        //
        //
        public bool Resposta_Verificar(string Resposta)
        {
            if (Resposta == Resposta_Correta)
            {
                Nivel_da_Pergunta++;
                return true;
            }
            else
                return false;
            //string query = "SELECT ID_Pergunta, Pergunta, Resposta1, Resposta2, Resposta3, Resposta4, Resposta_Correta, Nivel FROM Perguntas WHERE Nivel=" + Nivel_da_Pergunta.ToString() + ";";
            //MySqlCommand cmd = new MySqlCommand(query, con);

            //try
            //{

            //    con.Open();

            //    MySqlDataReader dr = cmd.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        if (dr.GetValue(0).ToString() == NPergunta.ToString())
            //        {
            //            if (dr.GetValue(6).ToString() == Resposta)
            //            {
            //                Nivel_da_Pergunta++;
            //                return true;
            //            }
            //            else
            //            {
            //                return false;
            //            }
            //        }
                        

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
            //         ex.ToString());
            //}
            //finally
            //{
            //    con.Close();
            //}

            //return false;
        }
        //
        //
        //
        //
        //
        public int Nivel_Get()
        {
            return Nivel_da_Pergunta;
        }

        public string Pergunta_Get()
        {
            return Pergunta_Atual;
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

