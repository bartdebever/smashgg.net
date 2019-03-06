using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

using smashgg.net.Models.Interfaces;
using smashgg.net.Models.Media;

namespace smashgg.net.Models.Tournaments
{
    public class Tournament : ISmashEntity
    {
        /// <inheritdoc />
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the state where the tournament is being held.
        /// </summary>
        [JsonProperty("addrState")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the city where the tournament is being held.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the postal code of the venue.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the region the tournament is being held in.
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the contact email.
        /// </summary>
        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the custom contact information.
        /// </summary>
        [JsonProperty("contactInfo")]
        public string ContactInfo { get; set; }

        /// <summary>
        /// Gets or sets the phone number that can be used for contacting the tournament organizers.
        /// </summary>
        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Gets or sets the Twitter account that can be used to contact the tournament organizers.
        /// </summary>
        [JsonProperty("contactTwitter")]
        public string ContactTwitter { get; set; }

        /// <summary>
        /// Gets or sets the country code where the tournament is being held.
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the currency being used.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets custom Markdown which was added to the tournament page.
        /// </summary>
        [JsonProperty("customMarkdown")]
        public string CustomMarkdown { get; set; }

        /// <summary>
        /// Gets or sets the directions about the email.
        /// </summary>
        [JsonProperty("emailDirections")]
        public string EmailDirections { get; set; }

        /// <summary>
        /// Gets or sets the instructions about how to send the email.
        /// </summary>
        [JsonProperty("emailInstructions")]
        public string EmailInstructions { get; set; }

        /// <summary>
        /// Gets or sets the note about the email.
        /// </summary>
        [JsonProperty("emailNote")]
        public string EmailNote { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the tournament ends.
        /// </summary>
        [JsonProperty("endAt")]
        public int Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the tabs which have been generated.
        /// </summary>
        [JsonProperty("generatedTabs")]
        public string GeneratedTabs { get; set; }

        /// <summary>
        /// Gets or sets the "getting there" information.
        /// </summary>
        [JsonProperty("gettingThere")]
        public string GettingThere { get; set; }

        /// <summary>
        /// Gets or sets the hashtag for this tournament.
        /// </summary>
        [JsonProperty("hashtag")]
        public string HashTag { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether there are online events in this tournament.
        /// </summary>
        [JsonProperty("hasOnlineEvents")]
        public bool HasOnlineEvents { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the admins should be hidden.
        /// </summary>
        [JsonProperty("hideAdmins")]
        public bool HideAdmins { get; set; }

        /// <summary>
        /// Gets or sets the latitude where the tournament is being held at.
        /// </summary>
        [JsonProperty("lat")]
        public float Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude where the tournament is being held at.
        /// </summary>
        [JsonProperty("lng")]
        public float Longitude { get; set; }

        /// <summary>
        /// Gets or sets the id of the maps place.
        /// </summary>
        [JsonProperty("mapsPlaceId")]
        public string MapsPlaceId { get; set; }

        /// <summary>
        /// Gets or sets the name of the tournament.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the user's id which owns the tournament.
        /// </summary>
        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the registration closes.
        /// </summary>
        [JsonProperty("registrationClosesAt")]
        public int RegistrationClosesAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp that the tournament starts at.
        /// </summary>
        [JsonProperty("startAt")]
        public int StartAt { get; set; }

        // TODO create this into an enum.
        [JsonProperty("state")]
        public int TournamentState { get; set; }

        /// <summary>
        /// Gets or sets the default tab of the tournament website.
        /// </summary>
        [JsonProperty("defaultTab")]
        public string DefaultTab { get; set; }

        /// <summary>
        /// Gets or sets the rules for the tournament.
        /// </summary>
        [JsonProperty("rules")]
        public string Rules { get; set; }

        /// <summary>
        /// Gets or sets the slug for the tournament.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets the short slug for the tournament.
        /// </summary>
        [JsonProperty("shortSlug")]
        public string ShortSlug { get; set; }

        /// <summary>
        /// Gets or sets the timezone which the tournament is being held in.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets the type of tournament being ran.
        /// </summary>
        [JsonProperty("tournamentType")]
        public int TournamentType { get; set; }

        /// <summary>
        /// Gets or sets the address of the venue.
        /// </summary>
        [JsonProperty("venueAddress")]
        public string VenueAddress { get; set; }

        /// <summary>
        /// Gets or sets the name of the venue.
        /// </summary>
        [JsonProperty("venueName")]
        public string VenueName { get; set; }

        /// <summary>
        /// Gets or sets the social media links for the tournament.
        /// </summary>
        [JsonProperty("links")]
        public TournamentLinks Links { get; set; }

        /// <summary>
        /// Gets or sets a collection of images.
        /// </summary>
        [JsonProperty("images")]
        public List<Image> Images { get; set; }
    }
}
