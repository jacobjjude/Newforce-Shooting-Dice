using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice

    //Everytime dice is rolled, console.writeline a taunt
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }

        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"Talk your smack");
            string Taunt = Console.ReadLine();
            Console.WriteLine($"{Name} says '{Taunt}'");

            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} wins! '{Taunt}'");
            }
            else if (otherRoll > myRoll)
            {
                Console.WriteLine($"{other.Name} wins!");
            }
            else
            {
                Console.WriteLine("It's a tie. How boring");
            }
        }
    }
}

//taco.Taunt