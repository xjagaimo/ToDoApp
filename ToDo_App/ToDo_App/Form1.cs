﻿using System;
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
using ToDo.Package.Rexiar;

namespace ToDo_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshTable();
            updateApp();
        }
        public void test()
        {
            Pkg1 package = new Pkg1();
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from ActivityTracker", dbConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            foreach (DataTable dt in dataSet.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (package.testTime(package.dateConverter(dr["Waktu"].ToString())) && !(bool)dr["Selesai"] && (bool)dr["Notifikasi"])
                    {
                        notifPopup.Visible = true;
                        notifPopup.Text = "Reminder Notes";
                        notifPopup.BalloonTipTitle = "Reminder Notes";
                        notifPopup.BalloonTipText = "It is time for " + dr["Aktivitas"].ToString();
                        notifPopup.ShowBalloonTip(800);
                        sqlDataAdapter.InsertCommand = new SqlCommand("UPDATE ActivityTracker SET Selesai='" + 1 + "' WHERE Aktivitas='" + dr["Aktivitas"].ToString() + "'", dbConnection);
                        sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                    }
                }
            }
            dbConnection.Close();
        }
        public void updateApp()
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_tick);
            //5 seconds
            timer.Interval = 5000;
            timer.Start();
        }

        public void timer_tick(object sender, EventArgs ev)
        {
            test();
        }

        public static string getConnectionString() 
        {
            string basePath = Application.StartupPath;
            int index = basePath.IndexOf("ToDoApp");
            string path = basePath.Substring(0, index + @"ToDoApp\ToDo_App\ToDo_App".Length) + @"\Database.mdf";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+path+ ";Integrated Security=True;Connect Timeout=30";
            return connectionString;
        }

        static string connectionString = getConnectionString();


        public void refreshTable()
        {
            Pkg1 package = new Pkg1();
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from ActivityTracker", dbConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            testCheckBox.Items.Clear();
            titleTextBox.Text = null;
            NewDescBox.Text = null;
            checkBoxTime.Checked = false;
            newDateTimePicker.Value = package.dateConverter(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            foreach (DataTable dt in dataSet.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    testCheckBox.Items.Add(dr["Aktivitas"].ToString());
                }
            }
            dbConnection.Close();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
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
                    sqlDataAdapter.InsertCommand = new SqlCommand("INSERT INTO ActivityTracker (Aktivitas, Selesai, Deskripsi, Waktu, Notifikasi) VALUES ('" + titleTextBox.Text + "','" + 0 + "','" + NewDescBox.Text + "','" + newDateTimePicker.Value.ToString() + "','" + checkBoxTime.Checked + "')", dbConnection);
                    sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Error! Activity with the same title already exists.");
                }
            }

            else if (testCheckBox.SelectedItem != null)
            {
                foreach (string obj in testCheckBox.Items)
                {
                    if (obj == titleTextBox.Text && titleTextBox.Text != testCheckBox.SelectedItem.ToString() )
                        duplicate = true;
                }
                if (!duplicate)
                {
                    sqlDataAdapter.InsertCommand = new SqlCommand("UPDATE ActivityTracker SET Aktivitas='" + titleTextBox.Text + "', Selesai='" + 0 + "', Deskripsi='" + NewDescBox.Text +"', Waktu='" + newDateTimePicker.Value.ToString() + "', Notifikasi='" + checkBoxTime.Checked + "' WHERE Aktivitas='" + testCheckBox.SelectedItem.ToString() + "'", dbConnection);
                    sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                }
                else if (testCheckBox.SelectedItem.ToString() != titleTextBox.Text)
                {
                    MessageBox.Show("Error! Activity with the same title already exists.");
                }
            }
            dbConnection.Close();
            refreshTable();
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
            dbConnection.Close();
            refreshTable();
        }

        string previousSelected = "";
        private void testCheckBox_Click(object sender, EventArgs e)
        {
            Pkg1 package = new Pkg1();
            if (testCheckBox.SelectedItem != null)
            {
                if (testCheckBox.SelectedItem.ToString() == previousSelected)
                {
                    testCheckBox.SelectedIndex = -1;
                    previousSelected = "";
                    titleTextBox.Text = null;
                    NewDescBox.Text = null;
                    checkBoxTime.Checked = false;
                    newDateTimePicker.Value = package.dateConverter(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
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
                    NewDescBox.Text = output;
                    titleTextBox.Text = itemSelected;
                    sqlDataReader.Close();
                    cmd.Dispose();
                    cmd = new SqlCommand("SELECT Waktu FROM ActivityTracker WHERE Aktivitas='" + itemSelected + "'", dbConnection);
                    SqlDataReader sqlDataReader2 = cmd.ExecuteReader();
                    while (sqlDataReader2.Read())
                    {
                        output = sqlDataReader2.GetString(0);
                    }
                    newDateTimePicker.Value = package.dateConverter(output);
                    sqlDataReader2.Close();
                    cmd.Dispose();
                    bool val = false;
                    cmd = new SqlCommand("SELECT Notifikasi FROM ActivityTracker WHERE Aktivitas='" + itemSelected + "'", dbConnection);
                    SqlDataReader sqlDataReader3 = cmd.ExecuteReader();
                    while (sqlDataReader3.Read())
                    {
                        val = sqlDataReader3.GetBoolean(0);
                    }
                    checkBoxTime.Checked = val;
                    dbConnection.Close();
                }
            }
        }
    }
}
