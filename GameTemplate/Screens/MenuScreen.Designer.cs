namespace GameTemplate.Screens
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.scoresButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.instructionButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Cyan;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(15, 245);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 75);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.Cyan;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.Location = new System.Drawing.Point(38, 168);
            this.optionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(180, 75);
            this.optionsButton.TabIndex = 9;
            this.optionsButton.Tag = "OptionsScreen";
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // scoresButton
            // 
            this.scoresButton.BackColor = System.Drawing.Color.Cyan;
            this.scoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoresButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresButton.Location = new System.Drawing.Point(68, -22);
            this.scoresButton.Margin = new System.Windows.Forms.Padding(2);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(180, 75);
            this.scoresButton.TabIndex = 8;
            this.scoresButton.Tag = "ScoreScreen";
            this.scoresButton.Text = "High Scores";
            this.scoresButton.UseVisualStyleBackColor = false;
            this.scoresButton.Click += new System.EventHandler(this.scoresButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Aqua;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(160, 3);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(180, 75);
            this.playButton.TabIndex = 6;
            this.playButton.Tag = "GameScreen";
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // instructionButton
            // 
            this.instructionButton.BackColor = System.Drawing.Color.Cyan;
            this.instructionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionButton.Location = new System.Drawing.Point(344, 206);
            this.instructionButton.Margin = new System.Windows.Forms.Padding(2);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(180, 75);
            this.instructionButton.TabIndex = 7;
            this.instructionButton.Text = "How To Play";
            this.instructionButton.UseVisualStyleBackColor = false;
            this.instructionButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GameTemplate.Properties.Resources.cube2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(500, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 124);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // gameTitle
            // 
            this.gameTitle.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.Color.Black;
            this.gameTitle.Location = new System.Drawing.Point(15, 110);
            this.gameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(555, 186);
            this.gameTitle.TabIndex = 5;
            this.gameTitle.Text = "Cube Runner";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GameTemplate.Properties.Resources.cube2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(500, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 127);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.scoresButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gameTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(726, 369);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button scoresButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button instructionButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
