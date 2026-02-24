using Microsoft.JSInterop;
using NorthWind.Membership.Entities.UserLogin;
using NorthWind.Membership.Frontend.RazorViews.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NorthWind.Membership.Frontend.RazorViews.Services
{
	public class TokenSessionStorage(IJSRuntime jsRuntime) : ITokenStorage
	{
		const string StorageKey = "tokens";
		const string StoreIdentifier = "sessionStorage.setItem";
		const string GetIdentifier = "sessionStorage.getItem";
		const string RemoveIdentifier = "sessionStorage.removeItem";
		public async Task StoreTokensAsync(TokensDto tokens)
		{
			string Value = JsonSerializer.Serialize(tokens);
			await jsRuntime.InvokeVoidAsync(StoreIdentifier,
			StorageKey, Value);
		}
		public async Task<TokensDto> GetTokensAsync()
		{
			string Value = await jsRuntime.InvokeAsync<string>(
			GetIdentifier, StorageKey);
			return Value == null ? null :
			JsonSerializer.Deserialize<TokensDto>(Value);
		}
		public async Task RemoveTokensAsync()
		{
			await jsRuntime.InvokeVoidAsync(RemoveIdentifier,
			StorageKey);
		}
	}
}
