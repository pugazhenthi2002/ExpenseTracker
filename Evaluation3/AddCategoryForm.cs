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
    public partial class AddCategoryForm : Form
    {
        private Point offset;
        private bool isTitleBarPanelDrag;

        public AddCategoryForm()
        {
            InitializeComponent();
            closeButton1.ButtonColor = Color.Gold;
        }
        public delegate void CategoryHandler(string name, string budget);
        public event CategoryHandler CategoryAdd;

        private void button1_Click(object sender, EventArgs e)
        {
            if(budgetLimitTextBox.Text!="" && categoryNameTextBox.Text != "")
            {
                CategoryAdd?.Invoke(categoryNameTextBox.Text, budgetLimitTextBox.Text);
                this.Close();
            }
        }

        public void SetDetails(int ID)
        {
            categoryNameTextBox.Text = ExpenseManager.CategoryDetails[ID].CategoryName;
            budgetLimitTextBox.Text = ExpenseManager.CategoryDetails[ID].BudgetLimitPerMonth.ToString();
            button1.Text = "Update";
        }

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
    }
}
