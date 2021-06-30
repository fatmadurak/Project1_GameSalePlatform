﻿using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Gamer:IEntity
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NationalityId { get; set; }

        public DateTime DateOfBirth { get; set; }


        public int Balance { get; set; }



    }
}
