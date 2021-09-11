using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BattleshipsAtC.BackedHost;

namespace BattleshipsAtC
{
    public partial class NewPlayerForm : Form
    {
        #region fields
        #region class objects
        ProgramService programService;
        DataService dataService;
        Thread thread;
        DataTable dataTable;
        #endregion
        #endregion

        public NewPlayerForm()
        {
            InitializeComponent();
            FillTeamComboBox();
        }

        private void FillTeamComboBox()
        {
            dataService = new DataService();
            dataTable = new DataTable();

            try
            {
                dataTable = dataService.GetAllTeams();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CONSTANTS.MESSAGEBOX_ERROR_TITLE);
            }

            cmbNewPlayerTeam.DataSource = dataTable;
            cmbNewPlayerTeam.DisplayMember = dataTable.Columns[(int)Enumerators.EnumTeam.teamName].ToString();
            cmbNewPlayerTeam.SelectedItem = null;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(OpenPlayerForm));
            thread.Start();
            Close();
        }

        private void OpenPlayerForm()
        {
            Application.Run(new PlayerForm());
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dataService = new DataService();

            if (tbxNewPlayerName.Text.Equals(CONSTANTS.EMPTY_STRING))
            {
                MessageBox.Show(CONSTANTS.UPDATE_NAME_FIELD_EMPTY, CONSTANTS.MESSAGEBOX_ERROR_TITLE);
            }
            else
            {
                try
                {
                    if (dataService.AddNewPlayer(tbxNewPlayerName.Text, cmbNewPlayerTeam.Text) > 0)
                    {
                        MessageBox.Show(CONSTANTS.WELCOME_NEW_PLAYER_MESSAGE, CONSTANTS.MESSAGEBOX_SUCCESS_TITLE);
                        tbxNewPlayerName.Text = CONSTANTS.EMPTY_STRING;
                        cmbNewPlayerTeam.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show(CONSTANTS.PLAYER_ALREADY_EXISTS_ERROR, CONSTANTS.MESSAGEBOX_ERROR_TITLE);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, CONSTANTS.MESSAGEBOX_ERROR_TITLE);
                }
            }
        }
    }
}
