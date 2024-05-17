﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace bm_shop
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class CategoryPage : Page
    {
        public CategoryPage()
        {
            this.InitializeComponent();
        }

        public static string CategoryName;

        //Обработчик кнопки грунтовки
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            CategoryName = btn.Content.ToString();
            Frame.Navigate(typeof(CatalogPage));
        }
    }
}