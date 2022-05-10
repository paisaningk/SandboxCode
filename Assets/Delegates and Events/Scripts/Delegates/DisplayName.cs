using System;
using TMPro;
using UnityEngine;

namespace Delegates_and_Events.Scripts.Delegates
{
    public class DisplayName : MonoBehaviour
    {
        public PlayerStats[] playerStatsArray;
        private delegate int ScoreDelegate(PlayerStats stats);

        public TextMeshProUGUI playerNameMostKillsText;
        public TextMeshProUGUI playerNameMostFlagsCapturedText;

        private void Start()
        {
            OnGameOver(playerStatsArray);
        }
        private void OnGameOver(PlayerStats[] allPlayerStatsArray)
        {
            
            // string playerNameMostKills = GetPlayerNameTopScore(allPlayerStatsArray,ScoreByKillCount);
            // string playerNameMostFlagsCaptured = GetPlayerNameTopScore(allPlayerStatsArray,ScoreByFlagCaptures);
            
            //Lambda Expression
            string playerNameMostKills = GetPlayerNameTopScore(allPlayerStatsArray, 
                stats => stats.kills);
            
            string playerNameMostFlagsCaptured = GetPlayerNameTopScore(allPlayerStatsArray,
                stats => stats.flagsCaptured);

            playerNameMostKillsText.text = $"player Most Kills :{playerNameMostKills}";
            playerNameMostFlagsCapturedText.text = $"player Most Flags Captured {playerNameMostFlagsCaptured}";
        }

        private int ScoreByKillCount(PlayerStats stats)
        {
            return stats.kills;
        }

        private int ScoreByFlagCaptures(PlayerStats stats)
        {
            return stats.flagsCaptured;
        }

        private string GetPlayerNameTopScore(PlayerStats[] allPlayerStats, ScoreDelegate scoreCalculator)
        {
            string name = "";
            int bestScore = 0;

            foreach (var stat in allPlayerStats)
            {
                int score = scoreCalculator(stat);
                if (score > bestScore)
                {
                    bestScore = score;
                    name = stat.name;
                }
            }
            return name;
        }
    }
}