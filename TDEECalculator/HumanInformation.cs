using System;
using System.Collections.Generic;
using System.Text;

namespace TDEECalculator
{
    class HumanInformation
    {
        public int Age { get; set; }
        private string _gender;
        public string Gender {
            get{ return _gender; }
            set{
                string upperValue = value.ToUpper();
                if (upperValue == "MALE" || upperValue == "FEMALE")
                {
                    Console.WriteLine(upperValue);
                    _gender = value;
                }
                else
                {
                    _gender = "MALE";
                }
            } 
        }
        public int Height { get; set; }
        public int Weight { get; set; }
        private int _activityLevel;
        public int ActivityLevel {
            get { return _activityLevel; }
            set { 
                if ( value <= 5 || value >= 1)
                {
                    _activityLevel = value;
                }
                else
                {
                    _activityLevel = 0;
                }
            }
        }
        public int BMR { get; set; }

        public HumanInformation(int age, string gender, int height, int weight, int activityLevel)
        {
            Age = age;
            Gender = gender;
            Height = height;
            Weight = weight;
            ActivityLevel = activityLevel;
        }

        public override string ToString()
        {
            return "Age: " + Age + " Gender: " + Gender + " Height: " + Height + " Weight: " + Weight + " Activity Level: " + ActivityLevel;
        }

    }
}
