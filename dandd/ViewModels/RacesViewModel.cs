using dandd.Models.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using dandd.Services;

namespace dandd.ViewModels
{
    internal partial class RacesViewModel : ObservableObject, IDisposable
    {
    


        private readonly RacesService _racesService;

        [ObservableProperty]
        public int _UserId;
        [ObservableProperty]
        public int _Id;
        [ObservableProperty]
        public string _Title;
        [ObservableProperty]
        public string _Body;
        //Uma coleção de Post
        [ObservableProperty]
        public ObservableCollection<Races> _races;

        public RacesViewModel()
        {

            Races = new ObservableCollection<Races>();
            _racesService = new RacesService();
        }
        public ICommand GetPostsCommand => new Command(async () => await LoadPostAsync());

        private async Task LoadPostAsync()
        {
            RacesViewModel = await _racesService.GetPostsAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

