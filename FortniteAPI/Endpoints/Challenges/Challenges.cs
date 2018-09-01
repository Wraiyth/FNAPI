using System;
using System.Collections.Generic;
using System.Text;
using FortniteAPI.Classes.Items;
using FortniteAPI.Enums;
using Newtonsoft.Json;

namespace FNAPI.Endpoints.Challenges
{
    public class ChallengeDetails
    {
        internal ChallengeDetails() { }

        [JsonProperty]
        public FNSeason Season { get; internal set; }
        [JsonProperty]
        public FNWeek CurrentWeek { get; internal set; }

        [JsonProperty("star")]
        public string Icon { get; internal set; }

        [JsonProperty]
        public Dictionary<string, List<FNChallengeItem>> Challenges { get; internal set; }
    }
}
