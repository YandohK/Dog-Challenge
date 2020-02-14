using System;

namespace Dog_Challenge
{
    public enum Gender {Male,Female};
    class Dog
    {
        private string name;
        private string owner;
        private int age;
        private Gender gender;
        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }
        public void Bark(int times)
        {
            for(int z = 0; z < times; z++)
            {
                Console.Write("Woof!!");
            }
            Console.WriteLine();
        }
        public string GetTag()
            {
                string tag ="if lost, call "+owner+".";
                if(gender == 0)
                {
                    tag += " His name is "+name+" he is " +age.ToString();
                }
                else
                {
                    tag += " Her name is "+name+" she is " +age.ToString();
                }
                if (age > 1)
                {
                    tag += " years old";
                }
                else
                {
                    tag += " year old";
                }
                return tag;
                
            }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Dog Puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
                Puppy.Bark(3);
                Console.WriteLine(Puppy.GetTag());
                Dog BigDog = new Dog("Lieu","Dale",4,Gender.Female);
                BigDog.Bark(1);
                Console.WriteLine(BigDog.GetTag());
            }
        }

}
