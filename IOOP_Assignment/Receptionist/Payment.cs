﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class frmPayment : Form
    {
        private string connectionString;

        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load_1(object sender, EventArgs e)
        {
            string maincon = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
            SqlConnection con = new SqlConnection(maincon);
            string sqlquery = "select Order.OrderID,Customer.Name, Types of Service Request.Service Title, Order.Servie Type, Order.Status,Order.Laptop, Order.Amount, Order.Payment Status" +
                " From [dob].[Order] inner join [dob].[Customer] on Order.CustomerID=Customer.CustomerID inner join [dob].[Types of Service Request] on Order.ServiceRequestTypeID=Types of Service Request.ServiceRequestTypeID";

            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewPayment.DataSource = dt;
            con.Close();
        }
    }
}
