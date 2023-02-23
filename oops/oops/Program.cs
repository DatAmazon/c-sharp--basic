

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Student nam = new Student("sv01", "Lan", "Lan@gmail.com", 20);

            //use set/get
            nam.SetAge(21);
            nam.SetFirstName("Hoa");
            Console.WriteLine(nam.GetAge());
            Console.WriteLine(nam.GetFirstName());

            // use .net property
            nam.Id = "svProperty";
            Console.WriteLine(nam.Id);

        }

    }
}