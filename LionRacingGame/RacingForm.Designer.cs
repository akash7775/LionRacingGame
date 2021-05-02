namespace LionRacingGame
{
    partial class RacingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacingForm));
            this.Lion1 = new System.Windows.Forms.PictureBox();
            this.Lion2 = new System.Windows.Forms.PictureBox();
            this.Lion3 = new System.Windows.Forms.PictureBox();
            this.Lion4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AliBet = new System.Windows.Forms.Label();
            this.MaryBet = new System.Windows.Forms.Label();
            this.JoBet = new System.Windows.Forms.Label();
            this.BetDetails = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.LionNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.AliRButton = new System.Windows.Forms.RadioButton();
            this.MaryRButton = new System.Windows.Forms.RadioButton();
            this.JoButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            this.racetrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lion3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lion4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LionNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // Lion1
            // 
            this.Lion1.Image = ((System.Drawing.Image)(resources.GetObject("Lion1.Image")));
            this.Lion1.Location = new System.Drawing.Point(18, 52);
            this.Lion1.Margin = new System.Windows.Forms.Padding(4);
            this.Lion1.Name = "Lion1";
            this.Lion1.Size = new System.Drawing.Size(89, 56);
            this.Lion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lion1.TabIndex = 1;
            this.Lion1.TabStop = false;
            // 
            // Lion2
            // 
            this.Lion2.Image = ((System.Drawing.Image)(resources.GetObject("Lion2.Image")));
            this.Lion2.Location = new System.Drawing.Point(17, 138);
            this.Lion2.Margin = new System.Windows.Forms.Padding(4);
            this.Lion2.Name = "Lion2";
            this.Lion2.Size = new System.Drawing.Size(83, 57);
            this.Lion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lion2.TabIndex = 2;
            this.Lion2.TabStop = false;
            // 
            // Lion3
            // 
            this.Lion3.Image = ((System.Drawing.Image)(resources.GetObject("Lion3.Image")));
            this.Lion3.Location = new System.Drawing.Point(18, 226);
            this.Lion3.Margin = new System.Windows.Forms.Padding(4);
            this.Lion3.Name = "Lion3";
            this.Lion3.Size = new System.Drawing.Size(83, 57);
            this.Lion3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lion3.TabIndex = 3;
            this.Lion3.TabStop = false;
            // 
            // Lion4
            // 
            this.Lion4.Image = ((System.Drawing.Image)(resources.GetObject("Lion4.Image")));
            this.Lion4.Location = new System.Drawing.Point(18, 319);
            this.Lion4.Margin = new System.Windows.Forms.Padding(4);
            this.Lion4.Name = "Lion4";
            this.Lion4.Size = new System.Drawing.Size(83, 57);
            this.Lion4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lion4.TabIndex = 4;
            this.Lion4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.AliBet);
            this.groupBox1.Controls.Add(this.MaryBet);
            this.groupBox1.Controls.Add(this.JoBet);
            this.groupBox1.Controls.Add(this.BetDetails);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.LionNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.AliRButton);
            this.groupBox1.Controls.Add(this.MaryRButton);
            this.groupBox1.Controls.Add(this.JoButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Location = new System.Drawing.Point(1076, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(259, 416);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lion Betting ";
            // 
            // AliBet
            // 
            this.AliBet.BackColor = System.Drawing.SystemColors.Info;
            this.AliBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AliBet.Location = new System.Drawing.Point(18, 315);
            this.AliBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AliBet.Name = "AliBet";
            this.AliBet.Size = new System.Drawing.Size(233, 36);
            this.AliBet.TabIndex = 13;
            // 
            // MaryBet
            // 
            this.MaryBet.BackColor = System.Drawing.SystemColors.Info;
            this.MaryBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaryBet.Location = new System.Drawing.Point(18, 266);
            this.MaryBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaryBet.Name = "MaryBet";
            this.MaryBet.Size = new System.Drawing.Size(233, 36);
            this.MaryBet.TabIndex = 12;
            // 
            // JoBet
            // 
            this.JoBet.BackColor = System.Drawing.SystemColors.Info;
            this.JoBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoBet.Location = new System.Drawing.Point(19, 217);
            this.JoBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JoBet.Name = "JoBet";
            this.JoBet.Size = new System.Drawing.Size(233, 36);
            this.JoBet.TabIndex = 11;
            // 
            // BetDetails
            // 
            this.BetDetails.AutoSize = true;
            this.BetDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetDetails.Location = new System.Drawing.Point(15, 187);
            this.BetDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetDetails.Name = "BetDetails";
            this.BetDetails.Size = new System.Drawing.Size(48, 20);
            this.BetDetails.TabIndex = 10;
            this.BetDetails.Text = "Bets";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(42, 369);
            this.race.Margin = new System.Windows.Forms.Padding(4);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(180, 37);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // LionNumber
            // 
            this.LionNumber.Location = new System.Drawing.Point(148, 154);
            this.LionNumber.Margin = new System.Windows.Forms.Padding(4);
            this.LionNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.LionNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LionNumber.Name = "LionNumber";
            this.LionNumber.Size = new System.Drawing.Size(85, 22);
            this.LionNumber.TabIndex = 8;
            this.LionNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lion number";
            // 
            // BettingAmount
            // 
            this.BettingAmount.Location = new System.Drawing.Point(149, 89);
            this.BettingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(84, 22);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bets.Location = new System.Drawing.Point(8, 89);
            this.Bets.Margin = new System.Windows.Forms.Padding(4);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(112, 44);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // AliRButton
            // 
            this.AliRButton.AutoSize = true;
            this.AliRButton.Checked = true;
            this.AliRButton.Location = new System.Drawing.Point(178, 60);
            this.AliRButton.Margin = new System.Windows.Forms.Padding(4);
            this.AliRButton.Name = "AliRButton";
            this.AliRButton.Size = new System.Drawing.Size(44, 21);
            this.AliRButton.TabIndex = 3;
            this.AliRButton.TabStop = true;
            this.AliRButton.Text = "Ali";
            this.AliRButton.UseVisualStyleBackColor = true;
            this.AliRButton.CheckedChanged += new System.EventHandler(this.AliButton_CheckedChanged);
            // 
            // MaryRButton
            // 
            this.MaryRButton.AutoSize = true;
            this.MaryRButton.Location = new System.Drawing.Point(85, 60);
            this.MaryRButton.Margin = new System.Windows.Forms.Padding(4);
            this.MaryRButton.Name = "MaryRButton";
            this.MaryRButton.Size = new System.Drawing.Size(60, 21);
            this.MaryRButton.TabIndex = 2;
            this.MaryRButton.Text = "Mary";
            this.MaryRButton.UseVisualStyleBackColor = true;
            this.MaryRButton.CheckedChanged += new System.EventHandler(this.MaryButton_CheckedChanged);
            // 
            // JoButton
            // 
            this.JoButton.AutoSize = true;
            this.JoButton.Location = new System.Drawing.Point(19, 60);
            this.JoButton.Margin = new System.Windows.Forms.Padding(4);
            this.JoButton.Name = "JoButton";
            this.JoButton.Size = new System.Drawing.Size(44, 21);
            this.JoButton.TabIndex = 1;
            this.JoButton.Text = "Jo";
            this.JoButton.UseVisualStyleBackColor = true;
            this.JoButton.CheckedChanged += new System.EventHandler(this.JoButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(15, 30);
            this.MaximumBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(120, 20);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-1, 4);
            this.racetrack.Margin = new System.Windows.Forms.Padding(4);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1069, 416);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // RacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lion4);
            this.Controls.Add(this.Lion3);
            this.Controls.Add(this.Lion2);
            this.Controls.Add(this.Lion1);
            this.Controls.Add(this.racetrack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RacingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Course";
            ((System.ComponentModel.ISupportInitialize)(this.Lion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lion3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lion4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LionNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Lion1;
        private System.Windows.Forms.PictureBox Lion2;
        private System.Windows.Forms.PictureBox Lion3;
        private System.Windows.Forms.PictureBox Lion4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AliRButton;
        private System.Windows.Forms.RadioButton MaryRButton;
        private System.Windows.Forms.RadioButton JoButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown LionNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label BetDetails;
        private System.Windows.Forms.Label JoBet;
        private System.Windows.Forms.Label AliBet;
        private System.Windows.Forms.Label MaryBet;
        private System.Windows.Forms.PictureBox racetrack;
    }
}
