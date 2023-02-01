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
using System.Configuration;
using System.Data.OleDb;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITMO2022.ADO.Net.ControlTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.connection.StateChange += new
                System.Data.StateChangeEventHandler(
                this.connection_StateChange);
        }

        SqlConnection connection = new SqlConnection();
        static string pass;
        static string login;

        private SqlDataAdapter SqlDataAdapter1;
        private SqlDataAdapter SqlDataAdapter2;
        private DataSet NorthwindDataSet = new DataSet("Northwind");
        private DataTable PersonsTable = new DataTable("dbo.Customers");
        private DataTable StateProvinceTable = new DataTable("dbo.Employees");

        string connect = $"Password={pass};Persist Security Info=True; User ID={login};" +
                " Initial Catalog=Northwind;Data Source=(localdb)\\Local";

        private void создатьСоединениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    PassForm passForm = new PassForm();
                    if (passForm.ShowDialog() != DialogResult.OK)
                        return;
                    pass = passForm.Password;
                    login = passForm.Login;

                    if (login == "MyLogin" && pass == "MyPassword")
                    {
                        connection.ConnectionString = connect;
                        connection.Open();
                        MessageBox.Show("Соединение с базой данных выполнено успешно");
                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль");
                    }
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void отключитьСоединениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            создатьСоединениеToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            отключитьСоединениеToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Open);
        }

        private void presentTable1Button_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }

            try
            {
                SqlCommand command1 = connection.CreateCommand();
                command1.CommandText = "Select * from dbo.Customers;";
                SqlDataAdapter1 = new SqlDataAdapter(command1.CommandText, connection);
                NorthwindDataSet.Tables.Add(PersonsTable);
                SqlDataAdapter1.Fill(NorthwindDataSet.Tables["dbo.Customers"]);
                table1DataGridView.DataSource = NorthwindDataSet.Tables["dbo.Customers"];
                SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось представить таблицу");
            }
        }

        private void presentTable2Button_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }

            try
            {
                SqlCommand command2 = connection.CreateCommand();
                command2.CommandText = "Select * from dbo.Employees";
                SqlDataAdapter2 = new SqlDataAdapter(command2.CommandText, connection);
                NorthwindDataSet.Tables.Add(StateProvinceTable);
                SqlDataAdapter2.Fill(NorthwindDataSet.Tables["dbo.Employees"]);
                table2DataGridView.DataSource = NorthwindDataSet.Tables["dbo.Employees"];
                SqlCommandBuilder commands2 = new SqlCommandBuilder(SqlDataAdapter2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось представить таблицу");
            }
        }

        private void updateButton1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }

            try
            {
                NorthwindDataSet.EndInit();
                SqlDataAdapter1.Update(NorthwindDataSet.Tables["dbo.Customers"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось сохранить данные");
            }
        }

        private void updateButton2_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }

            try
            {
                NorthwindDataSet.EndInit();
                SqlDataAdapter2.Update(NorthwindDataSet.Tables["dbo.Employees"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось сохранить данные");
            }
        }

        private void addRowInTable1Button_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }

            DataRow workRow = PersonsTable.NewRow();
            workRow["CustomerID"] = "ABCDEFG";
            workRow["ContactName"] = "Steve";
            workRow["City"] = "Moscow";

            try
            {
                NorthwindDataSet.Tables["dbo.Customers"].Rows.Add(workRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось добавить строку");
            }
        }

        private void addRowInTable2Button_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }

            DataRow workRow = StateProvinceTable.NewRow();
            workRow["EmployeeID"] = 10;
            workRow["LastName"] = "ABCDEFG";

            try
            {
                NorthwindDataSet.Tables["dbo.Employees"].Rows.Add(workRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось добавить строку");
            }
        }

        private void deleteRowInTable1Button_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }

            try
            {
                string selectedBusinessEntityID =
                (string)table1DataGridView.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
                PersonsTable.PrimaryKey = new DataColumn[] { PersonsTable.Columns["CustomerID"] };
                DataRow selectedRow = PersonsTable.Rows.Find(selectedBusinessEntityID);
                NorthwindDataSet.Tables["dbo.Customers"].Rows.Remove(selectedRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось удалить строку");
            }
        }

        private void deleteRowInTable2Button_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }

            try
            {
                int selectedStateProvinceID =
                (int)table2DataGridView.SelectedCells[0].OwningRow.Cells["EmployeeID"].Value;
                StateProvinceTable.PrimaryKey = new DataColumn[] { StateProvinceTable.Columns["EmployeeID"] };
                DataRow selectedRow = StateProvinceTable.Rows.Find(selectedStateProvinceID);
                NorthwindDataSet.Tables["dbo.Employees"].Rows.Remove(selectedRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось удалить строку");
            }
        }
    }
}
