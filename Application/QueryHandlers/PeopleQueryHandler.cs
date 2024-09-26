using MediatR;
using Web.Api.Application.Queries;
using Web.Api.CrossCutting;

namespace Web.Api.Application.QueryHandlers;

public class PeopleQueryHandler : IRequestHandler<PessoaQuery, PeopleQueryResponseDto>
{
    public async Task<PeopleQueryResponseDto> Handle(PessoaQuery request, CancellationToken cancellationToken)
    { 
        return await Task.FromResult(new PeopleQueryResponseDto(request.Id, "Rafael", "Souza"));
    }
}
