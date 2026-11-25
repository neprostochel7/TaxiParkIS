namespace TaxiParkIS
{
    partial class UsersForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvUsers;
        private Panel pnlInput;
        private Label lblLogin, lblPassword, lblRole;
        private TextBox txtLogin, txtPassword;
        private ComboBox cmbRole;
        private Button btnAdd, btnChange, btnUnblock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvUsers = new DataGridView();
            pnlInput = new Panel();
            lblLogin = new Label(); lblPassword = new Label(); lblRole = new Label();
            txtLogin = new TextBox(); txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnAdd = new Button(); btnChange = new Button(); btnUnblock = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlInput.SuspendLayout(); SuspendLayout();

            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AllowUserToAddRows = false; dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Location = new Point(12, 12); dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(676, 350);
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Логин" });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Роль" });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Статус" });
            dgvUsers.CellClick += DgvUsers_CellClick;

            pnlInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInput.Location = new Point(12, 368); pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(676, 160);

            lblLogin.Text = "Логин:"; lblLogin.Location = new Point(10, 15);
            txtLogin.Location = new Point(110, 12); txtLogin.Size = new Size(150, 25);
            lblPassword.Text = "Пароль:"; lblPassword.Location = new Point(10, 50);
            txtPassword.Location = new Point(110, 47); txtPassword.Size = new Size(150, 25);
            lblRole.Text = "Роль:"; lblRole.Location = new Point(10, 85);
            cmbRole.Location = new Point(110, 82); cmbRole.Size = new Size(150, 25);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "Администратор", "Пользователь" });

            btnAdd.Text = "Добавить"; btnAdd.Location = new Point(300, 12); btnAdd.Size = new Size(120, 30);
            btnChange.Text = "Изменить"; btnChange.Location = new Point(300, 50); btnChange.Size = new Size(120, 30);
            btnUnblock.Text = "Разблокировать"; btnUnblock.Location = new Point(300, 88); btnUnblock.Size = new Size(120, 30);
            btnAdd.Click += btnAdd_Click;
            btnChange.Click += btnChange_Click;
            btnUnblock.Click += btnUnblock_Click;

            pnlInput.Controls.AddRange(new Control[] { lblLogin, txtLogin, lblPassword, txtPassword, lblRole, cmbRole, btnAdd, btnChange, btnUnblock });

            ClientSize = new Size(700, 540); MinimumSize = new Size(500, 400);
            Controls.Add(pnlInput); Controls.Add(dgvUsers);
            Name = "UsersForm"; StartPosition = FormStartPosition.CenterParent;
            Text = "Управление пользователями — ИС Таксопарка";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlInput.ResumeLayout(false); pnlInput.PerformLayout();
            ResumeLayout(false);
        }
    }
}