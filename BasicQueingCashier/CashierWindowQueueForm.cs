using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicQueingCashier
{
    public partial class CashierWindowQueueForm : Form
    {

        public CashierWindowQueueForm()
        {
            InitializeComponent();
            RefreshAutomatically();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach(Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            RemoveNumberQueue(CashierClass.CashierQueue);
        }

        private void RemoveNumberQueue(Queue<string> cashierQueue)
        {
            if (cashierQueue.Count > 0)
            {
                cashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }
        private void RefreshAutomatically()
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(btnRefresh_Click);
            timer.Start();
        }
    }
}
