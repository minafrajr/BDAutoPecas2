using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AutoPeçasUI
{
    public class MyTextBox : TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = System.Drawing.Color.Yellow;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = System.Drawing.Color.White;
        }

        //protected override void OnMouseLeave(EventArgs e)
        //{
        //    base.OnMouseLeave(e);
        //    this.BackColor = System.Drawing.Color.White;
        //}

        //protected override void OnMouseEnter(EventArgs e)
        //{
        //    base.OnMouseEnter(e);
        //    this.BackColor = System.Drawing.Color.Yellow;
        //}
    }
}
