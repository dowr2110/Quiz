using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using quiz.viewModels;
using quiz.pages;

namespace quiz
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static MainWindowViewModel MainWindowView { get; set; } = new MainWindowViewModel();
        
        public static Page1 HomePage=new Page1();
        public static StartPage startPage;
    }
}
