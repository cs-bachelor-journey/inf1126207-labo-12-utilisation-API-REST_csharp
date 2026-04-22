using Newtonsoft.Json;

namespace Ex01_CatFacts.Models
{
    public class CatFact
    {
        [JsonProperty("fact")]
        public string Fact { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }
}
