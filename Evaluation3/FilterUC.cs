using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation3
{
    public partial class FilterUC : UserControl
    {
        public FilterUC()
        {
            InitializeComponent();
            label2.ForeColor = Color.Gold;
            DoubleBuffered = true;
        }

        public delegate void FilterHandler(int ID, DateTime start, DateTime end, int Month);
        public event FilterHandler Filtered;

        private void fiterBtn_Click(object sender, EventArgs e)
        {
            int ID, Month;
            DateTime start, end;

            ID = isCategoryFiltered ? Convert.ToInt32(comboBox1.SelectedValue) : -1;
            Month = isMonthFiltered ? comboBox2.SelectedIndex + 1 : -1;
            start = isDateFiltered ? startDateTimePicker.Value : DateTime.MaxValue;
            end = isDateFiltered ? endDateTimePicker.Value : DateTime.MaxValue;
            
            Filtered?.Invoke(ID, start, end, Month);
        }

        private void OnMonthFilterClicked(object sender, EventArgs e)
        {
            isMonthFiltered = !isMonthFiltered;
            tableLayoutPanel5.Invalidate();
        }

        private void OnDateFiltered(object sender, EventArgs e)
        {
            isDateFiltered = !isDateFiltered;
            tableLayoutPanel3.Invalidate();
            tableLayoutPanel4.Invalidate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            isCategoryFiltered = !isCategoryFiltered;
            label2.Invalidate();
            panel1.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isCategoryFiltered = true;
            label2.Invalidate();
            panel1.Invalidate();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            isDateFiltered = true;
            tableLayoutPanel3.Invalidate();
            tableLayoutPanel4.Invalidate();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            isMonthFiltered = true;
            tableLayoutPanel5.Invalidate();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            if (isDateFiltered)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(BackColor.R - 15, BackColor.G - 15, BackColor.B - 15)), new Rectangle(0, 0, (sender as TableLayoutPanel).Width, (sender as TableLayoutPanel).Height));
            }
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            if (isCategoryFiltered)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(BackColor.R - 15, BackColor.G - 15, BackColor.B - 15)), new Rectangle(0, 0, (sender as Label).Width, (sender as Label).Height));
                StringFormat SFormat = new StringFormat();
                SFormat.Alignment = SFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("Category", new Font(new FontFamily("Consolas"), 14, FontStyle.Bold), new SolidBrush(Color.Gold), new Rectangle(0, 0, (sender as Label).Width, (sender as Label).Height), SFormat);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (isCategoryFiltered)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(BackColor.R - 15, BackColor.G - 15, BackColor.B - 15)), new Rectangle(0, 0, (sender as Panel).Width, (sender as Panel).Height));
            }
        }
        
        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
            if(isMonthFiltered)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(BackColor.R - 15, BackColor.G - 15, BackColor.B - 15)), new Rectangle(0, 0, (sender as TableLayoutPanel).Width, (sender as TableLayoutPanel).Height));
            }
        }

        private bool isMonthFiltered = false, isDateFiltered = false, isCategoryFiltered = false;
    }
}
