﻿using System;
using System.Threading.Tasks;

using FortniteAPI;
using FortniteAPI.Classes;

namespace ExampleTest
{
    class Program
    {
        static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();

        public static FortniteApi APi = new FortniteApi("VALID API KEY HERE");

        public async Task MainAsync()
        {
            //APi.BR.StoreUpdated += StoreUpdated;

            // New way to retrieve Challenge Details
            var challengeDetails = await APi.Challenges.GetChallengeDetailsAsync();

            var season = APi.GetCurrentSeason();
            var week = APi.GetCurrentWeek();
            var version = APi.GetCurrentVersion();
            var status = await APi.GetStatusAsync();
            var patchnotes = await APi.GetPatchnotesAsync();

            var store = await APi.BR.GetStoreAsync();
            var featured = store.GetFeaturedStore();
            var daily = store.GetDailyStore();
            var upcoming = await store.GetUpcomingItemsAsync();
            var search = await store.SearchAsync("Brite Gunner", FortniteAPI.Enums.FNBRItemRarity.EPIC);
            var searchItem = search[0];

            var item = await APi.BR.GetItemAsync(searchItem.ItemID);
            
            var user = APi.GetUser("Kangaaa");
            var userBR = APi.GetUser<FNBRUser>("Kangaaa");
            var userBRR = user.ConvertTo<FNBRUser>();
            var userUID = APi.GetUser(new UID("711b6eaea0464736ab39212e16ac6c87"));
            var stats = await userBR.GetStatsAsync();

            var leaderboard = await APi.BR.GetLeaderboardAsync();
            var leader = leaderboard[0];
            var lUser = leader.GetUser(true);
            var lStats = await lUser.GetStatsAsync(user.Platforms[0]);

            var brNews = await APi.BR.GetNewsAsync();
            var challenges = await APi.BR.GetChallengesAsync();
            var stwNews = await APi.STW.GetNewsAsync();

            Console.Read();
        }

        private Task StoreUpdated(FNBRStore store)
        {
            Console.WriteLine(store.Items.Count.ToString());
            foreach (var item in store.Items)
            {
                Console.WriteLine("Name: {0}\nCost: {1}", item.Name, item.Cost);
            }
            return Task.CompletedTask;
        }
    }
}
