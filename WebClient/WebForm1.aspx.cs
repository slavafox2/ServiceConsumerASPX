using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebClient.EmployeeService;
using System.Data;

namespace WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var client = new EmployeeWSSoapClient();                
                DropDownList1.DataSource = client.GetJobs();
                DropDownList1.DataTextField = "Job_nm";
                DropDownList1.DataValueField = "Job_id";
                DropDownList1.AppendDataBoundItems = true;
                DropDownList1.DataBind();

                DataSet ds = new DataSet();
                ds = client.GetAllEmpployees();
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                ViewState["dtEmp"] = dt;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = new EmployeeWSSoapClient();
            DataSet ds = new DataSet();
            int parsedID;
            if (int.TryParse(DropDownList1.SelectedValue, out parsedID))
            {
                ds = client.GetEmpployeesByJobID(parsedID);
            }
            else
            {
                ds = client.GetAllEmpployees();
            }
                            
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ViewState["dtEmp"] = dt; 
              
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void GridView_Sorting1(object sender, GridViewSortEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)ViewState["dtEmp"];

            if (dt != null)
            {
                if (GridView1.Attributes["CustomSortDirection"] == "ASC")
                {
                    dt.DefaultView.Sort = "Salary DESC";
                    GridView1.Attributes["CustomSortDirection"] = "DESC";
                }
                else
                {
                    dt.DefaultView.Sort = "Salary ASC";
                    GridView1.Attributes["CustomSortDirection"] = "ASC";
                }
            }

            ViewState["dtEmp"] = dt.DefaultView.ToTable();
         
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)ViewState["dtEmp"];

            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = dt;
            GridView1.DataBind();            

        }

        
    }
}

