using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace loginAC
{
    public class conectar
    {
        public SqlConnection connect = new SqlConnection();
        public conectar(String user, String pass)
        {
            try
            {

                SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-43IRSAR;Database=Clientes;UID=" + user + ";PWD=" + pass);
                connect = sqlConnection;
                connect.Open();
            }
            catch (Exception)
            {


            }
        }
}
}
