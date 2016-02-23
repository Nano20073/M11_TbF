using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace M11_TbF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string for ADO.NET via OleDB
            OleDbConnection cn =
                //  new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\M11_TbF_DB.accdb;Jet OLEDB:Database");
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\M11_TbF_DB.accdb;");

            // Prepare SQL query
            string query = "SELECT Perguntas.* FROM Perguntas;";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {
                cn.Open();
                Console.WriteLine("{0}: Successfully connected to database. Data source name:\n {1}"
                    , cn.DataSource);
                Console.WriteLine("{0}: SQL query:\n {1}", query);

                // Run the query and create a record set
                OleDbDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("{0}: Retrieve schema info for the given result set:");
                for (int column = 0; column < dr.FieldCount; column++)
                {
                    Console.Write(" | {0}", dr.GetName(column));
                }
                Console.WriteLine("\n{0}: Fetch the actual data: ");
                int row = 0;
                while (dr.Read())
                {
                    MessageBox.Show( dr.GetValue(0).ToString() + dr.GetValue(1).ToString());
                    row++;
                }
                MessageBox.Show("Total Row Count: {1}" + row.ToString());
                dr.Close();
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
    }
}
