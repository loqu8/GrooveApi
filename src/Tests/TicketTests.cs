﻿using GrooveApi;
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
        public async Task CanCreateTicket()
        {
            var ticket = await api.CreateTicket(new TicketRequest()
            {
                To = "support@loqu8.com",
                Email = "torque@gmail.com",
                Name = "Tim Uy",
                Subject = "GrooveApi",
                Body = "Checking to see if this works."
            });

            Assert.IsNotNull(ticket);
        }
    }
}