using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder;
public static class EndpointsContainer
{
	public static WebApplication UseMembershipEndpoints(this WebApplication app)
	{
		app.UseUserRegistrationController();
		return app;
	}
}
