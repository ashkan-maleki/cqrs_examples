using MediatR.Lib.Models;

namespace MediatR.Lib.Queries;

public record GetPersonListQuery() : IRequest<List<PersonModel>>;