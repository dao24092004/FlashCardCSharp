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
    public partial class pnTuVung : UserControl
    {
        public pnTuVung()
        {
            InitializeComponent();
        }
        public void SetData(string word)
        {
            TuVung.Text = word;
        }
    }
}
