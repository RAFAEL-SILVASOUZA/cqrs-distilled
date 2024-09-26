using MediatR;
using Web.Api.CrossCutting;

namespace Web.Api.Application.Commands;

public sealed record PeopleCreateCommand(PeopleCreateRequestDto PeopleCreateRequestDto) 
    : IRequest<PeopleCreatedResponseDto>;
