using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VelizhaninPI.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            string letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Boolean x = true;
            for(int i = 0; i < value.Length; i++)
            {
                bool b = letters.Contains(value[i]);
                if (b == false)
                {
                    x = false;
                }
                    
            }
            return x;
        }
    }
}
