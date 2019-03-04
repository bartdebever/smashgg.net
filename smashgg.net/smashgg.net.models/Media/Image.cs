using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

using smashgg.net.Models.Interfaces;

namespace smashgg.net.Models.Media
{
    public class Image : ISmashEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("width")]
        public float Width { get; set; }

        [JsonProperty("height")]
        public float Height { get; set; }

        [JsonProperty("ratio")]
        public float Ratio { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isOriginal")]
        public bool IsOriginal { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("entityId")]
        public int EntityId { get; set; }

        [JsonProperty("uploadedBy")]
        public int UploadedBy { get; set; }
    }
}
