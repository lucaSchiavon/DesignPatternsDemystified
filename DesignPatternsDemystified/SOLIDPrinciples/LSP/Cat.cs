using System;


namespace DesignPatternsDemystified.SOLIDPrinciples.LSP
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("A cat meows.");
        }
    }
}
