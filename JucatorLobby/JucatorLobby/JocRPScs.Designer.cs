namespace JucatorLobby
{
    partial class JocRPScs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JocRPScs));
            this.btnPiatra = new System.Windows.Forms.Button();
            this.btnFoarfeca = new System.Windows.Forms.Button();
            this.btnHartie = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScadenta = new System.Windows.Forms.Label();
            this.txtScor = new System.Windows.Forms.Label();
            this.txtRunde = new System.Windows.Forms.Label();
            this.picPC = new System.Windows.Forms.PictureBox();
            this.picJucator = new System.Windows.Forms.PictureBox();
            this.numaraScadenta = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJucator)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPiatra
            // 
            this.btnPiatra.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPiatra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPiatra.Location = new System.Drawing.Point(65, 70);
            this.btnPiatra.Name = "btnPiatra";
            this.btnPiatra.Size = new System.Drawing.Size(84, 43);
            this.btnPiatra.TabIndex = 0;
            this.btnPiatra.Text = "Piatra";
            this.btnPiatra.UseVisualStyleBackColor = false;
            this.btnPiatra.Click += new System.EventHandler(this.btnPiatra_Click);
            // 
            // btnFoarfeca
            // 
            this.btnFoarfeca.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFoarfeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoarfeca.Location = new System.Drawing.Point(65, 128);
            this.btnFoarfeca.Name = "btnFoarfeca";
            this.btnFoarfeca.Size = new System.Drawing.Size(84, 43);
            this.btnFoarfeca.TabIndex = 0;
            this.btnFoarfeca.Text = "Foarfeca";
            this.btnFoarfeca.UseVisualStyleBackColor = false;
            this.btnFoarfeca.Click += new System.EventHandler(this.btnFoarfeca_Click);
            // 
            // btnHartie
            // 
            this.btnHartie.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnHartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHartie.Location = new System.Drawing.Point(65, 186);
            this.btnHartie.Name = "btnHartie";
            this.btnHartie.Size = new System.Drawing.Size(84, 43);
            this.btnHartie.TabIndex = 0;
            this.btnHartie.Text = "Hartie";
            this.btnHartie.UseVisualStyleBackColor = false;
            this.btnHartie.Click += new System.EventHandler(this.btnHartie_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Location = new System.Drawing.Point(700, 415);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jucator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "PC";
            // 
            // txtScadenta
            // 
            this.txtScadenta.AutoSize = true;
            this.txtScadenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScadenta.Location = new System.Drawing.Point(499, 131);
            this.txtScadenta.Name = "txtScadenta";
            this.txtScadenta.Size = new System.Drawing.Size(27, 29);
            this.txtScadenta.TabIndex = 4;
            this.txtScadenta.Text = "5";
            this.txtScadenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScor
            // 
            this.txtScor.AutoSize = true;
            this.txtScor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScor.Location = new System.Drawing.Point(417, 84);
            this.txtScor.Name = "txtScor";
            this.txtScor.Size = new System.Drawing.Size(191, 29);
            this.txtScor.TabIndex = 4;
            this.txtScor.Text = "Jucator:0- PC:0";
            this.txtScor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRunde
            // 
            this.txtRunde.AutoSize = true;
            this.txtRunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunde.Location = new System.Drawing.Point(449, 281);
            this.txtRunde.Name = "txtRunde";
            this.txtRunde.Size = new System.Drawing.Size(117, 29);
            this.txtRunde.TabIndex = 4;
            this.txtRunde.Text = "Runde: 3";
            this.txtRunde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPC
            // 
            this.picPC.Image = global::JucatorLobby.Properties.Resources.qq;
            this.picPC.Location = new System.Drawing.Point(652, 84);
            this.picPC.Name = "picPC";
            this.picPC.Size = new System.Drawing.Size(136, 104);
            this.picPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPC.TabIndex = 3;
            this.picPC.TabStop = false;
            // 
            // picJucator
            // 
            this.picJucator.Image = global::JucatorLobby.Properties.Resources.qq;
            this.picJucator.Location = new System.Drawing.Point(249, 84);
            this.picJucator.Name = "picJucator";
            this.picJucator.Size = new System.Drawing.Size(136, 104);
            this.picJucator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJucator.TabIndex = 2;
            this.picJucator.TabStop = false;
            // 
            // numaraScadenta
            // 
            this.numaraScadenta.Interval = 1000;
            this.numaraScadenta.Tick += new System.EventHandler(this.numaraScadentaEvent);
            // 
            // JocRPScs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPC);
            this.Controls.Add(this.txtRunde);
            this.Controls.Add(this.txtScor);
            this.Controls.Add(this.txtScadenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picJucator);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnHartie);
            this.Controls.Add(this.btnFoarfeca);
            this.Controls.Add(this.btnPiatra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JocRPScs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piatra Foarfeca Hartie";
            ((System.ComponentModel.ISupportInitialize)(this.picPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJucator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPiatra;
        private System.Windows.Forms.Button btnFoarfeca;
        private System.Windows.Forms.Button btnHartie;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picJucator;
        private System.Windows.Forms.PictureBox picPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtScadenta;
        private System.Windows.Forms.Label txtScor;
        private System.Windows.Forms.Label txtRunde;
        private System.Windows.Forms.Timer numaraScadenta;
    }
}