using NorthWind.Membership.Backend.Core.Interfaces.UserRegistration;
using NorthWind.Membership.Entities.Dtos.UserRegistration;
using NorthWind.Membership.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder;
internal static class UserRegistrationController
{
	public static WebApplication UseUserRegistrationController(
	this WebApplication app)
	{
		app.MapPost(Endpoints.Register,
			async (UserRegistrationDto userData,
				IUserRegistrationInputPort inputPort,
				IUserRegistrationOutputPort presenter) =>
		{
			await inputPort.Handle(userData);
			return presenter.Result;
		}
		);
		return app;
	}
}