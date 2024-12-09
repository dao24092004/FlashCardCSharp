﻿namespace FlashCard.View.TrangChu
{
    partial class PAGE2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Word = new DataGridViewTextBoxColumn();
            Meaning = new DataGridViewTextBoxColumn();
            Topic = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Word, Meaning, Topic, Column1 });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(0, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(960, 251);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += DataGridView1_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Word
            // 
            Word.HeaderText = "Tu vung";
            Word.MinimumWidth = 6;
            Word.Name = "Word";
            Word.ReadOnly = true;
            // 
            // Meaning
            // 
            Meaning.HeaderText = "Nghia cua tu";
            Meaning.MinimumWidth = 6;
            Meaning.Name = "Meaning";
            Meaning.ReadOnly = true;
            // 
            // Topic
            // 
            Topic.HeaderText = "Chu de";
            Topic.MinimumWidth = 6;
            Topic.Name = "Topic";
            Topic.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Thao tac";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // PAGE2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "PAGE2";
            Size = new Size(960, 476);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Word;
        private DataGridViewTextBoxColumn Meaning;
        private DataGridViewTextBoxColumn Topic;
        private DataGridViewImageColumn Column1;
    }
}
