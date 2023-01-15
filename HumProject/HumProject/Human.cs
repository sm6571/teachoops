namespace HumProject
{
    public class Human
    {
        public string Name { get; set; }

        internal string Address { get; set; }

        string PhoneNumber { get; set; }

        string Gender { get; set; }

        public Human(string name, string address, string phoneNumber, string gender)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }

        public void Walk()
        {
            Console.WriteLine("{0} is walking in {1} area.", this.Name, this.Address);
        }

        public void Sleep(int sleepDuration)
        {
            Console.WriteLine("{0} is going to sleep now.", this.Name);
            Thread.Sleep(sleepDuration);
            Console.WriteLine("{0} slept for {1} mili-seconds.", this.Name, sleepDuration);
        }

        public string GetGender()
        {
            return this.Gender; // child1.Gender
        }
    }
}
