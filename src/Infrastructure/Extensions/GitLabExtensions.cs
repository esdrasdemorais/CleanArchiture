using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using CleanArchiture.Infrastructure.GitLab.Configuration;

namespace CleanArchiture.Infrastructure.GitLab.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class GitLabExtension
    {
	public static IServiceCollection AddGitLab(this IServiceCollection services, IConfiguration configuration)
	{
	    var gitLabConfiguration = configuration.GetSection(nameof(GitLabConfiguration)).Get<GitLabConfiguration>();

	    return services;
	}
    }
}
