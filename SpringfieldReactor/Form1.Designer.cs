namespace SpringfieldReactor
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
            this.Reactor1Label = new System.Windows.Forms.Label();
            this.Reactor2Label = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Reactor1 = new System.Windows.Forms.Label();
            this.Reactor2 = new System.Windows.Forms.Label();
            this.EnableButton = new System.Windows.Forms.Button();
            this.ReactorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reactor1Label
            // 
            this.Reactor1Label.AutoSize = true;
            this.Reactor1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor1Label.Location = new System.Drawing.Point(141, 199);
            this.Reactor1Label.Name = "Reactor1Label";
            this.Reactor1Label.Size = new System.Drawing.Size(116, 29);
            this.Reactor1Label.TabIndex = 0;
            this.Reactor1Label.Text = "Reactor 1";
            this.Reactor1Label.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Reactor2Label
            // 
            this.Reactor2Label.AutoSize = true;
            this.Reactor2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor2Label.Location = new System.Drawing.Point(494, 199);
            this.Reactor2Label.Name = "Reactor2Label";
            this.Reactor2Label.Size = new System.Drawing.Size(116, 29);
            this.Reactor2Label.TabIndex = 1;
            this.Reactor2Label.Text = "Reactor 2";
            this.Reactor2Label.Click += new System.EventHandler(this.Label2_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(183, 77);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(427, 44);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Nuclear Reactor Control";
            // 
            // Reactor1
            // 
            this.Reactor1.BackColor = System.Drawing.Color.LimeGreen;
            this.Reactor1.Location = new System.Drawing.Point(143, 240);
            this.Reactor1.Name = "Reactor1";
            this.Reactor1.Size = new System.Drawing.Size(114, 72);
            this.Reactor1.TabIndex = 3;
            // 
            // Reactor2
            // 
            this.Reactor2.BackColor = System.Drawing.Color.LimeGreen;
            this.Reactor2.Location = new System.Drawing.Point(496, 240);
            this.Reactor2.Name = "Reactor2";
            this.Reactor2.Size = new System.Drawing.Size(114, 72);
            this.Reactor2.TabIndex = 4;
            // 
            // EnableButton
            // 
            this.EnableButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.EnableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.EnableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EnableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableButton.Location = new System.Drawing.Point(345, 312);
            this.EnableButton.Name = "EnableButton";
            this.EnableButton.Size = new System.Drawing.Size(66, 33);
            this.EnableButton.TabIndex = 5;
            this.EnableButton.Text = "Start";
            this.EnableButton.UseVisualStyleBackColor = false;
            this.EnableButton.Click += new System.EventHandler(this.EnableButton_Click);
            // 
            // ReactorLabel
            // 
            this.ReactorLabel.AutoSize = true;
            this.ReactorLabel.BackColor = System.Drawing.Color.DarkGray;
            this.ReactorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReactorLabel.Location = new System.Drawing.Point(302, 382);
            this.ReactorLabel.Name = "ReactorLabel";
            this.ReactorLabel.Size = new System.Drawing.Size(150, 25);
            this.ReactorLabel.TabIndex = 6;
            this.ReactorLabel.Text = "Reactors Stable";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.ReactorLabel);
            this.Controls.Add(this.EnableButton);
            this.Controls.Add(this.Reactor2);
            this.Controls.Add(this.Reactor1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Reactor2Label);
            this.Controls.Add(this.Reactor1Label);
            this.Name = "Form1";
            this.Text = "Reactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reactor1Label;
        private System.Windows.Forms.Label Reactor2Label;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Reactor1;
        private System.Windows.Forms.Label Reactor2;
        private System.Windows.Forms.Button EnableButton;
        private System.Windows.Forms.Label ReactorLabel;
    }
}

