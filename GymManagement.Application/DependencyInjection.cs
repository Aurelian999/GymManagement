﻿using GymManagement.Application.CreateSubscription;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ISubscriptionsService, SubscriptionsService>();

            return services;
        }
    }
}