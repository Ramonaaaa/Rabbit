using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework2
{
    public class Rabbit
    {
        private string eyeColor = "red";
        private string furColor = "white";
        private readonly DateTime birthDay;
        private bool gender = true;
        private readonly int age;

        public Rabbit() { }

        public Rabbit(string _eyeColor, string _furColor, DateTime _birthday, bool _gender)
        {
            this.eyeColor = _eyeColor;
            this.furColor = _furColor;
            this.birthDay = _birthday;
            this.gender = _gender;

        }

        public DateTime BirthDay
        {
            get
            {
                return this.birthDay;
            }
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                return now.Subtract(birthDay).Days;
            }
        }

        public bool Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (this.gender == value)
                {
                    Console.WriteLine("Rabbit gender: female");
                }
                else
                {
                    Console.WriteLine("Rabbit gender: masculin");
                }
            }
        }

        public string EyeColor
        {
            get
            {
                return this.eyeColor;
            }
            set
            {
                if (value == "blue" || value == "red" || value == "black")
                {
                    eyeColor = value;
                    Console.WriteLine("The rabbit have " + this.eyeColor + " eyes.");
                }
                else
                {
                    Console.WriteLine("Please insert eye color from the list: \n- red \n- blue \n- black");
                }
            }
        }

        public string FurColor
        {
            get
            {
                return this.furColor;
            }
            set
            {
                if (value == "white" || value == "brown" || value == "black" || value == "grey")
                {
                    furColor = value;
                    Console.WriteLine("The rabbit have " + this.furColor + " fur.");
                }
                else
                {
                    Console.WriteLine("Please insert one of the 4 colors: \n- white \n- brown \n- black \n- grey");
                }

            }
        }

        public override string ToString()
        {
            return "\n - Eye color: " + eyeColor.ToString() + "\n - Fur color: " + furColor.ToString() + ".\n - Birhday: " + birthDay.ToString()
                + "\n - Gender: " + ((gender) ? "female" : "male");
        }



    }
}


