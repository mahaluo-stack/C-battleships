using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BattleshipsAtC
{
    public partial class SetupGameWindow : Form
    {
        private delegate void InvokeHandler();
        private Point ptOriginal = Point.Empty;
        private Thread thread;

        public SetupGameWindow()
        {
            InitializeComponent();
            lblPlayerName.Text = CurrentPlayer.PlayerName;
            LoadShips(CurrentPlayer.PlayerTeam);
            
        }
    
        private void SetupGameWindow_Load(object sender, EventArgs e)
        {
            const int tileSize = 48;
            const int gridSize = 9;
            var clr1 = Color.MidnightBlue;
            var clr2 = Color.MidnightBlue;

            for (int i = 0; i < gridSize; i++)
            {

                for (int j = 0; j < gridSize; j++)
                {
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * i, tileSize * j)
                    };

                    if (j == 0 && i != 0)
                    {
                        switch (i)
                        {
                            case 1:
                                newPanel.BackgroundImage = Properties.Resources.HTile1;
                                break;
                            case 2:
                                newPanel.BackgroundImage = Properties.Resources.HTile2;
                                break;
                            case 3:
                                newPanel.BackgroundImage = Properties.Resources.HTile3;
                                break;
                            case 4:
                                newPanel.BackgroundImage = Properties.Resources.HTile4;
                                break;
                            case 5:
                                newPanel.BackgroundImage = Properties.Resources.HTile5;
                                break;
                            case 6:
                                newPanel.BackgroundImage = Properties.Resources.HTile6;
                                break;
                            case 7:
                                newPanel.BackgroundImage = Properties.Resources.HTile7;
                                break;
                            case 8:
                                newPanel.BackgroundImage = Properties.Resources.HTile8;
                                break;
                            default:
                                break;
                        }
                    }
                    else if (i == 0)
                    {
                        switch(j)
                        {
                            case 1:
                                newPanel.BackgroundImage = Properties.Resources.VTile1;
                                break;
                            case 2:
                                newPanel.BackgroundImage = Properties.Resources.VTile2;
                                break;
                            case 3:
                                newPanel.BackgroundImage = Properties.Resources.VTile3;
                                break;
                            case 4:
                                newPanel.BackgroundImage = Properties.Resources.VTile4;
                                break;
                            case 5:
                                newPanel.BackgroundImage = Properties.Resources.VTile5;
                                break;
                            case 6:
                                newPanel.BackgroundImage = Properties.Resources.VTile6;
                                break;
                            case 7:
                                newPanel.BackgroundImage = Properties.Resources.VTile7;
                                break;
                            case 8:
                                newPanel.BackgroundImage = Properties.Resources.VTile8;
                                break;
                            default:
                                break;
                        }
                       
                    }
                    else
                    {
                        newPanel.AllowDrop = true;
                        newPanel.BackgroundImage = Properties.Resources.EmptyTile;
                        newPanel.DragDrop += new DragEventHandler(gridPanel_DragDrop);
                        newPanel.DragEnter += new DragEventHandler(gridPanel_DragEnter);
                    }

                    newPanel.BorderStyle = BorderStyle.FixedSingle;
                    newPanel.BackgroundImageLayout = ImageLayout.Center;



                    gridPanel.Controls.Add(newPanel);
                }
            }
        }

       

        private void LoadShips(string playerTeam)
        {
            switch(playerTeam)
            {
                case CONSTANTS.BLUE_TEAM:
                    carrierPanel.BackgroundImage = Properties.Resources.BlueTeamCarrier;
                    destroyerPanel.BackgroundImage = Properties.Resources.BlueTeamDestroyer;
                    galleyPanel.BackgroundImage = Properties.Resources.BlueTeamGalley;
                    break;
                case CONSTANTS.RED_TEAM:
                    carrierPanel.BackgroundImage = Properties.Resources.RedTeamCarrier;
                    destroyerPanel.BackgroundImage = Properties.Resources.RedTeamDestroyer;
                    galleyPanel.BackgroundImage = Properties.Resources.RedTeamGalley;
                    break;
                case CONSTANTS.YELLOW_TEAM:
                    carrierPanel.BackgroundImage = Properties.Resources.YellowTeamCarrier;
                    destroyerPanel.BackgroundImage = Properties.Resources.YellowTeamDestroyer;
                    galleyPanel.BackgroundImage = Properties.Resources.YellowTeamGalley;
                    break;
                default:
                    break;
            }
            submarinePanel.BackgroundImage = Properties.Resources.Submarine;

            carrierPanel.MouseDown += new MouseEventHandler(shipMouseDown);
            destroyerPanel.MouseDown += new MouseEventHandler(shipMouseDown);
            galleyPanel.MouseDown += new MouseEventHandler(shipMouseDown);
            submarinePanel.MouseDown += new MouseEventHandler(shipMouseDown);

            carrierPanel.BackgroundImage.Tag = CONSTANTS.CARRIERTAG;
            destroyerPanel.BackgroundImage.Tag = CONSTANTS.DESTROYERTAG;
            galleyPanel.BackgroundImage.Tag = CONSTANTS.GALLEYTAG;
            submarinePanel.BackgroundImage.Tag = CONSTANTS.SUBMARINETAG;
        }

       


      


        private void gridPanel_DragDrop(object sender, DragEventArgs e)
        {
            Invoke(new InvokeHandler(delegate ()
            {
                Panel pb = (Panel)sender;
                pb.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                int X = (pb.Location.X / 48);
                int Y = (pb.Location.Y / 48);
                Point shipLocation = new Point(X, Y);

                if (rbtnHorizontal.Checked)
                {
                    PlaceHorizontalShip(pb.BackgroundImage.Tag.ToString(), shipLocation);
                }
                else
                {
                    PlaceVerticalShip(pb.BackgroundImage.Tag.ToString(), shipLocation);
                }


            }));
        }

        private void PlaceVerticalShip(string shipTag, Point shipLocation)
        {
           
        }

        private void PlaceHorizontalShip(string shipTag, Point shipLocation)
        {
            switch (shipTag)
            {
                case CONSTANTS.CARRIERTAG:

                    if (shipLocation.X >= 3)
                    {
                        for (int i = 1; i < 6; i++)
                        {
                            Point carrierPart = new Point(i, shipLocation.Y);
                            carrierPart.X = carrierPart.X * 48;
                            carrierPart.Y = carrierPart.Y * 48;
                            switch (i)
                            {
                                case 1:
                                    gridPanel.GetChildAtPoint(carrierPart).BackgroundImage = Properties.Resources.HCarrier1;
                                    break;
                                case 2:
                                    gridPanel.GetChildAtPoint(carrierPart).BackgroundImage = Properties.Resources.HCarrier2;
                                    break;

                                case 3:
                                    gridPanel.GetChildAtPoint(carrierPart).BackgroundImage = Properties.Resources.HCarrier3;
                                    break;

                                case 4:
                                    gridPanel.GetChildAtPoint(carrierPart).BackgroundImage = Properties.Resources.HCarrier4;
                                    break;

                                case 5:
                                    gridPanel.GetChildAtPoint(carrierPart).BackgroundImage = Properties.Resources.HCarrier5;
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {

                    }

                    break;

                case CONSTANTS.DESTROYERTAG:

                    break;

                case CONSTANTS.GALLEYTAG:

                    break;

                case CONSTANTS.SUBMARINETAG:

                    break;
                default:
                    break;
            }
        }

        private void gridPanel_DragEnter(object sender, DragEventArgs e)
        {
            Invoke(new InvokeHandler(delegate ()
            {
                e.Effect = DragDropEffects.Copy;
            }));
        }

        private void shipMouseDown(object sender, MouseEventArgs e)
        {
            Invoke(new InvokeHandler(delegate ()
            {
                Panel pb = (Panel)sender;
                pb.Select();
                pb.DoDragDrop(pb.BackgroundImage, DragDropEffects.Copy);
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(OpenStartWindow));
            thread.Start();
            Close();
        }

        private void OpenStartWindow()
        {
            Application.Run(new StartWindow());
        }
    }
}
