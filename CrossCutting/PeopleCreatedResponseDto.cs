using Swashbuckle.AspNetCore.Filters;

namespace Web.Api.CrossCutting;

public sealed record PeopleCreatedResponseDto(Guid Id, string FirstName, string LastName);


public sealed class PeopleCreateResponseDtoExamplesProvider : IExamplesProvider<PeopleCreatedResponseDto>
{
    public PeopleCreatedResponseDto GetExamples()
    => new PeopleCreatedResponseDto(Guid.NewGuid(), "Rafael", "Silva");
}
