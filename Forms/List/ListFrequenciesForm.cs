﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using BudgetWatcher.Database;
using BudgetWatcher.Database.Schemas;
using BudgetWatcher.Forms.Data;

namespace BudgetWatcher.Forms.List
{
    public partial class ListFrequenciesForm : Form
    {
        List<ExpenseFrequency> m_Frequencies = new List<ExpenseFrequency>();

        public ListFrequenciesForm()
        {
            InitializeComponent();
        }

        private async void ListFrequenciesForm_Load(object sender, System.EventArgs e)
        {
            ControlBox = false;
            await Task.Run(() =>
            {
                using (TableIterator<ExpenseFrequency> it = new TableIterator<ExpenseFrequency>(ExpenseFrequency.TableName))
                {
                    while (it.HasNext())
                    {
                        ExpenseFrequency frequency = it.Value;

                        m_Frequencies.Add(frequency);

                        if (FrequenciesGridView.IsHandleCreated)
                            FrequenciesGridView.Invoke(new Action(() => FrequenciesGridView.Rows.Add("modifică", "șterge", frequency.Id, frequency.Name, frequency.Days)));

                        it.MoveNext();
                    }
                }
            });
            ControlBox = true;
        }

        private void FrequenciesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            ExpenseFrequency currentFrequency = m_Frequencies[e.RowIndex];

            switch (e.ColumnIndex)
            {
                case 0:
                    FrequencyForm form = new FrequencyForm();
                    form.SetDefaultFormProperties("Modifică frecvența", currentFrequency);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        form.FillInData(currentFrequency);
                        currentFrequency.Update();

                        DataGridViewCellCollection cells = FrequenciesGridView.Rows[e.RowIndex].Cells;
                        cells[2].Value = currentFrequency.Id;
                        cells[3].Value = currentFrequency.Name;
                        cells[4].Value = currentFrequency.Days;

                        Utils.ShowInfoMessageBox("Frecvență modificată cu succes!");
                    }
                    return;
                case 1:
                    if (Utils.ShowQuestionBox("Sigur doriți să ștergeți frecvența?") == DialogResult.Yes)
                    {
                        currentFrequency.Delete();
                        m_Frequencies.RemoveAt(e.RowIndex);
                        FrequenciesGridView.Rows.RemoveAt(e.RowIndex);
                    }
                    return;
            }
        }
    }
}
