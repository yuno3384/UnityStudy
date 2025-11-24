namespace UnityStudy
{
    internal class Program
    {
        static void Main()
        {
            // if문 > 분기문

            // 반복문

            // while : 하는 동안에
            //while (조건)
            //{// 이 조건이 참인 동안 아래 명령문을 실행 반복해줘
            //}
            // 조건이 변경되지 않는다면 > 값은 달라지지 않을 것
            //int a = 0;
            //while (a < 5) // 조건이 true면 무한루프에 빠져버림
            //{
            //    Console.WriteLine("무한반복");
            //    a++; // 0 > 1 > 2 > 3 > 4 // while문을 쓸때는 반드시 조건변경이 중요하다
            //}
            // 깃허브가 private이라면 : Setting > Change Visuality선택
            /*
             정수변수 num을 1로 초기화한다.
             while문을 이용해 1부터 10까지 출력한다 > 10보다 작거나 같다 , 11 이전
             출력 후 num을 1씩 증가시킨다
             */
            int num = 1; // >> 초기화
            while (num < 11)
            {
                Console.WriteLine(num);
                num++; // 1 > 2 > 3 >> 조건 변경 > 빼먹을 수도 있으니까
                // ++num; // 1 > 2 > 3 > 4 => 아무런 상관이 없다
            }


            // dowhile > 일단 해봐 > 그리고 while 조건이 true면 반복해 : 무조건 한번은 실행이 된다
            //do
            //{
            //    Console.WriteLine(num);
            //    num++; // 항상 조건에 따라 실행되는 것이기 때문에 > 조건에 맞는 횟수로 간다
            //}
            //while (num < 11); // while과 똑같으나, 최초 한번은 무조건 실행된다.

            // for
            //for (초기화(변수); 조건(boolean값); 조건변경(값 변화))
            //{
            Console.WriteLine("aa");
            // for문에서 조건이 비면? > true로 인식 > 전부 비우면( ; ; ) 그냥 무한루프
            //}
            for (int num2 = 1; num2 < 11; ++num2) // while이나 for문이나 똑같다 
            {
                Console.WriteLine(num2);
            }

            for (int n = 0; n < 9; n++)
            {
                Console.WriteLine(n);
                for (int m = 0; m < 9; m++)
                {
                    Console.WriteLine($"{n} {m}"); //CW : Console.WriteLine();
                }

            }
            // 안에 있는 반복문이 먼저 시작해서 > 그 안의 반복문이 그다음 시작됨 > 그리고 안의 반복문이 끝나고 나면 다시 바깥쪽 반복문의 조건변경이 진행
            // 항상 V자로 그린다. >선언 > (조건 > 실행 > 조건변경)(계속 반복)


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
