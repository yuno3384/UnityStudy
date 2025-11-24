namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // 구구단 출력 프로그램
            // 앞자리는 2부터 뒷자리는 1부터
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine($"{i}단");
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}*{j} = {i * j}");
                }
            }

            // 아직도 중소기업에서는 별짓기가 나온다
            /*
                *
                * *
                * * *
                * * * *
                * * * * *
             
             */

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
