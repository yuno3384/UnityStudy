namespace ConsoleApp1
{
    class Program
    {

        static void Output() //함수를 생성 > Output함수는 뭔가를 넣지는 않지만
        {
            Console.WriteLine("hello World"); //Hello World를 출력시켜줄거야 > 반환은 없어
        }

        static void Main(string[] args)
        {
            //for문의 break와 continue
            // switch의 구조 - case / break / default 와 같이
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i); // 1 2 3 4 5> 왜냐? 조건문 보다 먼저이므로 먼저 출력
                // 3이 될때 멈추게 하고 싶어 > 조건문 + break 
                //if(i == 3)
                //{
                //    break;// > 반복문을 중단하고 빠져나와 주세요 > 자신과 가장 가까이 있는 스코프를 탈출
                //}
                if (i == 2)
                {
                    continue; // > 반복문에서 이번 회차만 건너뛰어주세요
                    //Console.WriteLine(""); // 이 아래 구문은 작동안됨
                }
                Console.WriteLine(i); // 1 3 4 5 > 왜냐? 조건문 보다 나중이므로 조건문 조건이 성립하여 제외

            }
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if (i == 2)
                    {
                        break;  // > 반복문을 중단하고 빠져나와 주세요 > 자신과 가장 가까이 있는 스코프를 탈출
                    }
                }
                
                Console.WriteLine(i); // 1 3 4 5 > 왜냐? 조건문 보다 나중이므로 조건문 조건이 성립하여 제외

            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    while (true)
                    {
                        if (i == 2)
                        {
                            break; // > 반복문을 중단하고 빠져나와 주세요 > 자신과 가장 가까이 있는 스코프를 탈출
                        }
                    }
                    
                }

                Console.WriteLine(i); // 1 3 4 5 > 왜냐? 조건문 보다 나중이므로 조건문 조건이 성립하여 제외

            }
            // break; // > 반복문을 중단하고 빠져나와 주세요 > 자신과 가장 가까이 있는 스코프를 탈출 
            // 즉 switch문의 구동은 => case 일치 > 일치 시 실행코드를 작동 > break로 switch문 스코프를 탈출하며 종료 > 다음 코드 

            // 함수 (=매소드, 프로시져)
            // 개념적으로는 코드를 재사용할 수 있도록 하나의 단위로 묶는 거
            // 만일 같은 것이 계속 반복해야 한다면 > 차라리 틀(거푸집)이 있으면 그게 편하겠다 
            // static void Main() > Main도 함수다
            // 반환형식(타입) 함수명(매개변수: 함수에 집어넣을 입력값, 여러개 가능하다)
            //  Console.WriteLine(" "); / Int.Parse() / void Main() > 끝에 괄호가 붙어있는 것은 다 함수다
            // 한정자 : static / public / private
            /*
                함수의 주요 모양 > 어떤 값을 넣으면 어떠한 행위가 일어나서 어떤 값이 나온다.
                한정자 반환형식(타입) 함수명(매개변수)
                {
             
                }
             
             */

            Output(); // 함수를 호출

            // for문을 안쓰고 Hello World를 세번 출력 > Hello World 출력을 함수로 해뒀지?
            Output();
            Output();
            Output();



        }
    }
}
