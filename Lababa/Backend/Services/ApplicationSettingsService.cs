using Lababa.Backend.Models;
using Lababa.Backend.Repositories;

namespace Lababa.Backend.Services
{
    public class ApplicationSettingsService
    {
        private readonly ApplicationSettingsRepository _appSettingsRepository;

        public ApplicationSettingsService()
        {
            _appSettingsRepository = new ApplicationSettingsRepository();
        }

        public ApplicationSettings LoadSettings()
        {
            return _appSettingsRepository.LoadData();
        }

        public void SaveSettings(ApplicationSettings appSettings)
        {
            _appSettingsRepository.SaveData(appSettings);
        }
    }
}
