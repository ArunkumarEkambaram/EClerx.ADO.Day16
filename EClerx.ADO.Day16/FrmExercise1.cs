using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace EClerx.ADO.Day16
{
    public partial class FrmExercise1 : Form
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;


        public FrmExercise1()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HR"].ConnectionString))
                {
                    using (cmd = new SqlCommand("usp_GetEmployeeSalaryByPayDate", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Initialize value for From Pay Date
                        cmd.Parameters.Add(new SqlParameter("@FromPayDate", SqlDbType.DateTime));
                        cmd.Parameters["@FromPayDate"].Value = DtpFromPayDate.Value;
                        //Initialize value for To Pay Date
                        cmd.Parameters.Add(new SqlParameter("@ToPayDate", SqlDbType.DateTime));
                        cmd.Parameters["@ToPayDate"].Value = DtpToPayDate.Value;

                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            GridEmployees.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Please provide proper date");
                        }
                        reader.Close();
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
