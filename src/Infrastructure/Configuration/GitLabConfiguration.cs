using System.Diagnostics.CodeAnalysis;

namespace CleanArchiture.Infrastructure.GitLab.Configuration
{
    [ExcludeFromCodeCoverage]
    public class GitLabConfiguration
    {
	public string ApiBasaeAddress { get; set; }
	public string User { get; set; }
	public string Password { get; set; }
    }
}
