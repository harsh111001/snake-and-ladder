namespace snakenladder
{
    internal class Program
    {
        const int START_POSITION = 0;
        const int END_POSITION = 100;
        const int NO_PLAY = 1;
        const int LADDER = 2;
        const int SNAKE = 3;

        static int Die_Roll()
        {
            Random random= new Random();
            int roll= random.Next(1, 7);
            return roll;
        }
        static int Move()
        {
            Random random= new Random();
            int decide= random.Next(1,4);
            return decide;
        }

        static void Single_Player()
        {
            Console.WriteLine("single player playing");
            int cur_Pos = 0,moves=0;
            while(cur_Pos<END_POSITION)
            {
                int decide=Move();
                int roll=Die_Roll();
                Console.WriteLine($"die roll is {roll} and number of times die roled is {moves}");
                if(decide==NO_PLAY) 
                {
                    Console.WriteLine("No Play");
                }else if (decide==LADDER)
                {
                    Console.WriteLine("Ladder");
                    cur_Pos += roll;
                }
                else
                {
                    Console.WriteLine("Snake");
                    if(cur_Pos-roll>START_POSITION)
                    {
                        cur_Pos-=roll;
                    }
                    else
                    {
                        cur_Pos= 0;
                    }
                }
                moves++;
                Console.WriteLine($"current position is {cur_Pos} ");
            }
            Console.WriteLine($"you won and took {moves} moves");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This is Snake and ladder game");
            Single_Player();
             
        }
    }
}