using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using XfMvvmLnetStd.Interface;
using XfMvvmLnetStd.Model;

namespace XfMvvmLnetStd.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IPeopleService _peopleService;

        public ObservableCollection<Person> People { get; private set; }

        public MainViewModel(IPeopleService peopleService)
        {
            if (peopleService == null) throw new ArgumentNullException("peopleService");
            _peopleService = peopleService;
            Task.Run(() => Init());
        }

        public async Task Init()
        {
            if (People != null) return;

            People = new ObservableCollection<Person>(await _peopleService.GetPeople());
            RaisePropertyChanged(() => People);
        }
    }
}
