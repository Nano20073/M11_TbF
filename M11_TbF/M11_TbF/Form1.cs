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
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            // Prepare SQL query
            string query = "SELECT Perguntas.* FROM Perguntas;";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {
                cn.Open();
                MessageBox.Show("{Successfully connected to database. Data source name:" +  cn.DataSource);
                MessageBox.Show("SQL query:\n {0}" + query);

                // Run the query and create a record set
                OleDbDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("{0}: Retrieve schema info for the given result set:");
                for (int column = 0; column < dr.FieldCount; column++)
                {
                    MessageBox.Show(" | {0}", dr.GetName(column));
                }
                MessageBox.Show("\n{0}: Fetch the actual data: ");
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
