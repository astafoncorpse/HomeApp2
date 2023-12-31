﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp2.Pages
{

    public partial class LoginPage : ContentPage
    {
        // Константа для текста кнопки
        public const string BUTTON_TEXT = "Войти";
        // Переменная счетчика
        public static int loginCouner = 0;

        public LoginPage()
        {
            InitializeComponent();
            // Изменяем внешний вид кнопки для Windows-версии
            if (Device.RuntimePlatform == Device.UWP)
                loginButton.CornerRadius = 0;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (loginCouner == 0)
            {
                loginButton.Text = $"Выполняется вход..";
            }
            else if (loginCouner > 5)
            {
                loginButton.IsEnabled = false;

                // Получаем последний дочерний элемент, используя свойство Children, затем выполняем распаковку
                var infoMessage = (Label)stackLayout.Children.Last();
                // Задаем текст элемента
                infoMessage.Text = "Слишком много попыток! Попробуйте позже";
                infoMessage.TextColor = Color.FromRgb(255, 0, 0);

            }
            else
            {
                loginButton.Text = $"Выполняется вход...   Попыток входа: {loginCouner}";
            }

            loginCouner += 1;
        }
    }
}