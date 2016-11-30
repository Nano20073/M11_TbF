using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;

namespace M11_TbF
{
    class Conquista
    {
        MySqlConnection con = Connections.con;


        public bool Verificar_Conquista(int ID_Utilizador, int ID_Conquista)
        {
            

            string query = "SELECT ID_Conquista, ID_Utilizador FROM UtilizadorConquista; ";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (int.Parse(dr.GetValue(1).ToString()) == ID_Utilizador)
                    {
                        if(int.Parse(dr.GetValue(0).ToString()) == ID_Conquista)
                        {
                            dr.Close();
                            return true;
                        }                       
                    }
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
            }
            return false;
        }
        //
        //
        //
        //
        //
        public void Adicionar_Conquista(int ID_Utilizador, int ID_Conquista)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into UtilizadorConquista (ID_Conquista,ID_Utilizador) values (?,?)";
            cmd.Parameters.AddWithValue("@ID_Conquista", ID_Conquista);
            cmd.Parameters.AddWithValue("@ID_Utilizador", ID_Utilizador);
            cmd.Connection = con;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                     ex.ToString());
            }
            finally
            {
            }
        }
        //
        //
        //
        //
        //
        public void Reset_Conquistas(int ID_Utilizador)
        {
            try
            {
                con.Open();
                string query = "Delete from UtilizadorConquista where ID_Utilizador =" + ID_Utilizador;
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
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
    }
}
