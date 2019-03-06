using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace smashgg.net.Models.Tournaments
{
    public class TournamentLinks
    {
        /// <summary>
        /// Gets or sets the link to the tournament's Facebook page.
        /// </summary>
        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        /// <summary>
        /// Gets or sets the link to the tournament's Discord.
        /// </summary>
        [JsonProperty("discord")]
        public string Discord { get; set; }
    }
}
