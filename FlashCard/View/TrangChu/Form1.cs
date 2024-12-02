

using FlashCard.Entity;
using FlashCard.View.DangNhap;


namespace FlashCard.View.TrangChu
{
    public partial class Form1 : Form
    {
        public User LoggedInUser { get; private set; }


        public Form1(User user)
        {
            LoggedInUser = user; // Gán giá trị cho LoggedInUser
            InitializeComponent();

            // Các phần khởi tạo khác
            pagE11 = new PAGE1(LoggedInUser);
            pagE11.Location = new Point(250, 154);
            pagE11.Size = new Size(960, 473);
            Controls.Add(pagE11);

            

            SildePanel.Height = button1.Height;
            SildePanel.Top = button1.Top;
            pagE11.BringToFront();

            if (notifyIcon1 == null)
            {
                notifyIcon1 = new NotifyIcon(components);
                notifyIcon1.Icon = new Icon("your_icon_path.ico");
                notifyIcon1.Visible = true;
            }

            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Hiển thị tên người dùng trên button5 nếu LoggedInUser đã được gán
            if (LoggedInUser != null && !string.IsNullOrEmpty(LoggedInUser.UserName))
            {
                button5.Text = $"Tài khoản: {LoggedInUser.UserName}";
            }

            // Kiểm tra vai trò người dùng
            if (LoggedInUser != null && LoggedInUser.Role != "admin")
            {
                button7.Visible = false; // Ẩn button7 nếu không phải admin
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Hiển thị lại form đăng nhập
            frmLogin loginForm = new frmLogin();
            loginForm.Show();

            // Đóng form hiện tại
            this.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Trang chu
        private void button1_Click(object sender, EventArgs e)
        {
            SildePanel.Height = button1.Height;
            SildePanel.Top = button1.Top;
            pagE11.BringToFront();
        }
        //Quan ly the
        private void button2_Click(object sender, EventArgs e)
        {
            SildePanel.Height = button2.Height;
            SildePanel.Top = button2.Top;
            pagE21.BringToFront();
        }
        //Quang ly chu de
        private void button3_Click(object sender, EventArgs e)
        {
            SildePanel.Height = button3.Height;
            SildePanel.Top = button3.Top;
            pagE31.BringToFront();
        }
        //Dich nghia
        private void button4_Click(object sender, EventArgs e)
        {
            SildePanel.Height = button4.Height;
            SildePanel.Top = button4.Top;
            pagE41.BringToFront();
        }
        //Tai khoan
        private void button5_Click(object sender, EventArgs e)
        {
            SildePanel.Height = button5.Height;
            SildePanel.Top = button5.Top;
            pagE51.BringToFront();
        }
        //Thoat
        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //An
        private void An_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false; // Ẩn biểu tượng trên Taskbar
            this.Hide(); // Ẩn cửa sổ chính
            notifyIcon1.Visible = true; // Hiển thị biểu tượng System Tray
        }

        // Hiển thị lại form khi nhấn vào biểu tượng
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true; // Hiển thị lại biểu tượng trên Taskbar
            this.Show(); // Hiển thị lại cửa sổ chính
            notifyIcon1.Visible = false; // Ẩn biểu tượng System Tray

        }
        //Phóng to thu nhỏ 
        private void Room_Click(object sender, EventArgs e)
        {
            // Nếu cửa sổ đang ở trạng thái bình thường (không phóng to), thì phóng to
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Phóng to cửa sổ
            }
            else
            {
                this.WindowState = FormWindowState.Normal; // Thu nhỏ về kích thước ban đầu
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
