using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {   
            try
            {
            int myRoll = Roll();
            int otherRoll = Roll();

            if (myRoll < otherRoll)
            {
                throw new InvalidOperationException();
            }

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} wins!");
            }
            else 
            {
                Console.WriteLine("It's a tie!");
            }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Oh nooo. The table got flipped. Wonder how that happened... Guess no one wins.");
            }
        }
        
    
}
}