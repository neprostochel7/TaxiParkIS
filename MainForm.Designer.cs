namespace TaxiParkIS
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDictionaries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCars = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTariffs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWork = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrips = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuFile, this.mnuDictionaries, this.mnuWork, this.mnuAdmin });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1024, 24);

            // Файл
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuChangeUser, this.mnuExit });
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Text = "Файл";
            this.mnuChangeUser.Name = "mnuChangeUser";
            this.mnuChangeUser.Text = "Сменить пользователя";
            this.mnuChangeUser.Click += new System.EventHandler(this.mnuChangeUser_Click);
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);

            // Справочники
            this.mnuDictionaries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuCars, this.mnuDrivers, this.mnuClients, this.mnuTariffs });
            this.mnuDictionaries.Name = "mnuDictionaries";
            this.mnuDictionaries.Text = "Справочники";
            this.mnuCars.Name = "mnuCars";
            this.mnuCars.Text = "Автомобили";
            this.mnuCars.Click += (s, e) => OpenDialog(new CarsForm());
            this.mnuDrivers.Name = "mnuDrivers";
            this.mnuDrivers.Text = "Водители";
            this.mnuDrivers.Click += (s, e) => OpenDialog(new DriversForm());
            this.mnuClients.Name = "mnuClients";
            this.mnuClients.Text = "Клиенты";
            this.mnuClients.Click += (s, e) => OpenDialog(new ClientsForm());
            this.mnuTariffs.Name = "mnuTariffs";
            this.mnuTariffs.Text = "Тарифы";
            this.mnuTariffs.Click += (s, e) => OpenDialog(new TariffsForm());

            // Работа
            this.mnuWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuTrips });
            this.mnuWork.Name = "mnuWork";
            this.mnuWork.Text = "Работа";
            this.mnuTrips.Name = "mnuTrips";
            this.mnuTrips.Text = "Поездки";
            this.mnuTrips.Click += (s, e) => OpenDialog(new TripsForm());

            // Администрирование
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuUsers });
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Text = "Администрирование";
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Text = "Управление пользователями";
            this.mnuUsers.Click += (s, e) => OpenDialog(new UsersForm());

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusUser });
            this.statusStrip.Location = new System.Drawing.Point(0, 719);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1024, 22);

            // lblWelcome
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // MainForm
            this.ClientSize = new System.Drawing.Size(1024, 741);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИС Таксопарка — Управление заказами";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeUser;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDictionaries;
        private System.Windows.Forms.ToolStripMenuItem mnuCars;
        private System.Windows.Forms.ToolStripMenuItem mnuDrivers;
        private System.Windows.Forms.ToolStripMenuItem mnuClients;
        private System.Windows.Forms.ToolStripMenuItem mnuTariffs;
        private System.Windows.Forms.ToolStripMenuItem mnuWork;
        private System.Windows.Forms.ToolStripMenuItem mnuTrips;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuUsers;
        private System.Windows.Forms.Label lblWelcome;
    }
}