namespace ScalingAndTranslation
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TranslationRadio = new System.Windows.Forms.RadioButton();
            this.RawScaleRadio = new System.Windows.Forms.RadioButton();
            this.ScaleAboutCenterRadio = new System.Windows.Forms.RadioButton();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(622, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 368);
            this.listBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScaleAboutCenterRadio);
            this.groupBox1.Controls.Add(this.RawScaleRadio);
            this.groupBox1.Controls.Add(this.TranslationRadio);
            this.groupBox1.Location = new System.Drawing.Point(92, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of transformation";
            // 
            // TranslationRadio
            // 
            this.TranslationRadio.AutoSize = true;
            this.TranslationRadio.Location = new System.Drawing.Point(33, 19);
            this.TranslationRadio.Name = "TranslationRadio";
            this.TranslationRadio.Size = new System.Drawing.Size(77, 17);
            this.TranslationRadio.TabIndex = 0;
            this.TranslationRadio.TabStop = true;
            this.TranslationRadio.Text = "Translation";
            this.TranslationRadio.UseVisualStyleBackColor = true;
            // 
            // RawScaleRadio
            // 
            this.RawScaleRadio.AutoSize = true;
            this.RawScaleRadio.Location = new System.Drawing.Point(33, 42);
            this.RawScaleRadio.Name = "RawScaleRadio";
            this.RawScaleRadio.Size = new System.Drawing.Size(85, 17);
            this.RawScaleRadio.TabIndex = 1;
            this.RawScaleRadio.TabStop = true;
            this.RawScaleRadio.Text = "Raw Scaling";
            this.RawScaleRadio.UseVisualStyleBackColor = true;
            // 
            // ScaleAboutCenterRadio
            // 
            this.ScaleAboutCenterRadio.AutoSize = true;
            this.ScaleAboutCenterRadio.Location = new System.Drawing.Point(33, 65);
            this.ScaleAboutCenterRadio.Name = "ScaleAboutCenterRadio";
            this.ScaleAboutCenterRadio.Size = new System.Drawing.Size(117, 17);
            this.ScaleAboutCenterRadio.TabIndex = 2;
            this.ScaleAboutCenterRadio.TabStop = true;
            this.ScaleAboutCenterRadio.Text = "Scale About Center";
            this.ScaleAboutCenterRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ScaleAboutCenterRadio;
        private System.Windows.Forms.RadioButton RawScaleRadio;
        private System.Windows.Forms.RadioButton TranslationRadio;
    }
}

