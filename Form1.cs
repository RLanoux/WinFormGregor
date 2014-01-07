using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormGregor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoWork()
        {
            //MessageBox that identifies what's going to happen
            MessageBox.Show("Watch Gregor the Drunken Cockroach\n wander the kitchen floor!",
                "Gregor the Drunken Cockroach",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            //-------------------------------------------------------
            //Declare constants
            const Int32 XLIMIT = 8;
            const Int32 YLIMIT = 8;

            //Declare and initialize variables
            Int32 iOldX = 0;
            Int32 iOldY = 0;
            Int32 iNewX = 0;
            Int32 iNewY = 0;
            Int32 iZeroCount = 0;

            Random rnd = new Random();
            Boolean bAllTilesCovered = false;

            //Make the floor
            Int32[,] iFloor = new Int32[XLIMIT, YLIMIT];

            //Randomly generate a starting point
            //iStart = rnd.Next(XLIMIT, YLIMIT);

            //Set the values to zero
            for (Int32 j = 0; j < YLIMIT; j++)
            {
                for (Int32 i = 0; i < XLIMIT; i++)
                {
                    iFloor[j, i] = 0;
                }
            }

            //Randomly select a tile
            iNewX = rnd.Next(0, XLIMIT);
            iNewY = rnd.Next(0, YLIMIT);

            //Increment that tile's count
            iFloor[iNewX, iNewY]++;
            while (!bAllTilesCovered)
            {


                //Randomly select new title coordinates that are adjacent to but not the same as
                iOldX = iNewX;
                iOldY = iNewY;
                if (iNewX == XLIMIT - 1)
                {
                    iNewX = rnd.Next(iOldX - 1, XLIMIT);
                }
                else if (iNewX == 0)
                {
                    iNewX = rnd.Next(iOldX, iOldX + 2);
                }
                else
                {
                    iNewX = rnd.Next(iOldX - 1, iOldX + 2);
                }
                if (iNewY == YLIMIT - 1)
                {
                    iNewY = rnd.Next(iOldY - 1, YLIMIT);
                }
                else if (iNewY == 0)
                {
                    iNewY = rnd.Next(iOldY, iOldY + 2);
                }
                else
                {
                    iNewY = rnd.Next(iOldY - 1, iOldY + 2);
                }

                //Rule out selectiong of the same tile
                while ((iOldX == iNewX) && (iOldY == iNewY))
                {
                    if (iNewX == XLIMIT - 1)
                    {
                        iNewX = rnd.Next(iOldX - 1, XLIMIT);
                    }
                    else if (iNewX == 0)
                    {
                        iNewX = rnd.Next(iOldX, iOldX + 2);
                    }
                    else
                    {
                        iNewX = rnd.Next(iOldX - 1, iOldX + 2);
                    }

                    if (iNewY == YLIMIT - 1)
                    {
                        iNewY = rnd.Next(iOldY - 1, YLIMIT);
                    }
                    else if (iNewY == 0)
                    {
                        iNewY = rnd.Next(iOldY, iOldY + 1);
                    }
                    else
                    {
                        iNewY = rnd.Next(iOldY - 1, iOldY + 2);
                    }
                }

                //Move Gregor to the new tile(increment that tile's value)
                iFloor[iNewX, iNewY]++;
                iZeroCount = 0;

                //Update the visuals
                String sPosition = iNewX.ToString() + iNewY.ToString();
                switch (sPosition)
                {
                    case "00":
                    lblTile00.BackColor = Color.LightYellow;
                    lblTile00.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "01":
                    lblTile01.BackColor = Color.LightYellow;
                    lblTile01.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "02":
                    lblTile02.BackColor = Color.LightYellow;
                    lblTile02.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "03":
                    lblTile03.BackColor = Color.LightYellow;
                    lblTile03.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "04":
                    lblTile04.BackColor = Color.LightYellow;
                    lblTile04.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "05":
                    lblTile05.BackColor = Color.LightYellow;
                    lblTile05.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "06":
                    lblTile06.BackColor = Color.LightYellow;
                    lblTile06.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "07":
                    lblTile07.BackColor = Color.LightYellow;
                    lblTile07.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "10":
                    lblTile10.BackColor = Color.LightYellow;
                    lblTile10.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "11":
                    lblTile11.BackColor = Color.LightYellow;
                    lblTile11.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "12":
                    lblTile12.BackColor = Color.LightYellow;
                    lblTile12.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "13":
                    lblTile13.BackColor = Color.LightYellow;
                    lblTile13.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "14":
                    lblTile14.BackColor = Color.LightYellow;
                    lblTile14.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "15":
                    lblTile15.BackColor = Color.LightYellow;
                    lblTile15.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "16":
                    lblTile16.BackColor = Color.LightYellow;
                    lblTile16.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "17":
                    lblTile17.BackColor = Color.LightYellow;
                    lblTile17.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "20":
                    lblTile20.BackColor = Color.LightYellow;
                    lblTile20.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "21":
                    lblTile21.BackColor = Color.LightYellow;
                    lblTile21.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "22":
                    lblTile22.BackColor = Color.LightYellow;
                    lblTile22.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "23":
                    lblTile23.BackColor = Color.LightYellow;
                    lblTile23.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "24":
                    lblTile24.BackColor = Color.LightYellow;
                    lblTile24.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "25":
                    lblTile25.BackColor = Color.LightYellow;
                    lblTile25.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "26":
                    lblTile26.BackColor = Color.LightYellow;
                    lblTile26.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "27":
                    lblTile27.BackColor = Color.LightYellow;
                    lblTile27.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "30":
                    lblTile30.BackColor = Color.LightYellow;
                    lblTile30.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "31":
                    lblTile31.BackColor = Color.LightYellow;
                    lblTile31.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "32":
                    lblTile32.BackColor = Color.LightYellow;
                    lblTile32.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "33":
                    lblTile33.BackColor = Color.LightYellow;
                    lblTile33.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "34":
                    lblTile34.BackColor = Color.LightYellow;
                    lblTile34.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "35":
                    lblTile35.BackColor = Color.LightYellow;
                    lblTile35.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "36":
                    lblTile36.BackColor = Color.LightYellow;
                    lblTile36.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "37":
                    lblTile37.BackColor = Color.LightYellow;
                    lblTile37.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "40":
                    lblTile40.BackColor = Color.LightYellow;
                    lblTile40.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "41":
                    lblTile41.BackColor = Color.LightYellow;
                    lblTile41.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "42":
                    lblTile42.BackColor = Color.LightYellow;
                    lblTile42.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "43":
                    lblTile43.BackColor = Color.LightYellow;
                    lblTile43.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "44":
                    lblTile44.BackColor = Color.LightYellow;
                    lblTile44.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "45":
                    lblTile45.BackColor = Color.LightYellow;
                    lblTile45.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "46":
                    lblTile46.BackColor = Color.LightYellow;
                    lblTile46.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "47":
                    lblTile47.BackColor = Color.LightYellow;
                    lblTile47.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "50":
                    lblTile50.BackColor = Color.LightYellow;
                    lblTile50.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "51":
                    lblTile51.BackColor = Color.LightYellow;
                    lblTile51.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "52":
                    lblTile52.BackColor = Color.LightYellow;
                    lblTile52.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "53":
                    lblTile53.BackColor = Color.LightYellow;
                    lblTile53.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "54":
                    lblTile54.BackColor = Color.LightYellow;
                    lblTile54.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "55":
                    lblTile55.BackColor = Color.LightYellow;
                    lblTile55.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "56":
                    lblTile56.BackColor = Color.LightYellow;
                    lblTile56.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "57":
                    lblTile57.BackColor = Color.LightYellow;
                    lblTile57.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "60":
                    lblTile60.BackColor = Color.LightYellow;
                    lblTile60.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "61":
                    lblTile61.BackColor = Color.LightYellow;
                    lblTile61.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "62":
                    lblTile62.BackColor = Color.LightYellow;
                    lblTile62.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "63":
                    lblTile63.BackColor = Color.LightYellow;
                    lblTile63.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "64":
                    lblTile64.BackColor = Color.LightYellow;
                    lblTile64.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "65":
                    lblTile65.BackColor = Color.LightYellow;
                    lblTile65.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "66":
                    lblTile66.BackColor = Color.LightYellow;
                    lblTile66.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "67":
                    lblTile67.BackColor = Color.LightYellow;
                    lblTile67.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "70":
                    lblTile70.BackColor = Color.LightYellow;
                    lblTile70.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "71":
                    lblTile71.BackColor = Color.LightYellow;
                    lblTile71.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "72":
                    lblTile72.BackColor = Color.LightYellow;
                    lblTile72.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "73":
                    lblTile73.BackColor = Color.LightYellow;
                    lblTile73.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "74":
                    lblTile74.BackColor = Color.LightYellow;
                    lblTile74.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "75":
                    lblTile75.BackColor = Color.LightYellow;
                    lblTile75.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "76":
                    lblTile76.BackColor = Color.LightYellow;
                    lblTile76.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    case "77":
                    lblTile77.BackColor = Color.LightYellow;
                    lblTile77.Text = iFloor[iNewX, iNewY].ToString();
                    break;

                    default:
                    break;
                }

                //Traverse the array to determine if any value is still 0
                for (Int32 j = 0; j < YLIMIT; j++)
                {
                    for (Int32 i = 0; i < XLIMIT; i++)
                    {
                        if (iFloor[j, i] == 0)
                        {
                            iZeroCount++;
                        }
                    }
                }

                if (iZeroCount == 0)
                {
                    bAllTilesCovered = true;
                }
            } //End of the while loop that generates moves
            //---------------------------------------------------------------------------
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoWork();
        }

        }
    }

