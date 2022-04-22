namespace Herencia
{

    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Moises", 33, "developer");
            Console.WriteLine(doctor1.Getinfo());
            Console.WriteLine(doctor1.GetData());
        }

        class People
        {
            private string _name;
            private int _age;
            public People(string name, int age)
            {
                _name = name;
                _age = age;
            }
            public string Getinfo()
            {
               return _name+ " "+ _age;
            } 
        }


        class Doctor : People
        {
            private string _speciality;
            public Doctor(string name, int age, string speciality) : base(name, age)   
            {
                _speciality = speciality;
            }

            public string GetData()
            {
                return Getinfo() + " " + _speciality;
            }
        }
    }
}