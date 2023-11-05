using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatternsDemystified.CreationalPatterns.Prototype
{
    public static class CopierManagerExtension
    {
        public static T DeepBinaryCopy<T>(this T self)
        {
            using (var stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                object copy = formatter.Deserialize(stream);
                return (T)copy;

            }
        }

        public static T DeepXmlCopy<T>(this T self)
        {
            using (var ms = new MemoryStream())
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(ms, self);
                ms.Position = 0;
                return (T)xmlSerializer.Deserialize(ms);
            }
        }


    }
}
