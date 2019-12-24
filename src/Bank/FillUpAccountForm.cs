using Bank.BankDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class FillUpAccountForm : Form
    {
        private ClientFullInfoForm cfif;
        private int isCard;
        private QueriesTableAdapter ta = new QueriesTableAdapter();

        public FillUpAccountForm(ClientFullInfoForm cfif, int isCard)
        {
            InitializeComponent();
            this.cfif = cfif;
            this.isCard = isCard;
            if (isCard == 1)
            {
                accountToFillUpNumberLabel.Text = "Номер карты";
                accountToFillUpNumberTextBox.Text = cfif.getSelectedCard().ToString();
            }
            else
            {
                accountToFillUpNumberLabel.Text = "Номер вклада";
                accountToFillUpNumberTextBox.Text = cfif.getSelectedContribution().ToString();
            }
        }

        private void fillUpTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fillUpTypeComboBox.Text == "Наличные")
            {
                accountNumberComboBox.Visible = false;
                accountNumberLabel.Visible = false;
                noAccountTextBox.Visible = false;
            }
            else if (fillUpTypeComboBox.Text == "С карты")
            {
                accountNumberComboBox.Visible = true;
                accountNumberLabel.Visible = true;
                BankDataSet.СписокАктивныхКартКлиентаDataTable dt = new BankDataSet.СписокАктивныхКартКлиентаDataTable();
                списокАктивныхКартКлиентаTableAdapter.Fill(dt, cfif.clientID);
                accountNumberComboBox.DataSource = dt;
                accountNumberComboBox.DisplayMember = "НомерКарты";
                if (isCard == 1)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        if (dr["НомерКарты"].ToString() == accountToFillUpNumberTextBox.Text)
                        {
                            dt.Rows.RemoveAt(i);
                        }
                    }
                    Console.WriteLine(dt.Rows.Count);
                }
                if (dt.Rows.Count == 0)
                {
                    accountNumberComboBox.Visible = false;
                    accountNumberLabel.Visible = false;
                    noAccountTextBox.Visible = true;
                    noAccountTextBox.Text = "Карт нет";
                }
                else
                {
                    accountNumberComboBox.Visible = true;
                    accountNumberLabel.Visible = true;
                    noAccountTextBox.Visible = false;
                }
            }
            else
            {
                accountNumberComboBox.Visible = true;
                accountNumberLabel.Visible = true;
                BankDataSet.СписокАктивныхВкладовКлиентаDataTable dt = new BankDataSet.СписокАктивныхВкладовКлиентаDataTable();
                списокАктивныхВкладовКлиентаTableAdapter.Fill(dt, cfif.clientID);
                accountNumberComboBox.DataSource = dt;
                accountNumberComboBox.DisplayMember = "НомерВклада";
                if (isCard == 2)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        if (dr["НомерВклада"].ToString() == accountToFillUpNumberTextBox.Text)
                        {
                            dt.Rows.RemoveAt(i);
                        }
                    }
                    Console.WriteLine(dt.Rows.Count);
                }
                if (dt.Rows.Count == 0)
                {
                    accountNumberComboBox.Visible = false;
                    accountNumberLabel.Visible = false;
                    noAccountTextBox.Visible = true;
                    noAccountTextBox.Text = "Вкладов нет";
                }
                else
                {
                    accountNumberComboBox.Visible = true;
                    accountNumberLabel.Visible = true;
                    noAccountTextBox.Visible = false;
                }
            }
        }

        private void fillUpButton_Click(object sender, EventArgs e)
        {
            double sumToFillUp;
            bool isNum = double.TryParse(sumToFillUpTextBox.Text, out sumToFillUp);
            if (!isNum)
            {
                MessageBox.Show("Сумма должна быть числом",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sumToFillUpTextBox.Clear();
                return;
            }
            if (fillUpTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите способ оплаты", "Способ оплаты не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (fillUpTypeComboBox.Text == "Наличные")
            {
                if (isCard == 1)
                {
                    ta.ОсуществитьОперацию(4, null, isCard, cfif.getSelectedCard(),
                                            decimal.Parse(sumToFillUpTextBox.Text), cfif.of.operatorID);
                    ta.НачислитьНаКарту(cfif.getSelectedCard(), decimal.Parse(sumToFillUpTextBox.Text));
                }
                else
                {
                    ta.ОсуществитьОперацию(4, null, isCard, cfif.getSelectedContribution(),
                        decimal.Parse(sumToFillUpTextBox.Text), cfif.of.operatorID);
                    ta.НачислитьНаВклад(cfif.getSelectedContribution(), decimal.Parse(sumToFillUpTextBox.Text));
                }
                MessageBox.Show("Перевод осуществлен");
                if (isCard == 1)
                {
                    cfif.updateClientCards();
                    cfif.updateClientCardOperations();
                }
                else
                {
                    cfif.updateClientContributions();
                    cfif.updateClientContributionOperations();
                }
                cfif.updateClientStatus();
                cfif.of.updateClientsGrid();
                this.Close();
            }
            else if (fillUpTypeComboBox.Text == "С карты")
            {
                if (noAccountTextBox.Visible == true)
                {
                    MessageBox.Show("Выберите другой способ оплаты", "Нет карт для оплаты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (accountNumberComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите карту", "Карта не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool? availabilityToTransfer = false;
                ta.ПроверитьВозможностьПереводаСКарты(int.Parse(accountNumberComboBox.Text), 
                    decimal.Parse(sumToFillUpTextBox.Text), ref availabilityToTransfer);
                if (availabilityToTransfer == true)
                {
                    if (isCard == 1)
                    {
                        ta.ОсуществитьОперацию(1, int.Parse(accountNumberComboBox.Text), isCard, cfif.getSelectedCard(),
                                                 decimal.Parse(sumToFillUpTextBox.Text), cfif.of.operatorID);
                        ta.НачислитьНаКарту(cfif.getSelectedCard(), decimal.Parse(sumToFillUpTextBox.Text));
                    }
                    else
                    {
                        ta.ОсуществитьОперацию(1, int.Parse(accountNumberComboBox.Text), isCard, cfif.getSelectedContribution(),
                                                 decimal.Parse(sumToFillUpTextBox.Text), cfif.of.operatorID);
                        ta.НачислитьНаВклад(cfif.getSelectedContribution(), decimal.Parse(sumToFillUpTextBox.Text));
                    }

                    ta.СнятьСКарты(int.Parse(accountNumberComboBox.Text), decimal.Parse(sumToFillUpTextBox.Text));
                    MessageBox.Show("Перевод осуществлен");
                    if (isCard == 1)
                    {
                        cfif.updateClientCards();
                        cfif.updateClientCardOperations();
                    }
                    else
                    {
                        cfif.updateClientContributions();
                        cfif.updateClientCards();
                        cfif.updateClientContributionOperations();
                    }
                    cfif.updateClientStatus();
                    cfif.of.updateClientsGrid();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Недостаточно средств на карте", "Перевод не осуществлен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (noAccountTextBox.Visible == true)
                {
                    MessageBox.Show("Выберите другой способ оплаты", "Нет вкладов для оплаты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (accountNumberComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите вклад", "Вклад не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool? availabilityToTransfer = false;
                ta.ПроверитьВозможностьПереводаСВклада(int.Parse(accountNumberComboBox.Text), 
                    decimal.Parse(sumToFillUpTextBox.Text), ref availabilityToTransfer);
                if (availabilityToTransfer == true)
                {
                    if (isCard == 1)
                    {
                        ta.ОсуществитьОперацию(2, int.Parse(accountNumberComboBox.Text), isCard, cfif.getSelectedCard(),
                                                decimal.Parse(sumToFillUpTextBox.Text), cfif.of.operatorID);
                        ta.НачислитьНаКарту(cfif.getSelectedCard(), decimal.Parse(sumToFillUpTextBox.Text));
                    }
                    else
                    {
                        ta.ОсуществитьОперацию(2, int.Parse(accountNumberComboBox.Text), isCard, cfif.getSelectedContribution(),
                                                decimal.Parse(sumToFillUpTextBox.Text), cfif.of.operatorID);
                        ta.НачислитьНаВклад(cfif.getSelectedContribution(), decimal.Parse(sumToFillUpTextBox.Text));
                    }
                    ta.СнятьСВклада(int.Parse(accountNumberComboBox.Text), decimal.Parse(sumToFillUpTextBox.Text));
                    MessageBox.Show("Перевод осуществлен");
                    if (isCard == 1)
                    {
                        cfif.updateClientCards();
                        cfif.updateClientCardOperations();
                        cfif.updateClientContributions();
                    }
                    else
                    {
                        cfif.updateClientContributions();
                        cfif.updateClientContributionOperations();
                    }
                    cfif.updateClientStatus();
                    cfif.of.updateClientsGrid();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Недостаточно средств на вкладе", "Перевод не осуществлен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
