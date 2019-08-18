using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

using smashgg.net.Models.Interfaces;
using smashgg.net.Models.Media;
using smashgg.net.Models.Tournaments;

namespace smashgg.net.Models.Events
{
    public class Event : ISmashEntity
    {
        /// <inheritdoc />
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a collection of images.
        /// </summary>
        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the amount of entrants.
        /// </summary>
        [JsonProperty("numEntrants")]
        public int AmountOfEntrants { get; set; }

        /// <summary>
        /// Gets to set a value to indicate when the event starts.
        /// </summary>
        [JsonProperty("startAt")]
        public int StartAt { get; set; }

        /// <summary>
        /// Gets or sets the tournament that the event belongs to.
        /// </summary>
        [JsonProperty("tournament")]
        public Tournament Tournament { get; set; }

        /// <summary>
        /// Gets or sets how long before the event start will the check-in end (in seconds).
        /// </summary>
        [JsonProperty("checkInBuffer")]
        public int CheckInBuffer { get; set; }

        /// <summary>
        /// Gets or sets how long the event check-in will last (in seconds).
        /// </summary>
        [JsonProperty("checkInDuration")]
        public int checkInDuration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether check-in is enabled for this event.
        /// </summary>
        [JsonProperty("checkInEnabled")]
        public bool CheckInEnabled { get; set; }

        /// <summary>
        /// Gets or sets the last date attendees are able to create teams for team events
        /// </summary>
        [JsonProperty("deckSubmissionDeadline")]
        public int DeckSubmissionDeadline { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of participants each Entrant can have.
        /// </summary>
        [JsonProperty("entrantSizeMax")]
        public int EntrantSizeMax { get; set; }

        /// <summary>
        /// Gets or sets the minimum amount of participants each Entrant can have.
        /// </summary>
        [JsonProperty("entrantSizeMin")]
        public int EntrantSizeMin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the event has decks.
        /// </summary>
        [JsonProperty("hasDecks")]
        public bool HasDecks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the player tasks are enabled for this event.
        /// </summary>
        [JsonProperty("hasTasks")]
        public bool HasTasks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the event is online.
        /// </summary>
        [JsonProperty("isOnline")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// Gets or sets the match rules in the Markdown format.
        /// </summary>
        [JsonProperty("matchRulesMarkdown")]
        public string MatchRulesMarkdown { get; set; }

        /// <summary>
        /// Gets or sets the name of the event given by the TO.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the prizing settings in the JSON format.
        /// </summary>
        [JsonProperty("prizingInfo")]
        public string PrizingInfo { get; set; }

        /// <summary>
        /// Gets or sets the rules in the Markdown format.
        /// </summary>
        [JsonProperty("rulesMarkdown")]
        public string RulesMarkdown { get; set; }

        /// <summary>
        /// Gets or sets the id of the ruleset
        /// </summary>
        [JsonProperty("rulesetId")]
        public int RulesetId { get; set; }

        /// <summary>
        /// Gets or sets the ruleset settings in the JSON format.
        /// </summary>
        [JsonProperty("rulesetSettings")]
        public string RulesetSettings { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets the last date attendees are able to create teams for team events.
        /// </summary>
        [JsonProperty("teamManagementDeadline")]
        public int? TeamManagementDeadline { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a teams event, returns whether or not teams can set custom names.
        /// </summary>
        [JsonProperty("teamNameAllowed")]
        public bool? TeamNameAllowed { get; set; }

        /// <summary>
        /// Gets or sets the type of the event, whether an entrant will have one participant or multiple.
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the id of the videogame associated with this event.
        /// </summary>
        [JsonProperty("videoGameId")]
        public int VideoGameId { get; set; }
        
        public BaseNode<Standing> Standings { get; set; }
    }
}
