using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
       if(RadioButtonList1.Items.FindByText("Day").Selected == true)
       {
           DropDownList1.Items.Clear();
           DropDownList1.Items.Add("Coke");
           DropDownList1.Items.Add("Cream Soda");
       }
       if(RadioButtonList1.Items.FindByText("Night").Selected == true)
       {
           DropDownList1.Items.Clear();
           DropDownList1.Items.Add("Fanta");
           DropDownList1.Items.Add("Sprite"); 
       }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["CTIQuestionTwoConnectionString"].ConnectionString);
        sqlCon.Open();


            SqlCommand sqlcom = new SqlCommand("UPDATE [Movies] SET [drink] = '" + DropDownList1.Text + "' WHERE [SeatNo] = '" + TextBox2.Text + "'", sqlCon);
            int effect = sqlcom.ExecuteNonQuery();
        if (effect == 0)
        {
            Label3.Text = "Does not exist!";
        }
        else
        {
            Label3.Text = "Success!";
        }
    }
}