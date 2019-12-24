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
    public partial class OperatorForm : Form
    {
        public int operatorID;
        public int selectedClientRow;
        public int selectedPotentialClientRow;
        private QueriesTableAdapter ta = new QueriesTableAdapter();

        public OperatorForm(int operatorID)
        {
            InitializeComponent();
            this.operatorID = operatorID;
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            updateClientsGrid();
            updatePotentialClientsGrid();
            if (selectedPotentialClientRow == 0)
            {
                if (operatorPotentialClientsGrid.Rows[selectedPotentialClientRow].Cells[1].Value.ToString() == "Вклад")
                {
                    operatorOpenContributionButton.Visible = true;
                }
                else if (operatorPotentialClientsGrid.Rows[selectedPotentialClientRow].Cells[1].Value.ToString() == "Карта")
                {
                    operatorOpenCardButton.Visible = true;
                }
                else
                {
                    operatorOpenCreditRequestButton.Visible = true;
                }
            }
        }

        private void operatorShowClientsButton_Click(object sender, EventArgs e)
        {
            operatorTabControl.SelectedTab = operatorClientsPage;
        }

        private void operatorShowPotentialClientsButton_Click(object sender, EventArgs e)
        {
            operatorTabControl.SelectedTab = operatorPotentialClientsPage;
        }

        private void operatorClientsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            selectedClientRow = operatorClientsGrid.CurrentRow.Index;
        }

        private void operatorShowFullClientInfoButton_Click(object sender, EventArgs e)
        {
            ClientFullInfoForm cfif = new ClientFullInfoForm(this, (int)operatorClientsGrid.Rows[selectedClientRow].Cells[0].Value);
            cfif.Show();
        }

        private void operatorAddClientButton_Click(object sender, EventArgs e)
        {
            AddNewClientFrom af = new AddNewClientFrom(this);
            af.Show();
        }

        private void operatorGoToMainPageFromClientsPageButton_Click(object sender, EventArgs e)
        {
            operatorTabControl.SelectedTab = operatorMainPage;
        }

        private void operatorPotentialClientsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedPotentialClientRow = operatorPotentialClientsGrid.CurrentRow.Index;
            if (operatorPotentialClientsGrid.Rows[selectedPotentialClientRow].Cells[1].Value.ToString() == "Вклад")
            {
                operatorOpenCreditRequestButton.Visible = false;
                operatorOpenCardButton.Visible = false;
                operatorOpenContributionButton.Visible = true;
            }
            else if (operatorPotentialClientsGrid.Rows[selectedPotentialClientRow].Cells[1].Value.ToString() == "Карта")
            {
                operatorOpenCreditRequestButton.Visible = false;
                operatorOpenCardButton.Visible = true;
                operatorOpenContributionButton.Visible = false;
            }
            else
            {
                operatorOpenCreditRequestButton.Visible = true;
                operatorOpenCardButton.Visible = false;
                operatorOpenContributionButton.Visible = false;
            }
        }

        private void operatorOpenCardButton_Click(object sender, EventArgs e)
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
                    ta.ВыпуститьКарту(getSelectedPotentialClientID());
                    MessageBox.Show("Карта выпущена");
                    updatePotentialClientsGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Карта не была выпущена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void operatorOpenCreditRequestButton_Click(object sender, EventArgs e)
        {
            bool? isExistsActiveCreditRequestsFromClient = false;
            ta.ЕстьЛиОжидающиеЗаявкиНаКредитОтКлиента(getSelectedPotentialClientID(), 
                ref isExistsActiveCreditRequestsFromClient);
            if (isExistsActiveCreditRequestsFromClient == true)
            {
                string message = "У клиента уже имеется заявка в состоянии ожидания подтверждения.\nВы действительно хотите подать заявку?";
                string caption = "Подтверждение подачи заявки на кредит";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    AddNewCreditRequestForm acrf = new AddNewCreditRequestForm(this, getSelectedPotentialClientID());
                    acrf.Show();
                }
            }
            else
            {
                AddNewCreditRequestForm acrf = new AddNewCreditRequestForm(this, getSelectedPotentialClientID());
                acrf.Show();
            }
        }

        private void operatorOpenContributionButton_Click(object sender, EventArgs e)
        {
            AddNewContributionForm avf = new AddNewContributionForm(this, getSelectedPotentialClientID());
            avf.Show();
        }

        private void operatorGoToMainPageFromPotentialClientsPageButton_Click(object sender, EventArgs e)
        {
            operatorTabControl.SelectedTab = operatorMainPage;
        }

        public int getSelectedClientID()
        {
            return (int)operatorClientsGrid.Rows[selectedClientRow].Cells[0].Value;
        }

        private int getSelectedPotentialClientID()
        {
            return (int)operatorPotentialClientsGrid.Rows[selectedPotentialClientRow].Cells[0].Value;
        }

        public void updateClientsGrid()
        {
            this.получитьСписокКлиентовTableAdapter.Fill(this.bankDataSet.ПолучитьСписокКлиентов);
        }

        public void updatePotentialClientsGrid()
        {
            this.остутствующиеАктивныеСчетаTableAdapter.Fill(this.bankDataSet1.ОстутствующиеАктивныеСчета);
            operatorPotentialClientsGrid.ClearSelection();
            if (operatorPotentialClientsGrid.Rows.Count != 0)
            {
                selectedPotentialClientRow = 0;
                if (operatorPotentialClientsGrid.Rows[selectedPotentialClientRow].Cells[1].Value.ToString() == "Вклад")
                {
                    operatorOpenContributionButton.Visible = true;
                }
                else if (operatorPotentialClientsGrid.Rows[selectedPotentialClientRow].Cells[1].Value.ToString() == "Карта")
                {
                    operatorOpenCardButton.Visible = true;
                }
                else
                {
                    operatorOpenCreditRequestButton.Visible = true;
                }
                operatorPotentialClientsGrid.Rows[selectedPotentialClientRow].Selected = true;
            }
            else
            {
                selectedPotentialClientRow = -1;
                operatorOpenCreditRequestButton.Visible = false;
                operatorOpenCardButton.Visible = false;
                operatorOpenContributionButton.Visible = false;
            }
        }
    }
}
