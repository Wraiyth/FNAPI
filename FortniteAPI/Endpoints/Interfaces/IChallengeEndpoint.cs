using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FNAPI.Endpoints.Challenges;
using FortniteAPI.Classes;
using FortniteAPI.Enums;

namespace FNAPI.Endpoints.Interfaces
{
    public interface IChallengeEndpoint
    {
        Task<FNChallenges> GetChallengeDetailsAsync(FNSeason? season = FNSeason.SEASON5);
    }
}
