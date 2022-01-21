// See https://aka.ms/new-console-template for more information        

Main();

static void Main()
{
    Console.WriteLine("Happy Birthday!");
    dialogue();

    void dialogue() {
        bool loopKillswitch = false;
        while (loopKillswitch == false)
        {


            Console.WriteLine("How Old are you?!");

            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old? (y/n)");

            string confirmation = Console.ReadLine().ToLower();

            switch (confirmation)
            {
                case "y":
                    Console.WriteLine("this will soon house a method");
                    break;
                case "n":
                    Console.WriteLine("I'm Sorry, what was your age?");
                    break;
                default:
                    Console.WriteLine("I don't know what you just put, but it is NOT in a 'y' or 'n' format!");
                    loopKillswitch = true;
                    break;
            }
        }
    }

    //static void CountCandles(int age)
    //{
    //    int[] 
    //}
}
