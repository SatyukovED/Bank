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
    public partial class ChooseTransactionForm : Form
    {
        private ClientFullInfoForm cfif;
        private int isCard; 
        public ChooseTransactionForm(ClientFullInfoForm cfif, int isCard)
        {
            InitializeComponent();
            this.cfif = cfif;
            this.isCard = isCard;
        }

        private void fillUpAccountButton_Click(object sender, EventArgs e)
        {
            FillUpAccountForm fsf = new FillUpAccountForm(cfif, isCard);
            fsf.Show();
            this.Close();
        }

        private void transferMoneyButton_Click(object sender, EventArgs e)
        {
            TransferMoneyForm mmf = new TransferMoneyForm(cfif, isCard);
            mmf.Show();
            this.Close();
        }
    }
}
