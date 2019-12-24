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
    public partial class ClientCreditsInfoForm : Form
    {
        private int id;
        private int selectedCredit = 0;
        private bool showCredits;
        private QueriesTableAdapter qta = new QueriesTableAdapter();

        public ClientCreditsInfoForm(int id, bool showCredits)
        {
            InitializeComponent();
            this.id = id;
            this.showCredits = showCredits;
            if (!showCredits)
            {
                clientInfoTabControl.TabPages.Remove(clientCreditsPage);
            }
            BankDataSet.ПолучитьИнформациюКлиентаDataTable dt = new BankDataSet.ПолучитьИнформациюКлиентаDataTable();
            ПолучитьИнформациюКлиентаTableAdapter ta = new ПолучитьИнформациюКлиентаTableAdapter();
            ta.Fill(dt, id);
            clientIDTextBox.Text = dt.Rows[0].Field<int>("IDКлиента").ToString();
            clientNameTextBox.Text = dt.Rows[0].Field<string>("ФИО").ToString();
            clientTownTextBox.Text = dt.Rows[0].Field<string>("Город");
            clientIncomeTextBox.Text = dt.Rows[0].Field<decimal>("Доход").ToString();
            clientStatusTextBox.Text = dt.Rows[0].Field<string>("Статус");

            int ? numberOfActiveCredits = 0;
            qta.КоличествоАктивныхКредитовКлиента(id, ref numberOfActiveCredits);
            if (numberOfActiveCredits.ToString() == "")
            {
                numberOfActiveCredits = 0;
            }
            clientActiveCreditsNumberTextBox.Text = numberOfActiveCredits.ToString();
            int ? numberOfClosedCredits = 0;
            qta.КоличествоЗакрытыхКредитовКлиента(id, ref numberOfClosedCredits);
            if (numberOfClosedCredits.ToString() == "")
            {
                numberOfClosedCredits = 0;
            }
            clientClosedCreditsNumberTextBox.Text = numberOfClosedCredits.ToString();
            if (numberOfActiveCredits != 0)
            {
                clientDebtExistenceTextBox.Visible = true;
                clientDebtExistenceLabel.Visible = true;
                bool? checkDebtExistence = false;
                qta.ПроверитьНаличиеЗадолженностиКлиента(id, ref checkDebtExistence);

                if (checkDebtExistence == true)
                {
                    clientDebtExistenceTextBox.Text = "Да";
                }
                else
                {
                    clientDebtExistenceTextBox.Text = "Нет";
                }
            }
            BankDataSet.СписокКредитовКлиентаDataTable dtt = new BankDataSet.СписокКредитовКлиентаDataTable();
            списокКредитовКлиентаTableAdapter.Fill(dtt, id);
            clientCreditsGrid.DataSource = dtt;
        }

        private void clientShowCreditOperationsButton_Click(object sender, EventArgs e)
        {
            BankDataSet.ОперацииПоСчетуDataTable dt =
                 new BankDataSet.ОперацииПоСчетуDataTable();
            операцииПоСчетуTableAdapter.Fill(dt, (int)clientCreditsGrid.Rows[selectedCredit].Cells[0].Value);
            clientCreditOperationsGrid.DataSource = dt;
            clientCreditOperationsGrid.Visible = true;
            clientHideCreditOperationsButton.Visible = true;
            clientShowCreditOperationsButton.Visible = false;
            clientCreditsGrid.Visible = false;
        }

        private void clientHideCreditOperationsButton_Click(object sender, EventArgs e)
        {
            clientCreditOperationsGrid.Visible = false;
            clientHideCreditOperationsButton.Visible = false;
            clientShowCreditOperationsButton.Visible = true;
            clientCreditsGrid.Visible = true;
        }

        private void clientCreditsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            selectedCredit = clientCreditsGrid.CurrentRow.Index;
            if (clientCreditsGrid.Rows[selectedCredit].Cells[7].Value.ToString() == "")
            {
                clientCreditDebtAmountLabel.Visible = true;
                clientCreditDebtAmountTextBox.Visible = true;
                decimal? debtAmount = 0;
                qta.ПосчитатьЗадолженностьПоКредиту((int)clientCreditsGrid.Rows[selectedCredit].Cells[0].Value,
                                                    ref debtAmount);
                clientCreditDebtAmountTextBox.Text = debtAmount.ToString();
            }
            else
            {
                clientCreditDebtAmountLabel.Visible = false;
                clientCreditDebtAmountTextBox.Visible = false;
            }
        }

        private void ClientCreditsInfoForm_Load(object sender, EventArgs e)
        {
            if (showCredits)
            {
                if (clientCreditsGrid.Rows[0].Cells[7].Value.ToString() == "")
                {
                    clientCreditDebtAmountLabel.Visible = true;
                    clientCreditDebtAmountTextBox.Visible = true;
                    decimal? debtAmount = 0;
                    qta.ПосчитатьЗадолженностьПоКредиту((int)clientCreditsGrid.Rows[selectedCredit].Cells[0].Value,
                                                        ref debtAmount);
                    clientCreditDebtAmountTextBox.Text = debtAmount.ToString();
                }
                else
                {
                    clientCreditDebtAmountLabel.Visible = false;
                    clientCreditDebtAmountTextBox.Visible = false;
                }
            }
        }
    }
}
