using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkingWithDBEmployees
{
    public partial class Insert : Form
    {
        private SqlConnection sqlConnection = null;
        public Insert(SqlConnection connection)
        {
            InitializeComponent();
            sqlConnection = connection;
        }


        // обработчик события на кнопку Добавить
        private async void btnInsert_Click(object sender, EventArgs e)
        {
            // Проверка заполненности текстовых полей
            if (!string.IsNullOrEmpty(txtBoxInsertFName.Text) && !string.IsNullOrWhiteSpace(txtBoxInsertFName.Text) &&
                !string.IsNullOrEmpty(txtBoxInsertLName.Text) && !string.IsNullOrWhiteSpace(txtBoxInsertLName.Text) &&
                !string.IsNullOrEmpty(numInsertCountDays.Text) && !string.IsNullOrWhiteSpace(numInsertCountDays.Text) &&
                !string.IsNullOrEmpty(numInsertRate.Text) && !string.IsNullOrWhiteSpace(numInsertRate.Text))
            {
                string queryInsert = @"INSERT INTO [Employees] (F_NAME, L_NAME, FIX_PAYMENT, COUNT_DAYS, COUNT_HOUR, RATE) 
                    VALUES(@F_NAME, @L_NAME, @FIX_PAYMENT, @COUNT_DAYS, @COUNT_HOUR, @RATE)"; // запрос в БД
                SqlCommand insertEmployeeCommand = new SqlCommand(queryInsert, sqlConnection);
                insertEmployeeCommand.Parameters.AddWithValue("F_NAME", txtBoxInsertFName.Text);
                insertEmployeeCommand.Parameters.AddWithValue("L_NAME", txtBoxInsertLName.Text);
                insertEmployeeCommand.Parameters.AddWithValue("FIX_PAYMENT", Convert.ToString((FixPayment)Convert.ToInt32(checkBoxInsertPayment.Checked)));
                insertEmployeeCommand.Parameters.AddWithValue("COUNT_DAYS", Convert.ToString(numInsertCountDays.Value));
                insertEmployeeCommand.Parameters.AddWithValue("COUNT_HOUR", Convert.ToString(numInsertCountHours.Value));
                insertEmployeeCommand.Parameters.AddWithValue("RATE", Convert.ToString(numInsertRate.Value));
                try // обработчик исключений
                {
                    await insertEmployeeCommand.ExecuteNonQueryAsync();
                    Close();
                }
                catch (Exception ex)  // перехват исключений
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введены не все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // обработчик события на кнопку Отмена
        private void btnInsertCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // событие на изменение состояния элемента управления CheckBox, Форма Добавить сотрудника
        private void checkBoxInsertPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxInsertPayment.Checked)
            {
                lblInsertCountHours.Visible = true; numInsertCountHours.Visible = true;
            }
            else
            {
                lblInsertCountHours.Visible = false; numInsertCountHours.Visible = false;
            }
        }
    }
}
