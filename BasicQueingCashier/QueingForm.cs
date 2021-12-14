using System;
using System.Windows.Forms;

namespace BasicQueingCashier
{
    public partial class QueingForm : Form
    {
        private CashierClass cashier;
        public QueingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            new CashierWindowQueueForm().Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
