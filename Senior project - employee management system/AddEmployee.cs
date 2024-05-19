﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Senior_project___employee_management_system
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect
           = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\smart\Documents\employee.mdf;Integrated Security = True; Connect Timeout = 30");
        public AddEmployee()
        {
            InitializeComponent();
            displayEmployeeData();
        }

        


        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;

            }
            displayEmployeeData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {

            if (addEmployee_id.Text == ""
                || addEmployee_fullName.Text == ""
                || addEmployee_gender.Text == ""
                || addEmployee_phoneNum.Text == ""
                || addEmployee_position.Text == ""
                || addEmployee_training.Text == "")
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id =@emID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addEmployee_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_id.Text.Trim() + " is already taken",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees " +
                                    "(employee_id, full_name, gender, contact_number" +
                                    ", position, salary, insert_date, training)" +
                                    "VALUES(@employeeID, @fullName, @gender, @contactNum" +
                                    ", @position, @salary, @insertDate, @training)";

                                string path = Path.Combine(@"C:\Users\smart\source\repos\Senior project - employee management system\Senior project - employee management system.sln"
                                    + addEmployee_id.Text.Trim());


                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }



                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addEmployee_phoneNum.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@training", addEmployee_training.Text.Trim());


                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added Successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmployee_id.Text = row.Cells[1].Value.ToString();
                addEmployee_fullName.Text = row.Cells[2].Value.ToString();
                addEmployee_gender.Text = row.Cells[3].Value.ToString();
                addEmployee_phoneNum.Text = row.Cells[4].Value.ToString();
                addEmployee_position.Text = row.Cells[5].Value.ToString();
                addEmployee_training.Text = row.Cells[6].Value.ToString();

            }
        }
        public void clearFields()
        {
            addEmployee_id.Text = "";
            addEmployee_fullName.Text = "";
            addEmployee_gender.SelectedIndex = -1;
            addEmployee_phoneNum.Text = "";
            addEmployee_position.SelectedIndex = -1;
            addEmployee_training.SelectedIndex = -1;
        }

        private void addEmployee_updateBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == ""
               || addEmployee_fullName.Text == ""
               || addEmployee_gender.Text == ""
               || addEmployee_phoneNum.Text == ""
               || addEmployee_position.Text == ""
               || addEmployee_training.Text == "")
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult check = MessageBox.Show("Are you syre you want to UPDATE" +
                    "Employee ID:" + addEmployee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET full_name = @fullName " +
                            ", gender = @gender, contact_number = @contactNum " +
                            ",position = @position, update_date= @updateDate, training =@training " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNum", addEmployee_phoneNum.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@training", addEmployee_training.Text.Trim());


                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Updated Successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }








            }
        }

        private void addEmployee_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        
            
        
    }
}
