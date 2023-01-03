using MediatR.Lib.Commands;
using MediatR.Lib.DataAccess;
using MediatR.Lib.Models;

namespace MediatR.Lib.Handlers;

public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
{
    private readonly IDataAccess _data;

    public InsertPersonHandler(IDataAccess data) => _data = data;

    public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken) =>
        Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
}