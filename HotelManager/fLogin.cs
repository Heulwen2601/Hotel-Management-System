using HotelManager.DAO;
using System;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        public bool Login()
        {
            return AccountDAO.Instance.Login(txbIDCardSearch.Text, txbPassWord.Text);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (Login())
            {
                this.Hide();
                fManagement f = new fManagement(txbIDCardSearch.Text);
                f.ShowDialog();

                //txbUserName.Text = String.Empty;
                //txbPassWord.Text = String.Empty;
                //txbUserName.Focus();

            }
            else
            {
                MessageBox.Show( "Tên Đăng Nhập không tồn tại hoặc Mật Khẩu không đúng.\nVui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin_Click_1(sender, null);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
