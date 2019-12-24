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
    public partial class ClientFullInfoForm : Form
    {
        public int clientID;
        public OperatorForm of;
        private int selectedCard = 0;
        private int selectedContribution = 0;
        private int selectedCredit = 0;
        private QueriesTableAdapter qta = new QueriesTableAdapter();

        public ClientFullInfoForm(OperatorForm of, int clientID)
        {
            InitializeComponent();
            this.clientID = clientID;
            this.of = of;
            BankDataSet.ПолучитьИнформациюКлиентаDataTable dt = new BankDataSet.ПолучитьИнформациюКлиентаDataTable();
            ПолучитьИнформациюКлиентаTableAdapter ta = new ПолучитьИнформациюКлиентаTableAdapter();
            ta.Fill(dt, clientID);
            clientIDTextBox.Text = dt.Rows[0].Field<int>("IDКлиента").ToString();
            clientNameTextBox.Text = dt.Rows[0].Field<string>("ФИО").ToString();
            clientTownTextBox.Text = dt.Rows[0].Field<string>("Город");
            clientIncomeTextBox.Text = dt.Rows[0].Field<decimal>("Доход").ToString();
            updateClientStatus();
        }

        private void ClientFullInfoForm_Load(object sender, EventArgs e)
        {
            updateClientCards();
            updateClientCredits();
            updateClientContributions();
            updateClientCreditRequests();
            if (clientCreditsGrid.Rows.Count != 0)
            {
                selectedCredit = 0;
                if (clientCreditsGrid.Rows[0].Cells[7].Value.ToString() == "")
                {
                    clientCreditDebtStateLabel.Visible = true;
                    clientCreditDebtAmountTextBox.Visible = true;
                    clientPayForCreditButton.Visible = true;
                    decimal? debtAmount = 0;
                    qta.ПосчитатьЗадолженностьПоКредиту((int)clientCreditsGrid.Rows[selectedCredit].Cells[0].Value,
                                                        ref debtAmount);
                    clientCreditDebtAmountTextBox.Text = debtAmount.ToString();
                }
                else
                {
                    clientCreditDebtStateLabel.Visible = false;
                    clientCreditDebtAmountTextBox.Visible = false;
                    clientPayForCreditButton.Visible = false;
                }
            }
            else
            {
                clientShowCreditOperationsButton.Visible = false;
            }
        }


        private void clientCardsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            selectedCard = clientCardsGrid.CurrentRow.Index;
            int? isAccountActive = 0;
            qta.УзнатьТипАктивногоСчета(getSelectedCard(), ref isAccountActive);
            if (isAccountActive != 0)
            {
                clientTransferMoneyWithCardButton.Visible = true;
                clientCloseCardButton.Visible = true;
            }
            else
            {
                clientTransferMoneyWithCardButton.Visible = false;
                clientCloseCardButton.Visible = false;
            }
        }

        private void clientShowCardOperationsButton_Click(object sender, EventArgs e)
        {
            updateClientCardOperations();
            clientCardsGrid.Visible = false;
            clientShowCardOperationsButton.Visible = false;
            clientHideCardOperationsButton.Visible = true;
            clientCardOperationsGrid.Visible = true;
        }

        private void clientHideCardOperationsButton_Click(object sender, EventArgs e)
        {
            clientCardsGrid.Visible = true;
            clientShowCardOperationsButton.Visible = true;
            clientHideCardOperationsButton.Visible = false;
            clientCardOperationsGrid.Visible = false;
        }

        private void clientCloseCardButton_Click(object sender, EventArgs e)
        {
            string message = "Вы действительно хотите заблокировать карту?";
            string caption = "Подтверждение блокировки карты";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                qta.ЗаблокироватьКарту(getSelectedCard());
                MessageBox.Show("Карта заблокирована");
            }
            updateClientCards();
            updateClientStatus();
        }

        private void clientTransferMoneyWithCardButton_Click(object sender, EventArgs e)
        {
            ChooseTransactionForm ctf = new ChooseTransactionForm(this, 1);
            ctf.Show();
        }

        private void clientContributionsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            selectedContribution = clientContributionsGrid.CurrentRow.Index;
            int? isAccountActive = 0;
            qta.УзнатьТипАктивногоСчета(getSelectedContribution(), ref isAccountActive);
            if (isAccountActive != 0)
            {
                clientTransferMoneyWithContributionButton.Visible = true;
                clientCloseContributionButton.Visible = true;
            }
            else
            {
                clientTransferMoneyWithContributionButton.Visible = false;
                clientCloseContributionButton.Visible = false;
            }
        }

        private void clientShowContributionOperationsButton_Click(object sender, EventArgs e)
        {
            updateClientContributionOperations();
            clientContributionsGrid.Visible = false;
            clientContributionOperationsGrid.Visible = true;
            clientHideContributionOperationsButton.Visible = true;
            clientShowContributionOperationsButton.Visible = false;
        }

        private void clientHideContributionOperationsButton_Click(object sender, EventArgs e)
        {
            clientContributionsGrid.Visible = true;
            clientContributionOperationsGrid.Visible = false;
            clientHideContributionOperationsButton.Visible = false;
            clientShowContributionOperationsButton.Visible = true;
        }

        private void clientCloseContributionButton_Click(object sender, EventArgs e)
        {
            string message = "Вы действительно хотите закрыть вклад?";
            string caption = "Подтверждение закрытия вклада";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                qta.ЗакрытьВклад(getSelectedContribution());
                MessageBox.Show("Вклад закрыт");
            }
            updateClientContributions();
            updateClientStatus();
        }

        private void clientTransferMoneyWithContributionButton_Click(object sender, EventArgs e)
        {
            ChooseTransactionForm ctf = new ChooseTransactionForm(this, 2);
            ctf.Show();
        }

        private void clientCreditsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            selectedCredit = clientCreditsGrid.CurrentRow.Index;
            if (clientCreditsGrid.Rows[selectedCredit].Cells[7].Value.ToString() == "")
            {
                clientCreditDebtStateLabel.Visible = true;
                clientCreditDebtAmountTextBox.Visible = true;
                clientPayForCreditButton.Visible = true;
                decimal? debtAmount = 0;
                qta.ПосчитатьЗадолженностьПоКредиту((int)clientCreditsGrid.Rows[selectedCredit].Cells[0].Value,
                                                    ref debtAmount);
                clientCreditDebtAmountTextBox.Text = debtAmount.ToString();
            }
            else
            {
                clientCreditDebtStateLabel.Visible = false;
                clientCreditDebtAmountTextBox.Visible = false;
                clientPayForCreditButton.Visible = false;
            }
        }

        private void clientShowCreditOperationsButton_Click(object sender, EventArgs e)
        {
            updateClientCreditOperations();
            clientCreditsGrid.Visible = false;
            clientCreditOperationsGrid.Visible = true;
            clientHideCreditOperationsButton.Visible = true;
            clientShowCreditOperationsButton.Visible = false;
        }

        private void clientHideCreditOperationsButton_Click(object sender, EventArgs e)
        {
            clientCreditsGrid.Visible = true;
            clientCreditOperationsGrid.Visible = false;
            clientHideCreditOperationsButton.Visible = false;
            clientShowCreditOperationsButton.Visible = true;
        }

        private void clientPayForCreditButton_Click(object sender, EventArgs e)
        {
            CreditPaymentForm cf = new CreditPaymentForm(this);
            cf.Show();
        }

        private void clientOpenNewCardButton_Click(object sender, EventArgs e)
        {
            string message = "Карта действительна 2 года, начиная с сегодня.\nВыпустить карту?";
            string caption = "Подтверждение выпуска карты";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    qta.ВыпуститьКарту(clientID);
                    MessageBox.Show("Карта выпущена");
                    this.списокКартКлиентаTableAdapter.Fill(this.bankDataSet.СписокКартКлиента, clientID);
                    of.updatePotentialClientsGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Карта не была выпущена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                clientShowCardOperationsButton.Visible = true;
            updateClientCards();
            updateClientStatus();
        }

        private void clientOpenNewContributionButton_Click(object sender, EventArgs e)
        {
            AddNewContributionForm avf = new AddNewContributionForm(this.of, this, clientID);
            avf.Show();
            clientShowContributionOperationsButton.Visible = true;
        }

        private void clientOpenNewCreditRequestButton_Click(object sender, EventArgs e)
        {
            bool? isExistsActiveCreditRequst = false;
            qta.ЕстьЛиОжидающиеЗаявкиНаКредитОтКлиента(clientID, ref isExistsActiveCreditRequst);
            if (isExistsActiveCreditRequst == true)
            {
                string message = "У клиента уже имеется заявка в состоянии ожидания подтверждения.\nВы действительно хотите подать заявку?";
                string caption = "Подтверждение подачи заявки на кредит";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    AddNewCreditRequestForm acrf = new AddNewCreditRequestForm(this.of, this, clientID);
                    acrf.Show();
                }
            }
            else
            {
                AddNewCreditRequestForm acrf = new AddNewCreditRequestForm(this.of, this, clientID);
                acrf.Show();
            }
        }

        public int getSelectedCredit()
        {
            return (int)clientCreditsGrid.Rows[selectedCredit].Cells[0].Value;
        }

        public int getSelectedCard()
        {
            return (int)clientCardsGrid.Rows[selectedCard].Cells[0].Value;
        }

        public int getSelectedContribution()
        {
            return (int)clientContributionsGrid.Rows[selectedContribution].Cells[0].Value;
        }

        public void updateClientStatus()
        {
            BankDataSet.ПолучитьИнформациюКлиентаDataTable dt = new BankDataSet.ПолучитьИнформациюКлиентаDataTable();
            ПолучитьИнформациюКлиентаTableAdapter ta = new ПолучитьИнформациюКлиентаTableAdapter();
            ta.Fill(dt, clientID);
            clientStatusTextBox.Text = dt.Rows[0].Field<string>("Статус");
            decimal? sumOnAccounts = 0;
            qta.ПосчитатьСуммуНаСчетахКлиента(clientID, ref sumOnAccounts);
            clientSumOnAccountsTextBox.Text = sumOnAccounts.ToString();
            if (clientSumOnAccountsTextBox.Text == "")
            {
                clientSumOnAccountsTextBox.Text = "0,00";
            }
            int? activeAccountsNumber = 0;
            qta.КоличествоАктивныхСчетовКлиента(clientID, ref activeAccountsNumber);
            clientActiveAccountsNumberTextBox.Text = activeAccountsNumber.ToString();
            if (clientActiveAccountsNumberTextBox.Text == "")
            {
                clientActiveAccountsNumberTextBox.Text = "0";
            }
        }

        public void updateClientCredits()
        {
            BankDataSet.СписокКредитовКлиентаDataTable dt = new BankDataSet.СписокКредитовКлиентаDataTable();
            списокКредитовКлиентаTableAdapter.Fill(dt, clientID);
            clientCreditsGrid.DataSource = dt;
            clientCreditsGrid.Sort(clientCreditsGrid.Columns[7], ListSortDirection.Ascending);
        }

        public void updateClientContributions()
        {
            BankDataSet.СписокВкладовКлиентаDataTable dt = new BankDataSet.СписокВкладовКлиентаDataTable();
            списокВкладовКлиентаTableAdapter.Fill(dt, clientID);
            clientContributionsGrid.DataSource = dt;
            if (clientContributionsGrid.Rows.Count != 0)
            {
                selectedContribution = 0;
                int? isAccountActive = 0;
                qta.УзнатьТипАктивногоСчета(getSelectedContribution(), ref isAccountActive);
                if (isAccountActive != 0)
                {
                    clientTransferMoneyWithContributionButton.Visible = true;
                    clientCloseContributionButton.Visible = true;
                }
                else
                {
                    clientTransferMoneyWithContributionButton.Visible = false;
                    clientCloseContributionButton.Visible = false;
                }
            }
            else
            {
                clientShowContributionOperationsButton.Visible = false;
            }
        }

        public void updateClientCards()
        {
            BankDataSet.СписокКартКлиентаDataTable dt = new BankDataSet.СписокКартКлиентаDataTable();
            списокКартКлиентаTableAdapter.Fill(dt, clientID);
            clientCardsGrid.DataSource = dt;
            if (clientCardsGrid.Rows.Count != 0)
            {
                selectedCard = 0;
                int? isAccountActive = 0;
                qta.УзнатьТипАктивногоСчета(getSelectedCard(), ref isAccountActive);
                if (isAccountActive != 0)
                {
                    clientTransferMoneyWithCardButton.Visible = true;
                    clientCloseCardButton.Visible = true;
                }
                else
                {
                    clientTransferMoneyWithCardButton.Visible = false;
                    clientCloseCardButton.Visible = false;
                }
            }
            else
            {
                clientShowCardOperationsButton.Visible = false;
            }
        }

        public void updateClientCreditOperations()
        {
            BankDataSet.ОперацииПоСчетуDataTable dt = new BankDataSet.ОперацииПоСчетуDataTable();
            операцииПоСчетуTableAdapter.Fill(dt, getSelectedCredit());
            clientCreditOperationsGrid.DataSource = dt;
        }

        public void updateClientContributionOperations()
        {
            BankDataSet.ОперацииПоСчетуDataTable dt = new BankDataSet.ОперацииПоСчетуDataTable();
            операцииПоСчетуTableAdapter.Fill(dt, getSelectedContribution());
            clientContributionOperationsGrid.DataSource = dt;
        }

        public void updateClientCardOperations()
        {
            BankDataSet.ОперацииПоСчетуDataTable dt = new BankDataSet.ОперацииПоСчетуDataTable();
            операцииПоСчетуTableAdapter.Fill(dt, getSelectedCard());
            clientCardOperationsGrid.DataSource = dt;
        }

        public void updateClientCreditRequests()
        {
            BankDataSet.ЗаявкиНаКредитКлиентаDataTable dt = new BankDataSet.ЗаявкиНаКредитКлиентаDataTable();
            заявкиНаКредитКлиентаTableAdapter.Fill(dt, clientID);
            clientCreditRequestsGrid.DataSource = dt;
            clientCreditRequestsGrid.Sort(clientCreditRequestsGrid.Columns[1], ListSortDirection.Ascending);
        }
    }
}
