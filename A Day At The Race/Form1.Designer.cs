namespace A_Day_At_The_Race
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.bettingGroup = new System.Windows.Forms.GroupBox();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cashBet = new System.Windows.Forms.NumericUpDown();
            this.dogBet = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.bettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBet)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("racetrackPictureBox.Image")));
            this.racetrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(600, 200);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(12, 24);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(12, 80);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(12, 133);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog3.TabIndex = 3;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(12, 183);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog4.TabIndex = 4;
            this.dog4.TabStop = false;
            // 
            // bettingGroup
            // 
            this.bettingGroup.Controls.Add(this.button1);
            this.bettingGroup.Controls.Add(this.dogBet);
            this.bettingGroup.Controls.Add(this.cashBet);
            this.bettingGroup.Controls.Add(this.label2);
            this.bettingGroup.Controls.Add(this.button2);
            this.bettingGroup.Controls.Add(this.name);
            this.bettingGroup.Controls.Add(this.alBetLabel);
            this.bettingGroup.Controls.Add(this.bobBetLabel);
            this.bettingGroup.Controls.Add(this.joeBetLabel);
            this.bettingGroup.Controls.Add(this.label1);
            this.bettingGroup.Controls.Add(this.alRadioButton);
            this.bettingGroup.Controls.Add(this.bobRadioButton);
            this.bettingGroup.Controls.Add(this.joeRadioButton);
            this.bettingGroup.Controls.Add(this.minimumBetLabel);
            this.bettingGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettingGroup.Location = new System.Drawing.Point(12, 218);
            this.bettingGroup.Name = "bettingGroup";
            this.bettingGroup.Size = new System.Drawing.Size(600, 176);
            this.bettingGroup.TabIndex = 5;
            this.bettingGroup.TabStop = false;
            this.bettingGroup.Text = "Betting Parlor";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(7, 20);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(134, 17);
            this.minimumBetLabel.TabIndex = 3;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(10, 50);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(110, 19);
            this.joeRadioButton.TabIndex = 4;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(10, 76);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(114, 19);
            this.bobRadioButton.TabIndex = 5;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(10, 105);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(103, 19);
            this.alRadioButton.TabIndex = 6;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bets";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(185, 49);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(194, 20);
            this.joeBetLabel.TabIndex = 9;
            this.joeBetLabel.Text = "joeBetLabel";
            this.joeBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(185, 77);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(194, 20);
            this.bobBetLabel.TabIndex = 10;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(185, 106);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(194, 20);
            this.alBetLabel.TabIndex = 11;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(10, 140);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(39, 15);
            this.name.TabIndex = 12;
            this.name.Text = "name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Bets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(182, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "bucks on dog number";
            // 
            // cashBet
            // 
            this.cashBet.Location = new System.Drawing.Point(119, 142);
            this.cashBet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.cashBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cashBet.Name = "cashBet";
            this.cashBet.Size = new System.Drawing.Size(47, 21);
            this.cashBet.TabIndex = 15;
            this.cashBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dogBet
            // 
            this.dogBet.Location = new System.Drawing.Point(314, 144);
            this.dogBet.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogBet.Name = "dogBet";
            this.dogBet.Size = new System.Drawing.Size(47, 21);
            this.dogBet.TabIndex = 16;
            this.dogBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(404, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 145);
            this.button1.TabIndex = 17;
            this.button1.Text = "Race!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 405);
            this.Controls.Add(this.bettingGroup);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.bettingGroup.ResumeLayout(false);
            this.bettingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.GroupBox bettingGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.NumericUpDown dogBet;
        private System.Windows.Forms.NumericUpDown cashBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

