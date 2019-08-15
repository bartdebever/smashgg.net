using Newtonsoft.Json;
using smashgg.net.Models.Tournaments;

namespace smashgg.net.Models.Events
{
    public class Standing
    {
        [JsonProperty("standing")]
        public int Placement { get; set; }
        
        public Entrant Entrant { get; set; }
    }
}