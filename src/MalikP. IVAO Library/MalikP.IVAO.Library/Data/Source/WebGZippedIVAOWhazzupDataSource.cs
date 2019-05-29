// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: WebGZippedIVAOWhazzupDataSource.cs 
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

using MalikP.IVAO.Library.Common;

namespace MalikP.IVAO.Library.Data.Source
{
    public sealed class WebGZippedIVAOWhazzupDataSource : AbstractWebIVAOWhazzupDataSource
    {
        private readonly IGZipCompression _gZipCompression;

        public WebGZippedIVAOWhazzupDataSource(string url, IGZipCompression gZipCompression)
            : this(new Uri(url), gZipCompression)
        {
        }

        public WebGZippedIVAOWhazzupDataSource(Uri uri, IGZipCompression gZipCompression)
            : base(uri)
        {
            _gZipCompression = gZipCompression;
        }

        protected override string ProcessDataString(string dataString)
        {
            byte[] bytes = GetEncoding(ENCODING).GetBytes(dataString);

            bytes = _gZipCompression.Decompress(bytes);

            return GetEncoding(ENCODING).GetString(bytes);
        }
    }
}
