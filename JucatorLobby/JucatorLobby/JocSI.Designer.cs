namespace JucatorLobby
{
    partial class JocSI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JocSI));
            this.txtScor = new System.Windows.Forms.Label();
            this.jucator = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jucator)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScor
            // 
            this.txtScor.AutoSize = true;
            this.txtScor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScor.ForeColor = System.Drawing.Color.White;
            this.txtScor.Location = new System.Drawing.Point(12, 516);
            this.txtScor.Name = "txtScor";
            this.txtScor.Size = new System.Drawing.Size(95, 29);
            this.txtScor.TabIndex = 1;
            this.txtScor.Text = "Scor: 0";
            // 
            // jucator
            // 
            this.jucator.Image = global::JucatorLobby.Properties.Resources.tank;
            this.jucator.Location = new System.Drawing.Point(292, 463);
            this.jucator.Name = "jucator";
            this.jucator.Size = new System.Drawing.Size(100, 78);
            this.jucator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jucator.TabIndex = 0;
            this.jucator.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // JocSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.txtScor);
            this.Controls.Add(this.jucator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JocSI";
            this.Text = "Space Invaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.jucator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox jucator;
        private System.Windows.Forms.Label txtScor;
        private System.Windows.Forms.Timer gameTimer;
    }
}