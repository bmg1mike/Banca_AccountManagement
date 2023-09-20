using System.Reflection;
using Banca.AccountManagement.Application.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Contrib.WaitAndRetry;

namespace Banca.AccountManagement.Application;

public static class ApplicationRegistrationService
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient("AccountManagement").AddTransientHttpErrorPolicy(x => x.WaitAndRetryAsync(Backoff.DecorrelatedJitterBackoffV2(medianFirstRetryDelay: TimeSpan.FromSeconds(configuration.GetValue<double>("PollyConfig:RetryTime")), retryCount: configuration.GetValue<int>("PollyConfig:RetryCount"))))
            .AddTransientHttpErrorPolicy(x => x.CircuitBreakerAsync(configuration.GetValue<int>("PollyConfig:HandledEventsAllowedBeforeBreaking"), TimeSpan.FromSeconds(configuration.GetValue<double>("PollyConfig:breakerTime"))));
        services.AddTransient<IRestHelper, RestHelper>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<IEncryptionService, EncryptionService>();
        services.AddScoped<IAccountManagementService, AccountManagementService>();
        return services;
    }
}