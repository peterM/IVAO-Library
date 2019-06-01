// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: ServerBuilder.cs 
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

namespace MalikP.IVAO.Library.Models.Servers
{
    public sealed class ServerBuilder
    {
        private string _hostname;
        private string _ip;
        private string _location;
        private string _name;
        private bool _connectionsAllowed;
        private int _maximumConnections;

        private ServerBuilder()
        {
        }

        public static ServerBuilder Create()
        {
            return new ServerBuilder();
        }

        public ServerBuilder WithHostname(string hostname)
        {
            _hostname = hostname;
            return this;
        }

        public ServerBuilder WithIP(string ip)
        {
            _ip = ip;
            return this;
        }

        public ServerBuilder WithLocation(string location)
        {
            _location = location;
            return this;
        }

        public ServerBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public ServerBuilder WithConnectionsAllowed(bool connectionsAllowed)
        {
            _connectionsAllowed = connectionsAllowed;
            return this;
        }

        public ServerBuilder WithMaximumConnections(int maximumConnections)
        {
            _maximumConnections = maximumConnections;
            return this;
        }

        public Server Build()
        {
            return new Server(
                _hostname,
                _ip,
                _location,
                _name,
                _connectionsAllowed,
                _maximumConnections);
        }
    }
}
