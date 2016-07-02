using Refit;
using System;
using System.Net.Http;

namespace GrooveApi
{
    public class GrooveApiFactory
    {
        public static IGrooveApi Create(string token)
        {
            return RestService.For<IGrooveApi>(
                new HttpClient(
                    new AuthenticatedHttpClientHandler(token))
                {
                    BaseAddress = new Uri("https://api.groovehq.com/v1")
                });
        }

        // TODO: external GrooveApi token and refresh for customers
    } 
}