using System;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DataAccess
{
    public class PlayerDAO
    {
        /// <summary>
        /// File path to game folder
        /// </summary>
        private string playerFolderPath = AppDomain.CurrentDomain.BaseDirectory + @DATACONSTANTS.GAME_RESOURCES + @DATACONSTANTS.PLAYER_FOLDER;
        
        /// <summary>
        /// Empty constructor
        /// </summary>
        public PlayerDAO() { }

        /// <summary>
        /// New player method
        /// </summary>
        /// <param name="playerName">string parameter, use for XML file</param>
        /// <param name="playerTeam">string parameter, use for XML file</param>
        /// <returns></returns>
        public int AddNewPlayer(String playerName, String playerTeam)
        {
            playerFolderPath += playerName;
            try
            {
                if (File.Exists(playerFolderPath))
                {
                    //Player name taken, return error to client
                    return DATACONSTANTS.INSERT_ERROR;
                }
                else
                {
                    //Create new player xml file
                    using (XmlWriter writer = XmlWriter.Create(playerFolderPath))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement(DATACONSTANTS.NEW_PLAYER_NODE);
                        writer.WriteAttributeString(DATACONSTANTS.NEW_PLAYER_NAME_NODE, playerName);
                        writer.WriteAttributeString(DATACONSTANTS.NEW_PLAYER_TEAM_NODE, playerTeam);
                        writer.WriteAttributeString(DATACONSTANTS.PLAYER_GAMES_WON_NODE, DATACONSTANTS.PLAYER_ZERO_VALUE_STRING);
                        writer.WriteAttributeString(DATACONSTANTS.PLAYER_GAMES_LOST_NODE, DATACONSTANTS.PLAYER_ZERO_VALUE_STRING);
                        writer.WriteAttributeString(DATACONSTANTS.PLAYER_SCORE_NODE, DATACONSTANTS.PLAYER_ZERO_VALUE_STRING);
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                    //Return success to client
                    return DATACONSTANTS.INSERT_SUCCESS;
                }
            }
            catch (Exception ex)
            {
                throw new DataReadException(ex.Message);
            }
        }

        /// <summary>
        /// Get all player info method
        /// </summary>
        /// <returns></returns>
        public string[] GetAllPlayers()
        {
            try
            {
                string[] filePaths = Directory.GetFiles(playerFolderPath);
                return filePaths;
            }
            catch(Exception ex)
            {
                throw new DataReadException(ex.Message);
            }
        }

        public int UpdatePlayer(string currentPlayerName, string newPlayerName, string newPlayerTeam)
        {
            string currentPlayerPath = playerFolderPath + currentPlayerName;
            string newPlayerPath = playerFolderPath + newPlayerName;

            try
            {
                if (!File.Exists(currentPlayerPath))
                {
                    //Player was not found, send error to client
                    return DATACONSTANTS.INSERT_ERROR;
                }
                else
                {

                    //Append player xml file
                    XmlDocument doc = new XmlDocument();
                    doc.Load(currentPlayerPath);
                  
                    doc.DocumentElement.Attributes[(int)Enumerators.EnumPlayer.playerName].Value = newPlayerName;
                    doc.DocumentElement.Attributes[(int)Enumerators.EnumPlayer.playerTeam].Value = newPlayerTeam;
                    doc.Save(filename: currentPlayerPath);
                    //Return success to client
                    File.Move(currentPlayerPath, newPlayerPath);
                    return DATACONSTANTS.INSERT_SUCCESS;
                }
            }
            catch (Exception ex)
            {
                throw new DataReadException(ex.Message);
            }
        }
    }
}
