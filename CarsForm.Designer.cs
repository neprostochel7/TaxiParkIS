namespace TaxiParkIS
{
    partial class CarsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvCars;
        private Panel pnlButtons;
        private Button btnAdd, btnEdit, btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvCars = new DataGridView();
            pnlButtons = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            // dgvCars — Anchor на все стороны = масштабирование (требование задания)
            dgvCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.AllowUserToAddRows = false;
            dgvCars.ReadOnly = true;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Location = new Point(12, 12);
            dgvCars.Name = "dgvCars";
            dgvCars.Size = new Size(776, 500);
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Марка", Name = "colBrand" });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Модель", Name = "colModel" });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Госномер", Name = "colPlate" });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Год выпуска", Name = "colYear" });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Статус", Name = "colStatus" });

            // pnlButtons
            pnlButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlButtons.Location = new Point(12, 518);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(776, 50);

            btnAdd.Text = "Добавить"; btnAdd.Location = new Point(10, 10); btnAdd.Size = new Size(100, 30);
            btnEdit.Text = "Редактировать"; btnEdit.Location = new Point(120, 10); btnEdit.Size = new Size(110, 30);
            btnDelete.Text = "Удалить"; btnDelete.Location = new Point(240, 10); btnDelete.Size = new Size(100, 30);
            btnAdd.Click += (s, e) => ShowStub("Добавление автомобиля");
            btnEdit.Click += (s, e) => ShowStub("Редактирование автомобиля");
            btnDelete.Click += (s, e) => ShowStub("Удаление автомобиля");

            pnlButtons.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete });

            // CarsForm
            ClientSize = new Size(800, 580);
            MinimumSize = new Size(600, 400);
            Controls.Add(pnlButtons);
            Controls.Add(dgvCars);
            Name = "CarsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Справочник «Автомобили» — ИС Таксопарка";
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}