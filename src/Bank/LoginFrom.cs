using Bank.BankDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void loginUserTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loginUserTypeComboBox.SelectedIndex == 0)
            {
                passwordToolTip.SetToolTip(loginPasswordTextBox, "Пароль: root");
                loginPasswordLabel.Visible = true;
                loginPasswordTextBox.Visible = true;
                loginPasswordTextBox.Text = "";
                loginWorkerIDLabel.Visible = false;
                loginWorkerIDTextBox.Visible = false;
                loginWorkerIDTextBox.Text = "";
            }
            else
            {
                loginPasswordLabel.Visible = false;
                loginPasswordTextBox.Visible = false;
                loginPasswordTextBox.Text = "";
                loginWorkerIDLabel.Visible = true;
                loginWorkerIDTextBox.Visible = true;
                loginWorkerIDTextBox.Text = "";
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginUserTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Не выбран аккаунт, повторите попытку", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (loginUserTypeComboBox.SelectedIndex == 0)
            {
                if (loginPasswordTextBox.Text == "root")
                {
                    MessageBox.Show("Добро пожаловать, г-н/г-жа Директор!", "Вход выполнен");
                    DirectorForm dF = new DirectorForm();
                    dF.Show();
                    loginPasswordTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Пароль неверный, повторите попытку", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                QueriesTableAdapter ta = new QueriesTableAdapter();
                int workerID;
                bool isNum = int.TryParse(loginWorkerIDTextBox.Text, out workerID);
                if (!isNum)
                {
                    MessageBox.Show("ID сотрудника должно быть числом",
                        "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loginWorkerIDTextBox.Clear();
                    return;
                }
                int? checkWorkerExistence = 0;
                if (loginUserTypeComboBox.SelectedIndex == 1)
                {
                    ta.ПроверитьНаличиеОператора(int.Parse(loginWorkerIDTextBox.Text), ref checkWorkerExistence);
                }
                else
                {
                    ta.ПроверитьНаличиеКредитора(int.Parse(loginWorkerIDTextBox.Text), ref checkWorkerExistence);
                }
                string nameResult = "";
                switch (checkWorkerExistence)
                {
                    case -1:
                        {
                            MessageBox.Show("Такого банкира-оператора не существует, повторите попытку", 
                                "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            loginWorkerIDTextBox.Clear();
                            break;
                        }
                    case -2:
                        {
                            MessageBox.Show("Такого банкира-кредитора не существует, повторите попытку",
                                "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            loginWorkerIDTextBox.Clear();
                            break;
                        }
                    case 1:
                        {
                            ta.ПолучитьФИОСотрудника(int.Parse(loginWorkerIDTextBox.Text), ref nameResult);
                            MessageBox.Show("Добро пожаловать, " + nameResult + "!", "Вход выполнен");
                            OperatorForm oF = new OperatorForm(int.Parse(loginWorkerIDTextBox.Text));
                            oF.Show();
                            loginWorkerIDTextBox.Clear();
                            break;
                        }
                    case 2:
                        {
                            ta.ПолучитьФИОСотрудника(int.Parse(loginWorkerIDTextBox.Text), ref nameResult);
                            MessageBox.Show("Добро пожаловать, " + nameResult + "!", "Вход выполнен");
                            CreditorForm cF = new CreditorForm(int.Parse(loginWorkerIDTextBox.Text));
                            cF.Show();
                            loginWorkerIDTextBox.Clear();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}
