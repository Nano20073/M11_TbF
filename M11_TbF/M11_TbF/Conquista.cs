using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace M11_TbF
{
    class Conquista
    {
        OleDbConnection cn =
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

        

        public bool Verificar_Conquista(int ID_Utilizador, int ID_Conquista)
        {
            

            string query = "SELECT ID_Conquista, ID_Utilizador FROM UtilizadorConquista; ";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {
                cn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (int.Parse(dr.GetValue(1).ToString()) == ID_Utilizador)
                    {
                        if(int.Parse(dr.GetValue(0).ToString()) == ID_Conquista)
                        {
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
                cn.Close();
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
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into UtilizadorConquista ([ID_Conquista],[ID_Utilizador]) values (?,?)";
            cmd.Parameters.AddWithValue("@ID_Conquista", ID_Conquista);
            cmd.Parameters.AddWithValue("@ID_Utilizador", ID_Utilizador);
            cmd.Connection = cn;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
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
        //
        //
        //
        //
        //
        public void Reset_Conquistas(int ID_Utilizador)
        {
            try
            {
                cn.Open();
                string OleDBStatement = "Delete from UtilizadorConquista where ID_Utilizador =" + ID_Utilizador;
                OleDbCommand cmd = new OleDbCommand(OleDBStatement, cn);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
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
    }
}
