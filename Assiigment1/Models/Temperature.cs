using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppFirstCore.Models
{
    public class Temperature
    {
        
        public static string FeverChecker(int temp, string choise)
        //ToDo fever?
   
        {
            string answer = "";
            if (temp >= 38)
                answer =  "Doctor said you have fever";
            else if ( temp<= 35)
            {
                answer = "Docotor said you have to low temp";
            }
            else
            {
                answer = "Doctor said you have have normal";
            }

            return answer;
        }
        
    }

}
