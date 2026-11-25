namespace TaxiParkIS
{
    public partial class TripsForm : Form
    {
        public TripsForm() => InitializeComponent();
        private void ShowStub(string action) =>
            MessageBox.Show($"Действие «{action}» будет реализовано после подключения БД.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}