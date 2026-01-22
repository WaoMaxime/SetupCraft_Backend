using Domain.SetupSetting;

namespace Domain.SetupArea.Tabs;

public sealed record MechanicalBalanceTab(
    int ArbFront,
    int ArbRear,
    PerCorner<int> WheelRate,
    PerCorner<int> BumpStopRateUp,
    PerCorner<int> BumpStopRateDn,
    PerCorner<int> BumpStopWindow,
    int BrakeTorque,
    int BrakeBias
);