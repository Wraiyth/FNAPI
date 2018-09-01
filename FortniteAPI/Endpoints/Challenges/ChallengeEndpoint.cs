using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FNAPI.Endpoints.Interfaces;
using FortniteAPI;
using FortniteAPI.Classes;
using FortniteAPI.Enums;
using Newtonsoft.Json;
using RestSharp;

namespace FNAPI.Endpoints.Challenges
{
    public class ChallengeEndpoint : IChallengeEndpoint
    {
        public async Task<FNChallenges> GetChallengeDetailsAsync(FNSeason? season = FNSeason.SEASON5)
        {
            RestClient restClient = new RestClient("https://fortnite-public-api.theapinetwork.com/prod09/");

            var request = new RestRequest("challenges/get", Method.POST);

            request.AddHeader("Authorization", FortniteApi.ApiKey);
            request.AddParameter("language", "en");
            request.AddParameter("season", season.ToString().ToLower());

            IRestResponse response = await restClient.ExecuteTaskAsync(request).ConfigureAwait(false);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<FNChallenges>(response.Content);
        }
    }
}
