using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace BusinessLogic
{
    public class PlayerModel
    {
        #region properties
        public string PlayerName { get; set; }
        public string PlayerTeam { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Score { get; set; }
        #endregion


        #region methods
        public PlayerModel() { }

        public PlayerModel(string playerName, string playerTeam, int wins, int losses, int score)
        {
            PlayerName = playerName;
            PlayerTeam = playerTeam;
            Wins = wins;
            Losses = losses;
            Score = score;
        }

        public static PlayerModel ParseXml(XmlDocument playerXml)
        {
            return new PlayerModel(
                playerXml.DocumentElement.Attributes[(int)Enumerators.EnumPlayer.playerName].InnerText, 
                playerXml.DocumentElement.Attributes[(int)Enumerators.EnumPlayer.playerTeam].InnerText,
                int.Parse(playerXml.DocumentElement.Attributes[(int)Enumerators.EnumPlayer.wins].InnerText),
                int.Parse(playerXml.DocumentElement.Attributes[(int)Enumerators.EnumPlayer.losses].InnerText),
                int.Parse(playerXml.DocumentElement.Attributes[(int)Enumerators.EnumPlayer.score].InnerText));
        }
        #endregion
    }
}
