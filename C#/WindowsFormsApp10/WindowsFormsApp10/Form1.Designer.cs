namespace WindowsFormsApp10 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.WidthFeet = new System.Windows.Forms.TextBox();
            this.WidthInches = new System.Windows.Forms.TextBox();
            this.FeetLabel = new System.Windows.Forms.Label();
            this.InchesLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.LengthInches = new System.Windows.Forms.TextBox();
            this.LengthFeet = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.FinalCost = new System.Windows.Forms.Label();
            this.YardCost = new System.Windows.Forms.Label();
            this.FinalCostText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WidthFeet
            // 
            this.WidthFeet.Location = new System.Drawing.Point(65, 28);
            this.WidthFeet.Name = "WidthFeet";
            this.WidthFeet.Size = new System.Drawing.Size(50, 22);
            this.WidthFeet.TabIndex = 0;
            this.WidthFeet.TextChanged += new System.EventHandler(this.WidthFeet_TextChanged);
            // 
            // WidthInches
            // 
            this.WidthInches.Location = new System.Drawing.Point(143, 28);
            this.WidthInches.Name = "WidthInches";
            this.WidthInches.Size = new System.Drawing.Size(50, 22);
            this.WidthInches.TabIndex = 1;
            this.WidthInches.TextChanged += new System.EventHandler(this.WidthInches_TextChanged);
            // 
            // FeetLabel
            // 
            this.FeetLabel.AutoSize = true;
            this.FeetLabel.Location = new System.Drawing.Point(71, 8);
            this.FeetLabel.Name = "FeetLabel";
            this.FeetLabel.Size = new System.Drawing.Size(34, 16);
            this.FeetLabel.TabIndex = 2;
            this.FeetLabel.Text = "Feet";
            // 
            // InchesLabel
            // 
            this.InchesLabel.AutoSize = true;
            this.InchesLabel.Location = new System.Drawing.Point(147, 9);
            this.InchesLabel.Name = "InchesLabel";
            this.InchesLabel.Size = new System.Drawing.Size(46, 16);
            this.InchesLabel.TabIndex = 3;
            this.InchesLabel.Text = "Inches";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(13, 33);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(44, 16);
            this.WidthLabel.TabIndex = 4;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(7, 72);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(50, 16);
            this.LengthLabel.TabIndex = 7;
            this.LengthLabel.Text = "Length:";
            // 
            // LengthInches
            // 
            this.LengthInches.Location = new System.Drawing.Point(143, 66);
            this.LengthInches.Name = "LengthInches";
            this.LengthInches.Size = new System.Drawing.Size(50, 22);
            this.LengthInches.TabIndex = 6;
            this.LengthInches.TextChanged += new System.EventHandler(this.LengthInches_TextChanged);
            // 
            // LengthFeet
            // 
            this.LengthFeet.Location = new System.Drawing.Point(65, 66);
            this.LengthFeet.Name = "LengthFeet";
            this.LengthFeet.Size = new System.Drawing.Size(50, 22);
            this.LengthFeet.TabIndex = 5;
            this.LengthFeet.TextChanged += new System.EventHandler(this.LengthFeet_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(105, 91);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(65, 110);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(128, 22);
            this.NameText.TabIndex = 9;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // FinalCost
            // 
            this.FinalCost.AutoSize = true;
            this.FinalCost.Location = new System.Drawing.Point(95, 168);
            this.FinalCost.Name = "FinalCost";
            this.FinalCost.Size = new System.Drawing.Size(66, 16);
            this.FinalCost.TabIndex = 10;
            this.FinalCost.Text = "Final Cost";
            // 
            // YardCost
            // 
            this.YardCost.AutoSize = true;
            this.YardCost.Location = new System.Drawing.Point(68, 135);
            this.YardCost.Name = "YardCost";
            this.YardCost.Size = new System.Drawing.Size(124, 16);
            this.YardCost.TabIndex = 11;
            this.YardCost.Text = "Cost per yard: 15.95";
            // 
            // FinalCostText
            // 
            this.FinalCostText.Location = new System.Drawing.Point(65, 187);
            this.FinalCostText.Name = "FinalCostText";
            this.FinalCostText.ReadOnly = true;
            this.FinalCostText.Size = new System.Drawing.Size(128, 22);
            this.FinalCostText.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinalCostText);
            this.Controls.Add(this.YardCost);
            this.Controls.Add(this.FinalCost);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.LengthInches);
            this.Controls.Add(this.LengthFeet);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.InchesLabel);
            this.Controls.Add(this.FeetLabel);
            this.Controls.Add(this.WidthInches);
            this.Controls.Add(this.WidthFeet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WidthFeet;
        private System.Windows.Forms.TextBox WidthInches;
        private System.Windows.Forms.Label FeetLabel;
        private System.Windows.Forms.Label InchesLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox LengthInches;
        private System.Windows.Forms.TextBox LengthFeet;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label FinalCost;
        private System.Windows.Forms.Label YardCost;
        private System.Windows.Forms.TextBox FinalCostText;
    }
}

