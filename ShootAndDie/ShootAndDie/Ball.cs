using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace ShootAndDie
{
    class Ball : Entity
    {
        Image imgBall = Image.CreateCircle(10);

        Speed speed = new Speed(10, 10);


        public Ball() : base()
        {
            SetGraphic(imgBall);
            imgBall.CenterOrigin();

            SetHitbox(7, 7, (int)Tags.Ball);
            Collider.CenterOrigin();

            speed.X = 5;

            X = Game.Instance.HalfWidth;
            Y = Game.Instance.HalfHeight;
        }

        public override void Update()
        {
            base.Update();
            X += speed.X;
            Y += speed.Y;

            var c = Collider.Collide(X, Y, (int)Tags    .Paddle);
            if (c != null)
            {
                speed.X *= -1;
            }
        }
    }
}
