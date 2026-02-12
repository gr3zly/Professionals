using System;
using System.Windows.Forms;

namespace Sorbent
{
    public partial class ucMonitoring : UserControl
    {
        public ucMonitoring()
        {
            InitializeComponent();

            // Пример заполнения таблицы при открытии
            dgvEvents.Columns.Add("Время", "Время");
            dgvEvents.Columns.Add("Событие", "Событие");
            dgvEvents.Columns.Add("Статус", "Статус");

            dgvEvents.Rows.Add("14:32", "Превышение давления в линии 3", "Критично");
            dgvEvents.Rows.Add("14:15", "Температура в норме", "Норма");
            dgvEvents.Rows.Add("13:58", "Поступила партия респираторов", "Инфо");
        }

        private void btnJournal_Click(object sender, EventArgs e)
        {

        }
    }
}