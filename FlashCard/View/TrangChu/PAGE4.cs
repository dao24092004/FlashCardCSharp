using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using GTranslate;
using GTranslate.Translators;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard.View.TrangChu
{
    public partial class PAGE4 : UserControl
    {
        public PAGE4()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BorderStyle = BorderStyle.None;
        }

        // mặc định là dịch từ tiếng việt sang tiếng anh
        string targetLanguage = "en"; // Tiếng anh
        string sourceLanguage = "vi"; //nguồn tiếng viết

        List<Vocabulary> data = new List<Vocabulary> { };

        private async void Dich_Click(object sender, EventArgs e)
        {
            try
            {
                string textToTranslate = txtInput.Text;
                var translator = new GoogleTranslator();
                var translationResult = await translator.TranslateAsync(textToTranslate, targetLanguage, sourceLanguage);

                txtOutput.Text = translationResult.Translation;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // chuyển đổi dịch từ tiếng anh sang tiếng việt
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            if (selectedIndex == 0)
            {
                targetLanguage = "en";
                sourceLanguage = "vi";
            }
            else if (selectedIndex == 1)
            {
                targetLanguage = "vi";
                sourceLanguage = "en";
            }
        }

        private class Vocabulary
        {
            //public string IdUser { get; set; }
            public string Word { get; set; }
            public string Meaning { get; set; }
        }


        private void Luu_Click(object sender, EventArgs e)
        {
            string word = txtInput.Text;
            string meaning = txtOutput.Text;

            if (string.IsNullOrWhiteSpace(word) || string.IsNullOrWhiteSpace(meaning))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ từ và nghĩa.");
                return;
            }

            bool targetEn = data.Any(v => v.Word.Equals(word, StringComparison.OrdinalIgnoreCase));
            bool targetVi = data.Any(v => v.Meaning.Equals(word, StringComparison.OrdinalIgnoreCase));

            if (targetLanguage == "en")
            {
                if (!targetEn)
                {
                    data.Add(new Vocabulary { Word = meaning, Meaning = word });
                }
                else
                {
                    MessageBox.Show("Từ này đã tồn tại!");
                }
            }
            else
            {
                if (!targetVi)
                {
                    data.Add(new Vocabulary { Word = word, Meaning = meaning });
                }
                else
                {
                    MessageBox.Show("Từ này đã tồn tại!");
                }
            }
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void LoadData()
        {
            foreach (var item in data)
            {
                dataGridView1.Rows.Add(item.Word, item.Meaning);
            }
        }
    }
}
