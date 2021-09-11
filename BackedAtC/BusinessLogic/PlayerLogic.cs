using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using DataAccess;


namespace BusinessLogic
{
    public class PlayerLogic
    {
        #region field
        #region class objects
        /// <summary>
        /// Player data access
        /// </summary>
        PlayerDAO playerDAO;
        /// <summary>
        /// Player xml files
        /// </summary>
        XmlDocument playerXml;
        /// <summary>
        /// List of players
        /// </summary>
        List<PlayerModel> players;
        #endregion
        #endregion

        public PlayerLogic()
        {
            playerDAO = new PlayerDAO();
        }

        public int AddNewPlayer(string playerName, string playerTeam)
        {
            try
            {
                return playerDAO.AddNewPlayer(playerName, playerTeam);
            }
            catch (DataReadException ex)
            {
                throw new LogicException(ex.Message);
            }
        }

        public List<PlayerModel> GetAllPlayers()
        {
            players = new List<PlayerModel>();
            string[] playerFiles;

            try
            {
                playerFiles = playerDAO.GetAllPlayers();

                foreach (string playerFile in playerFiles)
                {
                    playerXml = new XmlDocument();
                    playerXml.Load(playerFile.ToString());
                    PlayerModel player = PlayerModel.ParseXml(playerXml);
                    players.Add(player);
                }
            }
            catch(DataReadException ex)
            {
                throw new LogicException(ex.Message);
            }
            
            return players;
        }

        public int UpdatePlayer(string currentPlayerName, string newPlayerName, string newPlayerTeam)
        {
            try
            {
                return playerDAO.UpdatePlayer(currentPlayerName, newPlayerName, newPlayerTeam);
            }
            catch (DataReadException ex)
            {
                throw new LogicException(ex.Message);
            }
        }



    }
}
