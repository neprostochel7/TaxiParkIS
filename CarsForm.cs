namespace TaxiParkIS
{
    public partial class CarsForm : Form
    {
        public CarsForm() => InitializeComponent();

        // Пока БД не разрабатывается — данные не вводятся (требование задания)
        private void ShowStub(string action) =>
            MessageBox.Show($"Действие «{action}» будет реализовано после подключения БД.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}