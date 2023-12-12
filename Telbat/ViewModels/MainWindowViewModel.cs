using System.Windows;
using System.Windows.Input;
using Telbat.Infrastructure.Commands;
using Telbat.ViewModels.Base;

namespace Telbat.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _title = "Гланое окно";

        /// <summary>
        /// заголовок окна
        /// </summary>
        public string Title 
        {
            get => _title;
            set => Set(ref _title, value);
        }

        #endregion

        #region команды

        #region команда закрыть

        public ICommand CloseAppCommand { get; }

        private bool CanCloseAppCommandExecuted(object p) => true;

        private void OnCloseAppCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion
        #endregion

        public MainWindowViewModel()
        {
            #region команды

            CloseAppCommand = new LambdaCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecuted);

            #endregion
        }
    }
}
