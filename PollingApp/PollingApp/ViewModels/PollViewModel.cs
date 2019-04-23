using Xamarin.Forms;

namespace PollingApp.ViewModels
{
    public class PollViewModel: BindableObject
    {
        private readonly IDatabase database;
        private Poll poll;

        public PollViewModel()
        {
            database = DependencyService.Get<IDatabase>();

        }
        
        public Polls[] Poll { get; }

        public Poll CurrentPoll
        {
            get { return CurrentPoll; }
            set
            {
                CurrentPoll = value;
                OnPropertyChanged();
            }
        }


    }
}