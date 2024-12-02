

namespace FlashCard.View.DangNhap
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var loginForm = new frmLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    var user = loginForm.user; // Lấy thông tin User từ loginForm

                    // Truyền thông tin User sang Form1
                    var mainForm = new FlashCard.View.TrangChu.Form1(user);
                    Application.Run(mainForm);
                }
            }
        }
    }
}