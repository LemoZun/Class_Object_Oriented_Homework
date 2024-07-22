namespace ClassHomework
{
    internal class Program
    {
        class Character
        {
            int level;
            int hp;
            double moveSpeed;
            double attack;

            void GoFront()
            {
                Console.WriteLine("캐릭터가 앞으로 이동했습니다.");
            }
            void GoBack()
            {
                Console.WriteLine("캐릭터가 뒤로 이동했습니다.");
            }
            void TurnLeft()
            {
                Console.WriteLine("캐릭터가 왼쪽으로 이동했습니다.");
            }

            void TurnRight()
            {
                Console.WriteLine("캐릭터가 오른쪽으로 이동했습니다.");
            }

            void Attack()
            {
                Console.WriteLine($"캐릭터가 공격해 {attack}의 데미지를 입혔습니다");
            }

            void Hit()
            {
                Console.WriteLine("캐릭터가 피격당했습니다.");
            }




        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
