using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {


        public void Sale(Game game, Gamer gamer,Campaign campaign)
        {

            if (gamer.Balance<game.UnitPrice)
            {
                Console.WriteLine("no balance.");
            }

            else
            {

                int newUnitPrice = game.UnitPrice - (game.UnitPrice * campaign.Discount / 100);

                Console.WriteLine(game.GameName + " the game has been sold: Gamer name : " + gamer.FirstName);

                Console.WriteLine("discounted price of the game: "+newUnitPrice);
            }


            

        }
    }
}
