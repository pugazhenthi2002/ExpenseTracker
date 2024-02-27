using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExpenseManager.AssignDataGridView(expenseDataGridView, filterUC1.comboBox1, totalLabel, notificationManager1);
            InitializeDataGridView();
            InitializeDoubleBuffered();

            addExpenseBtn.Click += OnPanelCheckClick;
            addCategoryBtn.Click += OnPanelCheckClick;
            editCategory.Click += OnPanelCheckClick;
        }

        private void InitializeDataGridView()
        {
            DataGridViewCellStyle d = new DataGridViewCellStyle();
            d.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d.BackColor = Color.DimGray;
            d.ForeColor = Color.Gold;
            expenseDataGridView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle(d);

            expenseDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            expenseDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            expenseDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            expenseDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            expenseDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (DataGridViewColumn col in expenseDataGridView.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Consolas", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.HeaderCell.Style.ForeColor = Color.Black;
                col.HeaderCell.Style.BackColor = Color.Gold;
            }
        }

        private void InitializeDoubleBuffered()
        {
            DoubleBuffered = true;

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, expenseDataGridView, new object[] { true });
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, tableLayoutPanel1, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel2, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel3, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel4, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel5, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel6, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel7, new object[] { true });
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, totalExpenseLabel, new object[] { true });
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, totalLabel, new object[] { true });
        }

        private void addExpenseBtn_Click(object sender, EventArgs e)
        {
            ExpenseManager.AddExpense();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            ExpenseManager.AddCategory();
        }

        private void EditCategoryBtn_Click(object sender, EventArgs e)
        {
            ExpenseManager.EditCategory();
        }

        private void OnFiltered(int ID, DateTime start, DateTime end, int Month)
        {
            ExpenseManager.FilterCategory(ID, start, end, Month);
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            //filterUC1.comboBox1.SelectedIndex = 1;
            isFilterVisible = !isFilterVisible;
            
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel6.Width = 0;
            panel6.Visible = false;
            t.Interval = 1;
            t.Tick += OnFilterPanelTick;
        }

        private void OnFilterPanelTick(object sender, EventArgs e)
        {
            if(isFilterVisible)
            {
                panel6.Visible = true;
                panel6.Width += 28;
                if (panel6.Width >= 140) 
                {
                    panel6.Width = 140;
                    t.Stop();
                }
            }
            else
            {
                panel6.Width -= 28;
                if (panel6.Width <= 0)
                {
                    panel6.Visible = false;
                    panel6.Width = 0;
                    t.Stop();
                }
            }
        }

        private bool isFilterVisible = false;
        private Timer t = new Timer();

        private void expenseDataGridView_Click(object sender, EventArgs e)
        {
           
        }

        private void expenseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = e;
        }

        private void expenseDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            expenseDataGridView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            if (e.Button == MouseButtons.Right)
            {
                
                int currentMouseOverRow = expenseDataGridView.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow != -1)
                {
                    for (int ctr = 0; ctr < expenseDataGridView.Rows.Count; ctr++)
                    {
                        if(ctr==currentMouseOverRow)
                        {
                            expenseDataGridView.Rows[ctr].Selected = true;
                        }
                        else
                        {
                            expenseDataGridView.Rows[ctr].Selected = false;
                        }
                    }
                    ExpenseManager.CrudExpense(currentMouseOverRow, Cursor.Position);
                }

            }
        }

        private void OnPanelCheckClick(object sender, EventArgs e)
        {
            if (isFilterVisible)
            {
                isFilterVisible = false;
                OnFiltered(-1, DateTime.MaxValue, DateTime.MaxValue, -1);
                t.Start();
            }
        }
    }
}
