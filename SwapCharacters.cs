using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input Any String");
            string s = "zAz";
            int index = 3;            
           string final =  ConvertString(s, index);
        }

        public static string ConvertString(string s, int index)
        {
            char [] arr = s.ToCharArray();
            var finalArr = new List<char>();                       
            for (int i=0; i<arr.Length; i++)
            {               
               if(char.IsLower(arr[i]))
                {
                    int val = Convert.ToInt32(arr[i]);
                    if (val + index > 122)
                    {
                        int temp = (val + index) - 122;
                        finalArr.Add(Convert.ToChar((temp - 1) + 97));
                    }
                    else
                    {
                        finalArr.Add(Convert.ToChar(val + index));
                    }
                }
               else if(char.IsUpper(arr[i]))
                {
                    int val = Convert.ToInt32(arr[i]);
                    if (val + index > 90)
                    {
                        int temp = (val + index) - 90;
                        finalArr.Add(Convert.ToChar((temp - 1) + 65));
                    }
                    else
                    {
                        finalArr.Add(Convert.ToChar(val + index));
                    }
                }
            }
            return string.Join("",finalArr);            
        }
    }
}
