using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;

public class ResponseGetPetByIdJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime BirhDate { get; set; }
    public PetType Type { get; set; }
}
