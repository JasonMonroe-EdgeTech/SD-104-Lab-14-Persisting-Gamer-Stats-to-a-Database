namespace Hangman_GUI
{
    partial class frmMain
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
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtNewPlayerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreatePlayer.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreatePlayer.Location = new System.Drawing.Point(146, 195);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(167, 42);
            this.btnCreatePlayer.TabIndex = 8;
            this.btnCreatePlayer.Text = "Create Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = false;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(77, 96);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(101, 21);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // txtNewPlayerName
            // 
            this.txtNewPlayerName.Location = new System.Drawing.Point(184, 97);
            this.txtNewPlayerName.Name = "txtNewPlayerName";
            this.txtNewPlayerName.Size = new System.Drawing.Size(172, 20);
            this.txtNewPlayerName.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 330);
            this.Controls.Add(this.btnCreatePlayer);
            this.Controls.Add(this.txtNewPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtNewPlayerName;
    }
}