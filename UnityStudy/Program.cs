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

        static void Attack(int attackAmount)
        {
            if(attackAmount == 0)
            {
                return; // 이럴때 void에도 return을 써서 > 함수를 무효화
                // monsterHp - attackAmount;
            }
        }

        // 함수를 만들어 주세요
        // 반환형식은 정수이고
        // 이름은 Test이고
        // 매개변수는 int 형식으로 한개만 받는 걸로
        // 넘겨받은 매개변수의 값에 +1을 하여 반환하게 하세요
        static int Test(int a) // 왜 매개변수에 타입을 붙일까? > 컴퓨터가 어떤 타입인지 모르니까
        {                      // 메모리 공간 > 한칸 한칸이 비트인데 > 메모리는 다 분산되어있다 > 그럼 크기를 모르면 자리를 어떻게 할 지 모르니까
            Console.WriteLine($"before cal :{a}");
            a++;
            Console.WriteLine($"after cal :{a}");
            return a;        // 잘못하면 덮어씌울 수도 있으니까 > 형식을 지정하여 주소를 피해가니까
        }
        static int Test2(int a) // 왜 매개변수에 타입을 붙일까? > 컴퓨터가 어떤 타입인지 모르니까
        {                      // 메모리 공간 > 한칸 한칸이 비트인데 > 메모리는 다 분산되어있다 > 그럼 크기를 모르면 자리를 어떻게 할 지 모르니까
            Console.WriteLine($"a in :{a}");
            
            // return a++; >> 이러면 a만 리턴되고 1이 더해지는 연산이 날아감 >> 주의!
            return ++a;       // 잘못하면 덮어씌울 수도 있으니까 > 형식을 지정하여 주소를 피해가니까
        }
        // 보통 프로그램 흐름이 시작은 Main임 > 호출이 안되면 건너뛰는 거임
        // 그래서 변수 선언을 맨 위에서 하면 안됨 > 이것은 static때문
        // main함수 바깥의 공간은 그냥 다른 공간 > 메소드의 공간이라 생각하고
        // 함수 호출전에 매개변수가 먼저 선언되어야 오류가 안난다. / 매개변수에 꼭 변수가 필요한 건 아님, 리터럴이 들어가도 작동함
        // 참고로 매개변수끼리 변수명을 맞출 필요는 없다
        // int x = 99 > 함수 호출 > 값이 들어가서 > 가상의 변수로 연산 > 반환시킴

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

            
            Console.WriteLine($"before Method : {x}");
            int t = Test(x); // return값을 어떤 변수에 담음
            Console.WriteLine($"after Method : {t}"); // 그것을 출력
            Console.WriteLine(Test(x)); // 그냥 출력만
            int t2 = Test2(x);
            Console.WriteLine($"after Method : {t2}");

            // ref stack heap도 배우면 좋지만... 일단은 넘어갑시다 > 메소드 만드는 법을 꼭 기억하라
            // 값형식, 참조형식
        }
    }
}
