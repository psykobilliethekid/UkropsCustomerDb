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

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            SqlConnection conn;
            SqlCommand comm;
            string connectionString = ConfigurationManager.ConnectionStrings["UkropsCustomers"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("INSERT INTO Customers(FirstName, LastName, StreetAddress, City, State, ZipCode, HomePhone, WorkPhone, MobilePhone, AlternatePhone) VALUES (@FirstName, @LastName, @StreetAddress, @City, @State, @ZipCode, @HomePhone, @WorkPhone, @MobilePhone, @AlternatePhone ) ", conn);

            comm.Parameters.Add("@FirstName", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@FirstName"].Value = FirstNameTextBox.Text;

            comm.Parameters.Add("@LastName", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@LastName"].Value = LastNameTextBox.Text;

            comm.Parameters.Add("@StreetAddress", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@StreetAddress"].Value = StreetTextBox.Text;

            comm.Parameters.Add("@City", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@City"].Value = CityTextBox.Text;

            comm.Parameters.Add("@State", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@State"].Value = StateTextBox.Text;

            comm.Parameters.Add("@ZipCode", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@ZipCode"].Value = ZipCodeTextBox.Text;

            comm.Parameters.Add("@HomePhone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@HomePhone"].Value = HomePhoneTextBox.Text;

            comm.Parameters.Add("@WorkPhone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@WorkPhone"].Value = WorkPhoneTextBox.Text;

            comm.Parameters.Add("@MobilePhone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@MobilePhone"].Value = MobilePhoneTextBox.Text;

            comm.Parameters.Add("@AlternatePhone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@AlternatePhone"].Value = AltPhoneTextBox.Text;

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                Response.Redirect("Add.aspx");
            }

            catch
            {
               
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
