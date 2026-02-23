using NorthWind.Membership.Entities.UserLogin;
using NorthWind.Validation.Entities.Abstractions;
using NorthWind.Validation.Entities.Enums;
using NorthWind.Validation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Membership.Frontend.RazorViews.ViewModels.UserLogin
{
	public class UserLoginViewModelDtoValidator(
	IModelValidatorHub<UserCredentialsDto> validator) : AbstractViewModelValidator<UserCredentialsDto, UserLoginViewModel>(
	validator, ValidationConstraint.AlwaysValidate)
	{
	}
}
