namespace ConsoleApp1
{
    class Program
    {

        static void OutputHello() //함수를 생성 > Output함수는 뭔가를 넣지는 않지만
        {
            Console.WriteLine("hello World"); //Hello World를 출력시켜줄거야 > 반환은 없어
        }

        static void Output(int a , int b) //매개변수를 넣어보자 > 타입은 다양하게 넣을 수 있되 변수명은 중복이 불가
                                          //함수 시그니쳐 > 액션, 이벤트 , 펑크
        {
            Console.WriteLine(a + b); //Hello World를 출력시켜줄거야 > 반환은 없어
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

            // 변수를 선언하여 그 값을 넣은 경우
            int a = 10;
            int b = 20;
            Output(a, b);


            // 값형식, 참조형식
        }
    }
}
