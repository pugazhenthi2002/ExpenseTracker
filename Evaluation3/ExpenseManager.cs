using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation3
{
    static class ExpenseManager
    {
        static public int Count = 4;
        static public List<Category> CategoryDetails;
        static public List<Expense> ExpenseDetails;
        static private List<string> categoryNames = new List<string>();

        static ExpenseManager()
        {
            CategoryDetails = new List<Category>
            {
                new Category()
                {
                    CategoryID = Category.Count,
                    CategoryName = "Snacks",
                    BudgetLimitPerMonth = 200
                },
                new Category()
                {
                    CategoryID = Category.Count,
                    CategoryName = "Tour",
                    BudgetLimitPerMonth = 5000
                },
                new Category()
                {
                    CategoryID = Category.Count,
                    CategoryName = "Bus Fair",
                    BudgetLimitPerMonth = 500
                },
                new Category()
                {
                    CategoryID = Category.Count,
                    CategoryName = "Others",
                    BudgetLimitPerMonth = 2500
                }
            };

            ExpenseDetails = new List<Expense>
            {
                new Expense()
                {
                    ExpenseID = 1,
                    ExpenseCategoryID = 1,
                    ExpenseAmount = 20,
                    ExpenseDetails = "Puffs",
                    ExpenseDate = new DateTime(2024, 2, 24)
                },
                new Expense()
                {
                    ExpenseID = 2,
                    ExpenseCategoryID = 3,
                    ExpenseAmount = 17,
                    ExpenseDetails = "Morning Bus PP",
                    ExpenseDate = DateTime.Today
                },
                new Expense()
                {
                    ExpenseID = 3,
                    ExpenseCategoryID = 2,
                    ExpenseAmount = 200,
                    ExpenseDetails = "Bavani",
                    ExpenseDate = new DateTime(2024, 2, 18)
                }
            };

        }

        

        static public void AddExpense()
        {
            AddExpenseForm newAddForm = new AddExpenseForm();
            newAddForm.Location = new Point(500, 500);
            newAddForm.ExpenseAdd += OnExpenseAdded;
            newAddForm.Show();
        }

        static public void AddCategory()
        {
            AddCategoryForm newCategoryForm = new AddCategoryForm();
            newCategoryForm.CategoryAdd += OnCategoryAdded;
            newCategoryForm.Location = new Point(500, 500);
            newCategoryForm.Show();
        }

        static public void EditCategory()
        {
            EditCategoryForm newForm = new EditCategoryForm();
            newForm.Location = new Point(500, 500);
            newForm.CategoryEdited += OnCategoryEdit;
            newForm.Show();
        }

        static public void FilterCategory(int ID, DateTime start, DateTime end, int Month)
        {
            expenseDataTable.Rows.Clear();
            for (int ctr = 0; ctr < ExpenseManager.ExpenseDetails.Count; ctr++)
            {
                if (IsEligibleFilter(ID, start, end, Month, ExpenseManager.ExpenseDetails[ctr]))
                {
                    expenseDataTable.Rows.Add(GetString(ctr));
                }
            }
            expenseDataGridView.DataSource = expenseDataTable;
            UpdateTotal();

        }

        private static void OnExpenseAdded(object sender, Expense e)
        {
            if (selectedExpenseRow == -1)
            {
                ExpenseDetails.Add(e);
                expenseDataTable.Rows.Add(GetString(ExpenseDetails.Count - 1));
            }
            else
            {
                ExpenseDetails[selectedExpenseRow] = e;
                expenseDataTable.Rows[selectedExpenseRow].ItemArray = GetString(selectedExpenseRow);
                selectedExpenseRow = -1;
            }
            UpdateTotal();
            IsOutofBudget(e.ExpenseCategoryID, e.ExpenseDate, e.ExpenseDetails);
        }

        private static void IsOutofBudget(int expenseCategoryID, DateTime expenseDate, string content)
        {
            double budget = 0;
            for (int ctr = 0; ctr < CategoryDetails.Count; ctr++)
            {
                if(expenseCategoryID == CategoryDetails[ctr].CategoryID)
                {
                    content = CategoryDetails[ctr].CategoryName + "\n" + content + " - ";
                    budget = CategoryDetails[ctr].BudgetLimitPerMonth;
                    break;
                }
            }
            double total = 0.0;
            for (int ctr = 0; ctr < ExpenseDetails.Count; ctr++) 
            {
                if(ExpenseDetails[ctr].ExpenseCategoryID == expenseCategoryID && ExpenseDetails[ctr].ExpenseDate.Month == expenseDate.Month && ExpenseDetails[ctr].ExpenseDate.Year == expenseDate.Year)
                {
                    total += ExpenseDetails[ctr].ExpenseAmount;
                }
            }

            if (total > budget)
            {
                notify.AddNotification("Out of Budget", content + total.ToString());
            }
        }

        private static void UpdateTotal()
        {
            double total = 0.0;
            for (int ctr = 0; ctr < expenseDataTable.Rows.Count; ctr++)
            {
                total += Convert.ToDouble(expenseDataTable.Rows[ctr].ItemArray[2]);
            }
            totalLabel.Text = total.ToString();

            
        }

        private static void OnCategoryAdded(string name, string budget)
        {
            if (selectedCategoryRow != -1)
            {
                CategoryDetails[selectedCategoryRow].CategoryName = name;
                CategoryDetails[selectedCategoryRow].BudgetLimitPerMonth = Convert.ToDouble(budget);
                categoryNames[selectedCategoryRow] = name;

                for (int ctr = 0; ctr < expenseDataTable.Rows.Count; ctr++)
                {
                    if (ExpenseDetails[ctr].ExpenseCategoryID == CategoryDetails[selectedCategoryRow].CategoryID)
                    {
                        expenseDataTable.Rows[ctr].ItemArray[1] = name;
                        expenseDataTable.Rows[ctr].ItemArray = GetString(ctr);
                    }
                }


                selectedCategoryRow = -1;
            }
            else
            {
                CategoryDetails.Insert(CategoryDetails.Count - 1, new Category()
                {
                    CategoryID = Category.Count,
                    CategoryName = name,
                    BudgetLimitPerMonth = Convert.ToDouble(budget)
                });
              
                categoryNames.Add(name);
            }

            ComboBoxWrap();

        }

        private static void ComboBoxWrap()
        {
            StaticDataWrapper wrapper = new StaticDataWrapper();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = wrapper;

            combo.DataSource = wrapper.StaticList;
            combo.DisplayMember = "CategoryName";
            combo.ValueMember = "CategoryID";
        }

        internal static void UpdateCategory(int ID) 
        {
            AddCategoryForm newCategoryForm = new AddCategoryForm();
            newCategoryForm.CategoryAdd += OnCategoryAdded;
            newCategoryForm.Location = new Point(500, 500);
            newCategoryForm.SetDetails(ID);
            newCategoryForm.Show();
        }

       


        static public void UpdateExpense()
        {
            AddExpenseForm newAddForm = new AddExpenseForm();
            newAddForm.Location = new Point(500, 500);
            newAddForm.ExpenseAdd += OnExpenseAdded;
            newAddForm.SetDetails(selectedExpenseRow);
            newAddForm.Show();
        }

        static public void DeleteExpense()
        {
            expenseDataTable.Rows.RemoveAt(selectedExpenseRow);
            ExpenseDetails.RemoveAt(selectedExpenseRow);
            selectedExpenseRow = -1;
            UpdateTotal();
        }

        private static void OnFiltered(object sender, string e)
        {
            expenseDataGridView.Rows.Clear();

            for (int ctr = 0; ctr < ExpenseDetails.Count; ctr++)
            {
                if (ExpenseDetails[ctr].ExpenseCategoryID.ToString() == e)
                {
                    expenseDataGridView.Rows.Add(GetString(ctr));
                }
            }

        }
        public static string GetCategoryName(int expenseCategoryID)
        {
            for (int ctr = 0; ctr < CategoryDetails.Count; ctr++) 
            {
                if(CategoryDetails[ctr].CategoryID == expenseCategoryID)
                {
                    return CategoryDetails[ctr].CategoryName;
                }
            }

            return "";
        }

        static public void CrudExpense(int row, Point location)
        {
            selectedExpenseRow = row;
            ExpenseCrudForm newForm = new ExpenseCrudForm();
            newForm.Location = location;
            newForm.Show();
        }

        static public void AssignDataGridView(DataGridView newDataGridView, ComboBox comboBox, Label label, NotificationManager notification)
        {
            expenseDataGridView = newDataGridView;
            GetCategoryDetails();

            expenseDataTable = new DataTable();
            expenseDataTable.Columns.Add("ID", typeof(int));
            expenseDataTable.Columns.Add("Category", typeof(string));
            expenseDataTable.Columns.Add("Amount", typeof(double));
            expenseDataTable.Columns.Add("Details", typeof(string));
            expenseDataTable.Columns.Add("Date", typeof(string));

            expenseDataTable.Rows.Add(GetString(0));
            expenseDataTable.Rows.Add(GetString(1));
            expenseDataTable.Rows.Add(GetString(2));
            expenseDataGridView.DataSource = expenseDataTable;
            notify = notification;
            combo = comboBox;
            totalLabel = label;
            ComboBoxWrap();
            UpdateTotal();
        }

        private static void OnCategoryEdit(object sender, string e)
        {
            for (int ctr = 0; ctr < CategoryDetails.Count; ctr++)
            {
                if (CategoryDetails[ctr].CategoryID == Convert.ToInt32(sender))
                {
                    selectedCategoryRow = ctr;
                    break;
                }
            }

            if (e == "Update")
            {
                UpdateCategory(selectedCategoryRow);
            }
            else
            {
                DeleteCategory(selectedCategoryRow);
            }
        }

        private static void DeleteCategory(int row)
        {
            for (int ctr = 0; ctr < ExpenseDetails.Count; ctr++)
            {
                if(ExpenseDetails[ctr].ExpenseCategoryID == CategoryDetails[row].CategoryID)
                {
                    ExpenseDetails[ctr].ExpenseCategoryID = CategoryDetails[CategoryDetails.Count-1].CategoryID;
                    expenseDataTable.Rows[ctr].ItemArray = GetString(ctr);
                }
            }
            CategoryDetails.RemoveAt(row);
            categoryNames.RemoveAt(row);

            ComboBoxWrap();
        }

        private static bool IsEligibleFilter(int ID, DateTime start, DateTime end, int Month, Expense expense)
        {
            bool x , y , z;

            x = (ID == -1 || expense.ExpenseCategoryID == ID) ? true : false;
            y = (Month == -1 || expense.ExpenseDate.Month == Month) ? true : false;
            z = ((start == end && start == DateTime.MaxValue) || start < expense.ExpenseDate && expense.ExpenseDate < end) ? true : false;

            return x && y && z;
        }

        static private List<string> GetCategoryDetails()
        {
            foreach(var Iter in CategoryDetails)
            {
                categoryNames.Add(Iter.CategoryName);
            }

            return categoryNames;
        }

        private static object[] GetString(int row)
        {
            object[] str = new object[5];
            str[0] = ExpenseDetails[row].ExpenseID;
            str[1] = GetCategoryName(ExpenseDetails[row].ExpenseCategoryID);
            str[2] = ExpenseDetails[row].ExpenseAmount;
            str[3] = ExpenseDetails[row].ExpenseDetails;
            str[4] = ExpenseDetails[row].ExpenseDate.ToShortDateString();
            return str;
        }

        static private int selectedExpenseRow = -1;
        static private int selectedCategoryRow = -1;
        static private NotificationManager notify;
        static public DataTable expenseDataTable;
        static private DataGridView expenseDataGridView = new DataGridView();
        static private ComboBox combo;
        static private Label totalLabel;
    }
}
