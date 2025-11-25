namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // 구구단 출력 프로그램
            // 앞자리는 2부터 뒷자리는 1부터
            //for (int i = 2; i < 10; i++)
            //{
            //    Console.WriteLine($"{i}단");
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i}*{j} = {i * j}");
            //    }
            //}

            // 아직도 중소기업에서는 별짓기가 나온다
            

            // 숙제 하나 더
            // 1에서 10까지 출력하는데 
            // 1은 홀수 입니다
            // 2는 짝수 입니다
            for (int i = 1; i > 11; i++)
            {
                if (i % 2 == 0)
                {
                   Console.WriteLine($"{i}는 짝수입니다");
                }
                else if (i % 2 == 1)
                {
                   Console.WriteLine($"{i}는 홀수입니다.");
                }
            }

            // 누적합 알고리즘 > 1부터 n까지 더해주세요
            // 스코프 바깥에 변수선언 및 초기화 > 반복문 속에서 변수에 i값 계속 넣기 > 최종값을 반복문 밖에서 출력
            int save = 0;
            for (int i = 1; i < 11; i++)
            {
                save += i;
            }
            Console.WriteLine(save);

        }
    }
}
