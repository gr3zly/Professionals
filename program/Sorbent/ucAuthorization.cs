using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sorbent
{
    public partial class ucAuthorization : UserControl
    {
        // Событие, которое будет вызываться при успешном входе
        public event EventHandler LoginSuccessful;

        public ucAuthorization()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Очень простая проверка (в реальном проекте так НЕ делают!)
            if (login == "admin" && password == "1234")
            {
                lblError.Visible = false;
                txtLogin.Clear();
                txtPassword.Clear();

                // Сообщаем главной форме, что вход успешен
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                lblError.Text = "Неверный логин или пароль";
                lblError.Visible = true;
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        // Опционально: вход по нажатию Enter в поле пароля
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();
                e.SuppressKeyPress = true; // чтобы не пищал
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
