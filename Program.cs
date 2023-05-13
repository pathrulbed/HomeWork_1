class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Input Number:");
        int InputNum;
        int result = 1;
        while (true)
        {
            InputNum = int.Parse(Console.ReadLine());
            if (InputNum < 0)
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
            }
            else if (InputNum == 0)
            {
                InputNum = 1;
                break;
            }
            else 
            {
                break;
            }
        }

        for (int i = 0;i<InputNum;i++)
        {
            
            for (int j = 0;j<=i;j++)
            {
                if ((i==0)||(j==0))
                {
                    result = 1;
                }
                else 
                {
                    result = result*(i-j+1)/j;
                }
                Console.Write(result);
            }
            Console.WriteLine();
            

        }
    }
}