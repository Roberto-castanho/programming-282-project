using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Simulations_Project_PRG252
{
    class Airplane
    {
        private string airplaneType;

        public string AirplaneType
        {
            get { return airplaneType; }
            set { airplaneType = value; }
        }
        private int altitude;

        public int Altitude
        {
            get { return altitude; }
            set { altitude = value; }
        }

        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private int gastank;

        public int Gastank
        {
            get { return gastank; }
            set { gastank = value; }
        }

        private int damage;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public Airplane(string airplanetype, int altitude, int speed, int gastank, int damage)
        {
            this.airplaneType = airplanetype;
            this.altitude = altitude;
            this.speed = speed;
            this.gastank = gastank;
            this.damage = damage;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", AirplaneType, Altitude, Speed, Gastank, Damage);
        }
    }
}
