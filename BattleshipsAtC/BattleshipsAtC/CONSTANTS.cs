namespace BattleshipsAtC
{
    public static class CONSTANTS
    {
        /// <summary>
        /// Global constants
        /// </summary>
        public const string GAME_FOLDER = @"\BattleShip\";
        public const string SETTINGS_FOLDER = @"\BattleShip\" + @"\Settings\";
        public const string RESOURCES_FOLDER = @"\BattleShip\" + @"\Resources\";
        public const string IMAGES_FOLDER = @"\BattleShip\" + @"\Resources\" + @"\Images\";
        public const string BLUE_TEAM_IMAGES = @"\BattleShip\" + @"\Resources\" + @"\Images\" + @"\Blue Team\";
        public const string RED_TEAM_IMAGES = @"\BattleShip\" + @"\Resources\" + @"\Images\" + @"\Red Team\";
        public const string YELLOW_TEAM_IMAGES = @"\BattleShip\" + @"\Resources\" + @"\Images\" + @"\Yellow Team\";
        public const string MESSAGEBOX_ERROR_TITLE = "Error!";
        public const string MESSAGEBOX_SUCCESS_TITLE = "Success!";
        public const string ERROR_MESSAGE = "Something went wrong!";
        public const string EMPTY_STRING = "";
        public const int DATABASE_SUCCESS = 1;
        public const int DATABASE_ERROR = 0;
        public const string BLUE_TEAM = "blue";
        public const string RED_TEAM = "red";
        public const string YELLOW_TEAM = "yellow";

        /// <summary>
        /// PlayerForm constants
        /// </summary>
        public const string WELCOME_NEW_PLAYER_MESSAGE = "Welcome to Battleships @ C, ";
        public const string TREE_VIEW_TEAM = "Team ";
        public const string TREE_VIEW_WINS = "Wins ";
        public const string TREE_VIEW_LOSSES = "Losses ";
        public const string TREE_VIEW_SCORE = "Score ";
        public const string UPDATE_NAME_FIELD_EMPTY = "Every player needs a name! \n Don't hate a playa, hate the game";
        public static char[] TEAM_CHAR_ARRAY = { 'T', 'e', 'a', 'm', ' ' };

        /// <summary>
        /// NewPlayerForm constants
        /// </summary>
        public const string PLAYER_ALREADY_EXISTS_ERROR = "A player with that name already exists";

        /// <summary>
        /// SetupGame Constants
        /// </summary>
        public const string CARRIERTAG = "carrier";
        public const string DESTROYERTAG = "destroyer";
        public const string GALLEYTAG = "galley";
        public const string SUBMARINETAG = "submarine";
        public const string ALIGN_H = "horizontal";
        public const string ALIGN_V = "vertical";
    }
}
