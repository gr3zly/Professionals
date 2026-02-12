using System;
using System.Windows.Forms;

namespace Sorbent
{
    public partial class ucPersonalCabinet : UserControl
    {
        public ucPersonalCabinet()
        {
            InitializeComponent();
        }

        // Пример метода заполнения данными (вызывать после загрузки)
        public void SetEmployeeData(
            string surname,
            string name,
            string patronymic,
            string position,
            string experience,
            string workshop,
            Image photo = null)
        {
            txtSurname.Text = surname ?? "";
            txtName.Text = name ?? "";
            txtPatronymic.Text = patronymic ?? "";
            txtPosition.Text = position ?? "";
            txtExperience.Text = experience ?? "";
            txtWorkshop.Text = workshop ?? "";

            if (photo != null)
                pbPhoto.Image = photo;
        }
    }
}
