using System;
using System.Data;
using System.Web.Services;
using BusinessLogic;

namespace BackedAtC
{
    /// <summary>
    /// Summary description for DataService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataService : WebService
    {
        #region field
        #region class objects
        PlayerLogic playerLogic;
        TeamLogic teamLogic;
        #endregion
        #endregion

        [WebMethod]
        public int AddNewPlayer(string playerName, string playerTeam)
        {
            playerLogic = new PlayerLogic();

            try
            {
                return playerLogic.AddNewPlayer(playerName, playerTeam);
            }
            catch(LogicException ex)
            {
                throw new WebServiceException(ex.Message);
            }
        }

        [WebMethod]
        public DataTable GetAllPlayers()
        {
            playerLogic = new PlayerLogic();

            try
            {
                return playerLogic.GetAllPlayers().ToDataTable();
            }
            catch (LogicException ex)
            {
                throw new WebServiceException(ex.Message);
            }
        }

        [WebMethod]
        public int AddNewTeam(string teamName, string leader, string occupation, string vessel, string vesselName)
        {
            teamLogic = new TeamLogic();

            try
            {
                return teamLogic.AddNewTeam(teamName, leader, occupation, vessel, vesselName);
            }
            catch (LogicException ex)
            {
                throw new WebServiceException(ex.Message);
            }
        }

        [WebMethod]
        public DataTable GetAllTeams()
        {
            teamLogic = new TeamLogic();

            try
            {
                return teamLogic.GetAllTeams().ToDataTable();
            }
            catch (LogicException ex)
            {
                throw new WebServiceException(ex.Message);
            }
        }

        [WebMethod]
        public int UpdatePlayer(string currentPlayerName, string newPlayerName, string newPlayerTeam)
        {
            playerLogic = new PlayerLogic();

            try
            {
                return playerLogic.UpdatePlayer(currentPlayerName, newPlayerName, newPlayerTeam);
            }
            catch (LogicException ex)
            {
                throw new WebServiceException(ex.Message);
            }
        }
    }
}
