using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { NationalityId = "2564654655" });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.NewCampaign(new Campaign {CampaignName="New year"});


            IOrderService order = new OrderManager();
            order.Sale(new Game { GameName="Mario",UnitPrice=60},new Gamer {FirstName="Fatma",Balance=70},new Campaign {Discount=50});









        }
        }
    }

