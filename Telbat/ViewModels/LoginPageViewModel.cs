using System.Windows.Input;
using Telbat.Infrastructure.Commands;
using Telbat.ViewModels.Base;

namespace Telbat.ViewModels
{
    class LoginPageViewModel : ViewModel
    {
        #region команды

        #region команда открытия окна регистрации

        public ICommand OpenRegestrationWindowCommand { get; }

        private bool CanOpenRegestrationWindowCommandExecuted(object p) => true;

        private void OnOpenRegestrationWindowCommandExecuted(object p)
        {
            /*код открытия окна*/
        }

        #endregion

        #region команда входа

        public ICommand LogInCommand { get; }

        private bool CanLogInCommandExecuted(object p)
        {
            //проверка
            return true;
        }

        private void OnLogInCommandExecuted(object p)
        {
            /*код открытия окна*/
        }

        #endregion

        #endregion

        public LoginPageViewModel()
        {
            #region команды

            OpenRegestrationWindowCommand = new LambdaCommand(OnOpenRegestrationWindowCommandExecuted, CanOpenRegestrationWindowCommandExecuted);
            LogInCommand = new LambdaCommand(OnLogInCommandExecuted, CanLogInCommandExecuted);

            #endregion
        }
    }
}
