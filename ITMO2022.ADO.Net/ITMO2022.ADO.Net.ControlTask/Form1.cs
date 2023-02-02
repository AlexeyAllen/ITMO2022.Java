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
        private DataSet ApressFinancialDataSet = new DataSet("ApressFinancial");
        private DataTable CustomersTable = new DataTable("CustomerDetails.Customers");
        private DataTable SharesTable = new DataTable("ShareDetails.Shares");

        string connect = $"Password={pass};Persist Security Info=True; User ID={login};" +
                " Initial Catalog=ApressFinancial;Data Source=(localdb)\\Local";

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
                command1.CommandText = "Select * from CustomerDetails.Customers;";
                SqlDataAdapter1 = new SqlDataAdapter(command1.CommandText, connection);
                ApressFinancialDataSet.Tables.Add(CustomersTable);
                SqlDataAdapter1.Fill(ApressFinancialDataSet.Tables["CustomerDetails.Customers"]);
                table1DataGridView.DataSource = ApressFinancialDataSet.Tables["CustomerDetails.Customers"];
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
                command2.CommandText = "Select * from ShareDetails.Shares";
                SqlDataAdapter2 = new SqlDataAdapter(command2.CommandText, connection);
                ApressFinancialDataSet.Tables.Add(SharesTable);
                SqlDataAdapter2.Fill(ApressFinancialDataSet.Tables["ShareDetails.Shares"]);
                table2DataGridView.DataSource = ApressFinancialDataSet.Tables["ShareDetails.Shares"];
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
                ApressFinancialDataSet.EndInit();
                SqlDataAdapter1.Update(ApressFinancialDataSet.Tables["CustomerDetails.Customers"]);
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
                ApressFinancialDataSet.EndInit();
                SqlDataAdapter2.Update(ApressFinancialDataSet.Tables["ShareDetails.Shares"]);
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

            DataRow workRow = CustomersTable.NewRow();
            workRow["CustomerID"] = 8;
            workRow["CustomerFirstName"] = "Steve";
            workRow["CustomerLastName"] = "Jobs";

            try
            {
                ApressFinancialDataSet.Tables["CustomerDetails.Customers"].Rows.Add(workRow);
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

            DataRow workRow = SharesTable.NewRow();
            workRow["ShareID"] = 7;
            workRow["ShareDesc"] = "Gazprom";

            try
            {
                ApressFinancialDataSet.Tables["ShareDetails.Shares"].Rows.Add(workRow);
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
                long selectedCustomerID =
                (long)table1DataGridView.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
                CustomersTable.PrimaryKey = new DataColumn[] { CustomersTable.Columns["CustomerID"] };
                DataRow selectedRow = CustomersTable.Rows.Find(selectedCustomerID);
                ApressFinancialDataSet.Tables["CustomerDetails.Customers"].Rows.Remove(selectedRow);
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
                long selectedShareID =
                (long)table2DataGridView.SelectedCells[0].OwningRow.Cells["ShareID"].Value;
                SharesTable.PrimaryKey = new DataColumn[] { SharesTable.Columns["ShareID"] };
                DataRow selectedRow = SharesTable.Rows.Find(selectedShareID);
                ApressFinancialDataSet.Tables["ShareDetails.Shares"].Rows.Remove(selectedRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось удалить строку");
            }
        }
    }
}
