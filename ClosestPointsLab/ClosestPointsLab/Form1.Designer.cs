namespace ClosestPointsLab
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShipXInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ShipYInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ShipZInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MeteorStartZ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MeteorStartY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MeteorStartX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MeteorDirZ = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MeteorDirY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MeteorDirX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CXInput = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CYInput = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CZInput = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.AZInput = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.AYInput = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.AXInput = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.BZInput = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.BYInput = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.BXInput = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClosestPointMeteorText = new System.Windows.Forms.Label();
            this.DistanceMeteorText = new System.Windows.Forms.Label();
            this.PlanePointText = new System.Windows.Forms.Label();
            this.PlaneDistanceText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Closest Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ethan Vogelsang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ship Location";
            // 
            // ShipXInput
            // 
            this.ShipXInput.Location = new System.Drawing.Point(91, 126);
            this.ShipXInput.Name = "ShipXInput";
            this.ShipXInput.Size = new System.Drawing.Size(53, 20);
            this.ShipXInput.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y";
            // 
            // ShipYInput
            // 
            this.ShipYInput.Location = new System.Drawing.Point(90, 152);
            this.ShipYInput.Name = "ShipYInput";
            this.ShipYInput.Size = new System.Drawing.Size(53, 20);
            this.ShipYInput.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Z";
            // 
            // ShipZInput
            // 
            this.ShipZInput.Location = new System.Drawing.Point(91, 178);
            this.ShipZInput.Name = "ShipZInput";
            this.ShipZInput.Size = new System.Drawing.Size(53, 20);
            this.ShipZInput.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Metoer Thing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Start";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Direction";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Z";
            // 
            // MeteorStartZ
            // 
            this.MeteorStartZ.Location = new System.Drawing.Point(218, 178);
            this.MeteorStartZ.Name = "MeteorStartZ";
            this.MeteorStartZ.Size = new System.Drawing.Size(53, 20);
            this.MeteorStartZ.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Y";
            // 
            // MeteorStartY
            // 
            this.MeteorStartY.Location = new System.Drawing.Point(217, 152);
            this.MeteorStartY.Name = "MeteorStartY";
            this.MeteorStartY.Size = new System.Drawing.Size(53, 20);
            this.MeteorStartY.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(198, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "X";
            // 
            // MeteorStartX
            // 
            this.MeteorStartX.Location = new System.Drawing.Point(218, 126);
            this.MeteorStartX.Name = "MeteorStartX";
            this.MeteorStartX.Size = new System.Drawing.Size(53, 20);
            this.MeteorStartX.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Z";
            // 
            // MeteorDirZ
            // 
            this.MeteorDirZ.Location = new System.Drawing.Point(309, 178);
            this.MeteorDirZ.Name = "MeteorDirZ";
            this.MeteorDirZ.Size = new System.Drawing.Size(53, 20);
            this.MeteorDirZ.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Y";
            // 
            // MeteorDirY
            // 
            this.MeteorDirY.Location = new System.Drawing.Point(308, 152);
            this.MeteorDirY.Name = "MeteorDirY";
            this.MeteorDirY.Size = new System.Drawing.Size(53, 20);
            this.MeteorDirY.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(289, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "X";
            // 
            // MeteorDirX
            // 
            this.MeteorDirX.Location = new System.Drawing.Point(309, 126);
            this.MeteorDirX.Name = "MeteorDirX";
            this.MeteorDirX.Size = new System.Drawing.Size(53, 20);
            this.MeteorDirX.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(475, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "Plane";
            // 
            // CXInput
            // 
            this.CXInput.Location = new System.Drawing.Point(418, 228);
            this.CXInput.Name = "CXInput";
            this.CXInput.Size = new System.Drawing.Size(36, 20);
            this.CXInput.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(398, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "X";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(466, 231);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Y";
            // 
            // CYInput
            // 
            this.CYInput.Location = new System.Drawing.Point(483, 228);
            this.CYInput.Name = "CYInput";
            this.CYInput.Size = new System.Drawing.Size(36, 20);
            this.CYInput.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(528, 231);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Z";
            // 
            // CZInput
            // 
            this.CZInput.Location = new System.Drawing.Point(548, 228);
            this.CZInput.Name = "CZInput";
            this.CZInput.Size = new System.Drawing.Size(36, 20);
            this.CZInput.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(528, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "Z";
            // 
            // AZInput
            // 
            this.AZInput.Location = new System.Drawing.Point(548, 126);
            this.AZInput.Name = "AZInput";
            this.AZInput.Size = new System.Drawing.Size(36, 20);
            this.AZInput.TabIndex = 35;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(466, 129);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "Y";
            // 
            // AYInput
            // 
            this.AYInput.Location = new System.Drawing.Point(483, 126);
            this.AYInput.Name = "AYInput";
            this.AYInput.Size = new System.Drawing.Size(36, 20);
            this.AYInput.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(398, 129);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 32;
            this.label22.Text = "X";
            // 
            // AXInput
            // 
            this.AXInput.Location = new System.Drawing.Point(418, 126);
            this.AXInput.Name = "AXInput";
            this.AXInput.Size = new System.Drawing.Size(36, 20);
            this.AXInput.TabIndex = 31;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(528, 181);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 42;
            this.label23.Text = "Z";
            // 
            // BZInput
            // 
            this.BZInput.Location = new System.Drawing.Point(548, 178);
            this.BZInput.Name = "BZInput";
            this.BZInput.Size = new System.Drawing.Size(36, 20);
            this.BZInput.TabIndex = 41;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(466, 181);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "Y";
            // 
            // BYInput
            // 
            this.BYInput.Location = new System.Drawing.Point(483, 178);
            this.BYInput.Name = "BYInput";
            this.BYInput.Size = new System.Drawing.Size(36, 20);
            this.BYInput.TabIndex = 39;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(398, 181);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 38;
            this.label25.Text = "X";
            // 
            // BXInput
            // 
            this.BXInput.Location = new System.Drawing.Point(418, 178);
            this.BXInput.Name = "BXInput";
            this.BXInput.Size = new System.Drawing.Size(36, 20);
            this.BXInput.TabIndex = 37;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(493, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 13);
            this.label26.TabIndex = 43;
            this.label26.Text = "A";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(494, 159);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 13);
            this.label27.TabIndex = 44;
            this.label27.Text = "B";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(494, 212);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 45;
            this.label28.Text = "C";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(279, 273);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 46;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClosestPointMeteorText
            // 
            this.ClosestPointMeteorText.AutoSize = true;
            this.ClosestPointMeteorText.Location = new System.Drawing.Point(100, 320);
            this.ClosestPointMeteorText.Name = "ClosestPointMeteorText";
            this.ClosestPointMeteorText.Size = new System.Drawing.Size(41, 13);
            this.ClosestPointMeteorText.TabIndex = 47;
            this.ClosestPointMeteorText.Text = "label29";
            // 
            // DistanceMeteorText
            // 
            this.DistanceMeteorText.AutoSize = true;
            this.DistanceMeteorText.Location = new System.Drawing.Point(103, 354);
            this.DistanceMeteorText.Name = "DistanceMeteorText";
            this.DistanceMeteorText.Size = new System.Drawing.Size(41, 13);
            this.DistanceMeteorText.TabIndex = 48;
            this.DistanceMeteorText.Text = "label30";
            // 
            // PlanePointText
            // 
            this.PlanePointText.AutoSize = true;
            this.PlanePointText.Location = new System.Drawing.Point(371, 320);
            this.PlanePointText.Name = "PlanePointText";
            this.PlanePointText.Size = new System.Drawing.Size(41, 13);
            this.PlanePointText.TabIndex = 49;
            this.PlanePointText.Text = "label29";
            // 
            // PlaneDistanceText
            // 
            this.PlaneDistanceText.AutoSize = true;
            this.PlaneDistanceText.Location = new System.Drawing.Point(374, 353);
            this.PlaneDistanceText.Name = "PlaneDistanceText";
            this.PlaneDistanceText.Size = new System.Drawing.Size(41, 13);
            this.PlaneDistanceText.TabIndex = 50;
            this.PlaneDistanceText.Text = "label30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 432);
            this.Controls.Add(this.PlaneDistanceText);
            this.Controls.Add(this.PlanePointText);
            this.Controls.Add(this.DistanceMeteorText);
            this.Controls.Add(this.ClosestPointMeteorText);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.BZInput);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.BYInput);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.BXInput);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.AZInput);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.AYInput);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.AXInput);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.CZInput);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CYInput);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CXInput);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MeteorDirZ);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.MeteorDirY);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.MeteorDirX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MeteorStartZ);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MeteorStartY);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MeteorStartX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ShipZInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShipYInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShipXInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ShipXInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ShipYInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ShipZInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MeteorStartZ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MeteorStartY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MeteorStartX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MeteorDirZ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MeteorDirY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MeteorDirX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CXInput;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox CYInput;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox CZInput;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox AZInput;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox AYInput;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox AXInput;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox BZInput;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox BYInput;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox BXInput;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ClosestPointMeteorText;
        private System.Windows.Forms.Label DistanceMeteorText;
        private System.Windows.Forms.Label PlanePointText;
        private System.Windows.Forms.Label PlaneDistanceText;
    }
}

