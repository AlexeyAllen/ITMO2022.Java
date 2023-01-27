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
        private DataSet AdventureWorks2017DataSet = new DataSet("AdventureWorks2017");
        private DataTable PersonsTable = new DataTable("Person.Person");
        private DataTable StateProvinceTable = new DataTable("Person.StateProvince");

        string connect = $"Password={pass};Persist Security Info=True; User ID={login};" +
                " Initial Catalog=AdventureWorks2017;Data Source=(localdb)\\Local";

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
                command1.CommandText = "Select * from Person.Person;";
                SqlDataAdapter1 = new SqlDataAdapter(command1.CommandText, connection);
                AdventureWorks2017DataSet.Tables.Add(PersonsTable);
                SqlDataAdapter1.Fill(AdventureWorks2017DataSet.Tables["Person.Person"]);
                table1DataGridView.DataSource = AdventureWorks2017DataSet.Tables["Person.Person"];
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
                command2.CommandText = "Select * from Person.StateProvince";
                SqlDataAdapter2 = new SqlDataAdapter(command2.CommandText, connection);
                AdventureWorks2017DataSet.Tables.Add(StateProvinceTable);
                SqlDataAdapter2.Fill(AdventureWorks2017DataSet.Tables["Person.StateProvince"]);
                table2DataGridView.DataSource = AdventureWorks2017DataSet.Tables["Person.StateProvince"];
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
                AdventureWorks2017DataSet.EndInit();
                SqlDataAdapter1.Update(AdventureWorks2017DataSet.Tables["Person.Person"]);
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
                AdventureWorks2017DataSet.EndInit();
                SqlDataAdapter2.Update(AdventureWorks2017DataSet.Tables["Person.StateProvince"]);
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
            workRow["BusinessEntityID"] = 20779;
            workRow["FirstName"] = "Steve";
            workRow["MiddleName"] = "F";
            workRow["LastName"] = "Jim";

            try
            {
                AdventureWorks2017DataSet.Tables["Person.Person"].Rows.Add(workRow);
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
            workRow["StateProvinceID"] = 200;
            workRow["Name"] = "ABCDEFG";

            try
            {
                AdventureWorks2017DataSet.Tables["Person.StateProvince"].Rows.Add(workRow);
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
                int selectedBusinessEntityID =
                (int)table1DataGridView.SelectedCells[0].OwningRow.Cells["BusinessEntityID"].Value;
                PersonsTable.PrimaryKey = new DataColumn[] { PersonsTable.Columns["BusinessEntityID"] };
                DataRow selectedRow = PersonsTable.Rows.Find(selectedBusinessEntityID);
                AdventureWorks2017DataSet.Tables["Person.Person"].Rows.Remove(selectedRow);
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
                (int)table2DataGridView.SelectedCells[0].OwningRow.Cells["StateProvinceID"].Value;
                StateProvinceTable.PrimaryKey = new DataColumn[] { StateProvinceTable.Columns["StateProvinceID"] };
                DataRow selectedRow = StateProvinceTable.Rows.Find(selectedStateProvinceID);
                AdventureWorks2017DataSet.Tables["Person.StateProvince"].Rows.Remove(selectedRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось удалить строку");
            }
        }
    }
}
