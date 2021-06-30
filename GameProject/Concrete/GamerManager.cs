using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.IsValidate(gamer))
            {
                Console.WriteLine("Gamer added.");
            }

            else
            {
                Console.WriteLine("Invalid nationalityId");
            }
          
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated.");
        }
    }
}
