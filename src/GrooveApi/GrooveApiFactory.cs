using Refit;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

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
                }, 
                new RefitSettings
                {
                    JsonSerializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new SnakeCase.JsonNet.SnakeCaseContractResolver(),
                        Converters = { new StringEnumConverter() }
                    }
                });
        }

        // TODO: external GrooveApi token and refresh for customers
    } 
}