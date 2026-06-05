using System.Text.Json.Serialization;

namespace LandingPageTask.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InterestType
    {
        Acquisition,
        Sale,
        Investment
    }
}
