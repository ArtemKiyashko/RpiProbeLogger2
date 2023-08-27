namespace SharedModels.SIM7000E;

public record GpsData(
    GnssRunStatus GnssRunStatus,
    GnssFixStatus GnssFixStatus,
    DateTime? UtcDateTime,
    float? Latitude,
    float? Longitude,
    float? Altitude,
    float? GroundSpeed,
    float? GroundCourse,
    int? FixMode,
    float? Hdop,
    float? Pdop,
    float? Vdop,
    int? GnssSatellitesInView,
    int? GnssSatellitesUsed,
    int? GlonassSatellitesUsed,
    float? CnMax,
    float? Hpa,
    float? Vpa);