﻿using Application.Common.Interfaces.Authentication;
using Application.Common.Interfaces.Services;
using Application.Services.Authentication;
using Infrastructure.Authentication;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
	public static class DependencyInjection
	{
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
		{
			services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
			services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
			services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            return services;
		}
	}
}
