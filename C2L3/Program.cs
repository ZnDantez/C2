using System;

namespace C2L3
{
    //enum Gender
    //{
    //    Male,
    //    Female,
    //    Undefined // чтоб никого не обижать
    //}

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public object Gender { get; set; }
    }

    class Gender
    {
        public string Description { get; set; }

        public Gender(string description)
        {
            Description = description;
        }
    }

    class PersonV2<TGender> where TGender : Gender
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public TGender Gender { get; set; }

        public PersonV2(string name, int age, TGender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person() { Name = "Андрей", Age = 25, Gender = "Мужчина" };
            //var person2 = new Person() { Name = "Дарья", Age = 25, Gender = Gender.Female };
            var person3 = new Person() { Name = "Дарья", Age = 25, Gender = 1 };

            //if (person1.Gender is Gender && (Gender)person1.Gender == Gender.Female) { }

            //var person4 = new PersonV2<Gender>("Андрей", 33, Gender.Male);
            //var person5 = new PersonV2<string>("Андрей", 33, "Мужчина");
            //var person6 = new PersonV2<int>("Андрей", 33, 1);

            var person7 = new PersonV2<Gender>("Андрей", 33, new Gender("Мужчина"));
        }
    }
}
