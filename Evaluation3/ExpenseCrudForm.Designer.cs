namespace Evaluation3
{
    partial class ExpenseCrudForm
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
            this.UpdateExpense = new System.Windows.Forms.Button();
            this.DeleteExpense = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateExpense
            // 
            this.UpdateExpense.BackColor = System.Drawing.Color.DimGray;
            this.UpdateExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateExpense.FlatAppearance.BorderSize = 0;
            this.UpdateExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateExpense.ForeColor = System.Drawing.Color.White;
            this.UpdateExpense.Location = new System.Drawing.Point(1, 1);
            this.UpdateExpense.Margin = new System.Windows.Forms.Padding(1);
            this.UpdateExpense.Name = "UpdateExpense";
            this.UpdateExpense.Size = new System.Drawing.Size(160, 41);
            this.UpdateExpense.TabIndex = 0;
            this.UpdateExpense.Text = "Update";
            this.UpdateExpense.UseVisualStyleBackColor = false;
            this.UpdateExpense.Click += new System.EventHandler(this.UpdateExpense_Click);
            // 
            // DeleteExpense
            // 
            this.DeleteExpense.BackColor = System.Drawing.Color.DimGray;
            this.DeleteExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteExpense.FlatAppearance.BorderSize = 0;
            this.DeleteExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteExpense.ForeColor = System.Drawing.Color.White;
            this.DeleteExpense.Location = new System.Drawing.Point(1, 44);
            this.DeleteExpense.Margin = new System.Windows.Forms.Padding(1);
            this.DeleteExpense.Name = "DeleteExpense";
            this.DeleteExpense.Size = new System.Drawing.Size(160, 41);
            this.DeleteExpense.TabIndex = 1;
            this.DeleteExpense.Text = "Delete";
            this.DeleteExpense.UseVisualStyleBackColor = false;
            this.DeleteExpense.Click += new System.EventHandler(this.DeleteExpense_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DeleteExpense, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UpdateExpense, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 86);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ExpenseCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 86);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseCrudForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ExpenseCrudForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpdateExpense;
        private System.Windows.Forms.Button DeleteExpense;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}