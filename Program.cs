using System.Runtime.CompilerServices;
using System.Threading;
using System;
namespace tim_spel {
    public static class Program {
    public static void Main(string[] args)
    {    
            Knight knight = new Knight();
            Mage mage = new Mage();
            Random random = new Random();
            int poäng = 0; 
            int poänground = 1;
            List<Support> warriors = new List<Support>();
            warriors.Add(new Knight());
            warriors.Add(new Mage());
            warriors.Add(new Archer());

        while(knight.hp > 0 && mage.hp > 0){
                Console.WriteLine("Tjejerna Först");
                Console.WriteLine("Knight Hp " + knight.hp + ". Mage Hp " + mage.hp);
                Console.WriteLine("Skriv 'a' för attack eller 'h' för heal.");

                string alternativ = Console.ReadLine();

            if(alternativ == "a")
                {
                    mage.hp -= knight.Damage;
                    Console.WriteLine("Knight attack Mage och deals " + knight.Damage + " " +  "damage!");
                }
                else {
                    knight.hp += knight.Heal;
                    Console.WriteLine("Knight restores " + knight.Heal + " " + "health!");
                }
                
                if(mage.hp > 0)
                {
                    Console.WriteLine("Mage tur");
                    Console.WriteLine("Knight Hp " + knight.hp + ". Mage Hp " + mage.hp);
                    int Magealternativ = random.Next(0, 2);

                    if(Magealternativ == 0)
                    {
                        knight.hp -= mage.Damage;
                        Console.WriteLine("Mage attack player och deals " + mage.Damage + " " + "damage!");
                    }
                    else 
                    {
                        mage.hp += mage.Heal;
                        Console.WriteLine("Mage restores " + mage.Heal + " " + "health!");
                    }
                }
            }

            if(knight.hp > 0)
            {
                Console.WriteLine("Gratis! Du van");
                poäng += poänground;
                Console.WriteLine("Poäng som du har vunnit " + poäng);
                StreamWriter sw = new StreamWriter("./textfil.txt", true);
                sw.WriteLine(poäng);
                sw.Close();
            }
            else
            {
                Console.WriteLine("Next time! Du förlorat");
                poäng -= poänground;
                StreamWriter sw = new StreamWriter("./textfil.txt", true);
                sw.WriteLine(poäng);
                sw.Close();
            }
        }    
    }
        class Support 
        {
            public int hp;

            public int Heal;

            public virtual void TakeDamage(int amount, int heal)
            {
                hp = amount;
                Heal += heal;
            }   
            public Support(int hp, int heal)
            {
                this.hp = hp;
                this.Heal = heal;
            }
        }
        class Knight: Support, IDamage
        {
            private int damage = 15; 
            public int Damage
            {
                get { return damage; }
            }
            public void DealDamage(string target){  }

            public void Usegrenade() {  }

            public Knight(): base(100, 5){  }
            
            public Knight(int hp, int heal): base(hp, heal){  }


        }
        class Mage: Support, IDamage
        {
            private int damage = 20;

            public int Damage
            {
                get { return damage; }
            }

            public void DealDamage(string target){  }
            public Mage(): base(35, 12) {  }
            
            public Mage(int hp, int heal): base(hp, heal){   }
        }
        class Archer: Support, IDamage
        { 
            private int damage = 15;

            public int Damage
            {
                get { return damage; }
            }

            public void DealDamage(string target){  }
            public Archer(): base(100, 5){  }
            
            public Archer(int hp, int heal): base(hp, heal){  }
        }
    }