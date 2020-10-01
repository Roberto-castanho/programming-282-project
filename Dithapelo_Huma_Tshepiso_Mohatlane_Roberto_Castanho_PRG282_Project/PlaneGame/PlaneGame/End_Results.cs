using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneGame
{
    public partial class End_Results : Form
    {
        public End_Results(string planeName, double CountDistance)
        {
            InitializeComponent();
            lblAirplaneType.Text = planeName;
            lblDistanceTraveled.Text = Convert.ToString(CountDistance / 10 + " km");
            lblTime.Text = Convert.ToString(CountDistance / 60 + " Mins");
            lblDamage.Text = "Barracks destroyed and everyone died!";
        }

        private void End_Results_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
