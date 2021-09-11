using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace BusinessLogic
{
    public class TeamModel
    {
        #region properties
        public string TeamName { get; set; }
        public string Leader { get; set; }
        public string Occupation { get; set; }
        public string Vessel { get; set; }
        public string VesselName { get; set; }
        #endregion

        #region methods
        public TeamModel() { }

        public TeamModel(string teamName, string leader, string occupation, string vessel, string vesselName)
        {
            TeamName = teamName;
            Leader = leader;
            Occupation = occupation;
            Vessel = vessel;
            VesselName = vesselName;
        }

        public static TeamModel ParseXml(XmlDocument teamXml)
        {
            return new TeamModel(
            teamXml.DocumentElement.Attributes[(int)Enumerators.EnumTeam.teamName].InnerText,
            teamXml.DocumentElement.Attributes[(int)Enumerators.EnumTeam.leader].InnerText,
            teamXml.DocumentElement.Attributes[(int)Enumerators.EnumTeam.occupation].InnerText,
            teamXml.DocumentElement.Attributes[(int)Enumerators.EnumTeam.vessel].InnerText,
            teamXml.DocumentElement.Attributes[(int)Enumerators.EnumTeam.vesselName].InnerText);
        }
        #endregion
    }
}
