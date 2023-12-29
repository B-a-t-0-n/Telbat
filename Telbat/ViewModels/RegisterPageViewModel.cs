using System.Windows.Input;
using Telbat.Infrastructure.Commands;
using Telbat.ViewModels.Base;

namespace Telbat.ViewModels
{
    class RegisterPageViewModel : ViewModel
    {
        #region команды

        #region команда Зарегестрироваться

        public ICommand RegistrationCommand { get; }

        private bool CanRegistrationCommandExecuted(object p) => true;

        private void OnRegistrationCommandExecuted(object p)
        {
            /*код открытия окна*/
        }

        #endregion

        #region команда назад

        public ICommand BackWindowCommand { get; }

        private bool CanBackWindowCommandExecuted(object p)
        {
            //проверка
            return true;
        }

        private void OnBackWindowCommandExecuted(object p)
        {
            /*код открытия окна*/
        }

        #endregion

        #endregion

        public RegisterPageViewModel() 
        {
            #region команды

            RegistrationCommand = new LambdaCommand(OnRegistrationCommandExecuted, CanRegistrationCommandExecuted);
            BackWindowCommand = new LambdaCommand(OnBackWindowCommandExecuted, CanBackWindowCommandExecuted);

            #endregion
        }
    }
}
