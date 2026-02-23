using NorthWind.Membership.Backend.Core.Interfaces.UserLogin;
using NorthWind.Membership.Entities.UserLogin;
using NorthWind.Membership.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder;
internal static class UserLoginController
{
	public static WebApplication UseUserLoginController(
	this WebApplication app)
	{
		app.MapPost(Endpoints.Login,
		async (UserCredentialsDto userCredentials,
		IUserLoginInputPort inputPort,
		IUserLoginOutputPort presenter) =>
		{
			await inputPort.Handle(userCredentials);
			return presenter.Result;
		});
		return app;
	}
}
