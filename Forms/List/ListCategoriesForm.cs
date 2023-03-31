﻿using BudgetWatcher.Database.Schemas;
using BudgetWatcher.Forms.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetWatcher.Forms.List
{
    public partial class ListCategoriesForm : Form
    {
        List<ExpenseCategory> m_Categories = null;

        public ListCategoriesForm()
        {
            InitializeComponent();

            m_Categories = ExpenseCategory.FetchAll();

            foreach (var category in m_Categories)
            {
                CategoriesGridView.Rows.Add("modifică", category.Id, category.Name, category.Description);
            }

            CategoriesGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void CategoriesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) // button clicked, open update form
            {
                ExpenseCategory currentCateogry = m_Categories[e.RowIndex];

                CategoryForm form = new CategoryForm("Modifică categoria", currentCateogry);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    form.FillInData(currentCateogry);
                    currentCateogry.Update();

                    DataGridViewCellCollection cells = CategoriesGridView.Rows[e.RowIndex].Cells;
                    cells[1].Value = currentCateogry.Id;
                    cells[2].Value = currentCateogry.Name;
                    cells[3].Value = currentCateogry.Description;

                    Utils.ShowInfoMessageBox("Categorie modificată cu succes!");
                }
            }
        }
    }
}
