namespace LINQ_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>
            {
                new Person("adith",21,"calicut"),
                new Person("anandhu",21,"kochi"),
                new Person("nandhu",20,"kottayam"),
                new Person("sharan",45,"tvm"),
                new Person("abdulla",34,"kannur"),
                new Person("irfan",15,"kzd")

            };

            var oldpeople = from person in list where person.Age >= 25 select person;

            foreach(Person people in oldpeople)
            {
                Console.WriteLine(people.Name+" "+people.Age);
            }

        }
    }
}
