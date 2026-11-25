using TaxiParkIS.Models;

namespace TaxiParkIS
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvUsers.Rows.Clear();
            foreach (var u in UserRepository.Users)
                dgvUsers.Rows.Add(u.Login, u.Role, u.IsBlocked ? "Заблокирован" : "Активен");
        }

        private void DgvUsers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string login = dgvUsers.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            var user = UserRepository.Users.FirstOrDefault(u => u.Login == login);
            if (user != null)
            {
                txtLogin.Text = user.Login;
                txtPassword.Text = user.Password;
                cmbRole.SelectedItem = user.Role;
            }
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString() ?? "Пользователь";

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин и пароль обязательны для заполнения.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserRepository.LoginExists(login))
            {
                MessageBox.Show($"Пользователь с логином «{login}» уже существует.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserRepository.Users.Add(new User { Login = login, Password = password, Role = role });
            RefreshGrid();
            MessageBox.Show("Пользователь добавлен.", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChange_Click(object? sender, EventArgs e)
        {
            var user = UserRepository.Users.FirstOrDefault(u => u.Login == txtLogin.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("Выберите пользователя в таблице.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtPassword.Text)) user.Password = txtPassword.Text;
            if (cmbRole.SelectedItem != null) user.Role = cmbRole.SelectedItem.ToString()!;
            RefreshGrid();
            MessageBox.Show("Данные пользователя изменены.", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUnblock_Click(object? sender, EventArgs e)
        {
            var user = UserRepository.Users.FirstOrDefault(u => u.Login == txtLogin.Text.Trim());
            if (user == null) return;
            if (!user.IsBlocked)
            {
                MessageBox.Show("Пользователь не заблокирован.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            user.IsBlocked = false;
            RefreshGrid();
            MessageBox.Show("Пользователь разблокирован.", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}