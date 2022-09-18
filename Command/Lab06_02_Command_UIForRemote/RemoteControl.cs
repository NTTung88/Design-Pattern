using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_RemoteControl
{
    public partial class RemoteControl : Form
    {
        private ICommand Slot1ON;
        private ICommand Slot1OFF;
        private ICommand Slot2ON;
        private ICommand Slot2OFF;
        private ICommand Slot3ON;
        private ICommand Slot3OFF;


        //Light
        private Light light;
        private ICommand LightON;
        private ICommand LightOFF;

        //TV
        private TV tv;
        private ICommand TVON;
        private ICommand TVOFF;
        //Door
        private Door door;
        private ICommand DoorON;
        private ICommand DoorOFF;

        public RemoteControl()
        {
            InitializeComponent();

            //Light
            light = new Light(this.txtStatus1);
            LightON = new LightOn(light);
            LightOFF = new LightOff(light);

            //TV
            tv = new TV(this.btnTV);
            TVON = new TVOn(tv);
            TVOFF = new TVOff(tv);
            //Door
            door = new Door(this.btnDoor);
            DoorON = new DoorOn(door);
            DoorOFF = new DoorOff(door);
        }
        // Button 1 ON OFF
        private void btnOn1_Click(object sender, EventArgs e)
        {
            Slot1ON.Execute();        
        }

        private void btnOFF1_Click(object sender, EventArgs e)
        {
            Slot1OFF.Execute();
        }

        private void cboSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String option = cboSlot1.SelectedItem.ToString();
            choiceDevice(option, 1);
        }


        // button 2 ON OFF
        private void btnON2_Click(object sender, EventArgs e)
        {
            this.Slot2ON.Execute();
        } 

        private void btnOFF2_Click(object sender, EventArgs e)
        {
            this.Slot2OFF.Execute();
        }
        private void cboSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String option = cboSlot2.SelectedItem.ToString();

            choiceDevice(option, 2);
        }

        //Button 3 ON OFF
        private void btnON3_Click_1(object sender, EventArgs e)
        {
            this.Slot3ON.Execute();
        }

        private void btnOFF3_Click(object sender, EventArgs e)
        {
            this.Slot3OFF.Execute();
        }
        private void cboSlot3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String option = cboSlot3.SelectedItem.ToString();

            choiceDevice(option, 3);
        }


        private void assignCommandOnOFF(String option,  ref ICommand On, ref ICommand Off)
        {
            if (option.Equals("Light"))
            {
                Off = LightOFF;
                On = LightON;
            }
            else if (option.Equals("TV"))
            {
                Off = TVOFF;
                On = TVON;
            }
            else if (option.Equals("Door"))
            {
                Off = DoorOFF;
                On = DoorON;
            }

            //...
        }
        private void choiceDevice(String option, int slotNum)
        {
            if (slotNum == 1)
            {
                assignCommandOnOFF(option, ref Slot1ON, ref Slot1OFF);
            }
            else if(slotNum == 2)
            {
                assignCommandOnOFF(option, ref Slot2ON,  ref Slot2OFF);
            }
            else if (slotNum == 3)
            {
                assignCommandOnOFF(option, ref Slot3ON, ref Slot3OFF);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}
