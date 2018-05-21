using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkingWithDBEmployees
{
    public partial class Update : Form
    {
        private SqlConnection sqlConnection = null;
        private int id;
        public Update(SqlConnection connection, int id)
        {
            InitializeComponent();
            sqlConnection = connection;
            this.id = id;
        }

        private async void Update_Load(object sender, EventArgs e)
        {
            string queryInfoByID  = @"SELECT 
                           [F_NAME],
                           [L_NAME],
                           [FIX_PAYMENT],
                           [COUNT_DAYS],
                           [COUNT_HOUR],
                           [RATE]  
                           FROM [Employees] 
                           WHERE [ID]=@ID"; // запрос в БД
            SqlCommand getEmployeeInfoCommand = new SqlCommand(queryInfoByID, sqlConnection);
            getEmployeeInfoCommand.Parameters.AddWithValue("ID", id);
            SqlDataReader sqlReader = null;
            try // обработчик исключений
            {
                sqlReader = await getEmployeeInfoCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    txtBoxUpdateLName.Text = Convert.ToString(sqlReader["L_NAME"]);
                    txtBoxUpdateFName.Text = Convert.ToString(sqlReader["F_NAME"]); 
                    checkBoxUpdatePayment.Checked = Convert.ToBoolean
                        (
                            Convert.ToInt32
                            (
                                Enum.Parse(typeof(FixPayment),Convert.ToString(sqlReader["FIX_PAYMENT"]))
                            )
                        ); 
                    numUpdateCountDays.Value = Convert.ToInt32(sqlReader["COUNT_DAYS"]);
                    numUpdateCountHours.Value = Convert.ToInt32(sqlReader["COUNT_HOUR"]);
                    numUpdateRate.Value = Convert.ToDecimal(sqlReader["RATE"]);
                   
                }
            }
            catch (Exception ex)  // перехват исключений
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally // произойдет в любом случае, закрытие подключения
            {
                if (sqlReader != null && !sqlReader.IsClosed) sqlReader.Close();
            }
        }

        // событие на изменение состояния элемента управления CheckBox, Форма Изменить данные по сотруднику
        private void checkBoxUpdatePayment_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxUpdatePayment.Checked)
            {
                lblUpdateCountHours.Visible = true; numUpdateCountHours.Visible = true;
            }
            else
            {
                lblUpdateCountHours.Visible = false; numUpdateCountHours.Visible = false;
            }
        }

        // обработчик события на кнопку Изменить
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            // Проверка заполненности текстовых полей
            if (!string.IsNullOrEmpty(txtBoxUpdateLName.Text) && !string.IsNullOrWhiteSpace(txtBoxUpdateLName.Text) &&
                !string.IsNullOrEmpty(txtBoxUpdateFName.Text) && !string.IsNullOrWhiteSpace(txtBoxUpdateFName.Text) &&
                !string.IsNullOrEmpty(numUpdateRate.Text) && !string.IsNullOrWhiteSpace(numUpdateRate.Text) &&
                !string.IsNullOrEmpty(numUpdateCountDays.Text) && !string.IsNullOrWhiteSpace(numUpdateCountDays.Text))
            {
                string queryUpdate = @"UPDATE [Employees] SET
                           [F_NAME]=@F_NAME,
                           [L_NAME]=@L_NAME,
                           [FIX_PAYMENT]=@FIX_PAYMENT,
                           [COUNT_DAYS]=@COUNT_DAYS,
                           [COUNT_HOUR]=@COUNT_HOUR,
                           [RATE]=@RATE                      
                           WHERE [ID]=@ID"; // запрос в БД
                SqlCommand UpdateEmployeeCommand = new SqlCommand(queryUpdate, sqlConnection);
                UpdateEmployeeCommand.Parameters.AddWithValue("ID", id);
                UpdateEmployeeCommand.Parameters.AddWithValue("F_NAME", txtBoxUpdateFName.Text);
                UpdateEmployeeCommand.Parameters.AddWithValue("L_NAME", txtBoxUpdateLName.Text);
                UpdateEmployeeCommand.Parameters.AddWithValue("FIX_PAYMENT", Convert.ToString((FixPayment)Convert.ToInt32(checkBoxUpdatePayment.Checked)));
                UpdateEmployeeCommand.Parameters.AddWithValue("COUNT_DAYS", Convert.ToString(numUpdateCountDays.Value));
                UpdateEmployeeCommand.Parameters.AddWithValue("COUNT_HOUR", Convert.ToString(numUpdateCountHours.Value));
                UpdateEmployeeCommand.Parameters.AddWithValue("RATE", Convert.ToString(numUpdateRate.Value));
                try
                {
                    await UpdateEmployeeCommand.ExecuteNonQueryAsync();
                    Close();
                }
                catch (Exception ex)
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
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
