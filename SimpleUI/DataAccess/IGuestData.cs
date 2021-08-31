using Refit;
using SimpleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleUI.DataAccess
{
    public interface IGuestData
    {

        [Get("/Guests")]
        Task<List<GuestModel>> GetGuests();

        [Get("/Guests/{id}")]
        Task<GuestModel> GetGuest(string id);

        [Post("/Guests")]
        Task CreateGuest([Body] GuestModel guest);

        [Put("/Guests/{id}")]
        Task UpdateGuest(int id, [Body] GuestModel guest);

        [Delete("/Guests/{id}")]
        Task DeleteGuest(int id);
    }
}
