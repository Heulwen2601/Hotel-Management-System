﻿using HotelManager.DAO;
using HotelManager.DTO;
using System;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fProfile : Form
    {
        public fProfile(string userName)
        {
            InitializeComponent();
            LoadProfile(userName);
        }
        string Password;
        public void LoadProfile(string username)
        {
            Account staff = AccountDAO.Instance.LoadStaffInforByUserName(username);
            lblUserName.Text = txbUserName.Text = staff.UserName;
            lblDisplayName.Text = txbDisplayName.Text = staff.DisplayName;
            txbStaffType.Text = AccountTypeDAO.Instance.GetStaffTypeByUserName(username).Name;
            txbIDCard.Text = staff.IdCard.ToString();
            txbPhoneNumber.Text = staff.PhoneNumber.ToString();
            txbAddress.Text = staff.Address;
            dpkDateOfBirth.Value = staff.DateOfBirth;
            cbSex.Text = staff.Sex;
            txbStartDay.Text = staff.StartDay.ToShortDateString();
            Password = staff.PassWord;
        }
        public void UpdateDisplayName(string username, string displayname)
        {
            AccountDAO.Instance.UpdateDisplayName(username, displayname);
        }
        public void UpdatePassword(string username, string password)
        {
            AccountDAO.Instance.UpdatePassword(username, password);
        }
        public void UpdateInfo(string username, string address, int phonenumber,string idCard, DateTime dateOfBirth, string sex)
        {
            AccountDAO.Instance.UpdateInfo(username, address, phonenumber,idCard,dateOfBirth,sex);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if(txbDisplayName.Text!=String.Empty)
            {
                UpdateDisplayName(txbUserName.Text, txbDisplayName.Text);
                MessageBox.Show( "Cập nhật thông tin tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProfile(txbUserName.Text);
            }
            else
                MessageBox.Show( "Tên hiển thị không hợp lệ.\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.HashPass(txbPass.Text) == Password && txbNewPass.Text != String.Empty && txbReNewPass.Text != String.Empty)
            {
                if(txbNewPass.Text==txbReNewPass.Text)
                {
                    if(txbNewPass.Text.Length >= 8) {
                        UpdatePassword(txbUserName.Text, txbNewPass.Text);
                        MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbPass.Text = txbNewPass.Text = txbReNewPass.Text = String.Empty;
                        LoadProfile(txbUserName.Text);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không hợp lệ.\nVui lòng nhập lại mật khẩu mới có độ dài ít nhất 8 kí tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show( "Mật khẩu mới không giống nhau.\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbNewPass.Text = txbReNewPass.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show( "Mật khẩu không hợp lệ.\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPass.Text = txbNewPass.Text = txbReNewPass.Text = String.Empty;
            }   
        }
        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            if (txbAddress.Text != String.Empty && txbPhoneNumber.Text != String.Empty && cbSex.Text != string.Empty && dpkDateOfBirth.Value < DateTime.Now.Date)
            {
                if (AccountDAO.Instance.IsIdCardExists(txbIDCard.Text) && (txbIDCard.Text.Length == 9 || txbIDCard.Text.Length == 12))
                {
                    UpdateInfo(txbUserName.Text, txbAddress.Text, int.Parse(txbPhoneNumber.Text), txbIDCard.Text, dpkDateOfBirth.Value, cbSex.Text);
                    MessageBox.Show("Cập nhật thông tin cơ bản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProfile(txbUserName.Text);
                }
                else
                    MessageBox.Show("CMND/CCCD không tồn tại hoặc nhập vào không đúng.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Thông tin cơ bản không hợp lệ.\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnClose__Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
