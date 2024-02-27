using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation3
{
    public partial class ExpenseCrudForm : Form
    {
        public ExpenseCrudForm()
        {
            InitializeComponent();
        }

        public event EventHandler<string> CrudOccur;

        private void UpdateExpense_Click(object sender, EventArgs e)
        {
            ExpenseManager.UpdateExpense();
            this.Close();
        }

        private void DeleteExpense_Click(object sender, EventArgs e)
        {
            ExpenseManager.DeleteExpense();
            this.Close();
        }
    }
}
