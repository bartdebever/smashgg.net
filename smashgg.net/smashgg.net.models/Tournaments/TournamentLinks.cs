using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace smashgg.net.Models.Tournaments
{
    public class TournamentLinks
    {
        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("discord")]
        public string Discord { get; set; }
    }
}
