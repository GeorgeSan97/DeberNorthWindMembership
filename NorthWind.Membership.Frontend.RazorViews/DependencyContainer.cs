using NorthWind.HttpDelegatingHandlers;
using NorthWind.Membership.Frontend.RazorViews.ViewModels.UserRegistration;
using NorthWind.Membership.Frontend.RazorViews.WebApiGateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
	public static IServiceCollection AddMembershipServices(
	this IServiceCollection services,
	Action<HttpClient> configureHttpClient)
	{
		services.AddExceptionDelegatingHandler();
		services.AddHttpClient<MembershipGateway>(configureHttpClient)
		.AddHttpMessageHandler<ExceptionDelegatingHandler>();
		services.AddScoped<UserRegistrationViewModel>();
		services.AddMembershipValidators();
		services.AddModelValidator<UserRegistrationViewModel,
			UserRegistrationViewModelDtoValidator>();
		services.AddModelValidator<UserRegistrationViewModel,
			UserRegistrationViewModelValidator>();
		return services;
	}
}
