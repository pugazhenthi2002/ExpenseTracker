using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation3
{
    class StaticDataWrapper
    {
        public BindingList<Category> StaticList { get; } = new BindingList<Category>();

        public StaticDataWrapper()
        {
            foreach (Category item in ExpenseManager.CategoryDetails)
            {
                StaticList.Add(item);
            }
        }
    }
}
