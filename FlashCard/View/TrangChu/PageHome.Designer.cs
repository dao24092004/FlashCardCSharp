namespace FlashCard.View.TrangChu
{
    partial class PageHome
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Word = new DataGridViewTextBoxColumn();
            Meaning = new DataGridViewTextBoxColumn();
            Topic = new DataGridViewTextBoxColumn();
            ThaoTac = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 217);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Word, Meaning, Topic, ThaoTac });
            dataGridView1.Location = new Point(3, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(954, 313);
            dataGridView1.TabIndex = 1;
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
            Word.HeaderText = "Tu Vung";
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
            // ThaoTac
            // 
            ThaoTac.HeaderText = "Thao Tac";
            ThaoTac.MinimumWidth = 6;
            ThaoTac.Name = "ThaoTac";
            ThaoTac.ReadOnly = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Home";
            Size = new Size(960, 476);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Word;
        private DataGridViewTextBoxColumn Meaning;
        private DataGridViewTextBoxColumn Topic;
        private DataGridViewTextBoxColumn ThaoTac;
    }
}
