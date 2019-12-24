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
    public partial class AddNewContributionForm : Form
    {
        private OperatorForm of;
        private ClientFullInfoForm cfif;
        private int? duration;
        private int id;
 
        public AddNewContributionForm(OperatorForm of, int ID)
        {
            InitializeComponent();
            this.of = of;
            this.cfif = null;
            this.id = ID;
        }

        public AddNewContributionForm(OperatorForm of, ClientFullInfoForm cfif, int ID)
        {
            InitializeComponent();
            this.of = of;
            this.cfif = cfif;
            this.id = ID;
        }

        private void newContributionDurationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newContributionDurationComboBox.SelectedItem.ToString() == "Бессрочно")
            {
                duration = 0;
                newContributionPercentTextBox.Text = "0,01";
            }
            else if (newContributionDurationComboBox.SelectedItem.ToString() == "1 год")
            {
                duration = 1;
                newContributionPercentTextBox.Text = "5,00";
            }
            else if (newContributionDurationComboBox.SelectedItem.ToString() == "5 лет")
            {
                duration = 5;
                newContributionPercentTextBox.Text = "1,00";
            }
            else
            {
                duration = 10;
                newContributionPercentTextBox.Text = "0,10";
            }
        }

        private void addNewContributionButton_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter ta = new QueriesTableAdapter();
            try
            {
                decimal percent = decimal.Parse(newContributionPercentTextBox.Text);
                bool? status = false;
                ta.УзнатьСтатусКлиента(id, ref status);
                if (status == true)
                {
                    percent *= 2;
                }
                if (duration == 0)
                {
                    ta.ОткрытьБессрочныйВклад(id, percent);
                    MessageBox.Show("Открыт бессрочный вклад");
                }
                else
                {
                    ta.ОткрытьВклад(id, percent, duration);
                    if (duration == 1)
                    {
                        MessageBox.Show("Открыт вклад на " + duration + " год");
                    }
                    else
                    {
                        MessageBox.Show("Открыт вклад на " + duration + " лет");
                    }
                }
                if (status == true)
                {
                    MessageBox.Show("Процент вклада удвоен, так как статус клиента - Премиум");
                }
                of.updatePotentialClientsGrid();
                cfif.updateClientStatus();
                if (cfif != null)
                {
                    cfif.updateClientContributions();
                }
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Вклад не был открыт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
