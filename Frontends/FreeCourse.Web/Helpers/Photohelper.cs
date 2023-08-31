using FreeCourse.Web.Models;
using Microsoft.Extensions.Options;

namespace FreeCourse.Web.Helpers
{
    public class Photohelper
    {

        private readonly ServiceApiSettings _serviceApiSettings;

        public Photohelper(IOptions<ServiceApiSettings> serviceApiSettings)
        {
            _serviceApiSettings = serviceApiSettings.Value;
        }

        public string GetPhotoStockUrl(string photoUrl)
        {
            return $"{_serviceApiSettings.PhotoStockUri}/photos/{photoUrl}";
        }

    }
}
