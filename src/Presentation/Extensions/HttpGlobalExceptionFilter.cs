using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchiture.Presentation.Extensions
{
    public class HttpGlobalExceptionFilter : IExceptionFilter
    {
	public void OnException(ExceptionContext context)
    	{
	    context.Result = new ObjectResult(new ProblemDetails().Title = "Erro Generico Nao Mais!");
	}
    }
}
