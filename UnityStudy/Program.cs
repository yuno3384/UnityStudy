namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // 구구단 출력 프로그램
            // 앞자리는 2부터 뒷자리는 1부터
            /*
             2단
            2 * 1 = 2
            2 * 2 = 4
            .
            .
            .
            9단
            .
            .
            .
            9 * 8 = 72
            9 * 9 = 81
             */
            //for (int i = 2; i < 10; i++)
            //{
            //    Console.WriteLine($"{i}단");
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i}*{j} = {i * j}");
            //    }
            //}

            // 아직도 중소기업에서는 별짓기가 나온다
            /*
                *
                * *
                * * *
                * * * *
                * * * * *
             
            */
            //Console.Write("*");
            //Console.WriteLine("**"); // > 이거말고!!
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("-----------------------");
            /*
                * * * * *
                * * * * 
                * * *
                * * 
                * 
             
            */

            for (int i = 1; i < 7; i++)
            {
                for (int j = 7; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            // 숙제 하나 더
            // 1에서 10까지 출력하는데 
            // 1은 홀수 입니다
            // 2는 짝수 입니다
            for (int i = 1; i < 11; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"{i}는 짝수입니다");
                }
                else if(i % 2 == 1){
                    Console.WriteLine($"{i}는 홀수입니다.");
                }
            }



            

        }
    }
}
