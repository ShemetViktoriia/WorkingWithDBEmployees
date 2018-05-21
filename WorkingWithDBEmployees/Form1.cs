using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Threading.Tasks;

namespace WorkingWithDBEmployees
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        // обработчик события загрузки формы
        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeesCS"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            // настройка ListView
            listViewAll.GridLines = true;
            listViewAll.FullRowSelect = true;
            listViewAll.View = View.Details;
            listViewAll.Columns.Add("ID");
            listViewAll.Columns.Add("Имя");
            listViewAll.Columns.Add("Фамилия");
            listViewAll.Columns.Add("Фикс. ставка");
            listViewAll.Columns.Add("К-во дней");
            listViewAll.Columns.Add("К-во часов");
            listViewAll.Columns.Add("Ставка");
            await LoadEmployeesAsync();
            listViewAll.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewAll.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        // обработчик события закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        // метод по загрузке в ListView всех сотрудников
        private async Task LoadEmployeesAsync() // Select
        {
            SqlDataReader sqlReader = null;
            string query = "SELECT * FROM [Employees] ORDER BY [ID]"; // запрос в БД, выборка всех записей
            SqlCommand command = new SqlCommand(query, sqlConnection);
            try // обработчик исключений
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[] {
                        Convert.ToString(sqlReader["ID"]),
                        Convert.ToString(sqlReader["L_NAME"]),
                        Convert.ToString(sqlReader["F_NAME"]),
                        Convert.ToString(sqlReader["FIX_PAYMENT"]),
                        Convert.ToString(sqlReader["COUNT_DAYS"]),
                        Convert.ToString(sqlReader["COUNT_HOUR"]),
                        Convert.ToString(sqlReader["RATE"])
                    });
                    listViewAll.Items.Add(item);
                }
            }
            catch (Exception ex)  // перехват исключений
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally // произойдет в любом случае, закрытие подключения
            {
                if (sqlReader != null) sqlReader.Close();
            }
        }

        // обработчик события на кнопку Обновить
        private async void toolStripButton5_Click(object sender, EventArgs e)
        {
            listViewAll.Items.Clear();
            LoadEmployeesAsync();
        }

        // обработчик события на кнопку Добавить
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert(sqlConnection);
            insert.Show();
        }

        // обработчик события на кнопку Изменить
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (listViewAll.SelectedItems.Count > 0)
            {
                Update update = new Update(sqlConnection, Convert.ToInt32(listViewAll.SelectedItems[0].SubItems[0].Text));
                update.Show();
            }
            else
            {
                MessageBox.Show("Не выделена строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // обработчик события на кнопку Рассчитать ЗП
        private async void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (listViewAll.SelectedItems.Count > 0)
            {
                CalculateSalary calculate = new CalculateSalary(sqlConnection, Convert.ToInt32(listViewAll.SelectedItems[0].SubItems[0].Text));
                calculate.Show();
            }
            else
            {
                MessageBox.Show("Не выделена строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // обработчик события на кнопку Удалить
        private async void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (listViewAll.SelectedItems.Count > 0)
            {
                DialogResult res = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи",
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                switch (res)
                {
                    case DialogResult.OK:
                        string queryDelete = @"DELETE FROM [Employees] WHERE [ID]=@ID";  // запрос в БД
                        SqlCommand commandEmployeeDelete = new SqlCommand(queryDelete, sqlConnection);
                        commandEmployeeDelete.Parameters.AddWithValue("ID", Convert.ToInt32(listViewAll.SelectedItems[0].SubItems[0].Text));
                        try // обработчик исключений
                        {
                            await commandEmployeeDelete.ExecuteNonQueryAsync();
                        }
                        catch (Exception ex)  // перехват исключений
                        {
                            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        listViewAll.Items.Clear();
                        await LoadEmployeesAsync();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Не выделена строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Выход из приложения
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для учета ЗП сотрудников за месяц", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
