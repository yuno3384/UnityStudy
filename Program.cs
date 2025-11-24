namespace UnityStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if문 > 분기문

            // 반복문

            // while : 하는 동안에
            //while (조건)
            //{// 이 조건이 참인동안 아래 명령문을 실행 반복해줘
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
             while문을 이용해 1부터 10까지 출력한다
             출력 후 num을 1씩 증가시킨다
             */
            int num = 1;
            while (num < 11)
            {
                Console.WriteLine(num);
                num++;
            }



            // dowhile
            // for

        }
    }
}
