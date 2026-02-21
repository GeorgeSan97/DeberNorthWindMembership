using NorthWind.Membership.Backend.Core.Interfaces;
using NorthWind.Membership.Backend.Core.Interfaces.UserRegistration;
using NorthWind.Membership.Backend.Core.Presenters.UserRegistration;
using NorthWind.Membership.Backend.Core.UseCases.UserRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
	public static IServiceCollection AddMembershipCoreServices(this IServiceCollection services)
	{
		services.AddMembershipValidators();
		services.AddDefaultModelValidatorHub();
		services.AddScoped<IUserRegistrationInputPort,
		UserRegistrationInteractor>();
		services.AddScoped<IUserRegistrationOutputPort,
		UserRegistrationPresenter>();
		return services;
	}
}
