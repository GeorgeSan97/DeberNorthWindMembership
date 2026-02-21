using NorthWind.Membership.Entities.Dtos.UserRegistration;
using NorthWind.Membership.Entities.Validators.UserRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
	public static IServiceCollection AddMembershipValidators(
	this IServiceCollection services)
	{
		services.AddModelValidator<UserRegistrationDto,
		UserRegistrationDtoValidator>();
		return services;
	}

}
