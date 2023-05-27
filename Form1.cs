using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çoklu_engelden_seken_top
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            int DikeyYon = 1, YatayYon = 1;

            private void Form1_DoubleClick(object sender, EventArgs e)
            {
                this.Close();
            }

            private void Tick_Tick(object sender, EventArgs e)
            {
                if ((Ball.Bottom >= this.Height) || Ball.Top <= 0)
                {
                    DikeyYon *= -1;
                }

                if ((Ball.Right >= this.Width) || Ball.Left <= 0)
                {
                    YatayYon *= -1;
                }

                Ball.Top += DikeyYon;
                Ball.Left += YatayYon;

                //WALL

                //DİKEY
                if (Ball.Bottom >= Wall.Top && Ball.Top <= Wall.Bottom)
                {
                    if (YatayYon == 1 && Ball.Right == Wall.Left)
                    {
                        YatayYon *= -1;
                    }

                    if (YatayYon == -1 && Ball.Left == Wall.Right)
                    {
                        YatayYon *= -1;
                    }
                }
            if (Ball.Bottom >= Wall1.Top && Ball.Top <= Wall1.Bottom)
            {
                if (YatayYon == 1 && Ball.Right == Wall1.Left)
                {
                    YatayYon *= -1;
                }

                if (YatayYon == -1 && Ball.Left == Wall1.Right)
                {
                    YatayYon *= -1;
                }
            }
            

            //YATAY

            if (Ball.Right >= Wall.Left && Ball.Left <= Wall.Right)
                {
                    if (DikeyYon == 1 && Ball.Bottom == Wall.Top)
                    {
                        DikeyYon *= -1;
                    }

                    if (DikeyYon == -1 && Ball.Top == Wall.Bottom)
                    {
                        DikeyYon *= -1;
                    }
                }
            if (Ball.Right >= Wall1.Left && Ball.Left <= Wall1.Right)
            {
                if (DikeyYon == 1 && Ball.Bottom == Wall1.Top)
                {
                    DikeyYon *= -1;
                }

                if (DikeyYon == -1 && Ball.Top == Wall1.Bottom)
                {
                    DikeyYon *= -1;
                }
            }
            
        }
    }

       
    }

