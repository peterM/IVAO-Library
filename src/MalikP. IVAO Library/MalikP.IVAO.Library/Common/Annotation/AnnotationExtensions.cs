// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AnnotationExtensions.cs 
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MalikP.IVAO.Library.Common.Annotation
{
    public static class AnnotationExtensions
    {
        public static T GetFromMap<T>(this string map)
            where T : Enum
        {
            Dictionary<T, List<MapAttribute>> items = Enum.GetValues(typeof(T))
                .Cast<T>()
                .ToDictionary<T, T, List<MapAttribute>>(d => d, d => GetAttributes<MapAttribute>(d).ToList());

            if (items.Count > 0)
            {
                foreach (KeyValuePair<T, List<MapAttribute>> item in items)
                {
                    var result = item.Value.FirstOrDefault(d => string.Equals(d.Value, map, StringComparison.InvariantCultureIgnoreCase));
                    if (result != null)
                    {
                        return item.Key;
                    }
                }
            }

            return default;
        }

        public static IEnumerable<T> GetAttributes<T>(this Enum enumValue)
            where T : Attribute
        {
            IEnumerable<T> attributes = Enumerable.Empty<T>();

            MemberInfo memberInfo = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault();

            if (memberInfo != null)
            {
                attributes = memberInfo.GetCustomAttributes(typeof(T), false).Cast<T>().ToList();
            }

            return attributes;
        }
    }
}
