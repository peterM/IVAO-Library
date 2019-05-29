// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AbstractWebIVAOWhazzupDataSource.cs 
// Company: MalikP.
//
// Repository: https://github.com/peterM/IVAO-Net
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

using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

using MalikP.IVAO.Library.Models.DataHolders;

namespace MalikP.IVAO.Library.Data.Source
{
    public abstract class AbstractWebIVAOWhazzupDataSource : AbstractIVAOWhazzupDataSource, IWebIVAOWhazzupDataSource
    {
        protected const string ENCODING = "iso-8859-1";
        private readonly Uri _uri;

        protected AbstractWebIVAOWhazzupDataSource(string url)
            : this(new Uri(url))
        {
        }

        protected AbstractWebIVAOWhazzupDataSource(Uri uri)
        {
            _uri = uri;
        }

        public override IWhazzup GetIVAOData()
        {
            if (_uri == null)
            {
                return Whazzup.Null;
            }

            string[] data = Enumerable.Empty<string>().ToArray();

            using (WebClient client = new WebClient())
            {
                client.Encoding = GetEncoding(ENCODING);

                string dataString = client.DownloadString(_uri);
                dataString = ProcessDataString(dataString);

                data = Regex.Split(dataString, "\r\n|\r|\n")
                    .Where(d => !string.IsNullOrWhiteSpace(d))
                    .ToArray();
            }

            return new Whazzup(data);
        }

        protected virtual string ProcessDataString(string dataString)
        {
            return dataString;
        }

        protected virtual Encoding GetEncoding(string encoding)
        {
            return Encoding.GetEncoding(encoding);
        }
    }
}
