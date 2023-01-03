using MediatR.Lib.DataAccess;
using MediatR.Lib.Models;
using MediatR.Lib.Queries;

namespace MediatR.Lib.Handlers;

public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
{
    private readonly IDataAccess _data;

    public GetPersonListHandler(IDataAccess data)
    {
        _data = data;
    }

    public Task<List<PersonModel>> Handle(GetPersonListQuery request, 
        CancellationToken cancellationToken)
    {
        return Task.FromResult(_data.People);
    }
}