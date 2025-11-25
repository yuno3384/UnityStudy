namespace ConsoleApp1
{
    class Program
    {

        static void OutputHello() //함수를 생성 > Output함수는 뭔가를 넣지는 않지만
        {
            Console.WriteLine("hello World"); //Hello World를 출력시켜줄거야 > 반환은 없어
        }
        // 반환값 : void(반환값이 공허,아무것도 없음) / int > 값이 반환되지 않는데? > return
        // 
        static void Output(int a , int b) //매개변수를 넣어보자 > 타입은 다양하게 넣을 수 있되 변수명은 중복이 불가
                                          //함수 시그니쳐 > 액션, 이벤트 , 펑크
        {
            Console.WriteLine(a + b); //Hello World를 출력시켜줄거야 > 반환은 없어

            // return에는 반환타입에 맞게 / void면 내보낼 것이 없다? > return을 못쓰는 건 아님 > return하는 순간 그 프로그램은 종료됨
            // 어떤 경우에 쓰냐?
            int hp = 10;
            if(hp <= 0)
            {
                return; // 내보낸다 > 함수를 끝낸다
            }

            // return; // return도 그 아래 구문은 전부 작동이 불가해짐

            // 공격하기;
            int demage = 0;

            //return a;
            //return b;
            //return a + b;
        }

        // 함수를 만들어 주세요
        // 반환형식은 정수이고
        // 이름은 Test이고
        // 매개변수는 int 형식으로 한개만 받는 걸로
        // 넘겨받은 매개변수의 값에 +1을 하여 반환하게 하세요
        static void Test(int a)
        {
            Console.WriteLine(a++);
        }


        static void Main(string[] args)
        {
            

            OutputHello(); // 함수를 호출 > 근데 매개변수가 없으니 오류가 나네?

            // for문을 안쓰고 Hello World를 세번 출력 > Hello World 출력을 함수로 해뒀지?
            OutputHello();
            OutputHello();
            OutputHello();

            //정수 리터럴을 직접 넣은 경우
            Output(10 , 20); // 함수를 호출 > 근데 매개변수가 없으니 오류가 나네?
                             // 매개변수는 그 갯수에 맞게 넣어야 작동이 됨
                             // 매개변수가 없으면 당연히 넣으면 안되고, 갯수도 반드시 맞춰야한다.

            // 변수를 선언하여 그 값을 넣은 경우
            int x = 10;
            int y = 20;
            Output(x, y);

            // 반환값 : void(반환값이 공허,아무것도 없음) /


            // 값형식, 참조형식
        }
    }
}
