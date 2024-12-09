using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FlashCard.Entity;
using FlashCard.Model;

namespace FlashCard.View.TrangChu
{
    public partial class ThongTinNguoiDung : UserControl
    {
        private readonly UserProfileService _userProfileService;
        private int _currentUserId = Form1.LoggedInUser.UserID; // Thay bằng ID người dùng hiện tại

        public ThongTinNguoiDung()
        {
            InitializeComponent();
            _userProfileService = new UserProfileService();
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            try
            {
                if (_currentUserId <= 0)
                {
                    throw new InvalidOperationException("Invalid user ID.");
                }

                var userProfile = _userProfileService.GetAllById(_currentUserId);
                if (userProfile != null)
                {
                    txtName.Text = userProfile.FullName ?? string.Empty;
                    txtPhone.Text = userProfile.Phone ?? string.Empty;
                    txtDiaChi.Text = userProfile.Address ?? string.Empty;
                    txtMoTa.Text = userProfile.Bio ?? string.Empty;

                    if (!string.IsNullOrEmpty(userProfile.ProfilePicture))
                    {
                        string absolutePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, userProfile.ProfilePicture);
                        if (File.Exists(absolutePath))
                        {
                            pictureBox1.Image = Image.FromFile(absolutePath);
                        }
                        else
                        {
                            MessageBox.Show("Ảnh đại diện không tồn tại.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin người dùng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUserProfile();
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png",
                Title = "Chọn ảnh đại diện"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string imageFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

                if (!Directory.Exists(imageFolderPath))
                {
                    Directory.CreateDirectory(imageFolderPath);
                }

                string fileName = Guid.NewGuid() + Path.GetExtension(selectedFilePath);
                string destinationPath = Path.Combine(imageFolderPath, fileName);

                using (Image originalImage = Image.FromFile(selectedFilePath))
                {
                    Image resizedImage = ResizeImage(originalImage, 150, 150);
                    resizedImage.Save(destinationPath);
                }

                string relativePath = Path.Combine("Images", fileName);
                pictureBox1.ImageLocation = relativePath;

                // Kiểm tra đường dẫn
                MessageBox.Show($"Ảnh đã lưu tại: {relativePath}");
            }
        }

        private void buttonChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Chọn ảnh đại diện";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh lên PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }


        private void SaveUserProfile()
        {
            try
            {
                var updatedProfile = new ModelUserProfile
                {
                    FullName = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtDiaChi.Text.Trim(),
                    Bio = txtMoTa.Text.Trim(),
                    ProfilePicture = pictureBox1.ImageLocation
                };

                if (_currentUserId <= 0)
                {
                    throw new InvalidOperationException("Invalid user ID.");
                }

                bool result = _userProfileService.SaveProfile(updatedProfile, _currentUserId);

                if (result)
                {
                    MessageBox.Show("Lưu thông tin thành công!");
                }
                else
                {
                    MessageBox.Show("Lưu thông tin thất bại. Không có bản ghi nào được cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thông tin: {ex.Message}");
            }
        }


    }
}
