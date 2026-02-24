using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace NorthWind.Membership.Frontend.RazorViews.Pages
{
	public partial class LogoutPage
	{
		[CascadingParameter]
		private Task<AuthenticationState> authenticationState { get; set; }

		[Inject]
		private NavigationManager NavigationManager { get; set; }

		private async Task CloseSession()
		{
			// Redirigir a la página de login
			NavigationManager.NavigateTo("/user/login");
		}
	}
}
