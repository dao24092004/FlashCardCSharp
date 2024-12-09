namespace FlashCard.View.TrangChu
{
    partial class pnHinhAnh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnHinhAnh));
            labelTopic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)labelTopic).BeginInit();
            SuspendLayout();
            // 
            // labelTopic
            // 
            labelTopic.Image = (Image)resources.GetObject("labelTopic.Image");
            labelTopic.Location = new Point(256, 0);
            labelTopic.Margin = new Padding(3, 4, 3, 4);
            labelTopic.Name = "labelTopic";
            labelTopic.Size = new Size(449, 207);
            labelTopic.TabIndex = 1;
            labelTopic.TabStop = false;
            // 
            // pnHinhAnh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTopic);
            Name = "pnHinhAnh";
            Size = new Size(960, 207);
            ((System.ComponentModel.ISupportInitialize)labelTopic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox labelTopic;
    }
}
