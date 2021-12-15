using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicQueingCashier
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(Update);
            timer.Start();
        }

        public void Update(object sender, EventArgs e)
        {
            Queue<string> cashierQueue = CashierClass.CashierQueue;
            lblServingQueue.Text = cashierQueue.Count > 0 ? cashierQueue.Peek() : "";
        }
    }
}
