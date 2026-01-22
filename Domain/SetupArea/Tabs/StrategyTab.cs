using Domain.SetupSetting;

namespace Domain.SetupArea.Tabs;

public sealed record StrategyTab(
    int Fuel,
    int NPitStops,
    int TyreSet,
    int FrontBrakePadCompound,
    int RearBrakePadCompound,
    decimal FuelPerLap,
    IReadOnlyList<PitStopStrategy> PitStrategy
);