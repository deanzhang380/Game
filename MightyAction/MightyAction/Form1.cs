using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MightyAction
{
    public partial class Form1 : Form
    {
        bool flag_GameStart = false;
        bool flat_GameOver = false;
        bool Character_Status = true;
        const int Game_Time = 99;
        int temp = Game_Time;


        public Form1()
        {
            InitializeComponent();
        }
        public void setHitzone()
        {
            int x = playerCharacter1.Location.X+40;
            int y = playerCharacter1.Location.Y+30;
            Hitzone1.Location = new Point(x, y);
        }
        public void setHitzone2()
        {
            int x = playerCharacter2.Location.X + 40;
            int y = playerCharacter2.Location.Y + 30;
            Hitzone2.Location = new Point(x, y);
        }
        public void setPunchzone()
        {
            if(Character_Status==true)
            {
                int x = playerCharacter1.Location.X + 150;
                int y = playerCharacter1.Location.Y + 90;
                Punch_Zone.Location = new Point(x, y);
            }
            else
            {
                int x = playerCharacter1.Location.X ;
                int y = playerCharacter1.Location.Y + 90;
                Punch_Zone.Location = new Point(x, y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            setHitzone();
            setPunchzone();
            if(playerCharacter1.Move_Right1==true)
            {
                
                playerCharacter1.CharacterMove_Right();
                
            }

            if (playerCharacter1.Move_Left1 == true)
            {
                playerCharacter1.CharacterMove_Left();
            }
            if (playerCharacter1.Move_Jump1 == true)
            {
               playerCharacter1.CharacterMove_Jump();
                check_OnAir();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Right)
            {
                if (playerCharacter1.Right < Screen.Right)
                {
                    playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\Webp.net-gifmaker (14).gif");
                    playerCharacter1.Move_Right1 = true;
                    Character_Status = true;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
               playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\l3.png"); 
                playerCharacter1.Move_Left1 = true;
                Character_Status = false;
            }
           
            if (playerCharacter1.Move_Jump1 != true)
            {
                if (e.KeyCode == Keys.Space )
                {
                    playerCharacter1.Move_Jump1 = true;
                    playerCharacter1.Force1 = playerCharacter1.Gravity1;
                    playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\14.png");
                }
               
            }
            if (e.KeyCode == Keys.C)
            {
                checked_hit();
                playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\13.png");
            }
            if (e.KeyCode == Keys.X)
            {
                if (playerCharacter1.Move_Jump1 == true)
                { 
                    playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\15.png");
                }
            }
            if (e.KeyCode == Keys.Z)
            {
               
                playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\11.png");
                checked_hit();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                playerCharacter1.Move_Right1=false;
                playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\1.png");
            }
            if (e.KeyCode == Keys.Left)
            {
                playerCharacter1.Move_Left1 = false;
                playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\l1.png");
            }
            if (e.KeyCode == Keys.C)
            {
                playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\1.png");
            }
            if (e.KeyCode == Keys.Z)
            {
                playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\1.png");
            }


        }
        public void check_OnAir()
        {
            if (playerCharacter1.Height + playerCharacter1.Top >= Screen.Height)
            {
                playerCharacter1.Top = Screen.Height - playerCharacter1.Height;
                playerCharacter1.Move_Jump1 = false;
                playerCharacter1.Image = Image.FromFile(@"C:\Users\Asus\Source\Repos\Project-GUI-KMN\MightyAction\MightyAction\Character\1.png");
            }
            else
            {
                playerCharacter1.Top += 5;

            }
        }

      

      

        

        private void Form1_Load(object sender, EventArgs e)
        {
            Screen.Enabled = true;

        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            flag_GameStart = true;
            if (flag_GameStart == true)
            {
                MenuPanel.Hide();
                Screen.Enabled = false;
            }
            Game_Timer.Start();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Game_Timer_Tick(object sender, EventArgs e)
        {
            if(flag_GameStart==true)
            {
                temp = temp - 1;
                label1.Text = temp.ToString();
            }
            if (temp == 0)
            {
                flat_GameOver = true;
                Game_Timer.Stop();
                this.Close();
            }
        }

        public void checked_hit()
        {
            if ( Punch_Zone.Location.X >= Hitzone2.Location.X)
            {
                HP_Bar2.Value -= 5;
                
            }
        }

       
    }
}
