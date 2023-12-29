using Telbat.ViewModels.Base;

namespace Telbat.ViewModels
{
    public class AuthorizationWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _title = "Вход";

        /// <summary>
        /// заголовок окна
        /// </summary>
        public string Title 
        {
            get => _title;
            set => Set(ref _title, value);
        }

        #endregion

        public AuthorizationWindowViewModel()
        {
            
        }
    }
}
