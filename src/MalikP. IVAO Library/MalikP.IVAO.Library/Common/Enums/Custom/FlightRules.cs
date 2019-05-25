using MalikP.IVAO.Library.Common.Annotation;

namespace MalikP.IVAO.Library.Common.Enums.Custom
{
    public enum FlightRules
    {
        NotDefined,

        [Map("V")]
        [ItemDescription("Visual Flight Rules (VFR)")]
        VFR,

        [ItemDescription("Marginal VFR (MVFR)")]
        MVFR,

        [Map("I")]
        [ItemDescription("Instrument Flight Rules (IFR)")]
        IFR,

        [ItemDescription("Low Instrument Flight Rules (LIFR)")]
        LIFR
    }
}
