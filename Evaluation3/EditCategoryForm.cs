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
    public partial class EditCategoryForm : Form
    {
        private Point offset;
        private bool isTitleBarPanelDrag;

        public EditCategoryForm()
        {
            InitializeComponent();
            comboBox1.DataSource = ExpenseManager.CategoryDetails;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            closeButton1.ButtonColor = Color.Gold;
        }
        public delegate void CategoryHandler(object value, string e);
        public event CategoryHandler CategoryEdited;

        private void OnCategoryEdit(object sender, EventArgs e)
        {
            CategoryEdited?.Invoke(comboBox1.SelectedValue, (sender as Button).Text);
            this.Close();
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
