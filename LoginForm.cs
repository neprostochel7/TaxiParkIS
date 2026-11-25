using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TaxiParkIS.Models;

namespace TaxiParkIS
{
    public partial class LoginForm : Form
    {
        public User? CurrentUser { get; private set; }

        private int failedAttempts = 0;
        private int captchaErrors = 0;
        private int correctOrderIndex = 0;
        private string correctOrder = "TAXI";

        private Button[] captchaButtons = new Button[4];
        private Label lblCaptchaStatus;

        public LoginForm()
        {
            InitializeComponent();
            BuildCaptcha();
            txtLogin.Focus();
        }

        private void BuildCaptcha()
        {
            lblCaptchaStatus = new Label
            {
                Text = "Нажмите кнопки по порядку: T → A → X → I",
                Location = new Point(20, 20),
                Size = new Size(320, 20),
                AutoSize = false
            };
            pnlCaptcha.Controls.Add(lblCaptchaStatus);

            string[] letters = { "T", "A", "X", "I" };
            var shuffled = letters.OrderBy(x => Guid.NewGuid()).ToArray();

            for (int i = 0; i < 4; i++)
            {
                captchaButtons[i] = new Button
                {
                    Text = shuffled[i],
                    Size = new Size(70, 70),
                    Location = new Point(20 + i * 80, 50),
                    Font = new Font("Arial", 24, FontStyle.Bold),
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat
                };
                captchaButtons[i].Click += CaptchaButton_Click;
                pnlCaptcha.Controls.Add(captchaButtons[i]);
            }
        }

        private void CaptchaButton_Click(object? sender, EventArgs e)
        {
            var btn = (Button)sender!;
            char expected = correctOrder[correctOrderIndex];

            if (btn.Text[0] == expected)
            {
                btn.BackColor = Color.LightGreen;
                btn.Enabled = false;
                correctOrderIndex++;

                if (correctOrderIndex == correctOrder.Length)
                {
                    lblCaptchaStatus.Text = "Пазл собран верно. Нажмите «Войти».";
                    lblCaptchaStatus.ForeColor = Color.Green;
                }
            }
            else
            {
                captchaErrors++;
                lblCaptchaStatus.Text = $"Неверно! Попытка {captchaErrors}/3. Нажмите «Перемешать».";
                lblCaptchaStatus.ForeColor = Color.Red;

                if (captchaErrors >= 3)
                {
                    BlockCurrentUser();
                    lblCaptchaStatus.Text = "Вы заблокированы. Обратитесь к администратору.";
                    btnLogin.Enabled = false;
                }
            }
        }

        private void btnShuffle_Click(object? sender, EventArgs e)
        {
            correctOrderIndex = 0;
            lblCaptchaStatus.Text = "Нажмите кнопки по порядку: T → A → X → I";
            lblCaptchaStatus.ForeColor = Color.Black;

            string[] letters = { "T", "A", "X", "I" };
            var shuffled = letters.OrderBy(x => Guid.NewGuid()).ToArray();

            for (int i = 0; i < 4; i++)
            {
                captchaButtons[i].Text = shuffled[i];
                captchaButtons[i].BackColor = Color.LightBlue;
                captchaButtons[i].Enabled = true;
            }
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                ShowError("Заполните логин и пароль — оба поля обязательны.");
                return;
            }

            var user = UserRepository.Users.FirstOrDefault(u => u.Login == login);
            if (user != null && user.IsBlocked)
            {
                ShowError("Вы заблокированы. Обратитесь к администратору.");
                return;
            }

            var found = UserRepository.Find(login, password);
            if (found == null)
            {
                failedAttempts++;
                if (failedAttempts >= 3)
                {
                    if (user != null) user.IsBlocked = true;
                    ShowError("Вы заблокированы. Обратитесь к администратору.");
                    btnLogin.Enabled = false;
                }
                else
                {
                    ShowError($"Вы ввели неверный логин или пароль. Пожалуйста, проверьте ещё раз введенные данные. (попытка {failedAttempts}/3)");
                }
                return;
            }

            if (found.Role == "Пользователь")
            {
                pnlCaptcha.Visible = true;
                if (correctOrderIndex != correctOrder.Length)
                {
                    ShowError("Сначала соберите капчу (нажмите T → A → X → I).");
                    return;
                }
            }

            CurrentUser = found;
            MessageBox.Show("Вы успешно авторизовались.", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BlockCurrentUser()
        {
            var user = UserRepository.Users.FirstOrDefault(u => u.Login == txtLogin.Text.Trim());
            if (user != null) user.IsBlocked = true;
            btnLogin.Enabled = false;
        }

        private void ShowError(string text)
        {
            lblMessage.ForeColor = Color.Firebrick;
            lblMessage.Text = text;
        }
    }
}
