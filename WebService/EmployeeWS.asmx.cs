using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WebService
{
    /// <summary>
    /// Summary description for EmployeeWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EmployeeWS : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetAllEmpployees()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesDBConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", conn))
                {
                    if (conn.State != ConnectionState.Open) { conn.Open(); }

                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cmd;
                    adp.Fill(ds);
                    if (conn.State == ConnectionState.Open) { conn.Close(); }

                    return ds;
                }
            }
        }

        [WebMethod]
        public DataSet GetEmpployeesByJobID(int id)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn =  new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesDBConnectionString"].ConnectionString) )
            {                                                                
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE Job_id = @jobId", conn))
                {
                    cmd.Parameters.AddWithValue("@jobId", id);

                    if (conn.State != ConnectionState.Open) { conn.Open(); }

                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cmd;
                    adp.Fill(ds);
                    if (conn.State == ConnectionState.Open) { conn.Close(); }

                    return ds;
                }
            }           
        }

        [WebMethod]
        public DataSet GetJobs()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesDBConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Jobs", conn) ){

                    if (conn.State != ConnectionState.Open) { conn.Open(); }

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);

                    if (conn.State == ConnectionState.Open) { conn.Close(); }

                    return ds;
                }
            }
            
        }
    }
}
