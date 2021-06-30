using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {

       
        public  List<string> ReadText()
        {


           string[] lines = File.ReadAllLines("C:\\Users\\Usame\\source\\repos\\KampIntro\\GameProject\\NationalityIdDB.txt");

       
            return lines.ToList();



        }

        public bool IsValidate(Gamer gamer)
        {
          List<string>  textList = ReadText();

            for (int i = 0; i <textList.Count; i++)
            {
                if (textList[i]==gamer.NationalityId)
                {
                    return true;
                }
            }

            return false;


        }


    }
}