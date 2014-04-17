using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        string connectionString = ConfigurationManager.ConnectionStrings["UkropsCustomers"].ConnectionString;
        conn = new SqlConnection(connectionString);
        comm = new SqlCommand("SELECT CustomerID, FirstName, LastName, StreetAddress, City, State, ZipCode, HomePhone, WorkPhone, MobilePhone, AlternatePhone FROM Customers", conn);

        try
        {
            conn.Open();
            reader = comm.ExecuteReader();
            customerRepeater.DataSource = reader;
            customerRepeater.DataBind();
            reader.Close();
        }
        finally 
        {
            conn.Close();
        }
    }
}
