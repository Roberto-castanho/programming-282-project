using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PlaneGame
{
  
    public partial class Form1 : Form
    {
        Point location1 = Point.Empty;
        Point location2 = Point.Empty;
        Point location3 = Point.Empty;
        Point location4 = Point.Empty;
        public int VelocityX = 1;
        public int VelocityY = 1;
        public int CollidingBlock;
        public double CountDistance;

        public Form1()
        {
            InitializeComponent();
        
        }

        public void Report()
        {
            string planeName = "Thunder Bird";
            this.Hide();
            End_Results report = new End_Results(planeName,CountDistance);
            report.ShowDialog();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblArmory.Visible = true;
            lblBarracks.Visible = true;
            lblMessHall.Visible = true;
            lblOffice.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FindBase();
            this.pgbFuel.Increment(1);
            int fuel = pgbFuel.Value;
            double fuelLeft = ((580 - fuel) / 580) * 100;
            //pgbFuel.ForeColor = Color.White;
           // pgbFuel.Value = timer1.Interval;
            CountDistance += 1;
        }

        private void FindBase()
        {
            int baseX = picBase.Location.X;
            int baseY = picBase.Location.Y;
            int planeX = picPlane.Location.X;
            int planeY = picPlane.Location.Y;

            if (planeX == baseX && planeY == baseY)
            {
                timer1.Stop();
                Report();              
            }
            else
            {
                if (planeX != baseX)
                {
                    if (planeX > baseX)
                    {
                        VelocityX = -1;
                    }
                    else if (planeX < baseX)
                    {
                        VelocityX = 1;
                    }
                }
                else if (planeX == baseX)
                {
                    VelocityX = 0;
                }


                if (planeY != baseY)
                {
                    if (planeY > baseY)
                    {
                        VelocityY = -1;
                    }
                    else if (planeY < baseY)
                    {
                        VelocityY = 1;
                    }
                }
                else if (planeY == baseY)
                {
                    VelocityY = 0;
                }
                CollisionDetection();
                Avoidance();
                FindTarget();
                picPlane.Left = planeX + VelocityX;
                picPlane.Top = planeY + VelocityY;
            }  
        }

        private  void Avoidance()
        {
            int obstacleLeft = 0;
            int obstacleRight = 0;
            int obstacleTop = 0;
            int obstacleBottom = 0;

            if (CollidingBlock == 1)
            {
                obstacleLeft = obstacleRange1.Location.X;
                obstacleRight = obstacleRange1.Location.X + 80;
                obstacleTop = obstacleRange1.Location.Y;
                obstacleBottom = obstacleRange1.Location.Y + 80;
            }
            else if (CollidingBlock == 2)
            {
                obstacleLeft = obstacleRange2.Location.X;
                obstacleRight = obstacleRange2.Location.X + 80;
                obstacleTop = obstacleRange2.Location.Y;
                obstacleBottom = obstacleRange2.Location.Y + 80;
            }
            else if (CollidingBlock == 3)
            {
                obstacleLeft = obstacleRange3.Location.X;
                obstacleRight = obstacleRange3.Location.X + 80;
                obstacleTop = obstacleRange3.Location.Y;
                obstacleBottom = obstacleRange3.Location.Y + 80;
            }
            else if (CollidingBlock == 4)
            {
                obstacleLeft = obstacleRange4.Location.X;
                obstacleRight = obstacleRange4.Location.X + 80;
                obstacleTop = obstacleRange4.Location.Y;
                obstacleBottom = obstacleRange4.Location.Y + 80;
            }

            int planeLeft = picPlane.Location.X;
            int planeRight = picPlane.Location.X + 30;
            int planeTop = picPlane.Location.Y;
            int planeBottom = picPlane.Location.Y + 30;

            int baseX = picBase.Location.X;
            int baseY = picBase.Location.Y;

            if (planeLeft == obstacleRight && planeTop < obstacleBottom && planeBottom > obstacleTop)
            {
                VelocityX = 0;
            }
            else if (planeRight == obstacleLeft && planeTop < obstacleBottom && planeBottom > obstacleTop)
            {
                VelocityX = 0;
            }

            if (planeTop == obstacleBottom && planeLeft < obstacleRight && planeRight > obstacleLeft )
            {
                VelocityY = 0;
            }
            else if (planeBottom == obstacleTop && planeLeft < obstacleRight && planeRight > obstacleLeft)
            {
                VelocityY = 0;
            }
        }

        private void CollisionDetection()
        {
            int planeLeft = picPlane.Left;
            int planeRight = picPlane.Right;
            int planeTop = picPlane.Top;
            int planeBottom = picPlane.Bottom;

            if (planeRight == obstacleRange1.Left || planeLeft == obstacleRange1.Right || planeBottom == obstacleRange1.Top||planeTop == obstacleRange1.Bottom)
            {
                CollidingBlock = 1;
            }
            else if (planeRight == obstacleRange2.Left || planeLeft == obstacleRange2.Right || planeBottom == obstacleRange2.Top || planeTop == obstacleRange2.Bottom)
            {
                CollidingBlock = 2;
            }
            else if (planeRight == obstacleRange3.Left || planeLeft == obstacleRange3.Right || planeBottom == obstacleRange3.Top || planeTop == obstacleRange3.Bottom)
            {
                CollidingBlock = 3;
            }
            else if (planeRight == obstacleRange4.Left || planeLeft == obstacleRange4.Right || planeBottom == obstacleRange4.Top || planeTop == obstacleRange1.Bottom)
            {
                CollidingBlock = 4;
            }


        }

        private void FindTarget()
        {
            int planeX = picPlane.Location.X;
            int planeY = picPlane.Location.Y;
            int barrackX = picBarracks.Location.X;
            int barrackY = picBarracks.Location.Y;
            int storageX = picStorage.Location.X;
            int storageY = picStorage.Location.Y;
            int AirFieldX = picDepot.Location.X;
            int AirFieldY = picDepot.Location.Y;
            int ArmoryX = picArmory.Location.X;
            int ArmoryY = picArmory.Location.Y;

            if (planeX==barrackX || planeY==barrackY)
            {
                picBarracks.Visible = true;
            }

            if (planeX == storageX || planeY==storageY)
            {
                picStorage.Visible = true;
            }

            if (AirFieldX==planeX || planeY==AirFieldY)
            {
                picDepot.Visible = true;
            }

            if (planeX==ArmoryX || planeY==ArmoryY)
            {
                picStorage.Visible = true;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void pnlGameSpace_Paint(object sender, PaintEventArgs e)
        {
            int planeX = picPlane.Location.X;
            int planeY = picPlane.Location.Y;
            Graphics graphics = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 5);
            graphics.DrawLine(blackPen, new Point(planeX, planeY), new Point(planeX, planeY));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void obstacleRange1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location1 = new Point(e.X, e.Y);
            }
        }

        private void obstacleRange1_MouseMove(object sender, MouseEventArgs e)
        {
            if(location1 != Point.Empty)
            {
                Point newlocation = this.obstacleRange1.Location;
                newlocation.X += e.X - location1.X;
                newlocation.Y += e.Y - location1.Y;
                this.obstacleRange1.Location = newlocation;
            }
        }

        private void obstacleRange1_MouseUp(object sender, MouseEventArgs e)
        {
            location1 = Point.Empty;
        }

        private void obstacleRange2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location2= new Point(e.X, e.Y);
            }
        }

        private void obstacleRange2_MouseMove(object sender, MouseEventArgs e)
        {
            if (location2 != Point.Empty)
            {
                Point newlocation2 = this.obstacleRange2.Location;
                newlocation2.X += e.X - location2.X;
                newlocation2.Y += e.Y - location2.Y;
                this.obstacleRange2.Location = newlocation2;
            }
        }

        private void obstacleRange2_MouseUp(object sender, MouseEventArgs e)
        {
            location2 = Point.Empty;
        }

        private void obstacleRange3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location3 = new Point(e.X, e.Y);
            }
        }

        private void obstacleRange3_MouseMove(object sender, MouseEventArgs e)
        {
            if (location3 != Point.Empty)
            {
                Point newlocation3 = this.obstacleRange3.Location;
                newlocation3.X += e.X - location3.X;
                newlocation3.Y += e.Y - location3.Y;
                this.obstacleRange3.Location = newlocation3;
            }
        }

        private void obstacleRange3_MouseUp(object sender, MouseEventArgs e)
        {
            location3 = Point.Empty;
        }

        private void obstacleRange4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location4 = new Point(e.X, e.Y);
            }
        }

        private void obstacleRange4_MouseMove(object sender, MouseEventArgs e)
        {
            if (location4 != Point.Empty)
            {
                Point newlocation4 = this.obstacleRange4.Location;
                newlocation4.X += e.X - location4.X;
                newlocation4.Y += e.Y - location4.Y;
                this.obstacleRange4.Location = newlocation4;
            }
        }

        private void obstacleRange4_MouseUp(object sender, MouseEventArgs e)
        {
            location4 = Point.Empty;
        }

        private void obstacleRange1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBase_Click(object sender, EventArgs e)
        {

        }
    }
}
