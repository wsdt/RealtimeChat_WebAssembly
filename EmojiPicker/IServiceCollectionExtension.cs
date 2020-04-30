using Microsoft.Extensions.DependencyInjection;
using System;
using Blazor.FileReader;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Linq;

namespace EmojiPicker
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddEmojiPicker(this IServiceCollection services)
        {
            // Filereader - Image uploads etc.
            services.AddFileReaderService();
            services.AddServerSideBlazor().AddHubOptions(opts =>
            {
                opts.MaximumReceiveMessageSize = 10 * 1024 * 1024; // 10MB
            });

            // Server Side Blazor doesn't register HttpClient by default
            if (!services.Any(x => x.ServiceType == typeof(HttpClient)))
            {
                // Setup HttpClient for server side in a client side compatible fashion
                services.AddScoped<HttpClient>(s =>
                {
                    // Creating the URI helper needs to wait until the JS Runtime is initialized, so defer it.
                    var uriHelper = s.GetRequiredService<NavigationManager>();
                    return new HttpClient
                    {
                        BaseAddress = new Uri(uriHelper.BaseUri)
                    };
                });
            }
            return services;
        }
    }
}
