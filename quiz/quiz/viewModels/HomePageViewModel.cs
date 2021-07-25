using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.pages;
using System.Windows.Controls;
namespace quiz.viewModels
{
    class HomePageViewModel:ViewModelBase
    {
        public RellayCommand StartCommand { get; }

        public HomePageViewModel()
        {
            StartCommand = new RellayCommand(Start);
        }
        private void Start(object obj)
        {
            App.startPage = new StartPage();
            App.MainWindowView.CurrentPage = App.startPage;
        }
    }
}
