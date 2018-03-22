using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Prototype___Serialization
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin); // stream.Position = 0

                return (T)formatter.Deserialize(stream);
            }
        }

        public static T DeepCopyXml<T>(this T self)
        {
            using (var stream = new MemoryStream())
            {
                var s = new XmlSerializer(typeof(T));
                s.Serialize(stream, self);
                stream.Position = 0; // stream.Seek(0, SeekOrigin.Begin);
                return (T)s.Deserialize(stream);
            }
        }
    }
}
