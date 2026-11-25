namespace TaxiParkIS
{
    partial class TripsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvTrips;
        private Panel pnlButtons;
        private Button btnCreate, btnView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvTrips = new DataGridView();
            pnlButtons = new Panel();
            btnCreate = new Button(); btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTrips).BeginInit();
            pnlButtons.SuspendLayout(); SuspendLayout();

            dgvTrips.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrips.AllowUserToAddRows = false; dgvTrips.ReadOnly = true;
            dgvTrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrips.Location = new Point(12, 12); dgvTrips.Name = "dgvTrips";
            dgvTrips.Size = new Size(876, 500);
            dgvTrips.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Дата" });
            dgvTrips.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Клиент" });
            dgvTrips.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Адрес подачи" });
            dgvTrips.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Адрес назначения" });
            dgvTrips.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Водитель" });
            dgvTrips.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Стоимость" });
            dgvTrips.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Статус" });

            pnlButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlButtons.Location = new Point(12, 518); pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(876, 50);
            btnCreate.Text = "Создать поездку"; btnCreate.Location = new Point(10, 10); btnCreate.Size = new Size(140, 30);
            btnView.Text = "Обновить список"; btnView.Location = new Point(160, 10); btnView.Size = new Size(140, 30);
            btnCreate.Click += (s, e) => ShowStub("Создание поездки");
            btnView.Click += (s, e) => ShowStub("Обновление списка");
            pnlButtons.Controls.AddRange(new Control[] { btnCreate, btnView });

            ClientSize = new Size(900, 580); MinimumSize = new Size(700, 400);
            Controls.Add(pnlButtons); Controls.Add(dgvTrips);
            Name = "TripsForm"; StartPosition = FormStartPosition.CenterParent;
            Text = "Поездки — ИС Таксопарка";
            ((System.ComponentModel.ISupportInitialize)dgvTrips).EndInit();
            pnlButtons.ResumeLayout(false); ResumeLayout(false);
        }
    }
}