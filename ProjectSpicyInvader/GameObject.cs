using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSpicyInvader
{
    internal class GameObject
    {
        private void Update()
        {
            
        }

        private void Draw()
        {

        }

        private void IsAlive()
        {

        }
    }

    
    class SpaceShip : GameObject
    {
        private double _speedPixelPerSecond;
        private int _lives;

        public SpaceShip(double speedPixelPerSecond, int lives)
        {
            _speedPixelPerSecond = speedPixelPerSecond;
            _lives = lives;
        }

        public SpaceShip()
        {

        }

        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }

        public double SpeedPixelPerSecond
        {
            get { return _speedPixelPerSecond; }
            set { _speedPixelPerSecond = value; }
        }
        
    }
}
