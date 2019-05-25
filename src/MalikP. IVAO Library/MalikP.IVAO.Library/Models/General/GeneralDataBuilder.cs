// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: GeneralDataBuilder.cs 
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

namespace MalikP.IVAO.Library.Models.General
{
    public sealed class GeneralDataBuilder
    {
        private int _version;
        private int _reload;
        private DateTime _update;
        private int _connectedClients;
        private int _connectedServers;
        private int _connectedAirports;

        private GeneralDataBuilder()
        {
        }

        public static GeneralDataBuilder Create()
        {
            return new GeneralDataBuilder();
        }

        public GeneralDataBuilder WithVersion(int version)
        {
            _version = version;
            return this;
        }

        public GeneralDataBuilder WithReload(int reload)
        {
            _reload = reload;
            return this;
        }

        public GeneralDataBuilder WithUpdate(DateTime update)
        {
            _update = update;
            return this;
        }

        public GeneralDataBuilder WithConnectedClients(int connectedClients)
        {
            _connectedClients = connectedClients;
            return this;
        }

        public GeneralDataBuilder WithConnectedServers(int connectedServers)
        {
            _connectedServers = connectedServers;
            return this;
        }

        public GeneralDataBuilder WithConnectedAirports(int connectedAirports)
        {
            _connectedAirports = connectedAirports;
            return this;
        }

        public GeneralData Build()
        {
            return new GeneralData(
                _version,
                _reload,
                _update,
                _connectedClients,
                _connectedServers,
                _connectedAirports);
        }
    }
}