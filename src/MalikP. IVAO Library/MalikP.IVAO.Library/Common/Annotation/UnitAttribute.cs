using System;

namespace MalikP.IVAO.Library.Common.Annotation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UnitAttribute : Attribute
    {
        public UnitAttribute(string unit)
        {
            Unit = unit;
        }

        public string Unit { get; }
    }
}
