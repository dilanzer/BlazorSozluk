using BlazorSozluk.Api.Domain.Models;
using BlazorSozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Infrastructure.Persistence.EntityConfigurations
{
	public class UserEntityConfiguration : BaseEntityConfiguration<User>
	{
		public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
		{
			base.Configure(builder);

			builder.ToTable("users", BlazorSozlukContext.DEFAULT_SCHEMA);
		}
	}
}
