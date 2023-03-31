﻿using BudgetWatcher.Database.Schemas;
using System;
using System.Windows.Forms;

namespace BudgetWatcher.Forms.Data
{
    public partial class CategoryForm : Form
    {
        public CategoryForm(string formTitle, ExpenseCategory defaultCategory)
        {
            InitializeComponent();

            Text = formTitle;

            NameTextBox.Text = defaultCategory.Name;
            DescriptionTextBox.Text = defaultCategory.Description;
        }

        public void FillInData(ExpenseCategory expenseCategory)
        {
            expenseCategory.Name = NameTextBox.Text;
            expenseCategory.Description = DescriptionTextBox.Text.Length == 0 ? "-" : DescriptionTextBox.Text;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Button_Ok.Enabled = NameTextBox.Text.Length != 0;
        }
    }
}
