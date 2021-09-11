namespace DataAccess
{
    public static class DATACONSTANTS
    {
        /// <summary>
        /// File paths
        /// </summary>
        public const string GAME_RESOURCES = @"\Game Resources\";
        public const string SETTINGS_FOLDER = @"\Settings\";
        public const string TEAMS_FOLDER = @"\Teams\";
        public const string PLAYER_FOLDER = @"\Players\";

        /// <summary>
        /// XML stuff
        /// </summary>
        public const string NEW_PLAYER_GAMES_NODE = "PlayerGames";
        public const string NEW_PLAYER_NODE = "Player";
        public const string NEW_PLAYER_NAME_NODE = "PlayerName";
        public const string NEW_PLAYER_TEAM_NODE = "PlayerTeam";
        public const string PLAYER_GAMES_WON_NODE = "Wins";
        public const string PLAYER_ZERO_VALUE_STRING = "0";
        public const string PLAYER_GAMES_LOST_NODE = "Losses";
        public const string PLAYER_SCORE_NODE = "Score";
        public const string PLAYER_EXISTS_ERROR = "A player with that name already exists";
        public const string NEW_TEAM_NODE = "Team";
        public const string NEW_TEAM_NAME_NODE = "TeamName";
        public const string NEW_TEAM_LEADER_NODE = "Leader";
        public const string NEW_TEAM_LEADER_OCCUPATION_NODE = "Occupation";
        public const string NEW_TEAM_LEADER_VESSEL_NODE = "Vessel";
        public const string NEW_TEAM_LEADER_VESSEL_NAME_NODE = "VesselName";

      

        public const int INSERT_SUCCESS = 1;
        public const int INSERT_ERROR = 0;
    }
}
