using Web.Api.CrossCutting;
using Web.Api.Domain.Entities;

namespace Web.Api.Adapter;

public static class PeopleAdapter
{
    public static People CreatePeopleBy(PeopleCreateRequestDto peopleCreateRequestDto)
    => new People(peopleCreateRequestDto.FirstName, peopleCreateRequestDto.LastName);

    public static PeopleCreatedResponseDto CreatePeopleResponseDtoBy(People people)
    => new PeopleCreatedResponseDto(people.Id, people.FirstName, people.LastName);
}
