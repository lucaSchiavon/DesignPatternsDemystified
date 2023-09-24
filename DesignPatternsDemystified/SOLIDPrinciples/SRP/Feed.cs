
using System.Collections.Generic;
using System.Text;


namespace DesignPatternsDemystified.SOLIDPrinciples.SRP
{
    public class Feed
    {
        private readonly List<string> Posts = new List<string>();
        private static int Count = 0;
        public void AddPost(string Text)
        {
            Posts.Add($"{++Count}: {Text}");
        }
        public void RemovePost(int index)
        {
            Posts.RemoveAt(index);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            Posts.ForEach(x => sb.Append(x));

            return sb.ToString();

        }

    }

}
