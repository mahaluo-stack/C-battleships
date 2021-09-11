namespace BattleshipsAtC
{
    partial class NewPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayerForm));
            this.tabLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabLayoutNewPlayerControls = new System.Windows.Forms.TableLayoutPanel();
            this.cmbNewPlayerTeam = new System.Windows.Forms.ComboBox();
            this.lblNewPlayerName = new System.Windows.Forms.Label();
            this.lblNewPlayerTeam = new System.Windows.Forms.Label();
            this.tbxNewPlayerName = new System.Windows.Forms.TextBox();
            this.lblAddNewPlayer = new System.Windows.Forms.Label();
            this.tabLayoutMenuControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.tabLayoutPanel.SuspendLayout();
            this.tabLayoutNewPlayerControls.SuspendLayout();
            this.tabLayoutMenuControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayoutPanel
            // 
            this.tabLayoutPanel.ColumnCount = 5;
            this.tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutPanel.Controls.Add(this.tabLayoutNewPlayerControls, 2, 1);
            this.tabLayoutPanel.Controls.Add(this.lblAddNewPlayer, 2, 0);
            this.tabLayoutPanel.Controls.Add(this.tabLayoutMenuControls, 2, 2);
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
            this.tabLayoutPanel.TabIndex = 1;
            // 
            // tabLayoutNewPlayerControls
            // 
            this.tabLayoutNewPlayerControls.ColumnCount = 1;
            this.tabLayoutNewPlayerControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutNewPlayerControls.Controls.Add(this.cmbNewPlayerTeam, 0, 4);
            this.tabLayoutNewPlayerControls.Controls.Add(this.lblNewPlayerName, 0, 0);
            this.tabLayoutNewPlayerControls.Controls.Add(this.lblNewPlayerTeam, 0, 3);
            this.tabLayoutNewPlayerControls.Controls.Add(this.tbxNewPlayerName, 0, 1);
            this.tabLayoutNewPlayerControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutNewPlayerControls.Location = new System.Drawing.Point(405, 71);
            this.tabLayoutNewPlayerControls.Name = "tabLayoutNewPlayerControls";
            this.tabLayoutNewPlayerControls.RowCount = 6;
            this.tabLayoutNewPlayerControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutNewPlayerControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutNewPlayerControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabLayoutNewPlayerControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutNewPlayerControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutNewPlayerControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabLayoutNewPlayerControls.Size = new System.Drawing.Size(195, 260);
            this.tabLayoutNewPlayerControls.TabIndex = 4;
            // 
            // cmbNewPlayerTeam
            // 
            this.cmbNewPlayerTeam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbNewPlayerTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNewPlayerTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbNewPlayerTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbNewPlayerTeam.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewPlayerTeam.FormattingEnabled = true;
            this.cmbNewPlayerTeam.ItemHeight = 35;
            this.cmbNewPlayerTeam.Location = new System.Drawing.Point(3, 185);
            this.cmbNewPlayerTeam.Name = "cmbNewPlayerTeam";
            this.cmbNewPlayerTeam.Size = new System.Drawing.Size(189, 43);
            this.cmbNewPlayerTeam.TabIndex = 2;
            // 
            // lblNewPlayerName
            // 
            this.lblNewPlayerName.AutoSize = true;
            this.lblNewPlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewPlayerName.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPlayerName.Location = new System.Drawing.Point(3, 0);
            this.lblNewPlayerName.Name = "lblNewPlayerName";
            this.lblNewPlayerName.Size = new System.Drawing.Size(189, 52);
            this.lblNewPlayerName.TabIndex = 3;
            this.lblNewPlayerName.Text = "name";
            this.lblNewPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewPlayerTeam
            // 
            this.lblNewPlayerTeam.AutoSize = true;
            this.lblNewPlayerTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewPlayerTeam.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPlayerTeam.Location = new System.Drawing.Point(3, 130);
            this.lblNewPlayerTeam.Name = "lblNewPlayerTeam";
            this.lblNewPlayerTeam.Size = new System.Drawing.Size(189, 52);
            this.lblNewPlayerTeam.TabIndex = 0;
            this.lblNewPlayerTeam.Text = "team";
            this.lblNewPlayerTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxNewPlayerName
            // 
            this.tbxNewPlayerName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxNewPlayerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxNewPlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNewPlayerName.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPlayerName.Location = new System.Drawing.Point(3, 55);
            this.tbxNewPlayerName.Name = "tbxNewPlayerName";
            this.tbxNewPlayerName.Size = new System.Drawing.Size(189, 43);
            this.tbxNewPlayerName.TabIndex = 4;
            // 
            // lblAddNewPlayer
            // 
            this.lblAddNewPlayer.AutoSize = true;
            this.lblAddNewPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddNewPlayer.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewPlayer.Location = new System.Drawing.Point(405, 0);
            this.lblAddNewPlayer.Name = "lblAddNewPlayer";
            this.lblAddNewPlayer.Size = new System.Drawing.Size(195, 68);
            this.lblAddNewPlayer.TabIndex = 5;
            this.lblAddNewPlayer.Text = "new player";
            this.lblAddNewPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabLayoutMenuControls
            // 
            this.tabLayoutMenuControls.ColumnCount = 1;
            this.tabLayoutMenuControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutMenuControls.Controls.Add(this.btnReturn, 0, 3);
            this.tabLayoutMenuControls.Controls.Add(this.btnAddNew, 0, 1);
            this.tabLayoutMenuControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutMenuControls.Location = new System.Drawing.Point(405, 337);
            this.tabLayoutMenuControls.Name = "tabLayoutMenuControls";
            this.tabLayoutMenuControls.RowCount = 4;
            this.tabLayoutMenuControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutMenuControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutMenuControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tabLayoutMenuControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayoutMenuControls.Size = new System.Drawing.Size(195, 237);
            this.tabLayoutMenuControls.TabIndex = 4;
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
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(3, 50);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(189, 41);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "add";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // NewPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 577);
            this.Controls.Add(this.tabLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 616);
            this.Name = "NewPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "new player";
            this.tabLayoutPanel.ResumeLayout(false);
            this.tabLayoutPanel.PerformLayout();
            this.tabLayoutNewPlayerControls.ResumeLayout(false);
            this.tabLayoutNewPlayerControls.PerformLayout();
            this.tabLayoutMenuControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tabLayoutNewPlayerControls;
        private System.Windows.Forms.Label lblNewPlayerName;
        private System.Windows.Forms.Label lblNewPlayerTeam;
        private System.Windows.Forms.ComboBox cmbNewPlayerTeam;
        private System.Windows.Forms.TextBox tbxNewPlayerName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblAddNewPlayer;
        private System.Windows.Forms.TableLayoutPanel tabLayoutMenuControls;
        private System.Windows.Forms.Button btnReturn;
    }
}