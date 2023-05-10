using System;

namespace tim_spel {
    public static class fight {
        public static void Main(string[] args)
        {
            
            int playerHp = 40;
            int fiendeHp = 20;

            int playerAttack = 5;
            int fiendeAttack = 7;

            int heal = 5;

            Random random = new Random();
        

            while(playerHp > 0 && fiendeHp > 0)
            {
                Console.WriteLine("Tjejerna Först");
                Console.WriteLine("Player Hp -" + playerHp + ". Fiende Hp -" + fiendeHp);
                Console.WriteLine("Skriv 'a' för attack eller 'h' för heal.");

                string alternativ = Console.ReadLine();

                if(alternativ == "a")
                {
                    fiendeHp -= playerAttack;
                    Console.WriteLine("Player attack fiende och deals " + playerAttack + " " +  "damage!");
                }
                else {
                    playerHp += heal;
                    Console.WriteLine("Player restores " + heal + " " + "health!");
                }

                if(fiendeHp > 0)
                {
                    Console.WriteLine("Fiende tur");
                    Console.WriteLine("Player Hp -" + playerHp + ". Fiende Hp -" + fiendeHp);
                    int fiendealternativ = random.Next(0, 2);

                    if(fiendealternativ == 0)

                    {
                        playerHp -= fiendeAttack;
                        Console.WriteLine("Fiende attack player och deals " + fiendeAttack + " " + "damage!");
                    }
                    else 
                    {
                        fiendeHp += heal;
                        Console.WriteLine("Fiende restores " + heal + " " + "health!");
                    }
                }
            }

            if(playerHp > 0)
            {
                Console.WriteLine("Gratis! Du van");
            }
            else
            {
                Console.WriteLine("Next time! Du förlorat");
            }
        }
    }
}