using Lababa.Backend.Data;
using Lababa.Backend.Models;

namespace Lababa.Backend.Services
{
    public class ApplicationSettingsService
    {
        private readonly LababaDbContext _context;

        public ApplicationSettingsService(LababaDbContext context)
        {
            _context = context;
        }

        public ApplicationSettings LoadSettings()
        {
            return _context.AppSettings.Find(1);
        }

        public void SaveSettings(ApplicationSettings appSettings)
        {
            _context.AppSettings.Update(appSettings);
            _context.SaveChanges();
        }
    }
}
