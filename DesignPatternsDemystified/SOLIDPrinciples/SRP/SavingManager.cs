using System.IO;


namespace DesignPatternsDemystified.SOLIDPrinciples.SRP
{
    public class SavingManager
    {
        public void Save(Feed feed, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, feed.ToString());
            }

        }
    }

}
