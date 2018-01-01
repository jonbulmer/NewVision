using System.Net.Http;
using System.Threading.Tasks;

namespace ImageGallery.Client.Services
{
    public class IImageGaleryHttpClient
    {
        Task<HttpClient> GetClient();
    }
}
