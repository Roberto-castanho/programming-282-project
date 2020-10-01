using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Military_Simulations_Project_PRG252
{
    class Filehandler
    {
        string Conn = "Data Source=Localhost\\SQLEXPRESS;Initial Catalog=End_Results;Integrated Security=True";
        SqlConnection sqlConn;
        SqlDataReader reader = null;
        List<Airplane> ALLAirplanes = new List<Airplane>();

        public List<Airplane> ReadTo()
        {
            sqlConn = new SqlConnection(Conn);
            List<Airplane> ALLAirplanes = new List<Airplane>();

            try
            {
                sqlConn.Open();

                SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Results", sqlConn);
                reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    ALLAirplanes.Add(new Airplane(reader[0].ToString(), int.Parse(reader[1].ToString()), int.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), int.Parse(reader[4].ToString())));
                }
            }
            catch (CustomExeception C)
            {

                System.Windows.Forms.MessageBox.Show("public List<Airplane> ReadTo()" + C.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
            }
            return ALLAirplanes;

        }
    }
}
