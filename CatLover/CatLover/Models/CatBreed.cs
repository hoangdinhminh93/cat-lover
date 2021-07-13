using Newtonsoft.Json;

namespace CatLover.Models
{
    public partial class CatBreed : BaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonProperty("image")]
        public CatImage Image { get; set; }
    }
}