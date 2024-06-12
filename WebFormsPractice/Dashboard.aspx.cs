using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsPractice
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            string strPhysicalPath = Server.MapPath("Countries.xml");
            DS.ReadXml(strPhysicalPath);
            ddlEmployee.DataTextField = "CountryName";
            ddlEmployee.DataValueField = "CountryId";
            ddlEmployee.DataSource = DS;
            ddlEmployee.DataBind();

            ListItem li = new ListItem("Select", "-1");
            ddlEmployee.Items.Insert(0, li);
        }
    }
}



#region Comments
//From DB
//string conn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
//using (SqlConnection con = new SqlConnection(conn))
//{
//    SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", con);
//    con.Open();
//    ddlEmployee.DataSource = cmd.ExecuteReader();
//    ddlEmployee.DataTextField = "first_name";
//    ddlEmployee.DataValueField = "id";
//    ddlEmployee.DataBind();
//}

//From XML
//DataSet DS = new DataSet();
//string strPhysicalPath = Server.MapPath("Countries.xml");
//DS.ReadXml(strPhysicalPath);
//ddlEmployee.DataTextField = "CountryName";
//ddlEmployee.DataValueField = "CountryId";
//ddlEmployee.DataSource = DS;
//ListItem li = new ListItem("Select", "-1");
//ddlEmployee.Items.Insert(0, li);
//ddlEmployee.DataBind();
#endregion