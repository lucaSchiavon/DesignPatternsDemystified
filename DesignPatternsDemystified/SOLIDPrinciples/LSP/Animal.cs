using System;


namespace DesignPatternsDemystified.SOLIDPrinciples.LSP
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("An animal makes a sound.");
        }
    }

}
