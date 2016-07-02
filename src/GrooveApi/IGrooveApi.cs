using GrooveApi.Models;
using Refit;
using System.Threading.Tasks;

namespace GrooveApi
{
    public interface IGrooveApi
    {
        [Post("/tickets")]
        [Headers("Authorization: Bearer")]
        Task<Ticket> CreateTicket([Body(BodySerializationMethod.UrlEncoded)] TicketRequest ticket);
    }
}