using System;
using System.Windows.Forms;

namespace Sorbent
{
    public partial class MainForm : Form
    {
        private ucAuthorization ucAuth;
        private ucPersonalCabinet ucCabinet;
        private ucDashboard ucDash;
        private ucMonitoring ucMonitor;
        private ucTasks ucTasks;

        private UserControl currentScreen;        // ← для удобного переключения

        public MainForm()
        {
            InitializeComponent();

            ucAuth = new ucAuthorization { Dock = DockStyle.Fill };
            ucCabinet = new ucPersonalCabinet { Dock = DockStyle.Fill };
            ucDash = new ucDashboard { Dock = DockStyle.Fill };
            ucMonitor = new ucMonitoring { Dock = DockStyle.Fill };
            ucTasks = new ucTasks { Dock = DockStyle.Fill };

            // Подписываемся на событие успешного входа
            ucAuth.LoginSuccessful += ucAuth_LoginSuccessful;

            // Изначально показываем авторизацию
            ShowScreen(ucAuth);

            // Меню скрыто при запуске
            mainMenu.Visible = false;

            // Пример вызова (потом данные будут из базы)
            ucCabinet.SetEmployeeData(
                "Иванов",
                "Иван",
                "Иванович",
                "Упаковщик",
                "3 года 2 мес.",
                "Цех №4, участок сборки",
                // Image.FromFile("path/to/photo.jpg")  или null
                null
            );
        }

        // Универсальный метод переключения экранов
        private void ShowScreen(UserControl screen)
        {
            // Если текущий экран не тот, который мы хотим показать — убираем его
            if (currentScreen != null && currentScreen != screen)
            {
                panelContent.Controls.Remove(currentScreen);
                // НЕ вызываем Dispose() — контрол просто скрывается, а не уничтожается
            }

            // Добавляем нужный экран, если его ещё нет в панели
            if (!panelContent.Controls.Contains(screen))
            {
                panelContent.Controls.Add(screen);
            }

            // Поднимаем его наверх (чтобы точно был видимым)
            screen.BringToFront();

            currentScreen = screen;

            // Меню показываем только если это НЕ экран авторизации
            mainMenu.Visible = (screen != ucAuth);
        }

        private void ucAuth_LoginSuccessful(object sender, EventArgs e)
        {
            // Переключаемся на личный кабинет после успешного входа
            ShowScreen(ucCabinet);

            // Можно оставить приветствие, если хочешь
            // MessageBox.Show("Вход выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ────────────── Обработчики пунктов меню ──────────────

        private void miDashboard_Click(object sender, EventArgs e)
        {
            ShowScreen(ucDash);
        }

        private void miPersonalCabinet_Click(object sender, EventArgs e)
        {
            ShowScreen(ucCabinet);
        }

        private void miMonitoring_Click(object sender, EventArgs e)
        {
            ShowScreen(ucMonitor);
        }

        private void miTasks_Click(object sender, EventArgs e)
        {
            ShowScreen(ucTasks);
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти из программы?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Эти методы пока не нужны, но их можно оставить или удалить
        private void menuFile_Click(object sender, EventArgs e) { }
        private void menuNavigation_Click(object sender, EventArgs e) { }
        private void MainForm_Load(object sender, EventArgs e) { }
    }
}
