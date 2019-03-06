using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

using smashgg.net.Models.Interfaces;

namespace smashgg.net.Models.Media
{
    public class Image : ISmashEntity
    {
        /// <inheritdoc />
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the width of the image in pixels.
        /// </summary>
        [JsonProperty("width")]
        public float Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the image in pixels.
        /// </summary>
        [JsonProperty("height")]
        public float Height { get; set; }

        /// <summary>
        /// Gets or sets the ratio.
        /// </summary>
        [JsonProperty("ratio")]
        public float Ratio { get; set; }

        /// <summary>
        /// Gets or sets the type of image.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the image is original.
        /// </summary>
        [JsonProperty("isOriginal")]
        public bool IsOriginal { get; set; }

        /// <summary>
        /// Gets or sets the entity that corresponds to the image.
        /// </summary>
        [JsonProperty("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// Gets or sets the entity's id.
        /// </summary>
        [JsonProperty("entityId")]
        public int EntityId { get; set; }

        /// <summary>
        /// Gets or sets when the image was uploaded.
        /// </summary>
        [JsonProperty("uploadedBy")]
        public int UploadedBy { get; set; }
    }
}
