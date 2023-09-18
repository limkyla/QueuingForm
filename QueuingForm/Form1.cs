namespace QueuingForm
{
    public partial class Form1 : Form
    {
        private CashierClass cashier;
        private bool isOpen = false;
        public Form1()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void QueuingForm_Click(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGenerateNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
            if (isOpen)
            {
                return;
            }


            CashierWindowQueueForm form = new CashierWindowQueueForm();
            form.Show();
            isOpen = true;
        }
    }
}