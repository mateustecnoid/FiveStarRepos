using FiveStarRepos.Infra.Helper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using static FiveStarRepos.Infra.Data.Network.Configurations.CircuitBreakerPolicyConfiguration;

namespace FiveStarRepos.Infra.IoC.Extensions
{
    public static class RefitClientExtensions
    {
        public static IHttpClientBuilder AddRefit<T>(this IServiceCollection services, string apiName, IConfiguration configuration) where T : class
        {
            return services.AddRefitClient<T>()
             .ConfigureHttpClient(c =>
             {
                 c.BaseAddress = new Uri(configuration.GetValue<string>($"NetworkConfiguration:{apiName}:Uri"));
                 c.Timeout = TimeSpan.FromMilliseconds(configuration.GetValue<double>($"NetworkConfiguration:{apiName}:TimeoutMilliseconds"));
             }).SetHandlerLifetime(TimeSpan.FromHours(1));
        }

        public static IHttpClientBuilder AddRetryPolicy(this IHttpClientBuilder clientBuilder, IConfiguration configuration)
            => clientBuilder.AddPolicyHandler(RetryPolicyConfiguration.GetRetryPolicy(configuration));

        public static IHttpClientBuilder AddHeaders(this IHttpClientBuilder httpClientBuilder, string name, string values)
                    => httpClientBuilder.AddHeaders(name, new List<string>(1) { values });

        public static IHttpClientBuilder AddHeaders(this IHttpClientBuilder httpClientBuilder, string name, IEnumerable<string> values)
        {
            return httpClientBuilder.ConfigureHttpClient(c =>
            {
                if (string.IsNullOrEmpty(name) && values.Any(x => string.IsNullOrEmpty(x)))
                    throw new ArgumentException("Parametros invalidos, AddHeaders");
                else if (!c.DefaultRequestHeaders.Any(x => x.Key == name))
                    c.DefaultRequestHeaders.Add(name, values);
            });
        }

        public static IHttpClientBuilder UseConfigHeaders(this IHttpClientBuilder httpClientBuilder, string apiKey, IConfiguration configuration)
        {
            var headrers = configuration.GetSection($"NetworkConfiguration:{apiKey}:Headers").Get<IEnumerable<HeadersValues>>();

            if (headrers is null)
                return httpClientBuilder;

            foreach (var h in headrers)
            {
                if (h.Values != null && h.Values.Any())
                    httpClientBuilder.AddHeaders(h.Name, h.Values);
                else
                    httpClientBuilder.AddHeaders(h.Name, h.Value);
            }

            return httpClientBuilder;
        }
    }
}
