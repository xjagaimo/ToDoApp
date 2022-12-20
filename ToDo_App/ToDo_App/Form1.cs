using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ToDo_App
{
    public partial class Form1 : Form
    {
        public static string getConnectionString() 
        {
            string basePath = Application.StartupPath;
            int index = basePath.IndexOf("ToDo_App");
            // add ToDo_App to path 
            string path = basePath.Substring(0, index + @"ToDo_App\ToDo_App\ToDo_App".Length) + @"\Database.mdf";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+path+ ";Integrated Security=True;Connect Timeout=30";
            return connectionString;
            //static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Code\C#\ToDo\ToDo_App\ToDo_App\Database.mdf;Integrated Security=True;Connect Timeout=30";

        }
        static string connectionString = getConnectionString();
        public Form1()
        {
            InitializeComponent();
            refreshTable();
        }


        public void refreshTable()
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from ActivityTracker", dbConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            testCheckBox.Items.Clear();
            foreach (DataTable dt in dataSet.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    testCheckBox.Items.Add(dr["Aktivitas"].ToString());
                }
            }
            dbConnection.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO ActivityTracker (Aktivitas, Selesai, Deskripsi) VALUES ('" + titleTextBox.Text + "','" + 1 + "','" + NewDescBox.Text + "')", dbConnection);
            cmd.ExecuteNonQuery();

            dbConnection.Close();
            refreshTable();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            foreach (object itemChecked in testCheckBox.CheckedItems)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM ActivityTracker WHERE Aktivitas='" + itemChecked.ToString() + "'", dbConnection);
                cmd.ExecuteNonQuery();
            }
            
            //Console.Write(testCheckBox.SelectedIndex);
            
            dbConnection.Close();
            refreshTable();
        }

        private void testCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DescBox_TextChanged(object sender, EventArgs e)
        {

        }


        // CODE BELOW IS FOR TESTING ONLY
        private void WhatIsChecked_Click(object sender, EventArgs e)
        {
                // Display in a message box all the items that are checked.

                // First show the index and check state of all selected items.
                foreach (int indexChecked in testCheckBox.CheckedIndices)
                {
                    // The indexChecked variable contains the index of the item.
                    MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
                                    testCheckBox.GetItemCheckState(indexChecked).ToString() + ".");
                }

                // Next show the object title and check state for each item selected.
                foreach (object itemChecked in testCheckBox.CheckedItems)
                {

                    // Use the IndexOf method to get the index of an item.
                    MessageBox.Show("Item with title: \"" + itemChecked.ToString() +
                                    "\", is checked. Checked state is: " +
                                    testCheckBox.GetItemCheckState(testCheckBox.Items.IndexOf(itemChecked)).ToString() + ".");
                }
            
        }

        private void testCheckBox_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT Deskripsi FROM ActivityTracker WHERE Aktivitas='" + testCheckBox.SelectedItem.ToString() + "'", dbConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            //MessageBox.Show(dataSet.Tables[0].Rows[0].["Aktivitas"].ToString());

            //DescBox.Text =

            //object itemSelected = testCheckBox.SelectedItem;
            //MessageBox.Show("You are in the CheckedListBox.Click event.");
            //MessageBox.Show(itemSelected.ToString());
            //if (itemSelected.ToString() == "heya")
            // {
            DescBox.Text = testCheckBox.Text;
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
