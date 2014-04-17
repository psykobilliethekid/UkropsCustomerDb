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
        if (!IsPostBack)
        {
            LoadCustomerList();
        }
    }

    private void LoadCustomerList()
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        string connectionString = ConfigurationManager.ConnectionStrings["UkropsCustomers"].ConnectionString;
        conn = new SqlConnection(connectionString);
        comm = new SqlCommand("SELECT CustomerID FROM Customers", conn);

        try
        {
            conn.Open();
            reader = comm.ExecuteReader();
            customerList.DataSource = reader;
            customerList.DataValueField = "CustomerID";
            customerList.DataTextField = "CustomerID";
            customerList.DataBind();
            reader.Close();
        }
        catch
        {
            dbErrorLabel.Text = "Error loading list of customers!<br/>";
        }
        finally
        {
            conn.Close();
        }
        updateButton.Enabled = false;
        deleteButton.Enabled = false;

        FirstNameTextBox.Text = " ";
        LastNameTextBox.Text = " ";
        StreetTextBox.Text = " ";
        CityTextBox.Text = " ";
        StateTextBox.Text = " ";
        ZipCodeTextBox.Text = " ";
        HomePhoneTextBox.Text = " ";
        WorkPhoneTextBox.Text = " ";
        MobilePhoneTextBox.Text = " ";
        AltPhoneTextBox.Text = " ";
    }
    protected void selectButton_Click(object sender, EventArgs e)
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        string connectionString = ConfigurationManager.ConnectionStrings["UkropsCustomers"].ConnectionString;

        conn = new SqlConnection(connectionString);
        comm = new SqlCommand("SELECT FirstName, LastName, StreetAddress, City, State, ZipCode, HomePhone, WorkPhone, MobilePhone, AlternatePhone FROM Customers WHERE CustomerID = @CustomerID", conn);
        comm.Parameters.Add("@CustomerID", System.Data.SqlDbType.Int);
        comm.Parameters["@CustomerID"].Value = customerList.SelectedItem.Value;

        try
        {
            conn.Open();
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                FirstNameTextBox.Text = reader["FirstName"].ToString();
                LastNameTextBox.Text = reader["LastName"].ToString();
                StreetTextBox.Text = reader["StreetAddress"].ToString();
                CityTextBox.Text = reader["City"].ToString();
                StateTextBox.Text = reader["State"].ToString();
                ZipCodeTextBox.Text = reader["ZipCode"].ToString();
                HomePhoneTextBox.Text = reader["HomePhone"].ToString();
                WorkPhoneTextBox.Text = reader["WorkPhone"].ToString();
                MobilePhoneTextBox.Text = reader["MobilePhone"].ToString();
                AltPhoneTextBox.Text = reader["AlternatePhone"].ToString();
            }
            reader.Close();
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
        }
        catch
        {
            dbErrorLabel.Text = "Error loading customer information!<br/>";
        }
        finally
        {
            conn.Close();
        }
    }
    protected void updateButton_Click(object sender, EventArgs e)
    {
        SqlConnection conn;
        SqlCommand comm;
        string connectionString = ConfigurationManager.ConnectionStrings["UkropsCustomers"].ConnectionString;
        conn = new SqlConnection(connectionString);
        comm = new SqlCommand("UPDATE Customers Set FirstName=@FirstName, LastName=@LastName, StreetAddress=@StreetAddress, City=@City, State=@State, ZipCode=@ZipCode, HomePhone=@HomePhone, WorkPhone=@WorkPhone, MobilePhone=@MobilePhone, AlternatePhone=@AlternatePhone WHERE CustomerID=@CustomerID", conn);
        
        comm.Parameters.Add("@FirstName", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@FirstName"].Value = FirstNameTextBox.Text;

        comm.Parameters.Add("@LastName", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@LastName"].Value = LastNameTextBox.Text;

        comm.Parameters.Add("@StreetAddress", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@StreetAddress"].Value = StreetTextBox.Text;

        comm.Parameters.Add("@City", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@City"].Value = CityTextBox.Text;

        comm.Parameters.Add("@State", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@State"].Value = StateTextBox.Text;

        comm.Parameters.Add("@ZipCode", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@ZipCode"].Value = ZipCodeTextBox.Text;

        comm.Parameters.Add("@HomePhone", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@HomePhone"].Value = HomePhoneTextBox.Text;

        comm.Parameters.Add("@WorkPhone", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@WorkPhone"].Value = WorkPhoneTextBox.Text;

        comm.Parameters.Add("@MobilePhone", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@MobilePhone"].Value = MobilePhoneTextBox.Text;

        comm.Parameters.Add("@AlternatePhone", System.Data.SqlDbType.NVarChar, 50);
        comm.Parameters["@AlternatePhone"].Value = AltPhoneTextBox.Text;

        comm.Parameters.Add("CustomerID", System.Data.SqlDbType.Int);
        comm.Parameters["CustomerID"].Value = customerList.SelectedItem.Value;

        try
        {
            conn.Open();
            comm.ExecuteNonQuery();
        }
        catch
        {
            dbErrorLabel.Text = "Error updating customer information!<br/>";
        }
        finally
        {
            conn.Close();
        }
        LoadCustomerList();
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SqlConnection conn;
        SqlCommand comm;
        string connectionString = ConfigurationManager.ConnectionStrings["UkropsCustomers"].ConnectionString;
        conn = new SqlConnection(connectionString);
        comm = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", conn);
        comm.Parameters.Add("@CustomerID", System.Data.SqlDbType.Int);
        comm.Parameters["@CustomerID"].Value = customerList.SelectedItem.Value;

        try
        {
            conn.Open();
            comm.ExecuteNonQuery();
        }
        catch
        {
            dbErrorLabel.Text = "Error deleting employee!<br/>";
        }
        finally
        {
            conn.Close();
        }
        LoadCustomerList();
    }
}

