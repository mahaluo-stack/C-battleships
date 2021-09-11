using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace DataAccess
{
    public class GameSettingsDAO
    {
        /// <summary>
        /// File path to game folder
        /// </summary>
        private string gameSettingsPath = AppDomain.CurrentDomain.BaseDirectory + @DATACONSTANTS.GAME_RESOURCES + @DATACONSTANTS.SETTINGS_FOLDER;
        private string gameTeamsPath = AppDomain.CurrentDomain.BaseDirectory + @DATACONSTANTS.GAME_RESOURCES + @DATACONSTANTS.SETTINGS_FOLDER + @DATACONSTANTS.TEAMS_FOLDER;
        public GameSettingsDAO() { }

        public int AddNewTeam(String teamName, String teamLeader, String leaderOccupation, String specialVessel, String vesselName)
        {
            gameTeamsPath += teamName;

            try
            {
                if (File.Exists(gameTeamsPath))
                {
                    //Team name taken, return error
                    return DATACONSTANTS.INSERT_ERROR;
                }
                else
                {
                    using (XmlWriter writer = XmlWriter.Create(gameTeamsPath))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement(DATACONSTANTS.NEW_TEAM_NODE);
                        writer.WriteAttributeString(DATACONSTANTS.NEW_TEAM_NAME_NODE, teamName);
                        writer.WriteAttributeString(DATACONSTANTS.NEW_TEAM_LEADER_NODE, teamLeader);
                        writer.WriteAttributeString(DATACONSTANTS.NEW_TEAM_LEADER_OCCUPATION_NODE, leaderOccupation);
                        writer.WriteAttributeString(DATACONSTANTS.NEW_TEAM_LEADER_VESSEL_NODE, specialVessel);
                        writer.WriteAttributeString(DATACONSTANTS.NEW_TEAM_LEADER_VESSEL_NAME_NODE, vesselName);
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                    //Return success
                    return DATACONSTANTS.INSERT_SUCCESS;
                }
            }
            catch (Exception ex)
            {
                throw new DataReadException(ex.Message);
            }
        }





        /// <summary>
        /// Get all team info method
        /// </summary>
        /// <returns></returns>
        public string[] GetAllTeams()
        {
            try
            {
                string[] filePaths = Directory.GetFiles(gameTeamsPath);
                return filePaths;
            }
            catch (Exception ex)
            {
                throw new DataReadException(ex.Message);
            }
        }







    }
}
