﻿using System;
using Library.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Services.Api.Configurations
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile));
        }
    }
}