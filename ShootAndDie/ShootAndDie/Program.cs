using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace ShootAndDie
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Game", 800, 600);

            Global.playerOne = game.AddSession("P1");
            Global.playerTwo = game.AddSession("P2");

            Global.playerOne.Controller.Up.AddKey(Key.W);
            Global.playerOne.Controller.Down.AddKey(Key.S);

            Global.playerTwo.Controller.Up.AddKey(Key.Up);
            Global.playerTwo.Controller.Down.AddKey(Key.Down);


            game.FirstScene = new GameScene();

            game.Start();
            
           
        }
    }
}
