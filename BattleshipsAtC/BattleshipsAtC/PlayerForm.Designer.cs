namespace BattleshipsAtC
{
    partial class PlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.tabLayoutPlayerInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblChangePlayerName = new System.Windows.Forms.Label();
            this.lblPlayerTeam = new System.Windows.Forms.Label();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.cmbPlayerTeam = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.tabLayoutMenuButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.tabLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playerTreeView = new System.Windows.Forms.TreeView();
            this.tabLayoutEditPlayerButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCurrentPlayer = new System.Windows.Forms.Button();
            this.tabLayoutPlayerInfo.SuspendLayout();
            this.tabLayoutMenuButtons.SuspendLayout();
            this.tabLayoutPanel.SuspendLayout();
            this.tabLayoutEditPlayerButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayoutPlayerInfo
            // 
            this.tabLayoutPlayerInfo.ColumnCount = 1;
            this.tabLayoutPlayerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutPlayerInfo.Controls.Add(this.lblChangePlayerName, 0, 0);
            this.tabLayoutPlayerInfo.Controls.Add(this.lblPlayerTeam, 0, 3);
            this.tabLayoutPlayerInfo.Controls.Add(this.tbxPlayerName, 0, 1);
            this.tabLayoutPlayerInfo.Controls.Add(this.cmbPlayerTeam, 0, 4);
            this.tabLayoutPlayerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutPlayerInfo.Location = new System.Drawing.Point(606, 71);
            this.tabLayoutPlayerInfo.Name = "tabLayoutPlayerInfo";
            this.tabLayoutPlayerInfo.RowCount = 6;
            this.tabLayoutPlayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPlayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPlayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabLayoutPlayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPlayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPlayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabLayoutPlayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayoutPlayerInfo.Size = new System.Drawing.Size(195, 260);
            this.tabLayoutPlayerInfo.TabIndex = 6;
            this.tabLayoutPlayerInfo.Visible = false;
            // 
            // lblChangePlayerName
            // 
            this.lblChangePlayerName.AutoSize = true;
            this.lblChangePlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChangePlayerName.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePlayerName.Location = new System.Drawing.Point(3, 0);
            this.lblChangePlayerName.Name = "lblChangePlayerName";
            this.lblChangePlayerName.Size = new System.Drawing.Size(189, 52);
            this.lblChangePlayerName.TabIndex = 5;
            this.lblChangePlayerName.Text = "name";
            this.lblChangePlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerTeam
            // 
            this.lblPlayerTeam.AutoSize = true;
            this.lblPlayerTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayerTeam.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTeam.Location = new System.Drawing.Point(3, 130);
            this.lblPlayerTeam.Name = "lblPlayerTeam";
            this.lblPlayerTeam.Size = new System.Drawing.Size(189, 52);
            this.lblPlayerTeam.TabIndex = 0;
            this.lblPlayerTeam.Text = "team";
            this.lblPlayerTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxPlayerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxPlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPlayerName.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayerName.Location = new System.Drawing.Point(3, 55);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(189, 43);
            this.tbxPlayerName.TabIndex = 6;
            // 
            // cmbPlayerTeam
            // 
            this.cmbPlayerTeam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbPlayerTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPlayerTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPlayerTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPlayerTeam.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlayerTeam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbPlayerTeam.FormattingEnabled = true;
            this.cmbPlayerTeam.Location = new System.Drawing.Point(3, 185);
            this.cmbPlayerTeam.Name = "cmbPlayerTeam";
            this.cmbPlayerTeam.Size = new System.Drawing.Size(189, 43);
            this.cmbPlayerTeam.TabIndex = 7;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveChanges.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(3, 55);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(192, 46);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // tabLayoutMenuButtons
            // 
            this.tabLayoutMenuButtons.ColumnCount = 1;
            this.tabLayoutMenuButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutMenuButtons.Controls.Add(this.btnNewPlayer, 0, 1);
            this.tabLayoutMenuButtons.Controls.Add(this.btnReturn, 0, 3);
            this.tabLayoutMenuButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutMenuButtons.Location = new System.Drawing.Point(405, 337);
            this.tabLayoutMenuButtons.Name = "tabLayoutMenuButtons";
            this.tabLayoutMenuButtons.RowCount = 4;
            this.tabLayoutMenuButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutMenuButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutMenuButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tabLayoutMenuButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutMenuButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayoutMenuButtons.Size = new System.Drawing.Size(195, 237);
            this.tabLayoutMenuButtons.TabIndex = 4;
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPlayer.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayer.Location = new System.Drawing.Point(3, 50);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(189, 41);
            this.btnNewPlayer.TabIndex = 3;
            this.btnNewPlayer.Text = "new player";
            this.btnNewPlayer.UseVisualStyleBackColor = false;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(3, 191);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(189, 43);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayers.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(405, 0);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(195, 68);
            this.lblPlayers.TabIndex = 1;
            this.lblPlayers.Text = "players";
            this.lblPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabLayoutPanel
            // 
            this.tabLayoutPanel.ColumnCount = 5;
            this.tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPanel.Controls.Add(this.tabLayoutMenuButtons, 2, 2);
            this.tabLayoutPanel.Controls.Add(this.lblPlayers, 2, 0);
            this.tabLayoutPanel.Controls.Add(this.playerTreeView, 2, 1);
            this.tabLayoutPanel.Controls.Add(this.tabLayoutPlayerInfo, 3, 1);
            this.tabLayoutPanel.Controls.Add(this.tabLayoutEditPlayerButtons, 4, 1);
            this.tabLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tabLayoutPanel.Name = "tabLayoutPanel";
            this.tabLayoutPanel.RowCount = 3;
            this.tabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.35928F));
            this.tabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.64072F));
            this.tabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayoutPanel.Size = new System.Drawing.Size(1008, 577);
            this.tabLayoutPanel.TabIndex = 0;
            // 
            // playerTreeView
            // 
            this.playerTreeView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.playerTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playerTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerTreeView.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.playerTreeView.Location = new System.Drawing.Point(405, 71);
            this.playerTreeView.Name = "playerTreeView";
            this.playerTreeView.ShowLines = false;
            this.playerTreeView.ShowPlusMinus = false;
            this.playerTreeView.Size = new System.Drawing.Size(195, 260);
            this.playerTreeView.TabIndex = 7;
            this.playerTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.playerTreeView_NodeMouseClick);
            // 
            // tabLayoutEditPlayerButtons
            // 
            this.tabLayoutEditPlayerButtons.ColumnCount = 1;
            this.tabLayoutEditPlayerButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutEditPlayerButtons.Controls.Add(this.btnSaveChanges, 0, 1);
            this.tabLayoutEditPlayerButtons.Controls.Add(this.btnCurrentPlayer, 0, 2);
            this.tabLayoutEditPlayerButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutEditPlayerButtons.Location = new System.Drawing.Point(807, 71);
            this.tabLayoutEditPlayerButtons.Name = "tabLayoutEditPlayerButtons";
            this.tabLayoutEditPlayerButtons.RowCount = 5;
            this.tabLayoutEditPlayerButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutEditPlayerButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutEditPlayerButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutEditPlayerButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutEditPlayerButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutEditPlayerButtons.Size = new System.Drawing.Size(198, 260);
            this.tabLayoutEditPlayerButtons.TabIndex = 8;
            // 
            // btnCurrentPlayer
            // 
            this.btnCurrentPlayer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCurrentPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrentPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCurrentPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCurrentPlayer.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentPlayer.Location = new System.Drawing.Point(3, 107);
            this.btnCurrentPlayer.Name = "btnCurrentPlayer";
            this.btnCurrentPlayer.Size = new System.Drawing.Size(192, 46);
            this.btnCurrentPlayer.TabIndex = 1;
            this.btnCurrentPlayer.Text = "select";
            this.btnCurrentPlayer.UseVisualStyleBackColor = false;
            this.btnCurrentPlayer.Click += new System.EventHandler(this.btnCurrentPlayer_Click);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 577);
            this.Controls.Add(this.tabLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 616);
            this.Name = "PlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "battleship players";
            this.tabLayoutPlayerInfo.ResumeLayout(false);
            this.tabLayoutPlayerInfo.PerformLayout();
            this.tabLayoutMenuButtons.ResumeLayout(false);
            this.tabLayoutPanel.ResumeLayout(false);
            this.tabLayoutPanel.PerformLayout();
            this.tabLayoutEditPlayerButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayoutPlayerInfo;
        private System.Windows.Forms.Label lblPlayerTeam;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblChangePlayerName;
        private System.Windows.Forms.TableLayoutPanel tabLayoutMenuButtons;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.TableLayoutPanel tabLayoutPanel;
        private System.Windows.Forms.TreeView playerTreeView;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.TableLayoutPanel tabLayoutEditPlayerButtons;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.ComboBox cmbPlayerTeam;
        private System.Windows.Forms.Button btnCurrentPlayer;
    }
}