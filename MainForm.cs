using System;
using System.Windows.Forms;
using TaxiParkIS.Models;

namespace TaxiParkIS
{
    public partial class MainForm : Form
    {
        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            UpdateUi();
        }

        private void UpdateUi()
        {
            lblStatusUser.Text = $"Вы вошли как: {currentUser.Login} (роль: {currentUser.Role})";
            lblWelcome.Text = $"Добро пожаловать, {currentUser.Login}!\nВыберите раздел в меню выше.";
            mnuAdmin.Visible = currentUser.Role == "Администратор";
        }

        private void OpenDialog(Form form) => form.ShowDialog(this);

        private void mnuChangeUser_Click(object? sender, EventArgs e)
        {
            Hide();
            using LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK && login.CurrentUser != null)
            {
                currentUser = login.CurrentUser;
                UpdateUi();
                Show();
            }
            else
            {
                Close();
            }
        }

        private void mnuExit_Click(object? sender, EventArgs e) => Close();
    }
}