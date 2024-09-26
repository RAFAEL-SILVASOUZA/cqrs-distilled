using MediatR;
using Web.Api.Adapter;
using Web.Api.Application.Commands;
using Web.Api.CrossCutting;

namespace Web.Api.Application.CommandHandlers;

internal sealed class PeopleCreateCommandHandler : IRequestHandler<PeopleCreateCommand, PeopleCreatedResponseDto>
{
    public Task<PeopleCreatedResponseDto> Handle(PeopleCreateCommand request, CancellationToken cancellationToken)
    {
        var people = PeopleAdapter.CreatePeopleBy(request.PeopleCreateRequestDto);
        return Task.FromResult(PeopleAdapter.CreatePeopleResponseDtoBy(people));
    }
}
