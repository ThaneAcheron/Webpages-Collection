using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections; 

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuestionTwoADbConnectionString"].ConnectionString);
            sqlConn.Open();

            SqlCommand cmd = new SqlCommand("SELECT [Description] FROM [Feature]", sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList list = new ArrayList();

            int i = 0;
            while (reader.Read())
            {
                list.Add(reader.GetValue(i));
            }
            DropDownList1.DataSource = list;
            DropDownList1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Id = 0;

        SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuestionTwoADbConnectionString"].ConnectionString); 
        sqlConn.Open(); 


        SqlCommand sqlComm = new SqlCommand("SELECT [FeatureId] FROM [Feature] WHERE [Description] = '" + DropDownList1.SelectedValue + "'", sqlConn); 
        SqlDataReader reader = sqlComm.ExecuteReader(); 

        while(reader.Read())
        {
           Id = reader.GetInt32(0);
        }

      //  SqlCommand sqlCom = new SqlCommand("SELECT [Description] FROM [Vehical] WHERE [FeatureId] = '" + Id.ToString() + "'");
     //   SqlDataReader newReader = sqlCom.ExecuteReader();

        SqlDataSource1.SelectCommand = "SELECT [Description] FROM [Vehicle] WHERE [FeatureId] = '" + Id.ToString() + "'";
    }
}