using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Extensions.Curency
{
    public class CurencyData
    {
        private readonly RequestDelegate requestDelegate;

        public CurencyData(RequestDelegate requestDelegate) 
        {
            this.requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext httpContext )
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=eur&to=try&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "a9e2308b7emsha7e499c9f2b4aacp11c1bcjsnd711f2798946" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }

            await requestDelegate.Invoke( httpContext );
        }
    }
}
