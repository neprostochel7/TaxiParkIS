namespace TaxiParkIS
{
    partial class TariffsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvTariffs;
        private Panel pnlButtons;
        private Button btnAdd, btnEdit, btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvTariffs = new DataGridView();
            pnlButtons = new Panel();
            btnAdd = new Button(); btnEdit = new Button(); btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTariffs).BeginInit();
            pnlButtons.SuspendLayout(); SuspendLayout();

            dgvTariffs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTariffs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTariffs.AllowUserToAddRows = false; dgvTariffs.ReadOnly = true;
            dgvTariffs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTariffs.Location = new Point(12, 12); dgvTariffs.Name = "dgvTariffs";
            dgvTariffs.Size = new Size(776, 500);
            dgvTariffs.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Название" });
            dgvTariffs.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Стоимость" });

            pnlButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlButtons.Location = new Point(12, 518); pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(776, 50);
            btnAdd.Text = "Добавить"; btnAdd.Location = new Point(10, 10); btnAdd.Size = new Size(100, 30);
            btnEdit.Text = "Редактировать"; btnEdit.Location = new Point(120, 10); btnEdit.Size = new Size(110, 30);
            btnDelete.Text = "Удалить"; btnDelete.Location = new Point(240, 10); btnDelete.Size = new Size(100, 30);
            btnAdd.Click += (s, e) => ShowStub("Добавление тарифа");
            btnEdit.Click += (s, e) => ShowStub("Редактирование тарифа");
            btnDelete.Click += (s, e) => ShowStub("Удаление тарифа");
            pnlButtons.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete });

            ClientSize = new Size(800, 580); MinimumSize = new Size(600, 400);
            Controls.Add(pnlButtons); Controls.Add(dgvTariffs);
            Name = "TariffsForm"; StartPosition = FormStartPosition.CenterParent;
            Text = "Справочник «Тарифы» — ИС Таксопарка";
            ((System.ComponentModel.ISupportInitialize)dgvTariffs).EndInit();
            pnlButtons.ResumeLayout(false); ResumeLayout(false);
        }
    }
}