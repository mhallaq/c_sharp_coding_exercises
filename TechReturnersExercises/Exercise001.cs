using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word) 
        {

            string capitalWord =word.Substring(0,1).ToUpper()+ word.Substring(1);
            return (capitalWord);
        }

        public static String GenerateInitials(String firstName, String lastName) 
        {
            string nameInitials =  firstName.Substring(0,1)+'.'+lastName.Substring(0,1) ;
            return nameInitials;
        }

        public static double AddVat(double originalPrice, double vatRate) 
        {
            double grossPrice = Math.Round(originalPrice * vatRate/100 + originalPrice,2);
            return (grossPrice);
        }

        public static String Reverse(String sentence) 
        {
            char[] wordArray=sentence.ToCharArray();
            string reversedWord="";
            for (var i = wordArray.Length-1; i >=0; i--)
            {
                reversedWord += wordArray[i].ToString();
            }
            return (reversedWord);
        }

        public static int CountLinuxUsers(List<User> users) 
        {
            int count = 0;
            foreach (var user in users)
            {
                if (user.Type=="Linux" )
                {
                    count++;
                }
            }
            return (count);
        }
    }
}
