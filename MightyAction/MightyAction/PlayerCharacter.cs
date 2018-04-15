using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MightyAction
{
    public partial class PlayerCharacter : PictureBox
    {
        
        bool Move_Right = false;
        bool Move_Left = false;
        bool Move_Jump = false;
        bool Move_Attack = false;
        bool Move_Kick = false;
        int Gravity = 30;
        int Force;
        
       
        public bool Move_Right1
        {
            get
            {
                return Move_Right;
            }

            set
            {
                Move_Right = value;
            }
        }

        public bool Move_Left1
        {
            get
            {
                return Move_Left;
            }

            set
            {
                Move_Left = value;
            }
        }

        public bool Move_Jump1
        {
            get
            {
                return Move_Jump;
            }

            set
            {
                Move_Jump = value;
            }
        }

        public int Gravity1
        {
            get
            {
                return Gravity;
            }

            set
            {
                Gravity = value;
            }
        }

        public int Height1
        {
            get
            {
                return Height;
            }

            set
            {
                Height = value;
            }
        }

        public int Force1
        {
            get
            {
                return Force;
            }

            set
            {
                Force = value;
            }
        }

        public bool Move_Attack1
        {
            get
            {
                return Move_Attack;
            }

            set
            {
                Move_Attack = value;
            }
        }

        public bool Move_Kick1
        {
            get
            {
                return Move_Kick;
            }

            set
            {
                Move_Kick = value;
            }
        }

        public PlayerCharacter()
        {
            InitializeComponent();

            
        }
        public void CharacterMove_Right()
        {
            if(Move_Right1==true)
            {
                this.Left += 20;
            }
        }
        public void CharacterMove_Left()
        {
            if (Move_Left1 == true)
            {
                this.Left -= 20;
            }
        }
        public void CharacterMove_Jump()
        {
            if (Move_Jump1 == true)
            {
                this.Top -= Force1;
                Force1 -= 1;
            }

        }
        public void Character_Attack()
        {
            Move_Attack1 = true;
        }
        public void CharacterMov_Drop()
        {
            this.Top -= Force1;
            Force1--;
        }
    }
}
