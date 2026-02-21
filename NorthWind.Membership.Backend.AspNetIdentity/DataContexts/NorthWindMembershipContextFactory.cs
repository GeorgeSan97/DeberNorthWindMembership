using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using NorthWind.Membership.Backend.AspNetIdentity.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Membership.Backend.AspNetIdentity.DataContexts
{
	internal class NorthWindMembershipContextFactory :
	IDesignTimeDbContextFactory<NorthWindMembershipContext>
	{
		public NorthWindMembershipContext CreateDbContext(string[] args)
		{
			IOptions<MembershipDBOptions> DbOptions =
			Microsoft.Extensions.Options.Options.Create(
			new MembershipDBOptions()
			{
				ConnectionString = "Server=GEORGE-ASUS;Database=NorthWindUsersDB;User Id=sa;Password=jorgesa;TrustServerCertificate=True;"
			});
			return new NorthWindMembershipContext(DbOptions);
		}
	}
}
