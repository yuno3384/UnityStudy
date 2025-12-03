using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOOP
{
    class Program
    {

        public class Wizard
        {
            public int mp;
            public int intelligence;

            public Wizard(int mp , int intelligence)
            {
                this.mp = mp;
                this.intelligence = intelligence;
            }
        }




        static void Main()
        {
            // 깃의 오류?
            // 선문강사님 : 깃을 먼저 형성하자, 그리고 그 자리에서 만들자
            // 영훈강사님 : 깃보다 일단 유니티를 개발하자, 나중에 공유가 되면 그때 하자(현언에서 주로 함)
            // 유니티에서 git을 올리는 방법
            // 프로젝트를 먼저 만들고 
            // =======================================
            // 1. Wizard 클래스를 만들어 다음 조건을 만족하세요:
            // 
            // - 멤버 변수: mp, intelligence (둘 다 int형)
            // - 생성자에서 각각 50, 20으로 초기화
            // - Main()에서 Wizard 객체를 생성하고 두 값을 출력
            //
            // [실행 결과]
            // 마법사의 MP: 50, 지능: 20
            // =======================================

            Wizard wizard = new Wizard(50,20);
            Console.WriteLine($"마법사의 MP: {wizard.mp}, 지능: {wizard.intelligence}");




            
       }

        

    }
        
        
    


    
}
