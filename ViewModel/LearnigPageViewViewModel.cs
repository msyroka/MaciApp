using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MaciApp.ViewModel
{

    public class LearnigPageViewViewModel : INotifyPropertyChanged
    {
        public ICommand ClickedWorker { get; }
        private List<Worker> workers; 
        public List<Worker> Workers
        {
            get => workers;
            set => SetProperty(ref workers, value);
        }

        public LearnigPageViewViewModel(ICommand clickedWorker)
        {
           
            ClickedWorker = new Command<Worker>(WorkerClicked);
            var list = new List<Worker>();
            var monkey = new Worker() {Name = "Orangutan"};
            list.Add(new Worker() {Name = "Maciek"});
            Workers = list;
        }

        private void WorkerClicked(Worker obj)
        {
            throw new NotImplementedException();
        }


        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }


        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

