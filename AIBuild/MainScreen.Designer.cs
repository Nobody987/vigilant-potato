namespace AIBuild
{
    partial class MainScreen
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
            this.Square = new System.Windows.Forms.PictureBox();
            this.wallUp = new System.Windows.Forms.PictureBox();
            this.wallDown = new System.Windows.Forms.PictureBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.blocker = new System.Windows.Forms.PictureBox();
            this.wallVertical = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.SystemColors.Highlight;
            this.Square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Square.InitialImage = null;
            this.Square.Location = new System.Drawing.Point(12, 200);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(32, 32);
            this.Square.TabIndex = 0;
            this.Square.TabStop = false;
            // 
            // wallUp
            // 
            this.wallUp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.wallUp.Location = new System.Drawing.Point(49, 186);
            this.wallUp.Name = "wallUp";
            this.wallUp.Size = new System.Drawing.Size(393, 10);
            this.wallUp.TabIndex = 1;
            this.wallUp.TabStop = false;
            // 
            // wallDown
            // 
            this.wallDown.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.wallDown.Location = new System.Drawing.Point(49, 238);
            this.wallDown.Name = "wallDown";
            this.wallDown.Size = new System.Drawing.Size(462, 10);
            this.wallDown.TabIndex = 2;
            this.wallDown.TabStop = false;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 10;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // blocker
            // 
            this.blocker.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blocker.Location = new System.Drawing.Point(468, 52);
            this.blocker.Name = "blocker";
            this.blocker.Size = new System.Drawing.Size(11, 43);
            this.blocker.TabIndex = 3;
            this.blocker.TabStop = false;
            // 
            // wallVertical
            // 
            this.wallVertical.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.wallVertical.Location = new System.Drawing.Point(500, 186);
            this.wallVertical.Name = "wallVertical";
            this.wallVertical.Size = new System.Drawing.Size(11, 62);
            this.wallVertical.TabIndex = 4;
            this.wallVertical.TabStop = false;
            // 
            // MainScreen
            // 
            this.ClientSize = new System.Drawing.Size(983, 530);
            this.Controls.Add(this.wallVertical);
            this.Controls.Add(this.blocker);
            this.Controls.Add(this.wallDown);
            this.Controls.Add(this.wallUp);
            this.Controls.Add(this.Square);
            this.Name = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.Square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallVertical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Square;
        private System.Windows.Forms.PictureBox wallUp;
        private System.Windows.Forms.PictureBox wallDown;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.PictureBox blocker;
        private System.Windows.Forms.PictureBox wallVertical;
    }
}

