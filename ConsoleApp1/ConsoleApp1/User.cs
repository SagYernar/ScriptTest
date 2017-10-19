namespace ConsoleApp1
{
    public class User
    {
        public string Name { get; set; }
        public string Answers { get; set; }
        public bool[] Result { get; set; }
        public double Grade { get; set; }

        public User()
        {
            Result = new bool[25];
            Grade = 0;
            for(int i = 0; i<25; i++)
            {
                Result[i] = false;
            }
        }
    }
}