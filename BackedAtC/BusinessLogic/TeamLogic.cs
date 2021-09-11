using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using DataAccess;

namespace BusinessLogic
{
    public class TeamLogic
    {
        #region field
        #region class objects
        /// <summary>
        /// Player data access
        /// </summary>
        GameSettingsDAO gameSettingsDAO;
        /// <summary>
        /// Player xml files
        /// </summary>
        XmlDocument teamXml;
        /// <summary>
        /// List of players
        /// </summary>
        List<TeamModel> teams;
        #endregion
        #endregion

        public TeamLogic()
        {
            gameSettingsDAO = new GameSettingsDAO();
        }



        public int AddNewTeam(string teamName, string leader, string occupation, string vessel, string vesselName)
        {
            try
            {
                return gameSettingsDAO.AddNewTeam(teamName, leader, occupation, vessel, vesselName);
            }
            catch (DataReadException ex)
            {
                throw new LogicException(ex.Message);
            }
        }

        public List<TeamModel> GetAllTeams()
        {
            teams = new List<TeamModel>();
            string[] teamFiles;

            try
            {
                teamFiles = gameSettingsDAO.GetAllTeams();

                foreach (string teamFile in teamFiles)
                {
                    teamXml = new XmlDocument();
                    teamXml.Load(teamFile.ToString());
                    TeamModel team = TeamModel.ParseXml(teamXml);
                    teams.Add(team);
                }
            }
            catch (DataReadException ex)
            {
                throw new LogicException(ex.Message);
            }

            return teams;
        }

    }
}
