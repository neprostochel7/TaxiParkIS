namespace TaxiParkIS
{
    partial class DriversForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // dgvDrivers
            this.dgvDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Location = new System.Drawing.Point(12, 12);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.Size = new System.Drawing.Size(776, 500);
            this.dgvDrivers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "ФИО" });
            this.dgvDrivers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Номер ВУ" });
            this.dgvDrivers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Стаж" });
            this.dgvDrivers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Телефон" });
            this.dgvDrivers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Статус" });

            // pnlButtons
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Location = new System.Drawing.Point(12, 518);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(776, 50);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(10, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(120, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 30);
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(240, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnDelete);

            // DriversForm
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvDrivers);
            this.Name = "DriversForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник «Водители» — ИС Таксопарка";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}