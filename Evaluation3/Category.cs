using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation3
{
    public class Category
    {
        public Category()
        {
            Count++;
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public double BudgetLimitPerMonth { get; set; }

        public static int Count = 0;
    }
}
