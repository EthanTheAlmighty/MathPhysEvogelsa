namespace LinearAcceleratedMotionLab
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
            this.components = new System.ComponentModel.Container();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VelocityInput = new System.Windows.Forms.TextBox();
            this.DeltaTInput = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.WritingLabel = new System.Windows.Forms.Label();
            this.AnalyticButton = new System.Windows.Forms.Button();
            this.WindButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeightInput
            // 
            this.HeightInput.Enabled = false;
            this.HeightInput.Location = new System.Drawing.Point(151, 102);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(64, 20);
            this.HeightInput.TabIndex = 0;
            this.HeightInput.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Height (m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Initial Velocity (m/s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time Step";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Linear Accelerated Motion Lab";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ethan Vogelsang";
            // 
            // VelocityInput
            // 
            this.VelocityInput.Enabled = false;
            this.VelocityInput.Location = new System.Drawing.Point(151, 138);
            this.VelocityInput.Name = "VelocityInput";
            this.VelocityInput.Size = new System.Drawing.Size(64, 20);
            this.VelocityInput.TabIndex = 6;
            this.VelocityInput.Text = "49";
            // 
            // DeltaTInput
            // 
            this.DeltaTInput.Location = new System.Drawing.Point(151, 176);
            this.DeltaTInput.Name = "DeltaTInput";
            this.DeltaTInput.Size = new System.Drawing.Size(64, 20);
            this.DeltaTInput.TabIndex = 7;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(117, 205);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 8;
            this.CalcButton.Text = "Throw!";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // WritingLabel
            // 
            this.WritingLabel.AutoSize = true;
            this.WritingLabel.Location = new System.Drawing.Point(112, 242);
            this.WritingLabel.Name = "WritingLabel";
            this.WritingLabel.Size = new System.Drawing.Size(0, 13);
            this.WritingLabel.TabIndex = 9;
            // 
            // AnalyticButton
            // 
            this.AnalyticButton.Location = new System.Drawing.Point(237, 100);
            this.AnalyticButton.Name = "AnalyticButton";
            this.AnalyticButton.Size = new System.Drawing.Size(61, 23);
            this.AnalyticButton.TabIndex = 10;
            this.AnalyticButton.Text = "Analytic";
            this.AnalyticButton.UseVisualStyleBackColor = true;
            this.AnalyticButton.Click += new System.EventHandler(this.AnalyticButton_Click);
            // 
            // WindButton
            // 
            this.WindButton.Location = new System.Drawing.Point(237, 131);
            this.WindButton.Name = "WindButton";
            this.WindButton.Size = new System.Drawing.Size(61, 23);
            this.WindButton.TabIndex = 11;
            this.WindButton.Text = "Wind";
            this.WindButton.UseVisualStyleBackColor = true;
            this.WindButton.Click += new System.EventHandler(this.WindButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 281);
            this.Controls.Add(this.WindButton);
            this.Controls.Add(this.AnalyticButton);
            this.Controls.Add(this.WritingLabel);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.DeltaTInput);
            this.Controls.Add(this.VelocityInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VelocityInput;
        private System.Windows.Forms.TextBox DeltaTInput;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label WritingLabel;
        private System.Windows.Forms.Button AnalyticButton;
        private System.Windows.Forms.Button WindButton;
    }
}

