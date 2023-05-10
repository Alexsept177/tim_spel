// using System.Runtime.CompilerServices;
// using System.Threading;
// using System;
// namespace tim_spel {
//     public static class Program {
//     public static void Main(string[] args)
//     {
//         // Support knight = new Knight();
//         //     
//             // Slider slider = new Slider();
//             // Support support = new Knight();
//             // (support as Knight).Usegrenade();
//             // Knight T = (Knight)support;
//             // T = support as Knight;
            
            
//             Knight knight = new Knight();
//             Mage mage = new Mage();
//             // knight.DealDamage("Troll");
//             // Mage mage = new Mage();
//             // mage.DealDamage("Troll");

//             // support.TakeDamage(4);
//             // knight.TakeDamage(4);
//             //mage.DealDamage(4)
            
            
//             // Console.WriteLine("Support: " + support.hp);
//             // Console.WriteLine("Fighter: " + knight.hp);
//             List<Support> warriors = new List<Support>();
//             warriors.Add(new Knight());
//             warriors.Add(new Mage());
//             warriors.Add(new Archer());
//             foreach (Support support in warriors)
//             {
//                 if(support is IDamage damage)
//                     damage.DealDamage("Troll");
//             }
            
//     }
//         class Support 
//         {
            
//             public int hp;

//             public virtual void TakeDamage(int amount)
//             {
//                 hp -= amount;
//             }
            
//             public Support(int hp)
//             {
//                 this.hp = hp;
//             }

//             public Support()
//             {

//             }
//         }
//         class Knight: Support, IDamage
//         {
//             private int damage = 15;

//             public int Damage
//             {
//                 get { return damage; }
//             }

//             public void DealDamage(string target)
//             {
//                 Console.WriteLine("Knight deals " + Damage + " to "+ target);
//             }

//             public void Usegrenade() {  }

//             public Knight(): base(150)
//             {

//             }
            
//             public Knight(int hp): base(hp)
//             {

//             }

//             // public override void TakeDamage(int amount)
//             // {
//             //     hp -= amount / 2;
//             //     Console.WriteLine("Knight takes Damage!");
//             // } 
//         }
//         class Mage: Support, IDamage
//         {
//             private int damage = 10;

//             public int Damage
//             {
//                 get { return damage; }
//             }

//             public void DealDamage(string target)
//             {
//                 Console.WriteLine("Mage conjures " + Damage + " to"+ target);
//             }
//             public Mage(): base(50)
//             {

//             }
            
//             public Mage(int hp): base(hp)
//             {

//             }
//         }
//         class Archer: Support 
//         { 
//             private int damage = 15;

//             public int Damage
//             {
//                 get { return damage; }
//             }

//             public void DealDamage(string target)
//             {
//                 Console.WriteLine("Mage conjures " + Damage + " to"+ target);
//             }
//             public Archer(): base(100)
//             {

//             }
            
//             public Archer(int hp): base(hp)
//             {

//             }
//         }
//     }
// }