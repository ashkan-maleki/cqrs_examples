using MediatR.Lib.Models;

namespace MediatR.Lib.Queries;

public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;