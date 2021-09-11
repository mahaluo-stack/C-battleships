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
    public partial class PlayerForm : Form
    {
        #region fields
        #region class objects
        ProgramService programService;
        DataService dataService;
        Thread thread;
        DataTable dataTable;
        #endregion
        #endregion

        public PlayerForm()
        {
            InitializeComponent();
            dataService = new DataService();
            if (CurrentPlayer.PlayerName != null)
            {
                lblPlayers.Text = CurrentPlayer.PlayerName;
            }
            ReloadEditPlayerControls(GetPlayerTable(), GetTeamTable());
        }

        private DataTable GetTeamTable()
        {
            dataTable = new DataTable();

            try
            {
                return dataTable = dataService.GetAllTeams();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CONSTANTS.MESSAGEBOX_ERROR_TITLE);
                return null;
            }
        }

        private DataTable GetPlayerTable()
        {
            dataTable = new DataTable();
            try
            {
                return dataTable = dataService.GetAllPlayers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CONSTANTS.MESSAGEBOX_ERROR_TITLE);
                return null;
            }
        }

        private void ReloadEditPlayerControls(DataTable playerTable, DataTable teamTable)
        {
            UpdatePlayerTreeView(playerTable);
            UpdateTeamComboBox(teamTable);
        }

        private void UpdateTeamComboBox(DataTable teamTable)
        {
            cmbPlayerTeam.DataSource = teamTable;
            cmbPlayerTeam.DisplayMember = teamTable.Columns[(int)Enumerators.EnumTeam.teamName].ToString();
            cmbPlayerTeam.SelectedItem = null;
        }

        private void UpdatePlayerTreeView(DataTable playerTable)
        {

            playerTreeView.BeginUpdate();
            playerTreeView.Nodes.Clear();
            for (int i = 0; i < playerTable.Rows.Count; i++)
            {
                playerTreeView.Nodes.Add(playerTable.Rows[i][(int)Enumerators.EnumPlayer.playerName].ToString());
                playerTreeView.Nodes[i].Nodes.Add(CONSTANTS.TREE_VIEW_TEAM + playerTable.Rows[i][(int)Enumerators.EnumPlayer.playerTeam].ToString());
                playerTreeView.Nodes[i].Nodes.Add(CONSTANTS.TREE_VIEW_WINS + playerTable.Rows[i][(int)Enumerators.EnumPlayer.wins].ToString());
                playerTreeView.Nodes[i].Nodes.Add(CONSTANTS.TREE_VIEW_LOSSES + playerTable.Rows[i][(int)Enumerators.EnumPlayer.losses].ToString());
                playerTreeView.Nodes[i].Nodes.Add(CONSTANTS.TREE_VIEW_SCORE + playerTable.Rows[i][(int)Enumerators.EnumPlayer.score].ToString());
            }
          
            playerTreeView.EndUpdate();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbxPlayerName.Text.Equals(CONSTANTS.EMPTY_STRING))
            {
                MessageBox.Show(CONSTANTS.UPDATE_NAME_FIELD_EMPTY, CONSTANTS.MESSAGEBOX_ERROR_TITLE);
            }
            else
            {
                try
                {
                    if (dataService.UpdatePlayer(CurrentPlayer.PlayerName, tbxPlayerName.Text, cmbPlayerTeam.Text.TrimStart(CONSTANTS.TEAM_CHAR_ARRAY)) == CONSTANTS.DATABASE_SUCCESS)
                    {
                        tabLayoutPlayerInfo.Visible = false;
                        ReloadEditPlayerControls(GetPlayerTable(), GetTeamTable());
                    }
                    else
                    {
                        MessageBox.Show(CONSTANTS.ERROR_MESSAGE, CONSTANTS.MESSAGEBOX_ERROR_TITLE);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, CONSTANTS.MESSAGEBOX_ERROR_TITLE);
                }
                
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(OpenStartWindow));
            thread.Start();
            Close();
        }

        private void OpenStartWindow()
        {
            Application.Run(new StartWindow());
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(OpenNewPlayerForm));
            thread.Start();
            Close();
        }

        private void OpenNewPlayerForm()
        {
            Application.Run(new NewPlayerForm());
        }

        private void playerTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tabLayoutPlayerInfo.Visible = true;
            
            TreeNode node = e.Node;
            


            if (e.Node.FirstNode != null)
            {
                SetCurrentPlayer(node.Text, node.FirstNode.Text.TrimStart(CONSTANTS.TEAM_CHAR_ARRAY));
                tbxPlayerName.Text = CurrentPlayer.PlayerName;
                cmbPlayerTeam.SelectedIndex = cmbPlayerTeam.FindString(CurrentPlayer.PlayerTeam);
            }
        }

        private void SetCurrentPlayer(string playerName, string playerTeam)
        {
            CurrentPlayer.PlayerName = playerName;
            CurrentPlayer.PlayerTeam = playerTeam;
        }

        private void btnCurrentPlayer_Click(object sender, EventArgs e)
        {

            lblPlayers.Text = CurrentPlayer.PlayerName;
        }
    }
}
