using MediatR;

namespace CleanArchiture.Application.UseCases
{
    public interface ICleanArchiture : IRequestHandler<CleanArchitureRequest, Unit> {

    }
}
