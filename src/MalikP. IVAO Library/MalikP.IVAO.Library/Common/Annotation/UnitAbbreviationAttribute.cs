using System;

namespace MalikP.IVAO.Library.Common.Annotation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class UnitAbbreviationAttribute : UnitAttribute
    {
        public UnitAbbreviationAttribute(string unit, string abbreviation)
            : base(unit)
        {
            Abbreviation = abbreviation;
        }

        public string Abbreviation { get; }
    }
}
