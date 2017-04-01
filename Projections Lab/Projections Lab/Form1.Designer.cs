namespace Projections_Lab
{
    partial class Form1
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
            this.UtilityButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.utilityMagInput = new System.Windows.Forms.TextBox();
            this.utilityHeadInput = new System.Windows.Forms.TextBox();
            this.utilityPitchInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.JourneyText = new System.Windows.Forms.Label();
            this.TravelButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.JourneyPitchInput = new System.Windows.Forms.TextBox();
            this.JourneyHeadInput = new System.Windows.Forms.TextBox();
            this.JourneyMagInput = new System.Windows.Forms.TextBox();
            this.totalTripText = new System.Windows.Forms.Label();
            this.ShortestDistText = new System.Windows.Forms.Label();
            this.EndTripText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UtilityButton
            // 
            this.UtilityButton.Location = new System.Drawing.Point(57, 175);
            this.UtilityButton.Name = "UtilityButton";
            this.UtilityButton.Size = new System.Drawing.Size(75, 23);
            this.UtilityButton.TabIndex = 0;
            this.UtilityButton.Text = "Utility!";
            this.UtilityButton.UseVisualStyleBackColor = true;
            this.UtilityButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projections Lab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ethan Vogelsang";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(37, 239);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // utilityMagInput
            // 
            this.utilityMagInput.Location = new System.Drawing.Point(66, 94);
            this.utilityMagInput.Name = "utilityMagInput";
            this.utilityMagInput.Size = new System.Drawing.Size(56, 20);
            this.utilityMagInput.TabIndex = 4;
            // 
            // utilityHeadInput
            // 
            this.utilityHeadInput.Location = new System.Drawing.Point(66, 120);
            this.utilityHeadInput.Name = "utilityHeadInput";
            this.utilityHeadInput.Size = new System.Drawing.Size(56, 20);
            this.utilityHeadInput.TabIndex = 5;
            // 
            // utilityPitchInput
            // 
            this.utilityPitchInput.Location = new System.Drawing.Point(66, 146);
            this.utilityPitchInput.Name = "utilityPitchInput";
            this.utilityPitchInput.Size = new System.Drawing.Size(56, 20);
            this.utilityPitchInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Utility Pole";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Magnitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Heading (°)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pitch (°)";
            // 
            // JourneyText
            // 
            this.JourneyText.AutoSize = true;
            this.JourneyText.Location = new System.Drawing.Point(180, 68);
            this.JourneyText.Name = "JourneyText";
            this.JourneyText.Size = new System.Drawing.Size(77, 13);
            this.JourneyText.TabIndex = 11;
            this.JourneyText.Text = "Leg of Journey";
            // 
            // TravelButton
            // 
            this.TravelButton.Location = new System.Drawing.Point(183, 175);
            this.TravelButton.Name = "TravelButton";
            this.TravelButton.Size = new System.Drawing.Size(75, 23);
            this.TravelButton.TabIndex = 12;
            this.TravelButton.Text = "Travel!";
            this.TravelButton.UseVisualStyleBackColor = true;
            this.TravelButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pitch (°)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Heading (°)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Distance";
            // 
            // JourneyPitchInput
            // 
            this.JourneyPitchInput.Location = new System.Drawing.Point(220, 146);
            this.JourneyPitchInput.Name = "JourneyPitchInput";
            this.JourneyPitchInput.Size = new System.Drawing.Size(56, 20);
            this.JourneyPitchInput.TabIndex = 16;
            // 
            // JourneyHeadInput
            // 
            this.JourneyHeadInput.Location = new System.Drawing.Point(220, 120);
            this.JourneyHeadInput.Name = "JourneyHeadInput";
            this.JourneyHeadInput.Size = new System.Drawing.Size(56, 20);
            this.JourneyHeadInput.TabIndex = 15;
            // 
            // JourneyMagInput
            // 
            this.JourneyMagInput.Location = new System.Drawing.Point(220, 94);
            this.JourneyMagInput.Name = "JourneyMagInput";
            this.JourneyMagInput.Size = new System.Drawing.Size(56, 20);
            this.JourneyMagInput.TabIndex = 14;
            // 
            // totalTripText
            // 
            this.totalTripText.AutoSize = true;
            this.totalTripText.Location = new System.Drawing.Point(160, 215);
            this.totalTripText.Name = "totalTripText";
            this.totalTripText.Size = new System.Drawing.Size(41, 13);
            this.totalTripText.TabIndex = 20;
            this.totalTripText.Text = "label10";
            // 
            // ShortestDistText
            // 
            this.ShortestDistText.AutoSize = true;
            this.ShortestDistText.Location = new System.Drawing.Point(160, 239);
            this.ShortestDistText.Name = "ShortestDistText";
            this.ShortestDistText.Size = new System.Drawing.Size(41, 13);
            this.ShortestDistText.TabIndex = 21;
            this.ShortestDistText.Text = "label10";
            // 
            // EndTripText
            // 
            this.EndTripText.AutoSize = true;
            this.EndTripText.Location = new System.Drawing.Point(160, 263);
            this.EndTripText.Name = "EndTripText";
            this.EndTripText.Size = new System.Drawing.Size(41, 13);
            this.EndTripText.TabIndex = 22;
            this.EndTripText.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 288);
            this.Controls.Add(this.EndTripText);
            this.Controls.Add(this.ShortestDistText);
            this.Controls.Add(this.totalTripText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.JourneyPitchInput);
            this.Controls.Add(this.JourneyHeadInput);
            this.Controls.Add(this.JourneyMagInput);
            this.Controls.Add(this.TravelButton);
            this.Controls.Add(this.JourneyText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.utilityPitchInput);
            this.Controls.Add(this.utilityHeadInput);
            this.Controls.Add(this.utilityMagInput);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UtilityButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UtilityButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox utilityMagInput;
        private System.Windows.Forms.TextBox utilityHeadInput;
        private System.Windows.Forms.TextBox utilityPitchInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label JourneyText;
        private System.Windows.Forms.Button TravelButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox JourneyPitchInput;
        private System.Windows.Forms.TextBox JourneyHeadInput;
        private System.Windows.Forms.TextBox JourneyMagInput;
        private System.Windows.Forms.Label totalTripText;
        private System.Windows.Forms.Label ShortestDistText;
        private System.Windows.Forms.Label EndTripText;
    }
}

