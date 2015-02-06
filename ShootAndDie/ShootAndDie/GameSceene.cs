using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace ShootAndDie
{
    class GameScene : Scene
    {
        public GameScene() : base()
        {
            Add(new Paddel(Global.playerOne));
            Add(new Paddel(Global.playerTwo));
            Add(new Ball());
        }
    }
}
