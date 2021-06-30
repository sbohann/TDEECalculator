using System; 

namespace TDEECalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string ageInput = GetConsoleInput("age", false, "0-120");
            int age = ValidateIntConsoleInput(ageInput, "age");

            string weightInput = GetConsoleInput("weight", false, "lbs.");
            int weight = ValidateIntConsoleInput(weightInput, "weight");

            string heightInput = GetConsoleInput("height", false, "in.");
            int height = ValidateIntConsoleInput(heightInput, "height");
            
            string genderInput = GetConsoleInput("gender", false, "Male/Female");
            string gender = genderInput;

            string activityLevelInput = GetConsoleInput("activityLevel", false,"1-5 / 1-no activity -> 5-elite athlete");
            int activityLevel = ValidateIntConsoleInput(activityLevelInput, "activity level");

            HumanInformation Info = new HumanInformation(age, gender, height, weight, activityLevel);
            Console.WriteLine(Info.ToString());
            int TDEE = TDEECalculations.CalculateTDEE(Info);
            Console.WriteLine("YOUR TDEE IS...");
            Console.WriteLine(TDEE);            
        }

        static string GetConsoleInput(string inputName, bool validationError, string hint = "")
        {
            if (validationError)
            {
                Console.WriteLine("Please enter a valid " + inputName + ".");
                Console.WriteLine("Enter your " + inputName + " ( "+ hint + "): ");
                return Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter your " + inputName + " (" + hint + "): ");
                return Console.ReadLine();
            }
            
        }

        static int ValidateIntConsoleInput(string input, string inputName)
        {
            while (!Int32.TryParse(input, out int validate))
            {
                input = GetConsoleInput(inputName, true);
            }
            return Int32.Parse(input);
        }
    }
}
