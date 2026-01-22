using Domain.SetupSetting;

namespace Domain.SetupArea.Tabs;

public sealed record AeroBalanceTab(
    PerCorner<DualSetting<int, decimal>> RideHeight,
    int Splitter,
    int RearWing,
    PerAxle<int> BrakeDuct 
);