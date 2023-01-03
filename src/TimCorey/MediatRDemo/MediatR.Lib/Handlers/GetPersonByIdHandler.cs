using MediatR.Lib.Models;
using MediatR.Lib.Queries;

namespace MediatR.Lib.Handlers;

public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel?>
{
    private readonly IMediator _mediator;

    public GetPersonByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<PersonModel?> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        List<PersonModel> personList = await _mediator.Send(new GetPersonListQuery());
        PersonModel? person = personList.FirstOrDefault(x => x.Id == request.Id);

        return person;
    }
}