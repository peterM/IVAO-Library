using MalikP.IVAO.Library.Common.Annotation;

namespace MalikP.IVAO.Library.Common.Enums.Custom
{
    /// <summary>
    /// Enumeration to define flight types
    /// </summary>
    /// <remarks>
    /// Enumeration represents after converting
    /// <code>
    /// <summary>
    /// NotDefinedOrNull -> if not set or if flight plan is null
    /// ScheduledServices = S
    /// NonScheduledServices = N
    /// GeneralAviation = G
    /// Military = M
    /// Other = X
    /// </code>
    /// </remarks>
    public enum FlightType
    {
        /// <summary>
        /// If not set flight type
        /// </summary>
        [Map("NOTDEFINED")]
        [ItemDescription("Was not defined or fpl is null")]
        NotDefinedOrNull,

        /// <summary>
        /// Scheduled flight type
        /// </summary>
        [Map("S")]
        [ItemDescription("Scheduled flight type")]
        ScheduledServices,

        /// <summary>
        /// Non-Scheduled flight type
        /// </summary>
        [Map("N")]
        [ItemDescription("Non-Scheduled flight")]
        NonScheduledServices,

        /// <summary>
        /// General aviation flight type
        /// </summary>
        [Map("G")]
        [ItemDescription("General aviation flight")]
        GeneralAviation,

        /// <summary>
        /// Military flight type
        /// </summary>
        [Map("M")]
        [ItemDescription("Military flight")]
        Military,

        /// <summary>
        /// Other type as flight
        /// </summary>
        [Map("X")]
        [ItemDescription("Other type of flight")]
        Other,
    }
}
