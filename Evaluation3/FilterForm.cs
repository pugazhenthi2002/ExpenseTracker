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
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        public List<string> Details
        {
            set
            {
                comboBox1.DataSource = value;
            }
        }

        public event EventHandler<string> FilterClick;

        private void button1_Click(object sender, EventArgs e)
        {
            FilterClick?.Invoke(this, comboBox1.Text);
        }
    }
}
