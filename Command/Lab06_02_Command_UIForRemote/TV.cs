using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_RemoteControl
{
    class TV
    {
        private Button status;

        public TV(Button status)
        {
            this.status = status;
            powerOff();
        }

        public void powerOn()
        {
            status.Enabled = true;
            status.BackColor = Color.Green;
        }

        public void powerOff()
        {
            status.Enabled = false;
            status.BackColor = Color.Gray;
        }
    }


    class TVOn : ICommand
    {
        private TV tv;
        public TVOn(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            this.tv.powerOn();
        }
    }

    class TVOff : ICommand
    {
        private TV tv;

        public TVOff(TV tv)
        {
            this.tv = tv;        
        }
        public void Execute()
        {
            this.tv.powerOff();
        }
    }
}
