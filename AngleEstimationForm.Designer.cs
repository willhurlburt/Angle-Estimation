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

namespace AngleEstimation
{
    partial class AngleEstimationForm
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
            this.GuessBox = new System.Windows.Forms.TextBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultGuessDisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GuessCountDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AverageErrorDisplay = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultActualDisplay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ResultErrorDisplay = new System.Windows.Forms.Label();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.AxisCheck = new System.Windows.Forms.CheckBox();
            this.RotateCheck = new System.Windows.Forms.CheckBox();
            this.MaxAngleCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GuessBox
            // 
            this.GuessBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuessBox.Location = new System.Drawing.Point(101, 227);
            this.GuessBox.Name = "GuessBox";
            this.GuessBox.Size = new System.Drawing.Size(100, 20);
            this.GuessBox.TabIndex = 0;
            // 
            // GuessButton
            // 
            this.GuessButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuessButton.Location = new System.Drawing.Point(207, 225);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(75, 23);
            this.GuessButton.TabIndex = 1;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Error:";
            // 
            // ResultGuessDisplay
            // 
            this.ResultGuessDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResultGuessDisplay.AutoSize = true;
            this.ResultGuessDisplay.Location = new System.Drawing.Point(176, 264);
            this.ResultGuessDisplay.Name = "ResultGuessDisplay";
            this.ResultGuessDisplay.Size = new System.Drawing.Size(54, 13);
            this.ResultGuessDisplay.TabIndex = 3;
            this.ResultGuessDisplay.Text = "0 degrees";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Guesses:";
            // 
            // GuessCountDisplay
            // 
            this.GuessCountDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuessCountDisplay.AutoSize = true;
            this.GuessCountDisplay.Location = new System.Drawing.Point(155, 324);
            this.GuessCountDisplay.Name = "GuessCountDisplay";
            this.GuessCountDisplay.Size = new System.Drawing.Size(13, 13);
            this.GuessCountDisplay.TabIndex = 5;
            this.GuessCountDisplay.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Average Error:";
            // 
            // AverageErrorDisplay
            // 
            this.AverageErrorDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AverageErrorDisplay.AutoSize = true;
            this.AverageErrorDisplay.Location = new System.Drawing.Point(285, 324);
            this.AverageErrorDisplay.Name = "AverageErrorDisplay";
            this.AverageErrorDisplay.Size = new System.Drawing.Size(13, 13);
            this.AverageErrorDisplay.TabIndex = 7;
            this.AverageErrorDisplay.Text = "0";
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetButton.Location = new System.Drawing.Point(6, 319);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Guess:";
            // 
            // ResultActualDisplay
            // 
            this.ResultActualDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResultActualDisplay.AutoSize = true;
            this.ResultActualDisplay.Location = new System.Drawing.Point(176, 251);
            this.ResultActualDisplay.Name = "ResultActualDisplay";
            this.ResultActualDisplay.Size = new System.Drawing.Size(54, 13);
            this.ResultActualDisplay.TabIndex = 13;
            this.ResultActualDisplay.Text = "0 degrees";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Actual:";
            // 
            // ResultErrorDisplay
            // 
            this.ResultErrorDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResultErrorDisplay.AutoSize = true;
            this.ResultErrorDisplay.Location = new System.Drawing.Point(176, 277);
            this.ResultErrorDisplay.Name = "ResultErrorDisplay";
            this.ResultErrorDisplay.Size = new System.Drawing.Size(54, 13);
            this.ResultErrorDisplay.TabIndex = 14;
            this.ResultErrorDisplay.Text = "0 degrees";
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DrawingPanel.Location = new System.Drawing.Point(12, 12);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(350, 207);
            this.DrawingPanel.TabIndex = 15;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.Resize += new System.EventHandler(this.DrawingPanel_Resize);
            // 
            // AxisCheck
            // 
            this.AxisCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AxisCheck.AutoSize = true;
            this.AxisCheck.Location = new System.Drawing.Point(12, 229);
            this.AxisCheck.Name = "AxisCheck";
            this.AxisCheck.Size = new System.Drawing.Size(75, 17);
            this.AxisCheck.TabIndex = 16;
            this.AxisCheck.Text = "Show Axis";
            this.AxisCheck.UseVisualStyleBackColor = true;
            this.AxisCheck.CheckedChanged += new System.EventHandler(this.AxisCheck_CheckedChanged);
            // 
            // RotateCheck
            // 
            this.RotateCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RotateCheck.AutoSize = true;
            this.RotateCheck.Location = new System.Drawing.Point(12, 252);
            this.RotateCheck.Name = "RotateCheck";
            this.RotateCheck.Size = new System.Drawing.Size(58, 17);
            this.RotateCheck.TabIndex = 17;
            this.RotateCheck.Text = "Rotate";
            this.RotateCheck.UseVisualStyleBackColor = true;
            this.RotateCheck.CheckedChanged += new System.EventHandler(this.RotateCheck_CheckedChanged);
            // 
            // MaxAngleCheck
            // 
            this.MaxAngleCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MaxAngleCheck.AutoSize = true;
            this.MaxAngleCheck.Location = new System.Drawing.Point(12, 275);
            this.MaxAngleCheck.Name = "MaxAngleCheck";
            this.MaxAngleCheck.Size = new System.Drawing.Size(57, 17);
            this.MaxAngleCheck.TabIndex = 18;
            this.MaxAngleCheck.Text = "< 180°";
            this.MaxAngleCheck.UseVisualStyleBackColor = true;
            this.MaxAngleCheck.CheckedChanged += new System.EventHandler(this.MaxAngleCheck_CheckedChanged);
            // 
            // AngleEstimationForm
            // 
            this.AcceptButton = this.GuessButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 353);
            this.Controls.Add(this.MaxAngleCheck);
            this.Controls.Add(this.RotateCheck);
            this.Controls.Add(this.AxisCheck);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.ResultErrorDisplay);
            this.Controls.Add(this.ResultActualDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.AverageErrorDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GuessCountDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultGuessDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.GuessBox);
            this.MinimumSize = new System.Drawing.Size(390, 390);
            this.Name = "AngleEstimationForm";
            this.Text = "Angle Estimation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GuessBox;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultGuessDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GuessCountDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AverageErrorDisplay;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ResultActualDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ResultErrorDisplay;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.CheckBox AxisCheck;
        private System.Windows.Forms.CheckBox RotateCheck;
        private System.Windows.Forms.CheckBox MaxAngleCheck;
    }
}

