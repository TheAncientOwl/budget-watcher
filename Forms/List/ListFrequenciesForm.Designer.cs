﻿namespace BudgetWatcher.Forms.List
{
    partial class ListFrequenciesForm
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
            this.FrequenciesGridView = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FrequenciesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FrequenciesGridView
            // 
            this.FrequenciesGridView.AllowUserToAddRows = false;
            this.FrequenciesGridView.AllowUserToDeleteRows = false;
            this.FrequenciesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.FrequenciesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FrequenciesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FrequenciesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditButton,
            this.ID,
            this.Name_,
            this.Days});
            this.FrequenciesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrequenciesGridView.Location = new System.Drawing.Point(0, 0);
            this.FrequenciesGridView.Name = "FrequenciesGridView";
            this.FrequenciesGridView.ReadOnly = true;
            this.FrequenciesGridView.RowHeadersWidth = 51;
            this.FrequenciesGridView.RowTemplate.Height = 24;
            this.FrequenciesGridView.Size = new System.Drawing.Size(800, 450);
            this.FrequenciesGridView.TabIndex = 2;
            this.FrequenciesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FrequenciesGridView_CellContentClick);
            // 
            // EditButton
            // 
            this.EditButton.HeaderText = "Modifică";
            this.EditButton.MinimumWidth = 6;
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Width = 55;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 55;
            // 
            // Name_
            // 
            this.Name_.HeaderText = "Denumire";
            this.Name_.MinimumWidth = 6;
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            this.Name_.Width = 150;
            // 
            // Days
            // 
            this.Days.HeaderText = "Perioada (zile)";
            this.Days.MinimumWidth = 6;
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            this.Days.Width = 125;
            // 
            // ListFrequenciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FrequenciesGridView);
            this.Name = "ListFrequenciesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frecvențe de cheltuieli";
            ((System.ComponentModel.ISupportInitialize)(this.FrequenciesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FrequenciesGridView;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
    }
}