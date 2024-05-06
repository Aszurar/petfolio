using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseShortAllPetJson Execute()
    {
        var petsResponse = new ResponseShortAllPetJson();

        petsResponse.Pets = new List<ResponseShortPetJson>()
        {
             new ResponseShortPetJson()
                {
                    Id = 123,
                    Name = "Sorveteiro",
                    Type = PetType.Dog

                },
                new ResponseShortPetJson()
                {
                    Id = 456,
                    Name = "Pão de Queijo",
                    Type = PetType.Cat

                }
        };

        return petsResponse;

        /*
        return new ResponseShortAllPetJson()
        {
            Pets = new List<ResponseShortPetJson>()
            {
                new ResponseShortPetJson()
                {
                    Id = 123,
                    Name = "Sorveteiro",
                    Type = PetType.Dog
                    
                },
                new ResponseShortPetJson()
                {
                    Id = 456,
                    Name = "Pão de Queijo",
                    Type = PetType.Cat

                }
            }
        };
        */
    }
}
