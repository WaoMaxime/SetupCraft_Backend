using Domain.SetupSetting;

namespace Domain.SetupArea.Tabs;

public sealed record DampersTab(
    PerCorner<int> BumpSlow,
    PerCorner<int> BumpFast,
    PerCorner<int> ReboundSlow,
    PerCorner<int> ReboundFast
);