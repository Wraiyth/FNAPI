using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FNAPI.Endpoints.Interfaces;
using FortniteAPI.Classes;

namespace FNAPI.Interfaces
{
    public interface IFortniteApi
    {
        IChallengeEndpoint Challenges { get; }
    }
}
