/*
Angle Estimation - An application that lets the user practice guessing angles.
Copyright (C) 2011  Will Hurlburt

Website: https://github.com/willhurlburt/Angle-Estimation

Angle Estimation is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Angle Estimation is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Angle Estimation.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AngleEstimation
{
    public partial class AngleEstimationForm : Form
    {
        private Random R = new Random();

        Pen AnglePen = new Pen(Color.Black, 2);
        Pen ArcPen = new Pen(Color.Black, 1);
        Pen AxisPen = new Pen(Color.Gray, 1);
        
        private int currentAngle = 0;
        private int currentRotation = 0;
        private List<int> errorHistory = new List<int>();

        public AngleEstimationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowNewAngle();
        }

        private void ShowNewAngle()
        {
            currentAngle = R.Next((MaxAngleCheck.Checked) ? 180 : 360);
            currentRotation = (RotateCheck.Checked) ? R.Next(360) : 0;
            DrawingPanel.Invalidate();
            GuessBox.Focus();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int guess;
            if (!int.TryParse(GuessBox.Text, out guess)) return;
            if (0 > guess || guess >= 360) return;
            GuessBox.Text = string.Empty;

            int error = Math.Abs(currentAngle - guess);
            ResultActualDisplay.Text = currentAngle.ToString();
            ResultGuessDisplay.Text = guess.ToString();
            ResultErrorDisplay.Text = error.ToString();
            
            errorHistory.Add(error);
            GuessCountDisplay.Text = errorHistory.Count.ToString();
            AverageErrorDisplay.Text = (errorHistory.Sum() / errorHistory.Count).ToString();

            ShowNewAngle();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            errorHistory.Clear();
            GuessCountDisplay.Text = "0";
            AverageErrorDisplay.Text = "0";
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Point origin = new Point(DrawingPanel.Width / 2, DrawingPanel.Height / 2);
            int size = Math.Min(DrawingPanel.Width / 2, DrawingPanel.Height / 2);
            
            Graphics surface = DrawingPanel.CreateGraphics();
            surface.Clear(DrawingPanel.BackColor);

            if (AxisCheck.Checked)
            {
                surface.DrawLine(AxisPen, origin.X - size, origin.Y, origin.X + size, origin.Y);
                surface.DrawLine(AxisPen, origin.X, origin.Y - size, origin.X, origin.Y + size);
            }

            double baseRads = RadiansFromDegrees(currentRotation);
            double rads = RadiansFromDegrees(currentAngle + currentRotation);
            surface.DrawLine(AnglePen, origin.X, origin.Y, (int)(origin.X + size * Math.Cos(baseRads)), (int)(origin.Y - size * Math.Sin(baseRads)));
            surface.DrawLine(AnglePen, origin.X, origin.Y, (int)(origin.X + size * Math.Cos(rads)), (int)(origin.Y - size * Math.Sin(rads)));

            surface.DrawArc(ArcPen, new Rectangle((int)(origin.X - size / 8), (int)(origin.Y - size / 8), size/4, size/4), -currentRotation, -currentAngle);
        }

        private void DrawingPanel_Resize(object sender, EventArgs e)
        {
            DrawingPanel.Invalidate();
        }

        private static double RadiansFromDegrees(double degrees)
        {
            return (Math.PI / 180) * degrees;
        }

        private void AxisCheck_CheckedChanged(object sender, EventArgs e)
        {
            DrawingPanel.Invalidate();
        }

        private void RotateCheck_CheckedChanged(object sender, EventArgs e)
        {
            currentRotation = (RotateCheck.Checked) ? R.Next(360) : 0;
            DrawingPanel.Invalidate();
        }

        private void MaxAngleCheck_CheckedChanged(object sender, EventArgs e)
        {
            ShowNewAngle();
        }
    }
}
