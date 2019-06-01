using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace MalikP.IVAO.Library.Test.Framework
{
    public static class SerializerExtensions
    {
        public static string Serialize<T>(this T item)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(T));
                ser.WriteObject(memoryStream, item);

                byte[] data = memoryStream.ToArray();
                return Encoding.UTF8.GetString(data);
            }
        }

        public static T Deserialize<T>(this string item)
        {
            byte[] data = Encoding.UTF8.GetBytes(item);

            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(T));

                XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(memoryStream, new XmlDictionaryReaderQuotas());
                return (T)ser.ReadObject(reader, true);
            }
        }
    }
}
