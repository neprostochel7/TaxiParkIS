using System;
using System.Windows.Forms;

namespace TaxiParkIS
{
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            ShowStub("Добавление водителя");
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            ShowStub("Редактирование водителя");
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            ShowStub("Удаление водителя");
        }

        private void ShowStub(string action)
        {
            MessageBox.Show($"Действие «{action}» будет реализовано после подключения БД.", 
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}