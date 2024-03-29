﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator.NET
{
    public partial class EditElement : Form
    {

        private bool mouseOverLabel5;

        private int animationTick = 0;

        public bool changed = false;
        private bool dataGiven = false;

        private string before;
        public string after;



        Timer showingAnimation = new Timer();

        public EditElement()
        {
            InitializeComponent();
        }

        private void EditElement_Load(object sender, EventArgs e)
        {
            if(dataGiven == false)
            {
                MessageBox.Show("An error occured!\nerror code: HEX45646974456C656D656E742E63735F6C696E6533372D33395F6E6F5F646174615F676976656E21", "unexpected error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fisrtCharacter.Text = before;
                label5.Text = before;
            }

            MoveWindow movewindow = new MoveWindow(this, panel1);
            MoveWindow movewindow2 = new MoveWindow(this, label1);
            MoveWindow movewindow3 = new MoveWindow(this, panel4);

           
            showingAnimation.Interval = 1;
            showingAnimation.Tick += new EventHandler(showingAnimationTick);
            showingAnimation.Start();
        }

        public void GiveData(string data)
        { 
            before = data;
            dataGiven = true;
        }


        private void showingAnimationTick(object sender, EventArgs e)
        {
            if (animationTick == 0)
            {
                this.Opacity = 0;
            }

            if (animationTick <= 11)
            {
                this.Opacity += 0.2;
                animationTick += 2;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            mouseOverLabel5 = true;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            mouseOverLabel5 = false;
        }

        private void EditElement_MouseClick(object sender, MouseEventArgs e)
        {
            if (mouseOverLabel5 == false)
            {
                label5.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (changed == true)
            {
                DialogResult result = MessageBox.Show("do you want to exit without saving changes?", "abort editing item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    //do nothing
                }
                else
                {
                    MessageBox.Show("an error accured!");
                }
            }
            else
            {
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            after = textBox1.Text;
            secondCharacter.Text = after;
            

            changed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
