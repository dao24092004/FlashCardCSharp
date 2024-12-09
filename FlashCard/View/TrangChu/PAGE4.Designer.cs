namespace FlashCard.View.TrangChu
{
    partial class PAGE4
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
            comboBox1 = new ComboBox();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            label1 = new Label();
            Dich = new Button();
            Luu = new Button();
            dataGridView1 = new DataGridView();
            Word = new DataGridViewTextBoxColumn();
            Meaning = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dịch sang Tiếng Anh", "Dịch sang Tiếng Việt" });
            comboBox1.Location = new Point(356, 45);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Dịch sang Tiếng Anh";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(3, 91);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(460, 85);
            txtInput.TabIndex = 9;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Segoe UI", 9.75F);
            txtOutput.Location = new Point(483, 91);
            txtOutput.Margin = new Padding(3, 4, 3, 4);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(477, 85);
            txtOutput.TabIndex = 10;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(959, 41);
            label1.TabIndex = 11;
            label1.Text = "Google Translate Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dich
            // 
            Dich.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dich.Location = new Point(0, 190);
            Dich.Margin = new Padding(3, 4, 3, 4);
            Dich.Name = "Dich";
            Dich.Size = new Size(461, 49);
            Dich.TabIndex = 12;
            Dich.Text = "Dịch";
            Dich.UseVisualStyleBackColor = true;
            // 
            // Luu
            // 
            Luu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Luu.Location = new Point(483, 191);
            Luu.Margin = new Padding(3, 4, 3, 4);
            Luu.Name = "Luu";
            Luu.Size = new Size(478, 49);
            Luu.TabIndex = 13;
            Luu.Text = "Lưu Từ";
            Luu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Word, Meaning });
            dataGridView1.Cursor = Cursors.IBeam;
            dataGridView1.Location = new Point(-1, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(960, 219);
            dataGridView1.TabIndex = 14;
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
            // PAGE4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(Luu);
            Controls.Add(Dich);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(comboBox1);
            Name = "PAGE4";
            Size = new Size(960, 476);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Label label1;
        private Button Dich;
        private Button Luu;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Word;
        private DataGridViewTextBoxColumn Meaning;
    }
}
