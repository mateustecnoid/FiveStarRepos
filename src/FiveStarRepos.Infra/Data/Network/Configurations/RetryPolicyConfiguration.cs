using Microsoft.Extensions.Configuration;
using Polly;
using Polly.Extensions.Http;
using System;
using System.Net.Http;

namespace FiveStarRepos.Infra.Data.Network.Configurations
{
    public static class CircuitBreakerPolicyConfiguration
    {
        public static class RetryPolicyConfiguration
        {
            private static Random Jitter => new();

            public static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy(IConfiguration configuration)
            {
                var tentativas = configuration.GetValue("NetworkConfiguration:PolicyRetry:RetryCount", 3);
                var intervalo = configuration.GetValue("NetworkConfiguration:PolicyRetry:RetryDelayFromMilliseconds", 3000);

                return HttpPolicyExtensions
                     .HandleTransientHttpError()
                     .WaitAndRetryAsync(retryCount: tentativas, sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow((intervalo / 1000), retryAttempt))
                     + TimeSpan.FromMilliseconds(Jitter.Next(0, 100)));
            }
        }
    }
}
