using Domain.SetupArea.Tabs;

namespace Domain.SetupSetting;

public sealed record PitStopStrategy(
    int FuelToAdd,
    TyresTab Tyres,
    int TyreSet,
    int FrontBrakePadCompound,
    int RearBrakePadCompound
);