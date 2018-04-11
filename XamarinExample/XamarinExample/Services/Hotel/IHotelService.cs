using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinExample.Services.Hotel
{
    public interface IHotelService
    {
        Task<IEnumerable<Models.Hotel>> SearchAsync(int cityId);

        Task<IEnumerable<Models.Hotel>> SearchAsync(int cityId, int rating, int minPrice, int maxPrice);

        Task<IEnumerable<Models.Hotel>> GetMostVisitedAsync();

        Task<Models.Hotel> GetHotelByIdAsync(int id);

        Task<IEnumerable<Models.Service>> GetHotelServiceAsync();

        Task<IEnumerable<Models.Service>> GetRoomServicesAsync();

    }
}
