using System;
using System.Windows.Forms;

namespace Sorbent
{
    public partial class ucTasks : UserControl
    {
        public ucTasks()
        {
            InitializeComponent();

            // Настраиваем общие колонки для всех таблиц
            SetupGrid(dgvNew);
            SetupGrid(dgvInWork);
            SetupGrid(dgvCompleted);

            // Пример заполнения при открытии
            LoadExampleData();
        }

        private void SetupGrid(DataGridView grid)
        {
            grid.Columns.Add("ID", "№");
            grid.Columns.Add("Описание", "Задача");
            grid.Columns.Add("Сотрудник", "Исполнитель");
            grid.Columns.Add("Срок", "Срок");
            grid.Columns.Add("Приоритет", "Приоритет");

            grid.Columns["ID"].Width = 40;
            grid.Columns["Описание"].Width = 220;
            grid.Columns["Сотрудник"].Width = 120;
            grid.Columns["Срок"].Width = 100;
            grid.Columns["Приоритет"].Width = 80;

            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void LoadExampleData()
        {
            // Новые
            dgvNew.Rows.Add("T-045", "Провести поверку манометров на линии 2", "Иванов И.И.", "12.02 09:00", "Высокий");
            dgvNew.Rows.Add("T-046", "Заменить фильтры в системе вентиляции цеха №4", "Петров П.П.", "13.02", "Средний");

            // В работе
            dgvInWork.Rows.Add("T-038", "Согласовать новую партию респираторов", "Сидоров С.С.", "До 12.02", "Высокий");
            dgvInWork.Rows.Add("T-042", "Обучить 2-х сотрудников работе с новым СИЗОД", "Козлов К.К.", "В процессе", "Средний");

            // Завершённые
            dgvCompleted.Rows.Add("T-031", "Проведена инвентаризация СИЗОД", "Иванов И.И.", "10.02", "Низкий");
            dgvCompleted.Rows.Add("T-035", "Устранена утечка в линии подачи воздуха", "Петров П.П.", "09.02", "Высокий");
        }

        // Можно добавить обработчики кнопок позже
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Здесь будет реальное обновление из базы
            MessageBox.Show("Список задач обновлён (пока заглушка)");
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма создания новой задачи (пока заглушка)");
        }

        private void dgvCompleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}