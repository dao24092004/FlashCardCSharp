using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard.View.TrangChu
{
    public partial class pnHinhAnh : UserControl
    {
        public pnHinhAnh()
        {
            InitializeComponent();
        }
        public void SetData(string topic)
        {
            labelTopic.Text = $"Chủ đề: {topic}";
        }
    }
}
