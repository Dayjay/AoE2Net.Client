# AoE2Net.Client

> [!WARNING]  
> AoE2.net is dead

<p align="center">
  <a href="https://www.nuget.org/packages/AoE2Net.Client/">
    <img src="https://img.shields.io/nuget/v/AoE2Net.Client"/>
  </a>
</p>

 A C# Wrapper for the AoE2.NET API

 ## Usage
 
```c#

//create new Client
var aoe2NetClient = new AoE2NetClient("MyCoolApp");

//get AoE2Net API strings
var strings = await aoe2NetClient.GetStringsAsync();

//get leaderboard for 1v1
var leaderboard = await aoe2NetClient.GetLeaderboardAsync(LeaderboardType.RandomMap1v1, 0, 100);

//get rating history for 1v1
var ratinghistory = await aoe2NetClient.GetRatingHistoryAsync(LeaderboardType.RandomMap1v1, 0, 20, profileId: 123456);

//get match history
var matchHistory = await aoe2NetClient.GetPlayerMatchHistoryAsync(100, profileId: 123456);

//get match history for multiple players
var playerList = new List<string>();
playerList.Add("123456");
playerList.Add("78901");
playerList.Add("234567");

var matchesHistory = await aoe2NetClient.GetPlayersMatchHistoryAsync(100, profileIds: playerList);

//get ongoing matches
var ongoingMatches = await aoe2NetClient.GetOngoingMatchesAsync();
```	
 
 ## Todo

- Support for other AoE titles?

 
 ## Misc
 
 Special thanks to the [aoe2.net](https://aoe2.net/ "aoe2.net") creators and maintainers. 