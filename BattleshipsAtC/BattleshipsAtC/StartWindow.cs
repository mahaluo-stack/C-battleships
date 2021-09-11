using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BattleshipsAtC.BackedHost;
using static System.Windows.Forms.AxHost;

namespace BattleshipsAtC
{
    public partial class StartWindow : Form
    {
        #region fields
        #region class objects
        ProgramService programService;
        DataService dataService;
        Thread thread;
        #endregion
        #endregion

        public StartWindow()
        {
            programService = new ProgramService();
            dataService = new DataService();
           
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(OpenGameSetupForm));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(OpenPlayerForm));
            thread.Start();
            Close();
        }

        private void OpenPlayerForm()
        {
            Application.Run(new PlayerForm());
        }

        private void OpenGameSetupForm()
        {
            Application.Run(new SetupGameWindow());
        }


        private void btnOptions_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

   
}
