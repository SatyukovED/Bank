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
    public partial class CreditorForm : Form
    {
        private int creditorID;
        public int selectedCreditRequestRow;
        public int selectedClientRow;
        public int selectedClientWithDebtRow;
        private QueriesTableAdapter ta = new QueriesTableAdapter();

        public CreditorForm(int creditorID)
        {
            InitializeComponent();
            this.creditorID = creditorID;
        }

        private void CreditorForm_Load(object sender, EventArgs e)
        {
            this.клиентыИмеющиеКредитыСЗадолженностьюTableAdapter.Fill(this.bankDataSet.КлиентыИмеющиеКредитыСЗадолженностью);
            updateCreditRequestsGrid();
            updateClientsGrid();
            selectedClientRow = 0;
            selectedCreditRequestRow = 0;
            selectedClientWithDebtRow = 0;
            if (creditorCreditRequestsGrid.Rows[selectedCreditRequestRow].Cells[2].Value.ToString() == "В ожидании")
            {
                creditorApproveCreditRequestButton.Visible = true;
                creditorRejectCreditRequestButton.Visible = true;
            }
        }

        private void creditorShowCreditRequestsButton_Click(object sender, EventArgs e)
        {
            creditorTabControl.SelectedTab = creditorCreditRequestsPage;
        }

        private void creditorShowClientsWithCreditsButton_Click(object sender, EventArgs e)
        {
            creditorTabControl.SelectedTab = creditorClientsWithCreditsPage;
        }

        private void creditorCreditRequestsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            selectedCreditRequestRow = creditorCreditRequestsGrid.CurrentRow.Index;
            if (creditorCreditRequestsGrid.Rows[selectedCreditRequestRow].Cells[2].Value.ToString() == "В ожидании")
            {
                creditorApproveCreditRequestButton.Visible = true;
                creditorRejectCreditRequestButton.Visible = true;
            }
            else
            {
                creditorApproveCreditRequestButton.Visible = false;
                creditorRejectCreditRequestButton.Visible = false;
            }
        }

        private void creditorApproveCreditRequestButton_Click(object sender, EventArgs e)
        {
            string message = "Подтвердите одобрение заявки";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ta.ОдобритьЗаявку(getSelectedCreditReuquestID(), creditorID);
                MessageBox.Show("Заявка одобрена");
                int tempCreditSelectedRequestRow = selectedCreditRequestRow;
                updateCreditRequestsGrid();
                setPreviousCreditRequestSelection(tempCreditSelectedRequestRow);
                creditorApproveCreditRequestButton.Visible = false;
                creditorRejectCreditRequestButton.Visible = false;
            }
            updateClientsGrid();
            selectedClientRow = 0;
        }

        private void creditorRejectCreditRequestButton_Click(object sender, EventArgs e)
        {
            string message = "Вы действительно хотите отклонить заявку?";
            string caption = "Подтверждение отклонения";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ta.ОтклонитьЗаявку(getSelectedCreditReuquestID(), creditorID);
                MessageBox.Show("Заявка отклонена");
                int tempCreditSelectedRequestRow = selectedCreditRequestRow;
                updateCreditRequestsGrid();
                creditorApproveCreditRequestButton.Visible = false;
                creditorRejectCreditRequestButton.Visible = false;
                setPreviousCreditRequestSelection(tempCreditSelectedRequestRow);
            }
        }

        private void creditorShowShortClientCreditsInfoButton_Click(object sender, EventArgs e)
        {
            if (selectedCreditRequestRow == -1)
            {
                MessageBox.Show("Выберите заявку клиента", "Заявка не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClientCreditsInfoForm cif = new ClientCreditsInfoForm((int)creditorCreditRequestsGrid.Rows[selectedCreditRequestRow].Cells[1].Value, false);
            cif.Show();
        }

        private void creditorGoToMainPageFromCreditRequestsPageButton_Click(object sender, EventArgs e)
        {
            creditorTabControl.SelectedTab = creditorMainPage;
        }

        private void creditorClientsWithCreditsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            selectedClientRow = creditorClientsWithCreditsGrid.CurrentRow.Index;
        }

        private void creditorShowClientsWithDebtButton_Click(object sender, EventArgs e)
        {
            if (creditorClientsWithDebtGrid.Rows.Count == 0)
            {
                MessageBox.Show("На данный момент должников нет");
                return;
            }
            creditorClientsWithCreditsGrid.Visible = false;
            creditorClientsWithDebtGrid.Visible = true;
            creditorShowClientsWithDebtButton.Visible = false;
            creditorHideClientsWithDebtButton.Visible = true;
            creditorShowFullClientCreditsInfoButton.Visible = false;
            creditorShowFullClientWithDebtCreditsInfoButton.Visible = true;
        }

        private void creditorClientsWithDebtGrid_MouseClick(object sender, MouseEventArgs e)
        {
            selectedClientWithDebtRow = creditorClientsWithDebtGrid.CurrentRow.Index;
        }

        private void creditorShowFullClientWithDebtCreditsInfoButton_Click(object sender, EventArgs e)
        {
            if (selectedClientWithDebtRow == -1)
            {
                MessageBox.Show("Выберите клиента", "Клиент не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClientCreditsInfoForm cif = new ClientCreditsInfoForm((int)creditorClientsWithDebtGrid.Rows[selectedClientWithDebtRow].Cells[0].Value, true);
            cif.Show();
        }

        private void creditorHideClientsWithDebtButton_Click(object sender, EventArgs e)
        {
            creditorClientsWithCreditsGrid.Visible = true;
            creditorClientsWithDebtGrid.Visible = false;
            creditorShowClientsWithDebtButton.Visible = true;
            creditorHideClientsWithDebtButton.Visible = false;
            creditorShowFullClientCreditsInfoButton.Visible = true;
            creditorShowFullClientWithDebtCreditsInfoButton.Visible = false;
            selectedClientWithDebtRow = 0;
        }

        private void creditorShowFullClientCreditsInfoButton_Click(object sender, EventArgs e)
        {
            if (creditorClientsWithCreditsGrid.Rows.Count == 0)
            {
                MessageBox.Show("Нет клиентов с активными кредитами");
                return;
            }
            if (selectedClientRow == -1)
            {
                MessageBox.Show("Выберите клиента", "Клиент не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClientCreditsInfoForm cif = new ClientCreditsInfoForm((int)creditorClientsWithCreditsGrid.Rows[selectedClientRow].Cells[0].Value, true);
            cif.Show();
        }

        private void creditorGoToMainPageFromClientsWithCreditsPageButton_Click(object sender, EventArgs e)
        {
            creditorTabControl.SelectedTab = creditorMainPage;
        }

        public int getSelectedCreditReuquestID()
        {
            return (int)creditorCreditRequestsGrid.Rows[selectedCreditRequestRow].Cells[0].Value;
        }

        public void updateCreditRequestsGrid()
        {
            this.сортированныеЗаявкиНаКредитTableAdapter.Fill(this.bankDataSet.СортированныеЗаявкиНаКредит);
            creditorCreditRequestsGrid.ClearSelection();
            selectedCreditRequestRow = -1;
        }

        public void updateClientsGrid()
        {
            this.количествоАктивныхКредитовКлиентовСФИОИСтатусомTableAdapter.Fill(this.bankDataSet.КоличествоАктивныхКредитовКлиентовСФИОИСтатусом);
            creditorCreditRequestsGrid.ClearSelection();
            selectedClientRow = -1;
        }

        public void setPreviousCreditRequestSelection(int selectedCreditRequestRowNumber)
        {
            creditorCreditRequestsGrid.ClearSelection();
            selectedCreditRequestRow = selectedCreditRequestRowNumber;
            creditorCreditRequestsGrid.Rows[selectedCreditRequestRow].Selected = true;
        }
    }
}
