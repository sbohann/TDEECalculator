using System;
using System.Collections.Generic;
using System.Text;

namespace TDEECalculator
{
    class TDEECalculations
    {
        public static int CalculateTDEE(HumanInformation human)
        {
            return CalculateBMR(human) + CalculateTEF(human) + CalculateEEE(human) + CalculateNEAT(human);
        }

        private static int CalculateBMR(HumanInformation human)
        {
            if(human.Gender.ToLower() == "male")
            {
                return (int)(88.362 + (13.397 * human.Weight) + (4.799 * human.Height) - (5.677 * human.Age));
            }
            else if(human.Gender.ToLower() == "female")
            {
                return (int)(447.593 + (9.247 * human.Weight) + (3.098 * human.Height) - (4.330 * human.Age));
            }
            else
            {
                Console.WriteLine("Issue in BMR");
                return 0;
            }
        }
        private static int CalculateTEF(HumanInformation human)
        {
            return (int)(CalculateBMR(human) * .1);
        }
        private static int CalculateEEE(HumanInformation human)
        {
            switch (human.ActivityLevel)
            {
                case 1:
                    return 0;
                case 2:
                    return 200;
                case 3:
                    return 300;
                case 4:
                    return 450;
                case 5:
                    return 600;
                default:
                    Console.WriteLine("Issues in EEE");
                    return 0;
            }
        }
        private static int CalculateNEAT(HumanInformation human)
        {
            return 400;
        }
    }
}
