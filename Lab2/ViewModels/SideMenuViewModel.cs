using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Lab2.ViewModels
{
    class SideMenuViewModel : INotifyPropertyChanged
    {

        #region Binding Props
        public PersonPropertyName PersonPropertyName
        {
            get => _personPropertyName;
            set
            {
                if(_personPropertyName != value)
                {
                    _personPropertyName = value;
                    OnPropertyChanged();
                }
            }
        }


        ICommand _sortCommand;
        PersonPropertyName _personPropertyName;

        #endregion
        
        

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
