using Lababa.Backend.Models;

namespace Lababa.Backend.Repositories
{
    public interface IApplicationSettingsRepostiory
    {
        ApplicationSettings LoadData();
        void SaveData(ApplicationSettings applicationSettings);

    }
}
