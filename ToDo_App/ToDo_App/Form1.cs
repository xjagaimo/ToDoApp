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
using System.Data.Common;
using System.Globalization;

namespace ToDo_App
{
    public partial class Form1 : Form
    {
        public static string getConnectionString() 
        {
            string basePath = Application.StartupPath;
            int index = basePath.IndexOf("ToDoApp");
            // add ToDo_App to path 
            string path = basePath.Substring(0, index + @"ToDoApp\ToDo_App\ToDo_App".Length) + @"\Database.mdf";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+path+ ";Integrated Security=True;Connect Timeout=30";
            return connectionString;
            //static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Code\C#\ToDo\ToDo_App\ToDo_App\Database.mdf;Integrated Security=True;Connect Timeout=30";

        }

        public DateTime dateConverter (string date)
        {
            return DateTime.ParseExact(date, "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
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
            //SqlCommand cmd = new SqlCommand("INSERT INTO ActivityTracker (Aktivitas, Selesai, Deskripsi) VALUES ('" + titleTextBox.Text + "','" + 1 + "','" + NewDescBox.Text + "')", dbConnection);
            //cmd.ExecuteNonQuery();

            bool duplicate = false;
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            //if exec 
            if (testCheckBox.SelectedItem == null)
            {
                // Adds new activity
                foreach (string obj in testCheckBox.Items)
                {
                    if (obj == titleTextBox.Text)
                        duplicate = true;
                }
                if (!duplicate)
                {
                    sqlDataAdapter.InsertCommand = new SqlCommand("INSERT INTO ActivityTracker (Aktivitas, Selesai, Deskripsi, Waktu) VALUES ('" + titleTextBox.Text + "','" + 1 + "','" + NewDescBox.Text + "','" + newDateTimePicker.Value.ToString() + "')", dbConnection);
                    sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show(titleTextBox.Text + " was successfully added");
                }
                else
                {
                    MessageBox.Show("Error! There is already an activity with the same name.");
                }
            }

            if (testCheckBox.SelectedItem != null)
            {
                foreach (string obj in testCheckBox.Items)
                {
                    if (obj == titleTextBox.Text)
                        duplicate = true;
                }
                if (!duplicate)
                {
                    sqlDataAdapter.InsertCommand = new SqlCommand("UPDATE ActivityTracker SET Aktivitas='" + titleTextBox.Text + "', Deskripsi='" + NewDescBox.Text +"', Waktu='" + newDateTimePicker.Value.ToString() + "' WHERE Aktivitas='" + testCheckBox.SelectedItem.ToString() + "'", dbConnection);
                    sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Error! There is already an activity with the same name.");
                }
                DescBox.Text = NewDescBox.Text;
                MessageBox.Show(titleTextBox.Text + " was successfully edited");
            }
            //cmd.Dispose();
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

                MessageBox.Show(itemChecked.ToString() + " was succesfully deleted");
                titleTextBox.Text = null;
                NewDescBox.Text = null;
                DescBox.Text = null;
            }
            
            //Console.Write(testCheckBox.SelectedIndex);
            
            dbConnection.Close();
            refreshTable();
        }

        string previousSelected = "";
        private void testCheckBox_Click(object sender, EventArgs e)
        {
            if (testCheckBox.SelectedItem != null)
            {
                if (testCheckBox.SelectedItem.ToString() == previousSelected)
                {
                    testCheckBox.SelectedIndex = -1;
                    previousSelected = "";
                }
                else
                {
                    string output = "";
                    string itemSelected = testCheckBox.SelectedItem.ToString();
                    previousSelected = testCheckBox.SelectedItem.ToString();
                    SqlConnection dbConnection = new SqlConnection(connectionString);
                    dbConnection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Deskripsi FROM ActivityTracker WHERE Aktivitas='" + itemSelected + "'", dbConnection);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        output = sqlDataReader.GetString(0);
                    }
                    //MessageBox.Show(output);

                    DescBox.Text = output;
                    NewDescBox.Text = output;
                    titleTextBox.Text = itemSelected;

                    sqlDataReader.Close();
                    cmd.Dispose();
                    dbConnection.Close();
                    dbConnection.Open();
                    cmd = new SqlCommand("SELECT Waktu FROM ActivityTracker WHERE Aktivitas='" + itemSelected + "'", dbConnection);
                    SqlDataReader sqlDataReader2 = cmd.ExecuteReader();

                    while (sqlDataReader2.Read())
                    {
                        output = sqlDataReader2.GetString(0);
                    }
                    dbConnection.Close();
                    newDateTimePicker.Value = dateConverter(output);
                }
            }
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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void NewDescBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
