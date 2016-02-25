﻿using System;
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
        private int Numero_da_Pergunta;
        private string Pergutna;


        public string Pergunta_Set()
        {
            Random rnd = new Random();
            int nivel = 0;


            if (Vitorias_consecutivas % 3 == 0)
            {
                Nivel_da_Pergunta++;
            }

            if (Nivel_da_Pergunta == 1)
            {
                nivel = rnd.Next(1, 6);
            }



            // Connection string for ADO.NET via OleDB
            OleDbConnection cn =
                //  new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\M11_TbF_DB.accdb;Jet OLEDB:Database");
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            // Prepare SQL query
            string query = "SELECT Perguntas.ID_Pergunta, Perguntas.Pergunta, Perguntas.Resposta1, Perguntas.Resposta2, Perguntas.Resposta3, Perguntas.Resposta4, Perguntas.Resposta_Correta, Perguntas.Nivel FROM Perguntas WHERE (((Perguntas.Nivel)=" + Nivel_da_Pergunta.ToString() + "));";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {

                cn.Open();


                //MessageBox.Show("{Successfully connected to database. Data source name:" + cn.DataSource);
                //MessageBox.Show("SQL query:\n {0}" + query);

                // Run the query and create a record set
                OleDbDataReader dr = cmd.ExecuteReader();

                int row = 0;
                while (dr.Read())
                {
                    if (dr.GetValue(0).ToString() == nivel.ToString())
                    {
                        if (dr.GetValue(1).ToString() == Password)
                        {
                            Username_atual = Username;
                            MessageBox.Show("conetou-se");

                        }
                    }
                    row++;
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
                MessageBox.Show("{0}: Cleanup. Done.");
            }

        }
        public string Pergunta_Get()
        {
            return "";
        }


    }
}
