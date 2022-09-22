namespace JucatorLobby
{
    partial class JocCRcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JocCRcs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.premiu = new System.Windows.Forms.PictureBox();
            this.jucator = new System.Windows.Forms.PictureBox();
            this.explozie = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScor = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.premiu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explozie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.premiu);
            this.panel1.Controls.Add(this.jucator);
            this.panel1.Controls.Add(this.explozie);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 650);
            this.panel1.TabIndex = 0;
            // 
            // premiu
            // 
            this.premiu.Image = global::JucatorLobby.Properties.Resources.bronze;
            this.premiu.Location = new System.Drawing.Point(127, 277);
            this.premiu.Name = "premiu";
            this.premiu.Size = new System.Drawing.Size(250, 100);
            this.premiu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.premiu.TabIndex = 1;
            this.premiu.TabStop = false;
            // 
            // jucator
            // 
            this.jucator.Image = global::JucatorLobby.Properties.Resources.carYellow;
            this.jucator.Location = new System.Drawing.Point(225, 517);
            this.jucator.Name = "jucator";
            this.jucator.Size = new System.Drawing.Size(50, 99);
            this.jucator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.jucator.TabIndex = 1;
            this.jucator.TabStop = false;
            // 
            // explozie
            // 
            this.explozie.Image = global::JucatorLobby.Properties.Resources.explosion;
            this.explozie.Location = new System.Drawing.Point(83, 434);
            this.explozie.Name = "explozie";
            this.explozie.Size = new System.Drawing.Size(64, 64);
            this.explozie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explozie.TabIndex = 1;
            this.explozie.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.Image = global::JucatorLobby.Properties.Resources.carGrey;
            this.AI2.Location = new System.Drawing.Point(318, 154);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 100);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 1;
            this.AI2.TabStop = false;
            this.AI2.Tag = "masinaDreapta";
            // 
            // AI1
            // 
            this.AI1.Image = global::JucatorLobby.Properties.Resources.carGreen;
            this.AI1.Location = new System.Drawing.Point(83, 154);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 1;
            this.AI1.TabStop = false;
            this.AI1.Tag = "masinaStanga";
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::JucatorLobby.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(479, 645);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 0;
            this.roadTrack2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(203, 707);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // txtScor
            // 
            this.txtScor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScor.Location = new System.Drawing.Point(12, 669);
            this.txtScor.Name = "txtScor";
            this.txtScor.Size = new System.Drawing.Size(479, 35);
            this.txtScor.TabIndex = 2;
            this.txtScor.Text = "Scor: 0";
            this.txtScor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::JucatorLobby.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, -645);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(479, 645);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 2;
            this.roadTrack1.TabStop = false;
            // 
            // JocCRcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 773);
            this.Controls.Add(this.txtScor);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JocCRcs";
            this.Text = "Car Racing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.premiu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explozie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScor;
        private System.Windows.Forms.PictureBox premiu;
        private System.Windows.Forms.PictureBox jucator;
        private System.Windows.Forms.PictureBox explozie;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox roadTrack1;
    }
}