using MediatR;
using Web.Api.CrossCutting;

namespace Web.Api.Application.Queries;

public record PessoaQuery(Guid Id) : IRequest<PeopleQueryResponseDto>;
