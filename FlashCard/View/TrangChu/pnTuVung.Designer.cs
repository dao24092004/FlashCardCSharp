namespace FlashCard.View.TrangChu
{
    partial class pnTuVung
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
            TuVung = new Label();
            SuspendLayout();
            // 
            // TuVung
            // 
            TuVung.AutoSize = true;
            TuVung.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TuVung.Location = new Point(410, 83);
            TuVung.Name = "TuVung";
            TuVung.Size = new Size(141, 41);
            TuVung.TabIndex = 1;
            TuVung.Text = "Từ Vựng";
            // 
            // pnTuVung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TuVung);
            Name = "pnTuVung";
            Size = new Size(960, 207);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TuVung;
    }
}
