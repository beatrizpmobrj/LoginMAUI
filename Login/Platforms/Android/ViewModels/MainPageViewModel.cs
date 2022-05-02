using Login.Platforms.Android.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Login.Platforms.Android.ViewModels
{
    public class MainPageViewModel
    {
        private readonly IGoogleManager _googleManager;
        public ICommand Login { get; private set; }

        public MainPageViewModel()
        {
            _googleManager = DependencyService.Get<IGoogleManager>();
            Login = new Command(GoogleLogin);
        }

        private void GoogleLogin()
        {
            _googleManager.Login();
        }
    }
}
