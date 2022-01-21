// See https://aka.ms/new-console-template for more information        

Main();

static void Main()
{

    Console.WriteLine("Happy Birthday!");
    dialogue();


    void dialogue()
    {
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
                    CountCandles(age);
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

    void CountCandles(int age)
    {
        int[] candleSizes = new int[age];
        int sumOfAge = age;
        //placeholder for each pass in while loop. Holds value after number is subtracted from hold until it gets to zero
        bool anotherKillswitch = false;

        while (anotherKillswitch == false)
        {
            int changingAge = sumOfAge - 9;

            int indexTracker = 0;
            

            if(changingAge != 0 )
            {
                candleSizes[indexTracker] = changingAge;
                Console.WriteLine("On pass " + indexTracker + 1 + " we added " + changingAge);
                indexTracker++;
                sumOfAge = sumOfAge - 9;
            }
             if(changingAge >= 0 && changingAge != 0)
            {
                bool innermostKillswitch = false;
                int tenOrSmaller = changingAge;
                while(innermostKillswitch == false && tenOrSmaller != 0)
                {
                  var random = new Random();
                    tenOrSmaller = tenOrSmaller - random.Next(tenOrSmaller);
                    if(tenOrSmaller <= 0 )
                    {
                        innermostKillswitch = true;
                        
                    }
                    sumOfAge = sumOfAge - tenOrSmaller;

                }
                anotherKillswitch = true;
                      changingAge = 0;
            }
            else
            {
                anotherKillswitch = true;
            }

        }
    }
}


