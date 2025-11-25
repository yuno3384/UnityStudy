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
                사고 과정) i 안의 j가 반복될 때 j가 *을 출력하는 방식
                
             
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

            for (int i = 1; i < 6; i++)
            {
                for (int j = 6; j > i; j--)
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
                    Console.WriteLine($"{i}는 짝수입니다.");
                }
                else if(i % 2 == 1){
                    Console.WriteLine($"{i}는 홀수입니다.");
                }
            }

            //오른쪽 정렬 별찍기
            /*
              * * * * * // 1 -> 5
                * * * * // 2 -> 4 
                  * * * // 3 -> 3
                    * * // 4 -> 2
                      * // 5 -> 1
             */
            for (int i = 1; i < 6; i++)
            {
                for (int j = 6 ; j > i; j--)
                {
                  Console.Write("q");
                }
                for (int j = 6; j > i; j--)
                {
                    Console.Write("0");
                }
                Console.WriteLine("*");
            }
            /*
                        *
                      * *
                    * * *
                  * * * *
                * * * * *
             */
            // 게임수학을 하면 좋다 > 다크쏘울에서 뒤에 몰래 가서 잡는 것 > 그것을 구현하려면 외접 내접을 해야...
            // 방향벡터 A를 B로 갈때 d를 구할 때 > 노멀라이즈

        }
    }
}
