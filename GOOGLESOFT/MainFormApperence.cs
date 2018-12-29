using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GOOGLESOFT
{
    public partial class Form1
    {
        bool MD;
        int MPx, MPy;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MD == true)
            {
                this.SetDesktopLocation(MousePosition.X - MPx, MousePosition.Y - MPy);
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MD = false;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MD = true;
            MPx = e.X;
            MPy = e.Y;
        }

        
        private void LoginPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MD == true)
            {
                this.LoginPanel.Location = new Point(MousePosition.X - MPx, MousePosition.Y - MPy);
            }
        }

        private void LoginPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MD = false;
        }

        private void LoginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MD = true;
            MPx = e.X;
            MPy = e.Y;
        }
        
        

        private void LoginBoxID_MouseDown(object sender, MouseEventArgs e)
        {
            this.LoginBoxID.Text = "";
        }

        private void LoginBoxID_Leave(object sender, EventArgs e)
        {
            if (this.LoginBoxID.Text == "")
            {
                this.LoginBoxID.Text = "ID";
            }
        }

        private void LoginBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            this.LoginBoxPassword.Text = "";
            this.LoginBoxPassword.PasswordChar = 'ㅗ' ;
        }
        private void LoginBoxPassword_Leave(object sender, EventArgs e)
        {
            if (this.LoginBoxPassword.Text == "")
            {
                this.LoginBoxPassword.PasswordChar = (char)0;
                this.LoginBoxPassword.Text = "PassWord";
            }
        }
    }
}
