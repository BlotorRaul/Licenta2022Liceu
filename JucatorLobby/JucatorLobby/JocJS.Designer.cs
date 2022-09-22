namespace JucatorLobby
{
    partial class JocJS
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
            this.Dusman3 = new System.Windows.Forms.PictureBox();
            this.Jucator = new System.Windows.Forms.PictureBox();
            this.Glont = new System.Windows.Forms.PictureBox();
            this.Dusman2 = new System.Windows.Forms.PictureBox();
            this.Dusman1 = new System.Windows.Forms.PictureBox();
            this.txtScor = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dusman3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jucator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Glont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dusman2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dusman1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dusman3
            // 
            this.Dusman3.Image = global::JucatorLobby.Properties.Resources.enemy;
            this.Dusman3.Location = new System.Drawing.Point(585, 80);
            this.Dusman3.Name = "Dusman3";
            this.Dusman3.Size = new System.Drawing.Size(100, 85);
            this.Dusman3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dusman3.TabIndex = 0;
            this.Dusman3.TabStop = false;
            // 
            // Jucator
            // 
            this.Jucator.Image = global::JucatorLobby.Properties.Resources.player;
            this.Jucator.Location = new System.Drawing.Point(333, 556);
            this.Jucator.Name = "Jucator";
            this.Jucator.Size = new System.Drawing.Size(110, 98);
            this.Jucator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Jucator.TabIndex = 0;
            this.Jucator.TabStop = false;
            // 
            // Glont
            // 
            this.Glont.Image = global::JucatorLobby.Properties.Resources.bullet;
            this.Glont.Location = new System.Drawing.Point(380, 502);
            this.Glont.Name = "Glont";
            this.Glont.Size = new System.Drawing.Size(7, 27);
            this.Glont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Glont.TabIndex = 0;
            this.Glont.TabStop = false;
            // 
            // Dusman2
            // 
            this.Dusman2.Image = global::JucatorLobby.Properties.Resources.enemy;
            this.Dusman2.Location = new System.Drawing.Point(287, 70);
            this.Dusman2.Name = "Dusman2";
            this.Dusman2.Size = new System.Drawing.Size(100, 85);
            this.Dusman2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dusman2.TabIndex = 0;
            this.Dusman2.TabStop = false;
            // 
            // Dusman1
            // 
            this.Dusman1.Image = global::JucatorLobby.Properties.Resources.enemy;
            this.Dusman1.Location = new System.Drawing.Point(67, 80);
            this.Dusman1.Name = "Dusman1";
            this.Dusman1.Size = new System.Drawing.Size(100, 85);
            this.Dusman1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dusman1.TabIndex = 0;
            this.Dusman1.TabStop = false;
            // 
            // txtScor
            // 
            this.txtScor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScor.Location = new System.Drawing.Point(12, 260);
            this.txtScor.Name = "txtScor";
            this.txtScor.Size = new System.Drawing.Size(774, 152);
            this.txtScor.TabIndex = 1;
            this.txtScor.Text = "0";
            this.txtScor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // JocJS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(798, 666);
            this.Controls.Add(this.Dusman3);
            this.Controls.Add(this.Jucator);
            this.Controls.Add(this.Glont);
            this.Controls.Add(this.Dusman2);
            this.Controls.Add(this.Dusman1);
            this.Controls.Add(this.txtScor);
            this.Name = "JocJS";
            this.Text = "Fighter jet shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Dusman3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jucator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Glont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dusman2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dusman1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Dusman1;
        private System.Windows.Forms.PictureBox Dusman2;
        private System.Windows.Forms.PictureBox Dusman3;
        private System.Windows.Forms.PictureBox Glont;
        private System.Windows.Forms.PictureBox Jucator;
        private System.Windows.Forms.Label txtScor;
        private System.Windows.Forms.Timer gameTimer;
    }
}