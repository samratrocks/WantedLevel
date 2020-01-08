using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;
    
namespace WantedLevel
{
    public class WantedLevel : Script
    {
        public WantedLevel ()
        {
            Tick += onTick;
            KeyDown += onKeyDown;
            KeyUp += onKeyUp;
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.H:
                    Game.Player.WantedLevel = 0;
                    break;
                case Keys.J:
                    Game.Player.WantedLevel = 6;
                    break;
                default:
                    break;
            }
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void onTick(object sender, EventArgs e)
        {

        }
    }
}
