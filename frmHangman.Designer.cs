﻿namespace Hangman_GUI
{
    partial class frmHangman
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
            this.btnQ = new System.Windows.Forms.Button();
            this.pbGallows = new System.Windows.Forms.PictureBox();
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslWins = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStreak = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbGallows)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQ
            // 
            this.btnQ.Image = global::Hangman_GUI.Properties.Resources.Q;
            this.btnQ.Location = new System.Drawing.Point(516, 233);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(64, 63);
            this.btnQ.TabIndex = 1;
            this.btnQ.Tag = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnA_Click);
            // 
            // pbGallows
            // 
            this.pbGallows.Image = global::Hangman_GUI.Properties.Resources.Stage0;
            this.pbGallows.Location = new System.Drawing.Point(50, 165);
            this.pbGallows.Name = "pbGallows";
            this.pbGallows.Size = new System.Drawing.Size(400, 360);
            this.pbGallows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGallows.TabIndex = 0;
            this.pbGallows.TabStop = false;
            // 
            // btnW
            // 
            this.btnW.Image = global::Hangman_GUI.Properties.Resources.W;
            this.btnW.Location = new System.Drawing.Point(586, 233);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(64, 63);
            this.btnW.TabIndex = 2;
            this.btnW.Tag = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnE
            // 
            this.btnE.Image = global::Hangman_GUI.Properties.Resources.E;
            this.btnE.Location = new System.Drawing.Point(656, 233);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(64, 63);
            this.btnE.TabIndex = 3;
            this.btnE.Tag = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnR
            // 
            this.btnR.Image = global::Hangman_GUI.Properties.Resources.R;
            this.btnR.Location = new System.Drawing.Point(726, 233);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(64, 63);
            this.btnR.TabIndex = 4;
            this.btnR.Tag = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnT
            // 
            this.btnT.Image = global::Hangman_GUI.Properties.Resources.T;
            this.btnT.Location = new System.Drawing.Point(796, 233);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(64, 63);
            this.btnT.TabIndex = 5;
            this.btnT.Tag = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnY
            // 
            this.btnY.Image = global::Hangman_GUI.Properties.Resources.Y;
            this.btnY.Location = new System.Drawing.Point(866, 233);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(64, 63);
            this.btnY.TabIndex = 6;
            this.btnY.Tag = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnU
            // 
            this.btnU.Image = global::Hangman_GUI.Properties.Resources.U;
            this.btnU.Location = new System.Drawing.Point(936, 233);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(64, 63);
            this.btnU.TabIndex = 7;
            this.btnU.Tag = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnI
            // 
            this.btnI.Image = global::Hangman_GUI.Properties.Resources.I;
            this.btnI.Location = new System.Drawing.Point(1006, 233);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(64, 63);
            this.btnI.TabIndex = 8;
            this.btnI.Tag = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnO
            // 
            this.btnO.Image = global::Hangman_GUI.Properties.Resources.O;
            this.btnO.Location = new System.Drawing.Point(1076, 233);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(64, 63);
            this.btnO.TabIndex = 9;
            this.btnO.Tag = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnP
            // 
            this.btnP.Image = global::Hangman_GUI.Properties.Resources.P;
            this.btnP.Location = new System.Drawing.Point(1146, 233);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(64, 63);
            this.btnP.TabIndex = 10;
            this.btnP.Tag = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnA
            // 
            this.btnA.Image = global::Hangman_GUI.Properties.Resources.A;
            this.btnA.Location = new System.Drawing.Point(546, 302);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(64, 63);
            this.btnA.TabIndex = 11;
            this.btnA.Tag = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnS
            // 
            this.btnS.Image = global::Hangman_GUI.Properties.Resources.S;
            this.btnS.Location = new System.Drawing.Point(616, 302);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(64, 63);
            this.btnS.TabIndex = 12;
            this.btnS.Tag = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnD
            // 
            this.btnD.Image = global::Hangman_GUI.Properties.Resources.D;
            this.btnD.Location = new System.Drawing.Point(686, 302);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(64, 63);
            this.btnD.TabIndex = 13;
            this.btnD.Tag = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnF
            // 
            this.btnF.Image = global::Hangman_GUI.Properties.Resources.F;
            this.btnF.Location = new System.Drawing.Point(756, 302);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(64, 63);
            this.btnF.TabIndex = 14;
            this.btnF.Tag = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnG
            // 
            this.btnG.Image = global::Hangman_GUI.Properties.Resources.G;
            this.btnG.Location = new System.Drawing.Point(826, 302);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(64, 63);
            this.btnG.TabIndex = 15;
            this.btnG.Tag = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnH
            // 
            this.btnH.Image = global::Hangman_GUI.Properties.Resources.H;
            this.btnH.Location = new System.Drawing.Point(896, 302);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(64, 63);
            this.btnH.TabIndex = 16;
            this.btnH.Tag = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnJ
            // 
            this.btnJ.Image = global::Hangman_GUI.Properties.Resources.J;
            this.btnJ.Location = new System.Drawing.Point(966, 302);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(64, 63);
            this.btnJ.TabIndex = 17;
            this.btnJ.Tag = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnK
            // 
            this.btnK.Image = global::Hangman_GUI.Properties.Resources.K;
            this.btnK.Location = new System.Drawing.Point(1036, 302);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(64, 63);
            this.btnK.TabIndex = 18;
            this.btnK.Tag = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnL
            // 
            this.btnL.Image = global::Hangman_GUI.Properties.Resources.L;
            this.btnL.Location = new System.Drawing.Point(1106, 302);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(64, 63);
            this.btnL.TabIndex = 19;
            this.btnL.Tag = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnZ
            // 
            this.btnZ.Image = global::Hangman_GUI.Properties.Resources.Z;
            this.btnZ.Location = new System.Drawing.Point(586, 371);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(64, 63);
            this.btnZ.TabIndex = 20;
            this.btnZ.Tag = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnX
            // 
            this.btnX.Image = global::Hangman_GUI.Properties.Resources.X;
            this.btnX.Location = new System.Drawing.Point(656, 371);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(64, 63);
            this.btnX.TabIndex = 21;
            this.btnX.Tag = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnC
            // 
            this.btnC.Image = global::Hangman_GUI.Properties.Resources.C;
            this.btnC.Location = new System.Drawing.Point(726, 371);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(64, 63);
            this.btnC.TabIndex = 22;
            this.btnC.Tag = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnV
            // 
            this.btnV.Image = global::Hangman_GUI.Properties.Resources.V;
            this.btnV.Location = new System.Drawing.Point(796, 371);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(64, 63);
            this.btnV.TabIndex = 23;
            this.btnV.Tag = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Image = global::Hangman_GUI.Properties.Resources.B;
            this.btnB.Location = new System.Drawing.Point(866, 371);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(64, 63);
            this.btnB.TabIndex = 24;
            this.btnB.Tag = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnN
            // 
            this.btnN.Image = global::Hangman_GUI.Properties.Resources.N;
            this.btnN.Location = new System.Drawing.Point(936, 371);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(64, 63);
            this.btnN.TabIndex = 25;
            this.btnN.Tag = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnM
            // 
            this.btnM.Image = global::Hangman_GUI.Properties.Resources.M;
            this.btnM.Location = new System.Drawing.Point(1006, 371);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(64, 63);
            this.btnM.TabIndex = 26;
            this.btnM.Tag = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnA_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerStatsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerStatsToolStripMenuItem
            // 
            this.playerStatsToolStripMenuItem.Name = "playerStatsToolStripMenuItem";
            this.playerStatsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.playerStatsToolStripMenuItem.Text = "Player Stats";
            this.playerStatsToolStripMenuItem.Click += new System.EventHandler(this.playerStatsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslName,
            this.tsslWins,
            this.tsslStreak});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1234, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslName
            // 
            this.tsslName.Name = "tsslName";
            this.tsslName.Size = new System.Drawing.Size(56, 17);
            this.tsslName.Text = "tsslName";
            // 
            // tsslWins
            // 
            this.tsslWins.Name = "tsslWins";
            this.tsslWins.Size = new System.Drawing.Size(50, 17);
            this.tsslWins.Text = "tsslWins";
            // 
            // tsslStreak
            // 
            this.tsslStreak.Name = "tsslStreak";
            this.tsslStreak.Size = new System.Drawing.Size(56, 17);
            this.tsslStreak.Text = "tsslStreak";
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 580);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.pbGallows);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHangman";
            this.Text = "Hangman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHangman_FormClosed);
            this.Load += new System.EventHandler(this.frmHangman_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmHangman_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbGallows)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGallows;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerStatsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslName;
        private System.Windows.Forms.ToolStripStatusLabel tsslWins;
        private System.Windows.Forms.ToolStripStatusLabel tsslStreak;
    }
}

