namespace MightyAction
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Screen = new System.Windows.Forms.Panel();
            this.Punch_Zone = new System.Windows.Forms.PictureBox();
            this.HP_Bar1 = new System.Windows.Forms.ProgressBar();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HP_Bar2 = new System.Windows.Forms.ProgressBar();
            this.Hitzone1 = new System.Windows.Forms.PictureBox();
            this.Hitzone2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Game_Timer = new System.Windows.Forms.Timer(this.components);
            this.playerCharacter1 = new MightyAction.PlayerCharacter();
            this.playerCharacter2 = new MightyAction.PlayerCharacter();
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Punch_Zone)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hitzone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitzone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter2)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Screen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Screen.BackgroundImage")));
            this.Screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Screen.Controls.Add(this.Punch_Zone);
            this.Screen.Controls.Add(this.HP_Bar1);
            this.Screen.Controls.Add(this.MenuPanel);
            this.Screen.Controls.Add(this.label1);
            this.Screen.Controls.Add(this.HP_Bar2);
            this.Screen.Controls.Add(this.playerCharacter1);
            this.Screen.Controls.Add(this.Hitzone1);
            this.Screen.Controls.Add(this.playerCharacter2);
            this.Screen.Controls.Add(this.Hitzone2);
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(929, 631);
            this.Screen.TabIndex = 0;
            // 
            // Punch_Zone
            // 
            this.Punch_Zone.BackColor = System.Drawing.Color.Transparent;
            this.Punch_Zone.Location = new System.Drawing.Point(226, 413);
            this.Punch_Zone.Name = "Punch_Zone";
            this.Punch_Zone.Size = new System.Drawing.Size(29, 23);
            this.Punch_Zone.TabIndex = 8;
            this.Punch_Zone.TabStop = false;
            // 
            // HP_Bar1
            // 
            this.HP_Bar1.Location = new System.Drawing.Point(12, 28);
            this.HP_Bar1.Name = "HP_Bar1";
            this.HP_Bar1.Size = new System.Drawing.Size(319, 28);
            this.HP_Bar1.TabIndex = 3;
            this.HP_Bar1.Value = 100;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.Exit_Btn);
            this.MenuPanel.Controls.Add(this.Start_Btn);
            this.MenuPanel.Location = new System.Drawing.Point(273, 127);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(391, 289);
            this.MenuPanel.TabIndex = 6;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.Location = new System.Drawing.Point(74, 174);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(243, 77);
            this.Exit_Btn.TabIndex = 1;
            this.Exit_Btn.Text = "Exit";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Start_Btn
            // 
            this.Start_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Start_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Btn.Location = new System.Drawing.Point(74, 47);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(243, 78);
            this.Start_Btn.TabIndex = 0;
            this.Start_Btn.Text = "Game Start";
            this.Start_Btn.UseVisualStyleBackColor = false;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 124);
            this.label1.TabIndex = 5;
            this.label1.Text = " 99";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // HP_Bar2
            // 
            this.HP_Bar2.Location = new System.Drawing.Point(598, 28);
            this.HP_Bar2.Name = "HP_Bar2";
            this.HP_Bar2.Size = new System.Drawing.Size(319, 28);
            this.HP_Bar2.TabIndex = 4;
            this.HP_Bar2.Value = 100;
            // 
            // Hitzone1
            // 
            this.Hitzone1.BackColor = System.Drawing.Color.Transparent;
            this.Hitzone1.Location = new System.Drawing.Point(98, 368);
            this.Hitzone1.Name = "Hitzone1";
            this.Hitzone1.Size = new System.Drawing.Size(109, 192);
            this.Hitzone1.TabIndex = 7;
            this.Hitzone1.TabStop = false;
            // 
            // Hitzone2
            // 
            this.Hitzone2.BackColor = System.Drawing.Color.Transparent;
            this.Hitzone2.Location = new System.Drawing.Point(711, 344);
            this.Hitzone2.Name = "Hitzone2";
            this.Hitzone2.Size = new System.Drawing.Size(119, 198);
            this.Hitzone2.TabIndex = 10;
            this.Hitzone2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game_Timer
            // 
            this.Game_Timer.Enabled = true;
            this.Game_Timer.Interval = 1000;
            this.Game_Timer.Tick += new System.EventHandler(this.Game_Timer_Tick);
            // 
            // playerCharacter1
            // 
            this.playerCharacter1.BackColor = System.Drawing.Color.Transparent;
            this.playerCharacter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerCharacter1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playerCharacter1.ErrorImage")));
            this.playerCharacter1.Force1 = 0;
            this.playerCharacter1.Gravity1 = 30;
            this.playerCharacter1.Height1 = 276;
            this.playerCharacter1.Image = ((System.Drawing.Image)(resources.GetObject("playerCharacter1.Image")));
            this.playerCharacter1.Location = new System.Drawing.Point(57, 301);
            this.playerCharacter1.Margin = new System.Windows.Forms.Padding(0);
            this.playerCharacter1.Move_Attack1 = false;
            this.playerCharacter1.Move_Jump1 = false;
            this.playerCharacter1.Move_Kick1 = false;
            this.playerCharacter1.Move_Left1 = false;
            this.playerCharacter1.Move_Right1 = false;
            this.playerCharacter1.Name = "playerCharacter1";
            this.playerCharacter1.Size = new System.Drawing.Size(198, 276);
            this.playerCharacter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCharacter1.TabIndex = 2;
            this.playerCharacter1.TabStop = false;
            // 
            // playerCharacter2
            // 
            this.playerCharacter2.BackColor = System.Drawing.Color.Transparent;
            this.playerCharacter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerCharacter2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playerCharacter2.ErrorImage")));
            this.playerCharacter2.Force1 = 0;
            this.playerCharacter2.Gravity1 = 30;
            this.playerCharacter2.Height1 = 290;
            this.playerCharacter2.Image = ((System.Drawing.Image)(resources.GetObject("playerCharacter2.Image")));
            this.playerCharacter2.Location = new System.Drawing.Point(667, 287);
            this.playerCharacter2.Margin = new System.Windows.Forms.Padding(0);
            this.playerCharacter2.Move_Attack1 = false;
            this.playerCharacter2.Move_Jump1 = false;
            this.playerCharacter2.Move_Kick1 = false;
            this.playerCharacter2.Move_Left1 = false;
            this.playerCharacter2.Move_Right1 = false;
            this.playerCharacter2.Name = "playerCharacter2";
            this.playerCharacter2.Size = new System.Drawing.Size(198, 290);
            this.playerCharacter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCharacter2.TabIndex = 9;
            this.playerCharacter2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 631);
            this.Controls.Add(this.Screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MightyAction";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Screen.ResumeLayout(false);
            this.Screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Punch_Zone)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hitzone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitzone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.Timer timer1;
        private PlayerCharacter playerCharacter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar HP_Bar2;
        private System.Windows.Forms.ProgressBar HP_Bar1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.Timer Game_Timer;
        private System.Windows.Forms.PictureBox Hitzone1;
        private System.Windows.Forms.PictureBox Punch_Zone;
        private System.Windows.Forms.PictureBox Hitzone2;
        private PlayerCharacter playerCharacter2;
    }
}

