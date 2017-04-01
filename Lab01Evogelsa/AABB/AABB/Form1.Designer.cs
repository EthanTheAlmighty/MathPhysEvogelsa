namespace AABB
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
            this.threeDimensionCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.z1Label = new System.Windows.Forms.Label();
            this.x1Input = new System.Windows.Forms.TextBox();
            this.y1Input = new System.Windows.Forms.TextBox();
            this.z1Input = new System.Windows.Forms.TextBox();
            this.z2Input = new System.Windows.Forms.TextBox();
            this.y2Input = new System.Windows.Forms.TextBox();
            this.x2Input = new System.Windows.Forms.TextBox();
            this.z2Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.z4Input = new System.Windows.Forms.TextBox();
            this.y4Input = new System.Windows.Forms.TextBox();
            this.x4Input = new System.Windows.Forms.TextBox();
            this.z4Label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.z3Input = new System.Windows.Forms.TextBox();
            this.y3Input = new System.Windows.Forms.TextBox();
            this.x3Input = new System.Windows.Forms.TextBox();
            this.z3Label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CollisionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Axially-Aligned Boxes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ethan Vogelsang";
            // 
            // threeDimensionCheck
            // 
            this.threeDimensionCheck.AutoSize = true;
            this.threeDimensionCheck.Location = new System.Drawing.Point(172, 99);
            this.threeDimensionCheck.Name = "threeDimensionCheck";
            this.threeDimensionCheck.Size = new System.Drawing.Size(40, 17);
            this.threeDimensionCheck.TabIndex = 2;
            this.threeDimensionCheck.Text = "3D";
            this.threeDimensionCheck.UseVisualStyleBackColor = true;
            this.threeDimensionCheck.CheckedChanged += new System.EventHandler(this.threeDimensionCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Box 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vertex 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vertex 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Y";
            // 
            // z1Label
            // 
            this.z1Label.AutoSize = true;
            this.z1Label.Location = new System.Drawing.Point(21, 231);
            this.z1Label.Name = "z1Label";
            this.z1Label.Size = new System.Drawing.Size(14, 13);
            this.z1Label.TabIndex = 8;
            this.z1Label.Text = "Z";
            // 
            // x1Input
            // 
            this.x1Input.Location = new System.Drawing.Point(41, 180);
            this.x1Input.Name = "x1Input";
            this.x1Input.Size = new System.Drawing.Size(44, 20);
            this.x1Input.TabIndex = 9;
            // 
            // y1Input
            // 
            this.y1Input.Location = new System.Drawing.Point(41, 203);
            this.y1Input.Name = "y1Input";
            this.y1Input.Size = new System.Drawing.Size(43, 20);
            this.y1Input.TabIndex = 10;
            // 
            // z1Input
            // 
            this.z1Input.Location = new System.Drawing.Point(41, 228);
            this.z1Input.Name = "z1Input";
            this.z1Input.Size = new System.Drawing.Size(43, 20);
            this.z1Input.TabIndex = 11;
            // 
            // z2Input
            // 
            this.z2Input.Location = new System.Drawing.Point(113, 228);
            this.z2Input.Name = "z2Input";
            this.z2Input.Size = new System.Drawing.Size(43, 20);
            this.z2Input.TabIndex = 17;
            // 
            // y2Input
            // 
            this.y2Input.Location = new System.Drawing.Point(113, 203);
            this.y2Input.Name = "y2Input";
            this.y2Input.Size = new System.Drawing.Size(43, 20);
            this.y2Input.TabIndex = 16;
            // 
            // x2Input
            // 
            this.x2Input.Location = new System.Drawing.Point(113, 180);
            this.x2Input.Name = "x2Input";
            this.x2Input.Size = new System.Drawing.Size(44, 20);
            this.x2Input.TabIndex = 15;
            // 
            // z2Label
            // 
            this.z2Label.AutoSize = true;
            this.z2Label.Location = new System.Drawing.Point(93, 231);
            this.z2Label.Name = "z2Label";
            this.z2Label.Size = new System.Drawing.Size(14, 13);
            this.z2Label.TabIndex = 14;
            this.z2Label.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "X";
            // 
            // z4Input
            // 
            this.z4Input.Location = new System.Drawing.Point(326, 228);
            this.z4Input.Name = "z4Input";
            this.z4Input.Size = new System.Drawing.Size(43, 20);
            this.z4Input.TabIndex = 32;
            // 
            // y4Input
            // 
            this.y4Input.Location = new System.Drawing.Point(326, 203);
            this.y4Input.Name = "y4Input";
            this.y4Input.Size = new System.Drawing.Size(43, 20);
            this.y4Input.TabIndex = 31;
            // 
            // x4Input
            // 
            this.x4Input.Location = new System.Drawing.Point(326, 180);
            this.x4Input.Name = "x4Input";
            this.x4Input.Size = new System.Drawing.Size(44, 20);
            this.x4Input.TabIndex = 30;
            // 
            // z4Label
            // 
            this.z4Label.AutoSize = true;
            this.z4Label.Location = new System.Drawing.Point(306, 231);
            this.z4Label.Name = "z4Label";
            this.z4Label.Size = new System.Drawing.Size(14, 13);
            this.z4Label.TabIndex = 29;
            this.z4Label.Text = "Z";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(307, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "X";
            // 
            // z3Input
            // 
            this.z3Input.Location = new System.Drawing.Point(254, 228);
            this.z3Input.Name = "z3Input";
            this.z3Input.Size = new System.Drawing.Size(43, 20);
            this.z3Input.TabIndex = 26;
            // 
            // y3Input
            // 
            this.y3Input.Location = new System.Drawing.Point(254, 203);
            this.y3Input.Name = "y3Input";
            this.y3Input.Size = new System.Drawing.Size(43, 20);
            this.y3Input.TabIndex = 25;
            // 
            // x3Input
            // 
            this.x3Input.Location = new System.Drawing.Point(254, 180);
            this.x3Input.Name = "x3Input";
            this.x3Input.Size = new System.Drawing.Size(44, 20);
            this.x3Input.TabIndex = 24;
            // 
            // z3Label
            // 
            this.z3Label.AutoSize = true;
            this.z3Label.Location = new System.Drawing.Point(234, 231);
            this.z3Label.Name = "z3Label";
            this.z3Label.Size = new System.Drawing.Size(14, 13);
            this.z3Label.TabIndex = 23;
            this.z3Label.Text = "Z";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(234, 206);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Y";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(235, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "X";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(323, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Vertex 2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(252, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Vertex 1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(295, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Box 2";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(156, 275);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 33;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(283, 275);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 34;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CollisionLabel
            // 
            this.CollisionLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CollisionLabel.AutoSize = true;
            this.CollisionLabel.Location = new System.Drawing.Point(153, 323);
            this.CollisionLabel.Name = "CollisionLabel";
            this.CollisionLabel.Size = new System.Drawing.Size(35, 13);
            this.CollisionLabel.TabIndex = 35;
            this.CollisionLabel.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 363);
            this.Controls.Add(this.CollisionLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.z4Input);
            this.Controls.Add(this.y4Input);
            this.Controls.Add(this.x4Input);
            this.Controls.Add(this.z4Label);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.z3Input);
            this.Controls.Add(this.y3Input);
            this.Controls.Add(this.x3Input);
            this.Controls.Add(this.z3Label);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.z2Input);
            this.Controls.Add(this.y2Input);
            this.Controls.Add(this.x2Input);
            this.Controls.Add(this.z2Label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.z1Input);
            this.Controls.Add(this.y1Input);
            this.Controls.Add(this.x1Input);
            this.Controls.Add(this.z1Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.threeDimensionCheck);
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
        private System.Windows.Forms.CheckBox threeDimensionCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label z1Label;
        private System.Windows.Forms.TextBox x1Input;
        private System.Windows.Forms.TextBox y1Input;
        private System.Windows.Forms.TextBox z1Input;
        private System.Windows.Forms.TextBox z2Input;
        private System.Windows.Forms.TextBox y2Input;
        private System.Windows.Forms.TextBox x2Input;
        private System.Windows.Forms.Label z2Label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox z4Input;
        private System.Windows.Forms.TextBox y4Input;
        private System.Windows.Forms.TextBox x4Input;
        private System.Windows.Forms.Label z4Label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox z3Input;
        private System.Windows.Forms.TextBox y3Input;
        private System.Windows.Forms.TextBox x3Input;
        private System.Windows.Forms.Label z3Label;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label CollisionLabel;
    }
}

