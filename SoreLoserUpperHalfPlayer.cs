using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            return new Random().Next(4,6) + 1;
        }

        public override void Play(Player other)
        {
            try 
            {
                int myRoll = Roll();
                int otherRoll = other.Roll();

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
                Console.WriteLine("Hmmm. Table flipped again. Weird");
            }
        }
    }
}