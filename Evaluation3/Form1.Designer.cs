namespace Evaluation3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSwitch1 = new Evaluation3.TabSwitch();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.expenseDataGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filterBtn = new System.Windows.Forms.Button();
            this.editCategory = new System.Windows.Forms.Button();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.addExpenseBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.notificationManager1 = new Evaluation3.NotificationManager();
            this.filterUC1 = new Evaluation3.FilterUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tabSwitch1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense Tracker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSwitch1
            // 
            this.tabSwitch1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabSwitch1.Location = new System.Drawing.Point(0, 0);
            this.tabSwitch1.Name = "tabSwitch1";
            this.tabSwitch1.Size = new System.Drawing.Size(49, 49);
            this.tabSwitch1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 401);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.expenseDataGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(226, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(574, 341);
            this.panel5.TabIndex = 2;
            // 
            // expenseDataGridView
            // 
            this.expenseDataGridView.AllowUserToAddRows = false;
            this.expenseDataGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.expenseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.expenseDataGridView.ColumnHeadersHeight = 40;
            this.expenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.expenseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenseDataGridView.EnableHeadersVisualStyles = false;
            this.expenseDataGridView.GridColor = System.Drawing.Color.Maroon;
            this.expenseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.expenseDataGridView.Name = "expenseDataGridView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.expenseDataGridView.RowHeadersVisible = false;
            this.expenseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseDataGridView.Size = new System.Drawing.Size(574, 341);
            this.expenseDataGridView.TabIndex = 0;
            this.expenseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenseDataGridView_CellContentClick);
            this.expenseDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expenseDataGridView_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.totalExpenseLabel);
            this.panel4.Controls.Add(this.totalLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(226, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 60);
            this.panel4.TabIndex = 3;
            // 
            // totalExpenseLabel
            // 
            this.totalExpenseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalExpenseLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpenseLabel.ForeColor = System.Drawing.Color.Gold;
            this.totalExpenseLabel.Location = new System.Drawing.Point(0, 0);
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            this.totalExpenseLabel.Size = new System.Drawing.Size(437, 60);
            this.totalExpenseLabel.TabIndex = 1;
            this.totalExpenseLabel.Text = "Total Expense";
            this.totalExpenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(129)))), ((int)(((byte)(240)))));
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Gold;
            this.totalLabel.Location = new System.Drawing.Point(437, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(137, 60);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "0.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(140, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 401);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.filterBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.editCategory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addCategoryBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addExpenseBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(86, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.filterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filterBtn.BackgroundImage")));
            this.filterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.filterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBtn.FlatAppearance.BorderSize = 0;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Location = new System.Drawing.Point(1, 301);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(1);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(84, 99);
            this.filterBtn.TabIndex = 3;
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // editCategory
            // 
            this.editCategory.BackColor = System.Drawing.Color.DodgerBlue;
            this.editCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editCategory.BackgroundImage")));
            this.editCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editCategory.FlatAppearance.BorderSize = 0;
            this.editCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCategory.Location = new System.Drawing.Point(1, 201);
            this.editCategory.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.editCategory.Name = "editCategory";
            this.editCategory.Size = new System.Drawing.Size(84, 99);
            this.editCategory.TabIndex = 2;
            this.editCategory.UseVisualStyleBackColor = false;
            this.editCategory.Click += new System.EventHandler(this.EditCategoryBtn_Click);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addCategoryBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCategoryBtn.BackgroundImage")));
            this.addCategoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addCategoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCategoryBtn.FlatAppearance.BorderSize = 0;
            this.addCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryBtn.Location = new System.Drawing.Point(1, 101);
            this.addCategoryBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(84, 99);
            this.addCategoryBtn.TabIndex = 1;
            this.addCategoryBtn.UseVisualStyleBackColor = false;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // addExpenseBtn
            // 
            this.addExpenseBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addExpenseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addExpenseBtn.BackgroundImage")));
            this.addExpenseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addExpenseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addExpenseBtn.FlatAppearance.BorderSize = 0;
            this.addExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseBtn.Location = new System.Drawing.Point(1, 1);
            this.addExpenseBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.addExpenseBtn.Name = "addExpenseBtn";
            this.addExpenseBtn.Size = new System.Drawing.Size(84, 99);
            this.addExpenseBtn.TabIndex = 0;
            this.addExpenseBtn.UseVisualStyleBackColor = false;
            this.addExpenseBtn.Click += new System.EventHandler(this.addExpenseBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(140, 401);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.filterUC1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.panel7.Size = new System.Drawing.Size(140, 401);
            this.panel7.TabIndex = 1;
            // 
            // notificationManager1
            // 
            this.notificationManager1.BorderRadius = 10;
            this.notificationManager1.NotificationAlignment = Evaluation3.FromNotificationAlignment.RightDown;
            this.notificationManager1.NotificationScreenTime = 5;
            // 
            // filterUC1
            // 
            this.filterUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterUC1.Location = new System.Drawing.Point(1, 1);
            this.filterUC1.Name = "filterUC1";
            this.filterUC1.Size = new System.Drawing.Size(139, 399);
            this.filterUC1.TabIndex = 0;
            this.filterUC1.Filtered += new Evaluation3.FilterUC.FilterHandler(this.OnFiltered);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView expenseDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button editCategory;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.Button addExpenseBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Panel panel7;
        private NotificationManager notificationManager1;
        private System.Windows.Forms.Label label1;
        private TabSwitch tabSwitch1;
        private FilterUC filterUC1;
    }
}

