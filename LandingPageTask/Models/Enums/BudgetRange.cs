using System.Text.Json.Serialization;

namespace LandingPageTask.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BudgetRange
    {
        FiveToTen,    // 5M - 10M
        TenToTwenty,  // 10M - 20M
        TwentyPlus    // +20M
    }
}
