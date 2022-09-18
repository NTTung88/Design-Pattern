using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_RemoteControl
{
    class Door
    {
        private Button status;

        public Door(Button status)
        {
            this.status = status;

            this.status.BackColor = Color.Gray;
        }

        public void turnOn()
        {
            this.status.BackColor = Color.Green;
        }

        public void turnOff()
        {
            this.status.BackColor = Color.Gray;
        }
    }

    class DoorOn : ICommand
    {
        private Door door;

        public DoorOn(Door door)
        {
            this.door = door;
        }
        public void Execute()
        {
            this.door.turnOn();
        }
    }

    class DoorOff : ICommand
    {
        private Door door;

        public DoorOff(Door door)
        {
            this.door = door;
        }

        public void Execute()
        {
            this.door.turnOff();
        }
    }
}
