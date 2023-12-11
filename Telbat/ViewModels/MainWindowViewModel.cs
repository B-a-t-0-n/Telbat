using Telbat.ViewModels.Base;

namespace Telbat.ViewModels
{
    internal class MainWindowViewModel : ViewModel
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
    }
}
