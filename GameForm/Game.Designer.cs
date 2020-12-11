using System;
using System.ComponentModel;

namespace AppForConcentration.GameForm
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
            this.SuspendLayout();
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Game";
            this.Text = "GameForm";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Game_Closing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private void Game_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}