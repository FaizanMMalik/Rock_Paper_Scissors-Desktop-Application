
namespace client2
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.btnpaper = new System.Windows.Forms.Button();
            this.btnscissor = new System.Windows.Forms.Button();
            this.btnrock = new System.Windows.Forms.Button();
            this.lblp = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScoreBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(233, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "PICK YOUR CHOICE";
            // 
            // btnpaper
            // 
            this.btnpaper.Image = ((System.Drawing.Image)(resources.GetObject("btnpaper.Image")));
            this.btnpaper.Location = new System.Drawing.Point(595, 232);
            this.btnpaper.Name = "btnpaper";
            this.btnpaper.Size = new System.Drawing.Size(182, 151);
            this.btnpaper.TabIndex = 19;
            this.btnpaper.UseVisualStyleBackColor = true;
            this.btnpaper.Click += new System.EventHandler(this.btnpaper_Click);
            // 
            // btnscissor
            // 
            this.btnscissor.Image = ((System.Drawing.Image)(resources.GetObject("btnscissor.Image")));
            this.btnscissor.Location = new System.Drawing.Point(329, 232);
            this.btnscissor.Name = "btnscissor";
            this.btnscissor.Size = new System.Drawing.Size(193, 151);
            this.btnscissor.TabIndex = 18;
            this.btnscissor.UseVisualStyleBackColor = true;
            this.btnscissor.Click += new System.EventHandler(this.btnscissor_Click);
            // 
            // btnrock
            // 
            this.btnrock.Image = global::client2.Properties.Resources.images;
            this.btnrock.Location = new System.Drawing.Point(52, 232);
            this.btnrock.Name = "btnrock";
            this.btnrock.Size = new System.Drawing.Size(191, 151);
            this.btnrock.TabIndex = 17;
            this.btnrock.UseVisualStyleBackColor = true;
            this.btnrock.Click += new System.EventHandler(this.btnrock_Click);
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblp.Location = new System.Drawing.Point(24, 133);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(0, 30);
            this.lblp.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.chatToolStripMenuItem,
            this.viewScoreBoardToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.playAgainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.chatToolStripMenuItem.Text = "Play Again";
            // 
            // viewScoreBoardToolStripMenuItem
            // 
            this.viewScoreBoardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewScoreBoardToolStripMenuItem.Name = "viewScoreBoardToolStripMenuItem";
            this.viewScoreBoardToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.viewScoreBoardToolStripMenuItem.Text = "Chatbox";
            this.viewScoreBoardToolStripMenuItem.Click += new System.EventHandler(this.viewScoreBoardToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.exitToolStripMenuItem.Text = "ScoreBoard";
            // 
            // playAgainToolStripMenuItem
            // 
            this.playAgainToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playAgainToolStripMenuItem.Name = "playAgainToolStripMenuItem";
            this.playAgainToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.playAgainToolStripMenuItem.Text = "Exit";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpaper);
            this.Controls.Add(this.btnscissor);
            this.Controls.Add(this.btnrock);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpaper;
        private System.Windows.Forms.Button btnscissor;
        private System.Windows.Forms.Button btnrock;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScoreBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playAgainToolStripMenuItem;
    }
}