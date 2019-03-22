namespace BouncingBalls
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.reactionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(73, 80);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(682, 73);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Bouncing balls";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.Location = new System.Drawing.Point(288, 162);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(234, 22);
            this.subTitleLabel.TabIndex = 1;
            this.subTitleLabel.Text = "or a clumsy attempt to make it more accurate";
            this.subTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playButton
            // 
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(186, 288);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(143, 72);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(494, 288);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(143, 72);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "DON\'T PLAY";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // reactionTimer
            // 
            this.reactionTimer.Interval = 3000;
            this.reactionTimer.Tick += new System.EventHandler(this.reactionTimer_Tick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Timer reactionTimer;
    }
}
