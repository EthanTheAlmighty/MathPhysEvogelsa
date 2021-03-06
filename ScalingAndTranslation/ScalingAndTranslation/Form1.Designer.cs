﻿namespace ScalingAndTranslation
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
            this.AddVertexButton = new System.Windows.Forms.Button();
            this.ClearVertexButton = new System.Windows.Forms.Button();
            this.VertexXInput = new System.Windows.Forms.TextBox();
            this.VertexYInput = new System.Windows.Forms.TextBox();
            this.VertexZInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VerticesText = new System.Windows.Forms.Label();
            this.FinalResultsOutput = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScaleAboutCenterRadio = new System.Windows.Forms.RadioButton();
            this.RawScaleRadio = new System.Windows.Forms.RadioButton();
            this.TranslationRadio = new System.Windows.Forms.RadioButton();
            this.TranslateXInput = new System.Windows.Forms.TextBox();
            this.TranslateYInput = new System.Windows.Forms.TextBox();
            this.TranslateZInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ScaleZInput = new System.Windows.Forms.TextBox();
            this.ScaleYInput = new System.Windows.Forms.TextBox();
            this.ScaleXInput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CenterZInput = new System.Windows.Forms.TextBox();
            this.CenterYInput = new System.Windows.Forms.TextBox();
            this.CenterXInput = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.OldVerticesOutput = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.XradioButton = new System.Windows.Forms.RadioButton();
            this.YRadioButton = new System.Windows.Forms.RadioButton();
            this.ZRadioButton = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.degreesBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddVertexButton
            // 
            this.AddVertexButton.Location = new System.Drawing.Point(215, 62);
            this.AddVertexButton.Name = "AddVertexButton";
            this.AddVertexButton.Size = new System.Drawing.Size(75, 23);
            this.AddVertexButton.TabIndex = 0;
            this.AddVertexButton.Text = "Add Vertex";
            this.AddVertexButton.UseVisualStyleBackColor = true;
            this.AddVertexButton.Click += new System.EventHandler(this.AddVertexButton_Click);
            // 
            // ClearVertexButton
            // 
            this.ClearVertexButton.Location = new System.Drawing.Point(215, 105);
            this.ClearVertexButton.Name = "ClearVertexButton";
            this.ClearVertexButton.Size = new System.Drawing.Size(75, 23);
            this.ClearVertexButton.TabIndex = 1;
            this.ClearVertexButton.Text = "Clear";
            this.ClearVertexButton.UseVisualStyleBackColor = true;
            this.ClearVertexButton.Click += new System.EventHandler(this.ClearVertexButton_Click);
            // 
            // VertexXInput
            // 
            this.VertexXInput.Location = new System.Drawing.Point(109, 65);
            this.VertexXInput.Name = "VertexXInput";
            this.VertexXInput.Size = new System.Drawing.Size(58, 20);
            this.VertexXInput.TabIndex = 2;
            // 
            // VertexYInput
            // 
            this.VertexYInput.Location = new System.Drawing.Point(109, 91);
            this.VertexYInput.Name = "VertexYInput";
            this.VertexYInput.Size = new System.Drawing.Size(58, 20);
            this.VertexYInput.TabIndex = 3;
            // 
            // VertexZInput
            // 
            this.VertexZInput.Location = new System.Drawing.Point(109, 117);
            this.VertexZInput.Name = "VertexZInput";
            this.VertexZInput.Size = new System.Drawing.Size(58, 20);
            this.VertexZInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scaling and Translation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of Vertices";
            // 
            // VerticesText
            // 
            this.VerticesText.AutoSize = true;
            this.VerticesText.Location = new System.Drawing.Point(378, 91);
            this.VerticesText.Name = "VerticesText";
            this.VerticesText.Size = new System.Drawing.Size(35, 13);
            this.VerticesText.TabIndex = 10;
            this.VerticesText.Text = "label6";
            // 
            // FinalResultsOutput
            // 
            this.FinalResultsOutput.FormattingEnabled = true;
            this.FinalResultsOutput.Location = new System.Drawing.Point(622, 52);
            this.FinalResultsOutput.Name = "FinalResultsOutput";
            this.FinalResultsOutput.Size = new System.Drawing.Size(135, 368);
            this.FinalResultsOutput.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ZRadioButton);
            this.groupBox1.Controls.Add(this.YRadioButton);
            this.groupBox1.Controls.Add(this.XradioButton);
            this.groupBox1.Controls.Add(this.ScaleAboutCenterRadio);
            this.groupBox1.Controls.Add(this.RawScaleRadio);
            this.groupBox1.Controls.Add(this.TranslationRadio);
            this.groupBox1.Location = new System.Drawing.Point(46, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of transformation";
            // 
            // ScaleAboutCenterRadio
            // 
            this.ScaleAboutCenterRadio.AutoSize = true;
            this.ScaleAboutCenterRadio.Enabled = false;
            this.ScaleAboutCenterRadio.Location = new System.Drawing.Point(33, 65);
            this.ScaleAboutCenterRadio.Name = "ScaleAboutCenterRadio";
            this.ScaleAboutCenterRadio.Size = new System.Drawing.Size(117, 17);
            this.ScaleAboutCenterRadio.TabIndex = 2;
            this.ScaleAboutCenterRadio.TabStop = true;
            this.ScaleAboutCenterRadio.Text = "Scale About Center";
            this.ScaleAboutCenterRadio.UseVisualStyleBackColor = true;
            this.ScaleAboutCenterRadio.CheckedChanged += new System.EventHandler(this.ScaleAboutCenterRadio_CheckedChanged);
            // 
            // RawScaleRadio
            // 
            this.RawScaleRadio.AutoSize = true;
            this.RawScaleRadio.Enabled = false;
            this.RawScaleRadio.Location = new System.Drawing.Point(33, 42);
            this.RawScaleRadio.Name = "RawScaleRadio";
            this.RawScaleRadio.Size = new System.Drawing.Size(85, 17);
            this.RawScaleRadio.TabIndex = 1;
            this.RawScaleRadio.TabStop = true;
            this.RawScaleRadio.Text = "Raw Scaling";
            this.RawScaleRadio.UseVisualStyleBackColor = true;
            this.RawScaleRadio.CheckedChanged += new System.EventHandler(this.RawScaleRadio_CheckedChanged);
            // 
            // TranslationRadio
            // 
            this.TranslationRadio.AutoSize = true;
            this.TranslationRadio.Enabled = false;
            this.TranslationRadio.Location = new System.Drawing.Point(33, 19);
            this.TranslationRadio.Name = "TranslationRadio";
            this.TranslationRadio.Size = new System.Drawing.Size(77, 17);
            this.TranslationRadio.TabIndex = 0;
            this.TranslationRadio.TabStop = true;
            this.TranslationRadio.Text = "Translation";
            this.TranslationRadio.UseVisualStyleBackColor = true;
            this.TranslationRadio.CheckedChanged += new System.EventHandler(this.TranslationRadio_CheckedChanged);
            // 
            // TranslateXInput
            // 
            this.TranslateXInput.Enabled = false;
            this.TranslateXInput.Location = new System.Drawing.Point(55, 332);
            this.TranslateXInput.Name = "TranslateXInput";
            this.TranslateXInput.Size = new System.Drawing.Size(41, 20);
            this.TranslateXInput.TabIndex = 13;
            // 
            // TranslateYInput
            // 
            this.TranslateYInput.Enabled = false;
            this.TranslateYInput.Location = new System.Drawing.Point(55, 358);
            this.TranslateYInput.Name = "TranslateYInput";
            this.TranslateYInput.Size = new System.Drawing.Size(41, 20);
            this.TranslateYInput.TabIndex = 14;
            // 
            // TranslateZInput
            // 
            this.TranslateZInput.Enabled = false;
            this.TranslateZInput.Location = new System.Drawing.Point(55, 384);
            this.TranslateZInput.Name = "TranslateZInput";
            this.TranslateZInput.Size = new System.Drawing.Size(41, 20);
            this.TranslateZInput.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(52, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Translate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Δx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Δy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Δz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(99, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Δz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(99, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Δy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(99, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Δx";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(127, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Scale";
            // 
            // ScaleZInput
            // 
            this.ScaleZInput.Enabled = false;
            this.ScaleZInput.Location = new System.Drawing.Point(124, 385);
            this.ScaleZInput.Name = "ScaleZInput";
            this.ScaleZInput.Size = new System.Drawing.Size(41, 20);
            this.ScaleZInput.TabIndex = 22;
            // 
            // ScaleYInput
            // 
            this.ScaleYInput.Enabled = false;
            this.ScaleYInput.Location = new System.Drawing.Point(124, 359);
            this.ScaleYInput.Name = "ScaleYInput";
            this.ScaleYInput.Size = new System.Drawing.Size(41, 20);
            this.ScaleYInput.TabIndex = 21;
            // 
            // ScaleXInput
            // 
            this.ScaleXInput.Enabled = false;
            this.ScaleXInput.Location = new System.Drawing.Point(124, 333);
            this.ScaleXInput.Name = "ScaleXInput";
            this.ScaleXInput.Size = new System.Drawing.Size(41, 20);
            this.ScaleXInput.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(170, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Δz";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(170, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Δy";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Location = new System.Drawing.Point(170, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Δx";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(192, 316);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Center";
            // 
            // CenterZInput
            // 
            this.CenterZInput.Enabled = false;
            this.CenterZInput.Location = new System.Drawing.Point(195, 384);
            this.CenterZInput.Name = "CenterZInput";
            this.CenterZInput.Size = new System.Drawing.Size(41, 20);
            this.CenterZInput.TabIndex = 29;
            // 
            // CenterYInput
            // 
            this.CenterYInput.Enabled = false;
            this.CenterYInput.Location = new System.Drawing.Point(195, 358);
            this.CenterYInput.Name = "CenterYInput";
            this.CenterYInput.Size = new System.Drawing.Size(41, 20);
            this.CenterYInput.TabIndex = 28;
            // 
            // CenterXInput
            // 
            this.CenterXInput.Enabled = false;
            this.CenterXInput.Location = new System.Drawing.Point(195, 332);
            this.CenterXInput.Name = "CenterXInput";
            this.CenterXInput.Size = new System.Drawing.Size(41, 20);
            this.CenterXInput.TabIndex = 27;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(330, 190);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(103, 54);
            this.CalculateButton.TabIndex = 34;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(109, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Vertices";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(638, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "Edited Vertices";
            // 
            // OldVerticesOutput
            // 
            this.OldVerticesOutput.FormattingEnabled = true;
            this.OldVerticesOutput.Location = new System.Drawing.Point(473, 52);
            this.OldVerticesOutput.Name = "OldVerticesOutput";
            this.OldVerticesOutput.Size = new System.Drawing.Size(135, 368);
            this.OldVerticesOutput.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(490, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 17);
            this.label20.TabIndex = 38;
            this.label20.Text = "Old Vertices";
            // 
            // XradioButton
            // 
            this.XradioButton.AutoSize = true;
            this.XradioButton.Location = new System.Drawing.Point(159, 19);
            this.XradioButton.Name = "XradioButton";
            this.XradioButton.Size = new System.Drawing.Size(32, 17);
            this.XradioButton.TabIndex = 3;
            this.XradioButton.TabStop = true;
            this.XradioButton.Text = "X";
            this.XradioButton.UseVisualStyleBackColor = true;
            this.XradioButton.CheckedChanged += new System.EventHandler(this.XradioButton_CheckedChanged);
            // 
            // YRadioButton
            // 
            this.YRadioButton.AutoSize = true;
            this.YRadioButton.Location = new System.Drawing.Point(159, 42);
            this.YRadioButton.Name = "YRadioButton";
            this.YRadioButton.Size = new System.Drawing.Size(32, 17);
            this.YRadioButton.TabIndex = 4;
            this.YRadioButton.TabStop = true;
            this.YRadioButton.Text = "Y";
            this.YRadioButton.UseVisualStyleBackColor = true;
            this.YRadioButton.CheckedChanged += new System.EventHandler(this.YRadioButton_CheckedChanged);
            // 
            // ZRadioButton
            // 
            this.ZRadioButton.AutoSize = true;
            this.ZRadioButton.Location = new System.Drawing.Point(159, 65);
            this.ZRadioButton.Name = "ZRadioButton";
            this.ZRadioButton.Size = new System.Drawing.Size(32, 17);
            this.ZRadioButton.TabIndex = 5;
            this.ZRadioButton.TabStop = true;
            this.ZRadioButton.Text = "Z";
            this.ZRadioButton.UseVisualStyleBackColor = true;
            this.ZRadioButton.CheckedChanged += new System.EventHandler(this.ZRadioButton_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(302, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Degrees of Rotation";
            // 
            // degreesBox
            // 
            this.degreesBox.Location = new System.Drawing.Point(333, 312);
            this.degreesBox.Name = "degreesBox";
            this.degreesBox.Size = new System.Drawing.Size(42, 20);
            this.degreesBox.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 443);
            this.Controls.Add(this.degreesBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.OldVerticesOutput);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CenterZInput);
            this.Controls.Add(this.CenterYInput);
            this.Controls.Add(this.CenterXInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ScaleZInput);
            this.Controls.Add(this.ScaleYInput);
            this.Controls.Add(this.ScaleXInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TranslateZInput);
            this.Controls.Add(this.TranslateYInput);
            this.Controls.Add(this.TranslateXInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FinalResultsOutput);
            this.Controls.Add(this.VerticesText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VertexZInput);
            this.Controls.Add(this.VertexYInput);
            this.Controls.Add(this.VertexXInput);
            this.Controls.Add(this.ClearVertexButton);
            this.Controls.Add(this.AddVertexButton);
            this.Name = "Form1";
            this.Text = "ScalingAndTranslation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddVertexButton;
        private System.Windows.Forms.Button ClearVertexButton;
        private System.Windows.Forms.TextBox VertexXInput;
        private System.Windows.Forms.TextBox VertexYInput;
        private System.Windows.Forms.TextBox VertexZInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label VerticesText;
        private System.Windows.Forms.ListBox FinalResultsOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ScaleAboutCenterRadio;
        private System.Windows.Forms.RadioButton RawScaleRadio;
        private System.Windows.Forms.RadioButton TranslationRadio;
        private System.Windows.Forms.TextBox TranslateXInput;
        private System.Windows.Forms.TextBox TranslateYInput;
        private System.Windows.Forms.TextBox TranslateZInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ScaleZInput;
        private System.Windows.Forms.TextBox ScaleYInput;
        private System.Windows.Forms.TextBox ScaleXInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox CenterZInput;
        private System.Windows.Forms.TextBox CenterYInput;
        private System.Windows.Forms.TextBox CenterXInput;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox OldVerticesOutput;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton ZRadioButton;
        private System.Windows.Forms.RadioButton YRadioButton;
        private System.Windows.Forms.RadioButton XradioButton;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox degreesBox;
    }
}

