using System.ComponentModel;

namespace ViewModelToCustomControlBindingSample
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string titleVM;

        public MainWindowViewModel()
        {
            this.titleVM = "Default Title VM";
        }

        public string TitleVM
        {
            get { return titleVM; }
            set
            {
                titleVM = value;
                OnPropertyChanged(nameof(TitleVM));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
