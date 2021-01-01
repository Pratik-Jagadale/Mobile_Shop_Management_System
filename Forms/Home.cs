using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mobile_Shoppee_Management_System.Forms
{
    public partial class Home : Form
    {
        private int iImageNumber = 1;
        public Home()
        {
            InitializeComponent();
        }
        private void Slider()
        {
            if (iImageNumber == 5)
            {
                iImageNumber = 1;
            }
            Slider_Picture_Box.ImageLocation=string.Format(@"Images\{0}.jpg",iImageNumber);
            iImageNumber++;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
        //     if (iImageNumber == 1)
        //     {
        //    Slider_Picture_Box.ImageLocation=string.Format(@"Images.1.jpg");
        //         iImageNumber = 2;
        //         return ;
        //     }
        //     else if (iImageNumber == 2)
        //     {
        //         Slider_Picture_Box.ImageLocation = string.Format(@"Images.2.jpg");
        //         iImageNumber = 3;
        //         return;
        //     }
        //     else if (iImageNumber == 3)
        //     {
        //         Slider_Picture_Box.ImageLocation = string.Format(@"Images.3.jpg");
        //         iImageNumber = 4;
        //         return;
        //     }
        //     else if (iImageNumber == 4)
        //     {
        //         Slider_Picture_Box.ImageLocation = string.Format(@"Images.4.jpg");
        //         iImageNumber = 4;
        //         return;
        //     }
        //     else if (iImageNumber == 5)
        //     {
        //         Slider_Picture_Box.ImageLocation = string.Format(@"Images.5.jpg");
        //         iImageNumber = 1;
        //         return;
        //     }
        }
    }
}
