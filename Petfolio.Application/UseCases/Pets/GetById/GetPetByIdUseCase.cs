using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponseGetPetByIdJson Execute(int id)
    {
        return new ResponseGetPetByIdJson()
        {
            Id = id,
            Name = "Sorveteiro",
            Type = PetType.Dog,
            BirhDate = new DateTime(year: 2019, month: 10, day: 10)
        };
    }
}
