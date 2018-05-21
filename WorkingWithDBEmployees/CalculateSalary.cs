using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkingWithDBEmployees
{
    public partial class CalculateSalary : Form
    {

        private SqlConnection sqlConnection = null;
        private int id;
        public CalculateSalary(SqlConnection connection, int id)
        {
            InitializeComponent();
            sqlConnection = connection;
            this.id = id;
        }

        private async void CalculateSalary_Load(object sender, EventArgs e)
        {
            string queryInfoByID = @"SELECT 
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
                    bool fix = Convert.ToBoolean
                        (
                            Convert.ToInt32
                            (
                                Enum.Parse(typeof(FixPayment), Convert.ToString(sqlReader["FIX_PAYMENT"]))
                            )
                        );

                    int hours = Convert.ToInt32(sqlReader["COUNT_HOUR"]);
                    decimal rate = Convert.ToDecimal(sqlReader["RATE"]);
                    double salaryPayment = (double)rate * hours;
                    txtBoxSalaryLName.Text = Convert.ToString(sqlReader["L_NAME"]);
                    txtBoxSalaryFName.Text = Convert.ToString(sqlReader["F_NAME"]);

                    if (fix)
                    {
                        txtSumSalary.Text = Convert.ToString(rate);
                        lblCountDays.Visible = true;
                        txtSalaryCountDays.Visible = true;
                        txtSalaryCountDays.Text = Convert.ToString(WorkDays(2018, 5));
                    }
                    else
                    {
                        lblCountDays.Visible = false;
                        txtSalaryCountDays.Visible = false;
                        txtSumSalary.Text = Convert.ToString(salaryPayment);
                    }
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

        // функция подсчета рабочих дней в месяце определенного года
        // празднике не учитываются, выходные дни - суббота и воскресенье
        static private int WorkDays(int year, int month)
        {
            // всего дней в месяце
            int allDays = DateTime.DaysInMonth(year, month);
            // дата первого дня определенного месяца в определенном году
            DateTime date = new DateTime(year, month, 1);
            int countWeekend = 0;
            while (true)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) countWeekend++;
                date = date.AddDays(1.0);
                if (date.Month != month) break;
            }
            return allDays - countWeekend;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
