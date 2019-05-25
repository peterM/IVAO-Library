using System;

namespace MalikP.IVAO.Library.Common.Annotation
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public sealed class MapAttribute : Attribute
    {
        public MapAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
