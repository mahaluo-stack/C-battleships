using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsAtC
{
    public static class CurrentPlayer
    {
        #region properties
        public static string PlayerName { get; set; }
        public static string PlayerTeam { get; set; }
        public static int Wins { get; set; }
        public static int Losses { get; set; }
        public static int Score { get; set; }
        #endregion


        #region methods
        static CurrentPlayer() { }
        #endregion




    }
}
