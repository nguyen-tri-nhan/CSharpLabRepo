using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.DAOs
{
    class EmployeeDAO
    {
        string strConnection;
        public string getConnectionString()
        {
            string strConnection = "server=DESKTOP-LVLR7JR;database=BookStore;uid=sa;pwd=123456789";
            return strConnection;
        }

        public EmployeeDAO()
        {
            strConnection = getConnectionString();
        }

        public EmployeeDTO CheckLogin(string Id, string Password)
        {
            EmployeeDTO dto = null;
            SqlConnection conn = new SqlConnection(strConnection);
            string SQL = "SELECT EmpID, EmpPassword, EmpRole FROM Employee" +
                " WHERE EmpID = @ID AND EmpPassword = @Password AND EmpRole = @EmpRole";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@ID", Id);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@EmpRole", true);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

            }
            return dto;
        }
    }
}
