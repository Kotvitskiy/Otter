using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace ShootAndDie
{
    class Paddel : Entity
    {
        Session player;

        Image imgPaddel = Image.CreateRectangle(10, 100);

       

        public Paddel(Session player) : base()
        {
            this.player = player;

           

            SetGraphic(imgPaddel);
            imgPaddel.CenterOrigin();

            SetHitbox(10, 100, (int)Tags.Paddle);
            Collider.CenterOrigin();

            if (player.Id == 0)
            {
                X = 50;
            }
            else
            {
                X = Game.Instance.Width - 50;
            }

            Y = Game.Instance.HalfHeight;

        }
        public override void Update()
        {
            base.Update();
            if (player.Controller.Up.Down)
            {
                Y -= 5;
            }
            if (player.Controller.Down.Down)
            {
                Y += 5;
            }
        }

    }
}
