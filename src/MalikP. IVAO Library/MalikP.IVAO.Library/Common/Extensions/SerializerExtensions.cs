// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: SerializerExtensions.cs 
// Company: MalikP.
//
// Repository: https://github.com/peterM/IVAO-Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace MalikP.IVAO.Library.Common.Extensions
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
