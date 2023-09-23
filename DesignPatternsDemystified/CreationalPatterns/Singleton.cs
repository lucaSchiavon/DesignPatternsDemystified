using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns
{
    public sealed class Singleton
    {
        private static Singleton instance;
        private static readonly object lockObject = new object();

        private Singleton()
        {
            // Private constructor to prevent the creation of external instances. 
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        // Other methods and properties of the Singleton class can be added here.
    }
}
