using GrooveApi;
using GrooveApi.Models;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    [Category("Tickets")]
    public class TicketTests
    {
        private IGrooveApi api = GrooveApiFactory.Create(Settings.Token);

        [Test]
        public async Task CanCreateSimpleTicket()
        {
            var ticket = await api.CreateTicket(new TicketRequest()
            {
                to = "support@loqu8.com",
                from = new Customer
                {
                    email = "sal@test.com",
                    name = "Sal",
                    about = "a good friend"
                },
                subject = "GrooveApi",
                body = "Checking to see if this works.",
            });

            Assert.IsNotNull(ticket);
        }
    }
}