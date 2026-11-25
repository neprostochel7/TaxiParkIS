namespace TaxiParkIS
{
    partial class ClientsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvClients;
        private Panel pnlButtons;
        private Button btnAdd, btnEdit, btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvClients = new DataGridView();
            pnlButtons = new Panel();
            btnAdd = new Button(); btnEdit = new Button(); btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            pnlButtons.SuspendLayout(); SuspendLayout();

            dgvClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.AllowUserToAddRows = false; dgvClients.ReadOnly = true;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Location = new Point(12, 12); dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(776, 500);
            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ФИО" });
            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Телефон" });

            pnlButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlButtons.Location = new Point(12, 518); pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(776, 50);
            btnAdd.Text = "Добавить"; btnAdd.Location = new Point(10, 10); btnAdd.Size = new Size(100, 30);
            btnEdit.Text = "Редактировать"; btnEdit.Location = new Point(120, 10); btnEdit.Size = new Size(110, 30);
            btnDelete.Text = "Удалить"; btnDelete.Location = new Point(240, 10); btnDelete.Size = new Size(100, 30);
            btnAdd.Click += (s, e) => ShowStub("Добавление клиента");
            btnEdit.Click += (s, e) => ShowStub("Редактирование клиента");
            btnDelete.Click += (s, e) => ShowStub("Удаление клиента");
            pnlButtons.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete });

            ClientSize = new Size(800, 580); MinimumSize = new Size(600, 400);
            Controls.Add(pnlButtons); Controls.Add(dgvClients);
            Name = "ClientsForm"; StartPosition = FormStartPosition.CenterParent;
            Text = "Справочник «Клиенты» — ИС Таксопарка";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            pnlButtons.ResumeLayout(false); ResumeLayout(false);
        }
    }
}