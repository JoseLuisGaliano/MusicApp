using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MusicApp.Payment
{
    public class SubscriptionOption : INotifyPropertyChanged
    // La UI se actualizará automáticamente cuando cambien los valores de las propiedades gracias a INotifyPropertyChanged.
    {
        private string description = "$4.95/month"; // Valor inicial 
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
