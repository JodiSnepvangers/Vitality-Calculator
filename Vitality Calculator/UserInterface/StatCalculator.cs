using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterMerger.UserInterface {
    public partial class StatCalculator : Form {
        public StatCalculator() {
            InitializeComponent();
        }

        private void panelVitality_Paint(object sender, PaintEventArgs e) {

            Pen pen = new Pen(Color.Black);
            //pen.DashPattern = new float[] { 4.0F, 4.0F};
            pen.Width = 1;

            //general pen settings:
            int lenght = 142;

            //make a line for maximum:
            Point location = LabelVitalityMaximum.Location;
            int xOffset = 30;
            e.Graphics.DrawLine(pen, location.X + xOffset, location.Y, location.X + xOffset, location.Y + lenght);

            //make line for threshold
            location = LabelVitalityThreshold.Location;
            xOffset = 30;
            e.Graphics.DrawLine(pen, location.X + xOffset, location.Y, location.X + xOffset, location.Y + lenght);


            //change width:
            pen.Width = 1;
            lenght = 150;
            xOffset = 70;

            //make line for injured:
            location = LabelInjured.Location;
            int yoffset = 9;
            e.Graphics.DrawLine(pen, xOffset, location.Y + yoffset, xOffset + lenght, location.Y + yoffset);

            //make line for mauled:
            location = LabelMauled.Location;
            yoffset = 9;
            e.Graphics.DrawLine(pen, xOffset, location.Y + yoffset, xOffset + lenght, location.Y + yoffset);

            //make line for Critical:
            location = LabelCritical.Location;
            yoffset = 9;
            e.Graphics.DrawLine(pen, xOffset, location.Y + yoffset, xOffset + lenght, location.Y + yoffset);

            //make line for Deadly:
            location = LabelDeadly.Location;
            yoffset = 9;
            e.Graphics.DrawLine(pen, xOffset, location.Y + yoffset, xOffset + lenght, location.Y + yoffset);

            //make line for Overkill:
            location = LabelOverkill.Location;
            yoffset = 9;
            e.Graphics.DrawLine(pen, xOffset, location.Y + yoffset, xOffset + lenght, location.Y + yoffset);
            pen.Dispose();
        }

        private void ValueChanged(object sender, EventArgs e) {
            //first update athlethics calculations
            CalculateDisplay(IntPutAthletics, LabelAthleticsCalc);

            //calculate maximum:
            TextSet(DisplayMaxInjured, CalculateVitality(true, 0, (int)IntPutConviction.Value));
            TextSet(DisplayMaxMauled, CalculateVitality(true, 1, (int)IntPutConviction.Value));
            TextSet(DisplayMaxCritical, CalculateVitality(true, 2, (int)IntPutConviction.Value));
            TextSet(DisplayMaxDeadly, CalculateVitality(true, 3, (int)IntPutConviction.Value));

            //calculate Threshold:
            TextSet(DisplayThresholdInjured, CalculateVitality(false, 0, (int)IntPutBody.Value));
            TextSet(DisplayThresholdMauled, CalculateVitality(false, 1, (int)IntPutBody.Value));
            TextSet(DisplayThresholdCritical, CalculateVitality(false, 2, (int)IntPutBody.Value));
            TextSet(DisplayThresholdDeadly, CalculateVitality(false, 3, (int)IntPutBody.Value));
            TextSet(DisplayThresholdOverkill, CalculateVitality(false, 4, (int)IntPutBody.Value));

            //calculate all numbers:
            int stepSpeed = (int)(IntPutBody.Value + IntPutAthletics.Value);
            int totalSpeed = (int)(stepSpeed * IntPutMoveAmount.Value);
            int maxTiles = (int)(IntPutTileSize.Value * IntPutMoveAmount.Value);

            int totalTiles = (int)(totalSpeed / IntPutTileSize.Value);
            int leftOver = (int)(totalSpeed % IntPutTileSize.Value);
            

            //update display:
            TextSet(DisplayStepSpeed, stepSpeed);
            TextSet(DisplayTileAmount, totalTiles);
            TextSet(DisplayLeftOver, leftOver);
            TextSet(DisplayTotalSpeed, totalSpeed);

        }
















        //generic calculation method
        private void CalculateDisplay(NumericUpDown input, Label display) {
            if(input.Value == 0) {
                display.Text = "2x 6+";
            } else {
                display.Text = (7 - input.Value) + "+";
            }
        }


        //sets a text field while respecting the minimum and maximum values
        private void TextSet(Label field, int input) {
            field.Text = "" + Math.Max(Math.Min(input, 999), 0);
        }










        //vitality calculations:

        public int CalculateVitality(bool calcMax, int calcType, int requiredStat) {
            if(calcMax) {
                //calculating maximum:
                /** 
                    I: =conviction
                    M: conviction-1
                    C: conviction -2
                    D: only 1
                    O: only ever 1
                 */

                if(calcType >= 3) {
                    return 1;
                } else {
                    return requiredStat - calcType;
                }
            } else {
                //calculating Threshold:
                /**
                    I: 1+(body/2)
                    M: 1 + body
                    C: 1+ (body2)
                    D: 1+(body3)
                    O: 1+(body*4)
                 */
                if(calcType <= 0) {
                    return 1 + (requiredStat / 2);
                } else {
                    return 1 + (requiredStat * calcType);
                }
            }
        }
    }
}
