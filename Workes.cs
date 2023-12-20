using System.Windows.Input;

namespace MaciApp;

public class Worker
{
        public event EventHandler<Worker> Clicked;
        public ICommand ClickedWorker { get; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
}