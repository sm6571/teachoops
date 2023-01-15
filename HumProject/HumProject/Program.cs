namespace HumProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a new Human object
            Human child1 = new Human(name: "Bhagyashree",address: "Lynnwood",phoneNumber: "4324342",gender: "Female");

            child1.Walk();
            //child1.Sleep(4000);

            Human child2 = new Human("Satyajit", "Lynnwood", "9458", "Male");

            child2.Walk();
            //child2.Sleep(10000);

            Console.WriteLine(child1.Name);
            Console.WriteLine(child1.Address);

            string child1Gender = child1.GetGender();
            string child2Gender = child2.GetGender();
            Console.WriteLine(child1Gender);
            Console.WriteLine(child2Gender);
        }
    }
}