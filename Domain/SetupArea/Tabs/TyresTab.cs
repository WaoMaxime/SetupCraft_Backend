using Domain.SetupSetting;

namespace Domain.SetupArea.Tabs;

public sealed record TyresTab(
    int TyreCompound,
    PerCorner<int> TyrePressure 
);