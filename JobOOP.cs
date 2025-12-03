namespace JobOOP
{
    namespace Program
    {
        class Program
        {
            enum ClassType
            {
                None,
                Knight,
                Mage,
                Rogue
            }

            struct Player
            {
                public int hp;
                public int atk;
            }

            // 몬스터 구조체를 만들자









            static ClassType ClassChoice()
            {
                Console.WriteLine("직업을 선택하세요!");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[2] 마법사");
                Console.WriteLine("[3] 도둑");

                ClassType choice = ClassType.None;
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        choice = ClassType.Knight;
                        break;
                    case "2":
                        choice = ClassType.Mage;
                        break;
                    case "3":
                        choice = ClassType.Rogue;
                        break;
                }

                return choice;
            }

            static void CreatePlayer(ClassType choice, /*out int hp, out int atk,*/ out Player player)
            {
                // 기사(100/10), 마법사(50/15), 도둑(75/12)

                player.hp = 0;
                player.atk = 0;

                switch (choice)
                {
                    case ClassType.Knight:
                        player.hp = 100; 
                        player.atk = 10;
                        break;
                    case ClassType.Mage:
                        player.hp = 50;
                        player.atk = 15;
                        break;
                    case ClassType.Rogue:
                        player.hp = 75;
                        player.atk = 12;
                        break;
                   
                }
            }

            static void Main(string[] args)
            {
                ClassType choice = ClassType.None;

                Player player;

                while (true)
                {
                    choice = ClassChoice();
                    if (choice != ClassType.None)
                    {
                        //// 캐릭터 생성
                        //int hp;
                        //int atk;

                        CreatePlayer(choice, out hp, out atk, out player);

                        Console.WriteLine($"HP {hp}, ATK {atk}");

                        // 필드에서 싸울 몬스터
                    }
                }
            }





        }
    }
}
