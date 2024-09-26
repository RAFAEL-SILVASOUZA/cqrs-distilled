using Swashbuckle.AspNetCore.Filters;

namespace Web.Api.CrossCutting;

public sealed record PeopleCreateRequestDto(string FirstName, string LastName);

public sealed class PeopleCreateRequestDtoExamplesProvider : IExamplesProvider<PeopleCreateRequestDto>
{
    public PeopleCreateRequestDto GetExamples()
    => new PeopleCreateRequestDto("Rafael", "Silva");
}