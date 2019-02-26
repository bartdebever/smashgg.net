using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

using smashgg.net.Models.Interfaces;

namespace smashgg.net.Models.Tournaments
{
    public class Tournament : ISmashEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("addrState")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("contactInfo")]
        public string ContactInfo { get; set; }

        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contactTwitter")]
        public string ContactTwitter { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customMarkdown")]
        public string CustomMarkdown { get; set; }

        [JsonProperty("emailDirections")]
        public string EmailDirections { get; set; }

        [JsonProperty("emailInstructions")]
        public string EmailInstructions { get; set; }

        [JsonProperty("emailNote")]
        public string EmailNote { get; set; }

        [JsonProperty("endAt")]
        public int Timestamp { get; set; }

        [JsonProperty("generatedTabs")]
        public string GeneratedTabs { get; set; }

        [JsonProperty("gettingThere")]
        public string GettingThere { get; set; }

        [JsonProperty("hashtag")]
        public string HashTag { get; set; }

        [JsonProperty("hasOnlineEvents")]
        public bool HasOnlineEvents { get; set; }

        [JsonProperty("hideAdmins")]
        public bool HideAdmins { get; set; }

        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("lng")]
        public float Longitude { get; set; }

        [JsonProperty("mapsPlaceId")]
        public string MapsPlaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }

        [JsonProperty("registrationClosesAt")]
        public int RegistrationClosesAt { get; set; }

        [JsonProperty("startAt")]
        public int StartAt { get; set; }

        // TODO create this into an enum.
        [JsonProperty("state")]
        public int TournamentState { get; set; }

        [JsonProperty("defaultTab")]
        public string DefaultTab { get; set; }

        [JsonProperty("rules")]
        public string Rules { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("shortSlug")]
        public string ShortSlug { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("tournamentType")]
        public int TournamentType { get; set; }

        [JsonProperty("venueAddress")]
        public string VenueAddress { get; set; }

        [JsonProperty("venueName")]
        public string VenueName { get; set; }
    }
}
