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
    public partial class AddExpenseForm : Form
    {
        public AddExpenseForm()
        {
            InitializeComponent();
            categoryComboBox.DataSource = ExpenseManager.CategoryDetails;
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "CategoryID";
            closeButton1.ButtonColor = Color.Gold;
            detailsTextBox.Font = amountTextBox.Font = new Font(new FontFamily("Consolas"), 16);
        }

        public event EventHandler<Expense> ExpenseAdd;

        public List<string> ComboDataSource
        {
            set
            {
                categoryComboBox.DataSource = value;
            }
        }

        public void SetDetails(int row)
        {
            x = ExpenseManager.ExpenseDetails[row].ExpenseID;
            categoryComboBox.Text = ExpenseManager.GetCategoryName(ExpenseManager.ExpenseDetails[row].ExpenseCategoryID);
            amountTextBox.Text = ExpenseManager.ExpenseDetails[row].ExpenseAmount.ToString();
            detailsTextBox.Text = ExpenseManager.ExpenseDetails[row].ExpenseDetails;
            expenseDate.Value = ExpenseManager.ExpenseDetails[row].ExpenseDate;
            addExpenseBtn.Text = "Update";
        }
        
        private void addExpenseBtn_Click(object sender, EventArgs e)
        {
            if(isValidEntry())
            {
                x = x == -1 ? ExpenseManager.Count++ : x;
                ExpenseAdd?.Invoke(this, new Expense()
                {
                    ExpenseID = x,
                    ExpenseCategoryID = Convert.ToInt32(categoryComboBox.SelectedValue),
                    ExpenseAmount = Convert.ToDouble(amountTextBox.Text),
                    ExpenseDetails = detailsTextBox.Text,
                    ExpenseDate = this.expenseDate.Value
                });

                this.Close();
            }
        }

        private bool isValidEntry()
        {
            if(amountTextBox.Text!="" && detailsTextBox.Text!="")
            {
                return true;
            }
            return false;
        }

        private int x=-1;

        private void closeButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnTitleBarPanelMouseDown(object sender, MouseEventArgs e)
        {
            offset = e.Location;
            isTitleBarPanelDrag = true;
        }

        private void OnTitleBarPanelMouseUp(object sender, MouseEventArgs e)
        {
            isTitleBarPanelDrag = false;
        }

        private void OnTitleBarPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (isTitleBarPanelDrag)
            {
                Location = new Point(Cursor.Position.X - offset.X, Cursor.Position.Y - offset.Y);
            }
        }

        private Point offset;
        private bool isTitleBarPanelDrag = false;
    }
}
